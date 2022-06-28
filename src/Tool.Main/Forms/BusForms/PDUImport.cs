using Microsoft.EntityFrameworkCore;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tool.Business.Business;
using Tool.Data;
using Tool.Data.DataHelper;
using Tool.IService.Model.Bus;

namespace Tool.Main.Forms.BusForms
{
    public partial class PduImport : Form
    {
        #region 全局变量

        private ICommonDataHelper dataHelper;   //数据库操作类
        private bool isConnect = false;         //判断是否连接成功
        private string lastChoosePath = string.Empty; //上次打开的文件夹路径

        #endregion

        #region Ctor
        public PduImport()
        {
            InitializeComponent();
        }
        #endregion

        #region PageLoad
        private void PDUImport_Load(object sender, EventArgs e)
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

        #region 组织按钮事件

        #region 导入
        private void btn_Org_Import_Click(object sender, EventArgs e)
        {
            try
            {
                //判断数据库连接
                if (!isConnect)
                {
                    MessageBox.Show("请先测试数据库连接", "提示");
                    return;
                }
                //获取文档数据
                string errorMessage = string.Empty;
                DataTable dt = CreateOrgTable();
                bool validateSheetResult = GetExcelData(GetOrgColumns()[1], ref dt, ref errorMessage);
                if (!validateSheetResult)
                {
                    this.rtb_Org_FullError.Text = errorMessage;
                    this.rtb_Org_FullError.ForeColor = Color.Red;
                    return;
                }
                else
                {
                    this.rtb_Org_FullError.Clear();
                }
                //校验数据
                StringBuilder sbError = new StringBuilder();
                ValidateData(ref dt, ref sbError);
                //绑定网格，展示数据校验明细
                this.dv_Org.DvDataTable = dt;
                this.dv_Org.ViewDataBind(CusControls.DataGridViewEx.DataGridViewBindType.DataTable, false, false);
                //显示错误信息
                if (!string.IsNullOrEmpty(sbError.ToString()))
                {
                    this.rtb_Org_FullError.Text = sbError.ToString();
                    this.rtb_Org_FullError.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                this.rtb_Org_FullError.Text = $"错误\r{ex.Message}";
                this.rtb_Org_FullError.ForeColor = Color.Red;
                return;
            }
        }
        #endregion

        #endregion

        #region 人员按钮事件

        #region 导入
        private void btn_Emp_Import_Click(object sender, EventArgs e)
        {
            try
            {
                //判断数据库连接
                if (!isConnect)
                {
                    MessageBox.Show("请先测试数据库连接", "提示");
                    return;
                }
                //获取文档数据
                string errorMessage = string.Empty;
                DataTable dt = CreateEmpTable();
                bool validateSheetResult = GetExcelData(GetEmpColumns()[1], ref dt, ref errorMessage);
                if (!validateSheetResult)
                {
                    this.rtb_Emp_FullError.Text = errorMessage;
                    this.rtb_Emp_FullError.ForeColor = Color.Red;
                    return;
                }
                else
                {
                    this.rtb_Emp_FullError.Clear();
                }
                //校验数据
                StringBuilder sbError = new StringBuilder();
                ValidateData(ref dt, ref sbError);
                //绑定网格，展示数据校验明细
                this.dv_Emp.DvDataTable = dt;
                this.dv_Emp.ViewDataBind(CusControls.DataGridViewEx.DataGridViewBindType.DataTable, false, false);
                //显示错误信息
                if (!string.IsNullOrEmpty(sbError.ToString()))
                {
                    this.rtb_Emp_FullError.Text = sbError.ToString();
                    this.rtb_Emp_FullError.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                this.rtb_Emp_FullError.Text = $"错误\r{ex.Message}";
                this.rtb_Emp_FullError.ForeColor = Color.Red;
                return;
            }
        }
        #endregion

        #endregion

        #region 校验

        #region 校验并读取数据
        private bool GetExcelData(string[] columns, ref DataTable dt, ref string message)
        {
            //文件流
            FileStream fs = null;
            //workbook
            IWorkbook workbook = null;
            try
            {
                //记录文件路径
                string filePath = string.Empty;
                //打开导入文件对话框
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Excel ⼯作簿(*.xlsx)|*.xlsx";
                //判断是否记录上一次的打开文件夹路径
                if (!string.IsNullOrEmpty(lastChoosePath))
                {
                    ofd.InitialDirectory = lastChoosePath;
                }
                else
                {
                    ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                }
                ofd.Multiselect = false;
                //打开确认
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //全路径
                    filePath = ofd.FileName;
                    lastChoosePath = Path.GetDirectoryName(filePath);
                }
                else
                {
                    return false;
                }
                //读取文档
                using (fs = File.Open(filePath, FileMode.Open, FileAccess.Read))
                {
                    //workbook、sheets、columns
                    workbook = new XSSFWorkbook(fs);
                    int sheetNum = workbook.NumberOfSheets;
                    List<ISheet> sheets = new List<ISheet>();
                    //循环sheet
                    for (int i = 0; i < sheetNum; i++)
                    {
                        ISheet sheet = workbook.GetSheetAt(i);
                        if (sheet != null)
                        {
                            IRow columnRow = sheet.GetRow(1);
                            //判断字段列是否为空
                            if (columnRow == null)
                            {
                                message = $"错误\r文档第{i + 1}个sheet不存在字段列！";
                                return false;
                            }
                            //判断字段列是否为7个字段
                            if (columnRow.Cells.Count != columns.Length)
                            {
                                message = $"错误\r文档第{i + 1}个sheet列字段数量不正确！";
                                return false;
                            }
                            //判断列字段是否正确
                            for (int j = 0; j < columnRow.Cells.Count; j++)
                            {
                                if (columnRow.Cells[j].ToString().Replace("\r", "").Replace("\n", "") != columns[j])
                                {
                                    message = $"错误\r文档第{i + 1}个sheet列字段第{j + 1}个字段不正确，应该为【{columns[j]}】！";
                                    return false;
                                }
                            }
                            //获取字段拼接表
                            int rowNum = sheet.LastRowNum;
                            for (int j = 2; j < rowNum; j++)
                            {
                                IRow dataRow = sheet.GetRow(j);
                                DataRow dr = dt.NewRow();
                                //添加序号列
                                dr[0] = j - 1;
                                //添加字段列
                                for (int k = 0; k < columns.Length; k++)
                                {
                                    dr[k + 1] = dataRow.Cells[k].ToString();
                                }
                                dt.Rows.Add(dr);
                            }
                        }
                        else
                        {
                            message = $"错误\r文档第{i + 1}个sheet不存在！";
                            return false;
                        }
                    }
                }
                //返回正确结果
                return true;
            }
            catch (Exception ex)
            {
                message = $"错误\r{ex.Message}";
                return false;
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                    fs.Dispose();
                }
                if (workbook != null)
                {
                    workbook.Close();
                }
            }
        }
        #endregion

        #region 校验数据和数据库是否匹配
        private void ValidateData(ref DataTable dt, ref StringBuilder sbError)
        {
            //dt添加备注列
            dt.Columns.Add("Remark", typeof(string));
            //获取业务数据
            PduValidateResult pduValidateResult = GetBusinessData();
            //循环
            int index = 0;
            foreach (DataRow dr in dt.Rows)
            {
                //获取部门信息和员工信息
                string strBuNo = dr["BuNo"].ToString();
                string strBuName = dr["BuName"].ToString();
                string strEmpNo = dr["EmpNo"].ToString();
                string strEmpName = dr["EmpName"].ToString();
                //判断BU编号+BU名称是否存在
                int orgCount = pduValidateResult.orgResults.Where(item => item.OrgNo == strBuNo && item.OrgName == strBuName).ToList().Count;
                if (orgCount <= 0)
                {
                    string errOrg = $"第{index + 3}行数据，组织信息和数据库不匹配！\r\n";
                    dr["Remark"] = errOrg;
                    sbError.Append(errOrg);
                }
                //判断负责人工号+负责人姓名是否存在
                int empCount = pduValidateResult.empResults.Where(item => item.EmpNo == strEmpNo && item.EmpName == strEmpName).ToList().Count;
                if (empCount <= 0)
                {
                    string errEmp = $"第{index + 3}行数据，负责人信息和数据库不匹配！\r\n";
                    dr["Remark"] = errEmp;
                    sbError.Append(errEmp);
                }
                //自增序号
                index++;
            }
        }
        #endregion

        #region 获取业务数据
        private PduValidateResult GetBusinessData()
        {
            //获取业务数据
            PduValidateResult pduValidateResult = new PduValidateResult();
            PduImportBusiness piBusi = new PduImportBusiness();
            pduValidateResult.orgResults = piBusi.GetLevelFourOrg(dataHelper);
            pduValidateResult.empResults = piBusi.GetEmpInfo(dataHelper);
            return pduValidateResult;
        }
        #endregion

        #endregion

        #region 构建全局表对象字段
        private DataTable CreateOrgTable()
        {
            //获取字段列
            string[] columns = GetOrgColumns()[0];
            //创建表
            DataTable dt = new DataTable();
            //添加序号列
            dt.Columns.Add("序号", typeof(Int64));
            //添加字段列
            foreach (string col in columns)
            {
                dt.Columns.Add(col);
            }
            //返回表
            return dt;
        }

        private DataTable CreateEmpTable()
        {
            //获取字段列
            string[] columns = GetEmpColumns()[0];
            //创建表
            DataTable dt = new DataTable();
            //添加序号列
            dt.Columns.Add("序号", typeof(Int64));
            //添加字段列
            foreach (string col in columns)
            {
                dt.Columns.Add(col);
            }
            //返回表
            return dt;
        }
        #endregion

        #region 获取字段清单
        private string[][] GetOrgColumns()
        {
            string[] engColumns = new string[7] { "OrgName", "ParentName", "BuName", "BuNo", "EmpName", "EmpNo", "BeginDate" };
            string[] chnColumns = new string[7] { "* 业务组织名称", "直接上层业务组织", "* 所属BU", "* 所属BU编码", "* 部门负责人姓名", "* 部门负责人工号", "生效月" };
            return new string[2][] { engColumns, chnColumns };
        }

        private string[][] GetEmpColumns()
        {
            string[] engColumns = new string[6] { "EmpNo", "EmpName", "OrgName", "BuNo", "BuName", "BeginDate" };
            string[] chnColumns = new string[6] { "* 员工工号", "* 员工姓名", "* 所属业务组织名称（末级组织）", "* 所属BU编码", "* 所属BU", "生效月" };
            return new string[2][] { engColumns, chnColumns };
        }
        #endregion
    }
}
