using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.SqlClient;
using System.Numerics;
using System.Text;
using Tool.Business.Common;
using Tool.CusControls.DataGridViewEx;
using Tool.Data;
using Tool.Data.DataHelper;

namespace Tool.Main.Forms.BusForms
{
    public partial class CryptData : Form
    {
        #region 全局变量

        CryptHelper cryptHelper = new CryptHelper(); //解密类

        private ICommonDataHelper dataHelper;   //数据库操作类
        private bool isConnect = false;         //判断是否连接成功
        private DataTable dtSource = null;      //需要处理的数据源对象

        DateTime dtBegin = DateTime.Now;        //解密操作开始时间【全局变量】
        private Int32 perCount = 5000;          //每多少条一个线程进行解密
        private Int32 dataIndex = 0;            //当前操作的数据Index
        private Int32 dataCount = 0;            //需要处理的数据源总条数

        private BigInteger bigIntegerEncrypt = 0;       //加密数据库字符串对应的十进制数
        private string inputTableName = string.Empty;          //要写入的表名称
        private DataTable dtDistination = null;                //要写入的表数据
        private List<DataRow> rowList = new List<DataRow>();   //所有个线程的DataRow汇总

        private StringBuilder errorMessage = new StringBuilder();                  //线程内部错误消息提示
        System.Windows.Forms.Timer logTimer = new System.Windows.Forms.Timer();    //日志监听

        //多线程使用中间变量
        int[] numbers = new int[10000];

        #endregion

        #region Ctor
        public CryptData()
        {
            InitializeComponent();
        }
        #endregion

        #region PageLoad
        private void CryptData_Load(object sender, EventArgs e)
        {
            //定时器
            logTimer.Tick += LogTimer_Tick;
            logTimer.Interval = 1000;

            //中间变量
            for (int i = 0; i < 10000; i++)
            {
                numbers[i] = i;
            }
        }
        #endregion

        #region 测试连接按钮
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                //获取连接数据
                string strIP = cmb_IP.Text.Trim();
                string strAccount = tb_LoginAccount.Text.Trim();
                string strPassword = tb_LoginPassword.Text.Trim();
                string strDataBase = tb_DataBase.Text.Trim();
                string connectString = $"{strIP};Initial Catalog={strDataBase};User id={strAccount};Password={strPassword};Connection Timeout=30;Pooling=true;Max Pool Size=100;";
                //创建数据连接
                DbContextOptionsBuilder<DeveloperToolContext> dbOptionBuild = new DbContextOptionsBuilder<DeveloperToolContext>();
                dbOptionBuild.UseSqlServer($"Data Source={connectString}");
                DeveloperToolContext dbContext = new DeveloperToolContext(dbOptionBuild.Options);
                dataHelper = new MSSqlDataHelper(dbContext);
                //测试连接
                bool connectResult = dataHelper.CheckConnect();
                if (connectResult)
                {
                    MessageBox.Show("连接成功", "提示");
                    isConnect = true;
                }
                else
                {
                    MessageBox.Show("连接失败", "提示");
                    isConnect = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("连接失败：" + ex.Message, "提示");
                isConnect = false;
            }
        }
        #endregion

        #region 获取示例数据
        private void btn_GetModelData_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isConnect)
                {
                    MessageBox.Show("请先连接数据库", "提示");
                    return;
                }
                //查询数据
                string strMainSql = rtb_MainSql.Text.Trim();
                dtSource = dataHelper.GetDataTable(strMainSql, "");
                //定义列数据DataTable
                DataTable dtColumns = new DataTable();
                dtColumns.Columns.Add("字段名称");
                dtColumns.Columns.Add("数据类型");
                //处理列
                DataColumnCollection cols = dtSource.Columns;
                foreach (DataColumn col in cols)
                {
                    string colName = col.ColumnName;
                    string colType = col.DataType.ToString();
                    DataRow nRow = dtColumns.NewRow();
                    nRow["字段名称"] = colName;
                    nRow["数据类型"] = colType;
                    dtColumns.Rows.Add(nRow);
                }
                //绑定网格
                this.dvDataSource.DvDataTable = dtColumns;
                this.dvDataSource.ViewDataBind(CusControls.DataGridViewEx.DataGridViewBindType.DataTable, false, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误");
            }
        }
        #endregion

        #region 解析写入数据源
        private void btn_Anayly_Click(object sender, EventArgs e)
        {
            try
            {
                //校验数据源
                if (dvDataSource.DvDataTable == null || dvDataSource.DvDataTable.Rows.Count <= 0)
                {
                    MessageBox.Show("请获取需要解密的数据源", "提示");
                    return;
                }
                //校验表输入
                if (string.IsNullOrEmpty(tb_DataInput.Text.Trim()))
                {
                    MessageBox.Show("请输入要写入的数据表", "提示");
                    return;
                }
                //清除原dv
                this.dvInputSource.ClearColumns();
                //解析表
                //查询数据
                string strMainSql = $"SELECT TOP 0 * FROM {tb_DataInput.Text.Trim()}";
                dtDistination = dataHelper.GetDataTable(strMainSql, "");
                //定义列数据DataTable
                DataTable dtColumns = new DataTable();
                dtColumns.Columns.Add("字段名称");
                dtColumns.Columns.Add("数据类型");
                //处理列
                DataColumnCollection cols = dtDistination.Columns;
                foreach (DataColumn col in cols)
                {
                    string colName = col.ColumnName;
                    string colType = col.DataType.ToString();
                    DataRow nRow = dtColumns.NewRow();
                    nRow["字段名称"] = colName;
                    nRow["数据类型"] = colType;
                    dtColumns.Rows.Add(nRow);
                }
                //绑定网格
                this.dvInputSource.DvDataTable = dtColumns;
                this.dvInputSource.ViewDataBind(CusControls.DataGridViewEx.DataGridViewBindType.DataTable, false, false);
                //添加关联字段
                List<string> colNames = new List<string>();
                foreach (DataRow row in dvDataSource.DvDataTable.Rows)
                {
                    colNames.Add(row["字段名称"].ToString());
                }
                this.dvInputSource.AddColumn(this.dvInputSource.CreateColumn<DataGridViewComboBoxColumn>("SourceField", "源字段", colNames, 180));
                //添加固定值
                List<string> constValue = new List<string>();
                constValue.Add("");
                constValue.Add("GetDate()");
                this.dvInputSource.AddColumn(this.dvInputSource.CreateColumn<DataGridViewComboBoxColumn>("ConstValue", "固定值", constValue, 180));
                //添加是否解密
                this.dvInputSource.AddChkCol(CheckBoxName.CheckBox1, 4, true, "是否解密");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误");
            }
        }
        #endregion

        #region 开始解密
        private async void btnAnaly_Click(object sender, EventArgs e)
        {
            try
            {
                //记录开始时间
                dtBegin = DateTime.Now;
                //校验选择字段和固定值不能同时存在
                DataGridViewCommonEx dv = dvInputSource.Dv;
                foreach (DataGridViewRow row in dv.Rows)
                {
                    if (row.Cells[2].Value != null && row.Cells[3].Value != null
                        && !string.IsNullOrEmpty(row.Cells[2].Value.ToString()) && !string.IsNullOrEmpty(row.Cells[3].Value.ToString()))
                    {
                        MessageBox.Show("【源字段】和【固定值】只能存在一个", "警告");
                        return;
                    }
                }
                //加密数据库字符串对应的十进制数
                string sqlPassword = tb_SqlEncrypt.Text.Trim();
                bigIntegerEncrypt = BigInteger.Parse(BinaryHelper.StringToDecimal(sqlPassword));
                //写入数据表名称
                inputTableName = tb_DataInput.Text.Trim();
                //定义写入sql
                StringBuilder sbSqlDel = new StringBuilder();
                //校验是否要删除原有数据源
                if (this.rbDeleteTrue.Checked)
                {
                    DialogResult dialogResult = MessageBox.Show($"确定要删除写入数据源 ！！！  {inputTableName}  ！！！吗？", "警告", MessageBoxButtons.OKCancel);
                    if (dialogResult == DialogResult.Cancel)
                    {
                        return;
                    }
                    else
                    {
                        sbSqlDel.Append($"DELETE {inputTableName};");
                        dataHelper.ExcuteNoQuery(sbSqlDel.ToString());
                        WriteLog($"删除写入表成功！");
                    }
                }
                sbSqlDel.Clear();
                //写入数据 1.拼接SQL
                string strTempField = string.Empty;
                foreach (DataGridViewRow row in dv.Rows)
                {
                    strTempField += "," + row.Cells[0].Value.ToString();
                }
                strTempField = strTempField.Substring(1);
                //写入数据 2.循环数据
                cryptHelper.Key = tb_Key.Text.Trim();
                cryptHelper.IV = tb_IV.Text.Trim();

                //获取数据处理方案
                List<ChangeScheme> changeSchemesList = new List<ChangeScheme>();
                foreach (DataGridViewRow dvRow in dv.Rows)
                {
                    //标识是否转换字段，转换字段加引号
                    bool isChangeField = false;
                    //转换信息
                    ChangeScheme changeScheme = new ChangeScheme();
                    changeScheme.ColumnName = dvRow.Cells[0].Value != null ? dvRow.Cells[0].Value.ToString() : string.Empty;
                    changeScheme.SourceField = dvRow.Cells[2].Value != null ? dvRow.Cells[2].Value.ToString() : string.Empty;
                    changeScheme.ConstField = dvRow.Cells[3].Value != null ? dvRow.Cells[3].Value.ToString() : string.Empty;
                    changeScheme.IsCrypt = dvRow.Cells[4].Value != null ? (bool)dvRow.Cells[4].Value : false;
                    changeSchemesList.Add(changeScheme);
                }

                //将集合esList按每固定条数条一次插入数据库
                dataCount = dtSource.Rows.Count;
                int taskCount = (int)Math.Ceiling((double)dataCount / perCount);
                WriteLog($"开始处理数据，共{dataCount}条数据！");
                //开始处理定时任务！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！
                logTimer.Start();
                //开始处理定时任务！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！
                for (int perIndex = 0; perIndex < taskCount; perIndex++)
                {
                    var midNumber = perIndex;
#pragma warning disable CS4014 // 由于此调用不会等待，因此在调用完成前将继续执行当前方法
                    Task.Run(() => CoreFunction(strTempField, changeSchemesList, numbers[midNumber]));
#pragma warning restore CS4014 // 由于此调用不会等待，因此在调用完成前将继续执行当前方法
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误");
                this.rtbLogInfo.Clear();
            }
        }
        #endregion

        #region CoreFunction
        private void CoreFunction(string strTempField, List<ChangeScheme> changeSchemesList, int perIndex)
        {
            StringBuilder sbTaks = new StringBuilder();
            for (int per = 0; per < perCount; per++)
            {
                int insertIndex = perIndex * perCount + per;
                if (insertIndex >= dataCount) break;

                #region 核心SQL拼接逻辑
                DataRow dtRowSource = dtSource.Rows[insertIndex];
                DataRow dtRowDistination = dtDistination.NewRow();
                foreach (ChangeScheme changeScheme in changeSchemesList)
                {
                    //数据信息
                    object trueValue;
                    if (!string.IsNullOrEmpty(changeScheme.SourceField))
                    {
                        trueValue = dtRowSource[changeScheme.SourceField];
                    }
                    else if (!string.IsNullOrEmpty(changeScheme.ConstField))
                    {
                        trueValue = changeScheme.ConstField;
                    }
                    else
                    {
                        trueValue = DBNull.Value;
                    }
                    //解密
                    if (changeScheme.IsCrypt)
                    {
                        //解密再二进制加密
                        trueValue = cryptHelper.DecryptString(trueValue.ToString());
                        if (string.IsNullOrEmpty(trueValue.ToString()))
                        {
                            trueValue = DBNull.Value;
                        }
                        else
                        {
                            BigInteger passwordValue = BigInteger.Parse(BinaryHelper.StringToDecimal(trueValue.ToString()));
                            BigInteger sumValue = passwordValue + bigIntegerEncrypt;
                            //trueValue = BitConverter.GetBytes(sumValue.ToString());
                        }
                    }

                    //添加字段值
                    dtRowDistination[changeScheme.ColumnName] = trueValue;
                }
                //添加数据行
                rowList.Add(dtRowDistination);
                //Log Index
                dataIndex++;
                #endregion
            }
        }
        #endregion

        #region 停止解密
        private void btnStop_Click(object sender, EventArgs e)
        {
            //结束重置所有全局标识对象
            logTimer.Stop();
            //数据条数清空
            dataIndex = 0;
            dataCount = 0;
            //BlukCopy缓存清空
            rowList.Clear();
            //线程内错误信息清空
            errorMessage.Clear();
            //日志清空
            this.rtbLogInfo.Clear();
        }
        #endregion

        #region LogTimer_Tick 记录日志使用
        private void LogTimer_Tick(object? sender, EventArgs e)
        {
            //如果全部提交完成
            if (dataIndex == dataCount)
            {
                //提交
                SqlConnection con = (SqlConnection)dataHelper.Con();
                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(con))
                {
                    bulkCopy.DestinationTableName = inputTableName;

                    try
                    {
                        //打开连接
                        con.Open();
                        // Write the array of rows to the destination.
                        bulkCopy.WriteToServer(rowList.ToArray());
                    }
                    catch (Exception ex)
                    {
                        WriteLog(ex.Message);
                    }
                    finally
                    {
                        //关闭连接
                        con.Close();
                        //结束重置所有全局标识对象
                        logTimer.Stop();
                        //数据条数清空
                        dataIndex = 0;
                        dataCount = 0;
                        //缓存清空
                        rowList.Clear();
                        //线程内错误信息清空
                        errorMessage.Clear();
                        //结束重置所有全局标识对象
                        //---
                        //记录结束时间
                        DateTime dtEnd = DateTime.Now;
                        TimeSpan ts = dtEnd - dtBegin;
                        string strUseTime = "解密完成，总共用时" + ts.ToString();
                        WriteLog(strUseTime);
                    }
                }
            }
            else
            {
                WriteLog($"第{dataIndex}条数据拼接成功！------共{dataCount}条数据");
                if (errorMessage.ToString().Length > 0)
                {
                    WriteLog(errorMessage.ToString());
                }
            }
        }
        #endregion

        #region WriteLog
        private void WriteLog(string message)
        {
            this.rtbLogInfo.AppendText($"{message}         {DateTime.Now}\r\n");
            this.rtbLogInfo.Focus();
            this.rtbLogInfo.Select(this.rtbLogInfo.TextLength, 0);
            this.rtbLogInfo.ScrollToCaret();
        }
        #endregion

    }

    #region Class ： ChangeScheme
    public class ChangeScheme
    {
        public string ColumnName;
        public string SourceField;
        public string ConstField;
        public bool IsCrypt;
    }
    #endregion

}
