using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tool.CusControls.DataGridViewEx;
using Tool.Data;
using Tool.Data.DataHelper;

namespace Tool.Main.Forms.BusForms
{
    public partial class CryptData : Form
    {
        private ICommonDataHelper dataHelper;
        private bool isConnect = false;

        public CryptData()
        {
            InitializeComponent();
        }

        #region PageLoad
        private void CryptData_Load(object sender, EventArgs e)
        {

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
                string connectString = $"{strIP};Initial Catalog={strDataBase};User id={strAccount};Password={strPassword};Connection Timeout=1;";
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
                DataTable dtModel = dataHelper.GetDataTable(strMainSql, "");
                //定义列数据DataTable
                DataTable dtColumns = new DataTable();
                dtColumns.Columns.Add("字段名称");
                dtColumns.Columns.Add("数据类型");
                //处理列
                DataColumnCollection cols = dtModel.Columns;
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
                string strMainSql = $"SELECT TOP 1 * FROM {tb_DataInput.Text.Trim()}";
                DataTable dtModel = dataHelper.GetDataTable(strMainSql, "");
                //定义列数据DataTable
                DataTable dtColumns = new DataTable();
                dtColumns.Columns.Add("字段名称");
                dtColumns.Columns.Add("数据类型");
                dtColumns.Columns.Add("固定值");
                //处理列
                DataColumnCollection cols = dtModel.Columns;
                foreach (DataColumn col in cols)
                {
                    string colName = col.ColumnName;
                    string colType = col.DataType.ToString();
                    DataRow nRow = dtColumns.NewRow();
                    nRow["字段名称"] = colName;
                    nRow["数据类型"] = colType;
                    nRow["固定值"] = "";
                    dtColumns.Rows.Add(nRow);
                }
                //绑定网格
                this.dvInputSource.DvDataTable = dtColumns;
                this.dvInputSource.ViewDataBind(CusControls.DataGridViewEx.DataGridViewBindType.DataTable, false, false);
                //添加关联字段和是否主键
                List<string> colNames = new List<string>();
                foreach (DataRow row in dvDataSource.DvDataTable.Rows)
                {
                    colNames.Add(row["字段名称"].ToString());
                }
                this.dvInputSource.AddChkCol(CheckBoxName.CheckBox1, 2, true, "是否解密");
                this.dvInputSource.InsertColumn(this.dvInputSource.CreateColumn<DataGridViewComboBoxColumn>("SourceField", "源字段", colNames, 180), 3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误");
            }
        }
        #endregion

        #region 开始解密
        private void btnAnaly_Click(object sender, EventArgs e)
        {
            try
            {
                //校验选择字段和固定值不能同时存在
                DataTable dtIn = dvInputSource.DvDataTable;
                foreach (DataRow row in dtIn.Rows)
                {
                    if (row["源字段"] != null && row["固定值"].ToString().Trim() != "")
                    {

                    }
                }

                //写入数据表名称
                string inputTableName = tb_DataInput.Text.Trim();
                //定义写入sql
                StringBuilder sbSql = new StringBuilder();
                StringBuilder sbLog = new StringBuilder();
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
                        sbSql.Append($"DELETE {inputTableName};");
                        dataHelper.ExcuteNoQuery(sbSql.ToString());
                        sbLog.Append($"删除写入表成功！      {DateTime.Now}");
                        this.rtbLogInfo.Text = sbLog.ToString(); ;
                    }
                }
                sbSql.Clear();
                //写入数据

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误");
            }
        }
        #endregion
    }
}
