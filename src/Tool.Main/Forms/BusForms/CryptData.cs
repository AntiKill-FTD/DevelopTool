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
using Tool.Business.Common;
using Tool.CusControls.DataGridViewEx;
using Tool.Data;
using Tool.Data.DataHelper;

namespace Tool.Main.Forms.BusForms
{
    public partial class CryptData : Form
    {
        private ICommonDataHelper dataHelper;
        private bool isConnect = false;
        private DataTable dtModel = null;

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
                dtModel = dataHelper.GetDataTable(strMainSql, "");
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
        private void btnAnaly_Click(object sender, EventArgs e)
        {
            try
            {
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
                //写入数据表名称
                string inputTableName = tb_DataInput.Text.Trim();
                //定义写入sql
                StringBuilder sbSql = new StringBuilder();
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
                        WriteLog($"删除写入表成功！");
                    }
                }
                sbSql.Clear();
                //写入数据 1.拼接SQL
                string strTempField = string.Empty;
                foreach (DataGridViewRow row in dv.Rows)
                {
                    strTempField += "," + row.Cells[0].Value.ToString();
                }
                strTempField = strTempField.Substring(1);
                //写入数据 2.循环数据
                string sqlPassword = tb_SqlEncrypt.Text.Trim();
                CryptHelper cryptHelper = new CryptHelper();
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
                    changeScheme.SourceField = dvRow.Cells[2].Value != null ? dvRow.Cells[2].Value.ToString() : string.Empty;
                    changeScheme.ConstField = dvRow.Cells[3].Value != null ? dvRow.Cells[3].Value.ToString() : string.Empty;
                    changeScheme.IsCrypt = dvRow.Cells[4].Value != null ? (bool)dvRow.Cells[4].Value : false;
                    changeScheme.IsChangeField = !string.IsNullOrEmpty(changeScheme.SourceField) && !changeScheme.IsCrypt; //只有是转换源字段且不加密的时候才加引号
                    changeSchemesList.Add(changeScheme);
                }

                //将集合esList按10次插入数据库
                int rowCount = dtModel.Rows.Count;
                int perCount = (int)Math.Ceiling((double)rowCount / 10);
                WriteLog($"开始处理数据，共{rowCount}条数据！");
                for (int perIndex = 0; perIndex < 10; perIndex++)
                {
                    int insertMIndex = perIndex * perCount;
                    if (insertMIndex >= rowCount) break;

                    for (int per = 0; per < perCount; per++)
                    {
                        int insertIndex = perIndex * perCount + per;
                        if (insertIndex >= rowCount) break;

                        #region 核心SQL拼接逻辑
                        DataRow dtRow = dtModel.Rows[insertIndex];
                        string strTempValue = string.Empty;
                        foreach (ChangeScheme changeScheme in changeSchemesList)
                        {
                            //数据信息
                            string trueValue;
                            if (!string.IsNullOrEmpty(changeScheme.SourceField))
                            {
                                trueValue = dtRow[changeScheme.SourceField].ToString();
                            }
                            else if (!string.IsNullOrEmpty(changeScheme.ConstField))
                            {
                                trueValue = changeScheme.ConstField;
                            }
                            else
                            {
                                trueValue = "NULL";
                            }
                            //解密
                            if (changeScheme.IsCrypt)
                            {
                                //解密再SQL加密
                                trueValue = cryptHelper.DecryptString(trueValue);
                                trueValue = $"ENCRYPTBYPASSPHRASE('{sqlPassword}','{trueValue}')";
                            }
                            //最后转换字段加引号
                            if (changeScheme.IsChangeField)
                            {
                                trueValue = "'" + trueValue + "'";
                            }
                            //添加字段值
                            strTempValue += "," + trueValue;
                        }
                        strTempValue = strTempValue.Substring(1);
                        //插入语句
                        string strTempInsert = $"INSERT INTO {inputTableName} ({strTempField}) VALUES ( {strTempValue} );\r\n";
                        sbSql.Append(strTempInsert);
                        //Log
                        WriteLog($"第{insertIndex + 1}条数据拼接成功！------共{rowCount}条数据");
                        #endregion
                    }
                    //提交
                    dataHelper.ExcuteNoQuery(sbSql.ToString());
                    //清空
                    sbSql.Clear();
                    //Log
                    WriteLog($"第{perIndex + 1}次提交成功！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误");
                this.rtbLogInfo.Clear();
            }
        }
        #endregion

        private void WriteLog(string message)
        {
            this.rtbLogInfo.AppendText($"{message}         {DateTime.Now}\r\n");
            this.rtbLogInfo.Focus();
            this.rtbLogInfo.Select(this.rtbLogInfo.TextLength, 0);
            this.rtbLogInfo.ScrollToCaret();
        }
    }

    public class ChangeScheme
    {
        public bool IsChangeField;
        public string SourceField;
        public string ConstField;
        public bool IsCrypt;
    }
}
