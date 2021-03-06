using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Tool.Data.DataHelper
{
    public class MSSqlDataHelper : ICommonDataHelper
    {
        private SqlConnection _con = new SqlConnection();
        public DbConnection Con()
        {
            return _con;
        }
        private SqlDataAdapter _adapter;
        private SqlCommandBuilder _commandBuilder;
        private SqlCommand _command;
        private DataSet _ds;
        private DataTable _dt;
        private DataRow _dr;
        private object _scalarObject;
        private long _resultCount;
        private string _connectString = string.Empty;
        private string _message = string.Empty;

        #region 初始化DataHelper，读取connection
        public MSSqlDataHelper(DeveloperToolContext _iDeveloperToolContext)
        {
            if (string.IsNullOrEmpty(_con.ConnectionString) && _iDeveloperToolContext != null)
            {
                string strConnect = _iDeveloperToolContext.Database.GetConnectionString();
                _con.ConnectionString = strConnect;
                _connectString = strConnect;
            }
        }
        #endregion

        #region 打开连接
        public void OpenCon()
        {
            this._con.Open();
        }
        #endregion

        #region 关闭连接
        public void CloseCon()
        {
            this._con.Close();
        }
        #endregion

        #region 测试连接
        public bool CheckConnect()
        {
            try
            {
                _con.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                _con.Close();
            }
        }
        #endregion

        #region GetDataSet -- 调用FillDataSet
        public DataSet GetDataSet(string sql)
        {
            _adapter = new SqlDataAdapter(sql, _con);
            _commandBuilder = new SqlCommandBuilder(_adapter);

            _ds = new DataSet();
            FillDataSet();

            return _ds;
        }
        #endregion

        #region FillDataSet
        private void FillDataSet()
        {
            try
            {
                //打开连接填充数据
                _con.Open();
                _adapter.Fill(_ds);
            }
            catch (Exception ex)
            {
                _ds = null;
                _message = ex.Message;
            }
            finally
            {
                //关闭连接
                _con.Close();
                //释放      
                if (_command != null) _command.Dispose();
                if (_commandBuilder != null) _commandBuilder.Dispose();
                if (_adapter != null) _adapter.Dispose();
            }
        }
        #endregion

        #region GetDataTable -- 调用FillDataTable
        public DataTable GetDataTable(string sqlMain, string sqlOrder)
        {
            string sql = sqlMain + " " + sqlOrder;
            _adapter = new SqlDataAdapter(sql, _con);
            _commandBuilder = new SqlCommandBuilder(_adapter);

            _dt = new DataTable();
            FillDataTable();

            return _dt;
        }

        public DataTable GetDataTableByPage(string sqlMain, string sqlOrder, ref long allDataCount, int currentPageIndex = 1, int perPageCount = 100)
        {
            //拼接查询总数SQL
            string rSqlCount = @"SELECT COUNT(*)
                                  FROM ( " + sqlMain + @" ) _t1";
            bool rResult = true;
            allDataCount = ExcuteScalar<int>(rSqlCount, ref rResult);
            if (!rResult)
            {
                allDataCount = 0;
                return null;
            }
            //拼接排序SQL
            string rSql = @"SELECT  *
                            FROM    ( SELECT    ROW_NUMBER() OVER ( " + sqlOrder + @" ) AS RowNum ,
                                                *
                                       FROM( " + sqlMain + @" ) _t1 
                                     ) _t2";
            //拼接排序条件
            int beginRowNum = (currentPageIndex - 1) * perPageCount + 1;
            int endRowNum = currentPageIndex * perPageCount;
            //拼接
            rSql = rSql + " WHERE RowNum >= " + beginRowNum.ToString() + " AND RowNum <= " + endRowNum.ToString();

            _adapter = new SqlDataAdapter(rSql, _con);
            _commandBuilder = new SqlCommandBuilder(_adapter);

            _dt = new DataTable();
            FillDataTable();

            return _dt;
        }
        #endregion

        #region FillDataTable
        private void FillDataTable()
        {
            try
            {
                //打开连接填充数据
                _con.Open();
                _adapter.Fill(_dt);
            }
            catch (Exception ex)
            {
                _dt = null;
                _message = ex.Message;
                throw ex;
            }
            finally
            {
                //关闭连接
                _con.Close();
                //释放               
                if (_command != null) _command.Dispose();
                if (_commandBuilder != null) _commandBuilder.Dispose();
                if (_adapter != null) _adapter.Dispose();
            }
        }
        #endregion

        #region GetDataRow -- 调用FillDataRow
        public DataRow GetDataRow(string sql)
        {
            _adapter = new SqlDataAdapter(sql, _con);
            _commandBuilder = new SqlCommandBuilder(_adapter);

            _ds = new DataSet();
            FillDataRow();

            return _dr;
        }
        #endregion

        #region FillDataRow
        private void FillDataRow()
        {
            try
            {
                //打开连接填充数据
                _con.Open();
                _adapter.Fill(_dt);
                if (_dt != null && _dt.Rows.Count > 0)
                {
                    _dr = _dt.Rows[0];
                }
                else
                {
                    _dr = null;
                }
            }
            catch (Exception ex)
            {
                _dr = null;
                _message = ex.Message;
            }
            finally
            {
                //关闭连接
                _con.Close();
                //释放               
                if (_command != null) _command.Dispose();
                if (_commandBuilder != null) _commandBuilder.Dispose();
                if (_adapter != null) _adapter.Dispose();
            }
        }
        #endregion

        #region ExcuteNoQuery -- 调用ExcuteNoQuery
        public long ExcuteNoQuery(string sql)
        {
            _command = new SqlCommand(sql, _con);

            ExcuteNoQuery();

            return _resultCount;
        }
        #endregion

        #region ExcuteNoQuery
        private void ExcuteNoQuery()
        {
            try
            {
                //打开连接填充数据
                _con.Open();
                _resultCount = _command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                _message = ex.Message;
                _resultCount = -1;
                throw ex;
            }
            finally
            {
                //关闭连接
                _con.Close();
                //释放
                if (_command != null) _command.Dispose();
                if (_commandBuilder != null) _commandBuilder.Dispose();
                if (_adapter != null) _adapter.Dispose();
            }
        }
        #endregion

        #region ExcuteScalar -- 调用ExcuteScalar
        public T ExcuteScalar<T>(string sql, ref bool result)
        {
            _command = new SqlCommand(sql, _con);

            ExcuteScalar();

            if (_scalarObject == null) return default(T);

            //泛型转换
            T t;
            try
            {
                t = (T)_scalarObject;
                result = true;
            }
            catch (Exception ex)
            {
                _message = ex.Message;
                t = default(T);
                result = false;
            }
            return t;
        }
        #endregion

        #region ExcuteScalar
        private void ExcuteScalar()
        {
            try
            {
                //打开连接填充数据
                _con.Open();
                _scalarObject = _command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                _scalarObject = null;
                _message = ex.Message;
            }
            finally
            {
                //关闭连接
                _con.Close();
                //释放
                if (_command != null) _command.Dispose();
                if (_commandBuilder != null) _commandBuilder.Dispose();
                if (_adapter != null) _adapter.Dispose();
            }
        }
        #endregion

        #region ExcuteProc -- 调用ExcuteProc
        public DataSet ExcuteProc(string procName, DbParameter[] parameters)
        {
            _command = new SqlCommand(procName, _con);
            _command.CommandType = CommandType.StoredProcedure;
            //循环添加参数
            foreach (SqlParameter param in parameters)
            {
                _command.Parameters.Add(param);
            }

            _adapter = new SqlDataAdapter(_command);

            _ds = new DataSet();
            ExcuteProc();

            return _ds;
        }
        #endregion

        #region ExcuteProc
        private void ExcuteProc()
        {
            try
            {
                //打开连接填充数据
                _con.Open();
                _adapter.Fill(_ds);
            }
            catch (Exception ex)
            {
                _ds = null;
                _message = ex.Message;
            }
            finally
            {
                //关闭连接
                _con.Close();
                //释放
                if (_command != null) _command.Dispose();
                if (_commandBuilder != null) _commandBuilder.Dispose();
                if (_adapter != null) _adapter.Dispose();
            }
        }
        #endregion

        #region Clone
        public object Clone()
        {
            MSSqlDataHelper mSSqlDataHelper = new MSSqlDataHelper(null);
            mSSqlDataHelper._con.ConnectionString = this._connectString;
            mSSqlDataHelper._connectString = this._connectString;
            return mSSqlDataHelper;
        }
        #endregion
    }
}
