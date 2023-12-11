using Microsoft.EntityFrameworkCore;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private Dictionary<string, CompareOrg> dicOrgName = new Dictionary<string, CompareOrg>(); //存储PDU业务名称，用来校验重复

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
            //行点击事件
            this.dv_Org.Dv.CellClick += Org_Dv_CellClick;
            this.dv_Emp.Dv.CellClick += Emp_Dv_CellClick;
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

        #region 切换生产库
        private void cb_IsProb_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_IsProb.Checked)
            {
                this.cmb_IP.Text = "127.0.0.1,7002";
                this.tb_LoginAccount.Text = "recruit_w";
                this.tb_LoginPassword.Text = "wL1z26E5";
            }
            else
            {
                this.cmb_IP.Text = "10.136.0.114";
                this.tb_LoginAccount.Text = "hruser";
                this.tb_LoginPassword.Text = "rmohr123@abc";
            }
        }
        #endregion

        #region 网格行选中事件
        private void Org_Dv_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (this.dv_Org.GetRow(e.RowIndex).Cells["Remark"] != null)
                {
                    this.rtb_Org_RowError.Text = this.dv_Org.GetRow(e.RowIndex).Cells["Remark"].Value.ToString();
                    this.rtb_Org_RowError.ForeColor = Color.Red;
                }
                else
                {
                    this.rtb_Org_RowError.Clear();
                }
            }
        }

        private void Emp_Dv_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (this.dv_Emp.GetRow(e.RowIndex).Cells["Remark"] != null)
                {
                    this.rtb_Emp_RowError.Text = this.dv_Emp.GetRow(e.RowIndex).Cells["Remark"].Value.ToString();
                    this.rtb_Emp_RowError.ForeColor = Color.Red;
                }
                else
                {
                    this.rtb_Emp_RowError.Clear();
                }
            }
        }
        #endregion

        #region 组织导入按钮
        private void btn_Org_Import_Click(object sender, EventArgs e)
        {
            //记录处理时间
            Stopwatch timeWatch = Stopwatch.StartNew();
            //错误信息
            StringBuilder sbError = new StringBuilder();
            //清除历史日志
            this.rtb_Org_FullError.Text = string.Empty;
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
                //DT 序号+原始数据
                DataTable dt = CreateOrgTable();
                //开始读取数据
                this.rtb_Org_FullError.Text += $"{DateTime.Now}:开始读取Excel\r\n";
                bool validateSheetResult = GetExcelData(ImportType.Org, GetOrgColumns()[1], ref dt, ref errorMessage);
                if (!validateSheetResult)
                {
                    this.rtb_Org_FullError.Text = $"{DateTime.Now}:{timeWatch.Elapsed}\r\n";
                    this.rtb_Org_FullError.Text += errorMessage;
                    this.rtb_Org_FullError.ForeColor = Color.Red;
                    return;
                }
                //准备校验数据
                this.rtb_Org_FullError.Text += $"{DateTime.Now}:Excel取数已完成，开始校验数据\r\n";
                //DT 序号+原始数据+Remark
                ValidateData(ImportType.Org, ref dt, ref sbError);
                //校验数据完成
                this.rtb_Org_FullError.Text += $"{DateTime.Now}:Excel校验已完成\r\n";
                //绑定网格，展示数据校验明细
                this.dv_Org.DvDataTable = dt;
                this.dv_Org.ViewDataBind(CusControls.DataGridViewEx.DataGridViewBindType.DataTable, false, false);
                //禁止排序
                this.dv_Org.IsSort = false;
                //显示错误信息
                if (!string.IsNullOrEmpty(sbError.ToString()))
                {
                    this.rtb_Org_FullError.Text = $"{DateTime.Now}:{timeWatch.Elapsed}\r\n";
                    this.rtb_Org_FullError.Text += sbError.ToString();
                    this.rtb_Org_FullError.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                this.rtb_Org_FullError.Text = $"{DateTime.Now}:{timeWatch.Elapsed}:程序异常\r\n";
                this.rtb_Org_FullError.Text += $"错误如下===>\r{ex.Message}";
                this.rtb_Org_FullError.ForeColor = Color.Red;
                return;
            }
            finally
            {
                dicOrgName.Clear();
                if (string.IsNullOrEmpty(sbError.ToString()))
                {
                    this.rtb_Org_FullError.Text += $"{DateTime.Now}:数据正确\r\n";
                    this.rtb_Org_FullError.ForeColor = Color.Blue;
                }
            }
        }
        #endregion

        #region 人员导入按钮
        private void btn_Emp_Import_Click(object sender, EventArgs e)
        {
            //记录处理时间
            Stopwatch timeWatch = Stopwatch.StartNew();
            //错误信息
            StringBuilder sbError = new StringBuilder();
            //清除历史日志
            this.rtb_Emp_FullError.Text = string.Empty;
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
                //DT 序号+原始数据
                DataTable dt = CreateEmpTable();
                //开始读取数据
                this.rtb_Emp_FullError.Text += $"{DateTime.Now}:开始读取Excel\r\n";
                bool validateSheetResult = GetExcelData(ImportType.Emp, GetEmpColumns()[1], ref dt, ref errorMessage);
                if (!validateSheetResult)
                {
                    this.rtb_Emp_FullError.Text = $"{DateTime.Now}:{timeWatch.Elapsed}\r\n";
                    this.rtb_Emp_FullError.Text += errorMessage;
                    this.rtb_Emp_FullError.ForeColor = Color.Red;
                    return;
                }
                //准备校验数据
                this.rtb_Emp_FullError.Text += $"{DateTime.Now}:Excel取数已完成，开始校验数据\r\n";
                //DT 序号+原始数据+Remark
                ValidateData(ImportType.Emp, ref dt, ref sbError);
                //校验数据完成
                this.rtb_Emp_FullError.Text += $"{DateTime.Now}:Excel校验已完成\r\n";
                //绑定网格，展示数据校验明细
                this.dv_Emp.DvDataTable = dt;
                this.dv_Emp.ViewDataBind(CusControls.DataGridViewEx.DataGridViewBindType.DataTable, false, false);
                //禁止排序
                this.dv_Emp.IsSort = false;
                //显示错误信息
                if (!string.IsNullOrEmpty(sbError.ToString()))
                {
                    this.rtb_Emp_FullError.Text = $"{DateTime.Now}:{timeWatch.Elapsed}\r\n";
                    this.rtb_Emp_FullError.Text += sbError.ToString();
                    this.rtb_Emp_FullError.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                this.rtb_Emp_FullError.Text = $"{DateTime.Now}:{timeWatch.Elapsed}:程序异常\r\n";
                this.rtb_Emp_FullError.Text += $"错误如下===>\r{ex.Message}";
                this.rtb_Emp_FullError.ForeColor = Color.Red;
                return;
            }
            finally
            {
                if (string.IsNullOrEmpty(sbError.ToString()))
                {
                    this.rtb_Emp_FullError.Text += $"{DateTime.Now}:数据正确\r\n";
                    this.rtb_Emp_FullError.ForeColor = Color.Blue;
                }
            }
        }
        #endregion

        #region 校验Excel并读取数据
        /// <summary>
        /// 此方法只校验Excel格式，列字段信息;
        /// </summary>
        /// <param name="type"></param>
        /// <param name="columns"></param>
        /// <param name="dt"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        private bool GetExcelData(ImportType type, string[] columns, ref DataTable dt, ref string message)
        {
            //文件流
            FileStream fs = null;
            //workbook
            IWorkbook workbook = null;
            try
            {
                #region 记录上次打开路径，为空打开桌面

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

                #endregion

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
                            #region 判断sheet列字段是否正确

                            //sheet名称
                            string sheetName = sheet.SheetName;
                            //字段行
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

                            #endregion

                            #region 读取Excel内容

                            //获取字段拼接表
                            int rowNum = sheet.LastRowNum;
                            for (int j = 2; j <= rowNum; j++)
                            {
                                DataRow dr = dt.NewRow();
                                //写入序号列
                                dr[0] = $"{sheetName}:{j - 1}";
                                //添加字段列
                                for (int k = 0; k < columns.Length; k++)
                                {
                                    var objValue = sheet.GetRow(j).GetCell(k);
                                    dr[k + 1] = objValue == null ? "" : objValue.ToString();
                                }
                                //插入行
                                dt.Rows.Add(dr);
                            }

                            #endregion
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

        #region 校验数据
        /// <summary>
        /// 校验数据和数据库是否匹配
        /// 如果导入的是组织清单，还需要校验： ---- 后期还需要和数据库对比脚本（本次不做）
        /// 1.【业务组织名称】是否存在重复
        /// 2.【直接上层业务组织】是否在【业务组织名称】存在 （BuNo一致的才认为是上层组织）
        /// 如果导入的是人员清单，还需要校验
        /// 1.【员工工号】是否存在重复
        /// 2.【PDU业务组织】是否存在
        /// </summary>
        /// <param name="type"></param>
        /// <param name="dt"></param>
        /// <param name="sbError"></param>
        private void ValidateData(ImportType type, ref DataTable dt, ref StringBuilder sbError)
        {
            //dt添加备注列
            dt.Columns.Add("Remark", typeof(string));
            //获取业务数据
            PduValidateResult pduValidateResult = GetBusinessData();

            //循环
            foreach (DataRow dr in dt.Rows)
            {
                //获取序号信息
                string strNum = $"{dr["序号"]}";
                int iExcelNum = Convert.ToInt32(strNum.Split(':')[1]) + 2;
                //获取PDU信息
                string strOrgName = $"{dr["OrgName"]}";
                //获取PDU信息 - 获取父级信息
                string strParentName = type == ImportType.Org ? $"{dr["ParentName"]}" : "";
                //获取BU信息
                string strBuNo = $"{dr["BuNo"]}";
                string strBuName = $"{dr["BuName"]}";
                //获取员工信息
                string strEmpNo = $"{dr["EmpNo"]}";
                string strEmpName = $"{dr["EmpName"]}";

            }
        }

        #endregion

        #region 获取业务数据
        private PduValidateResult GetBusinessData()
        {
            //获取业务数据
            PduValidateResult pduValidateResult = new PduValidateResult();
            PduImportBusiness piBusi = new PduImportBusiness();
            pduValidateResult.OriginLevelFourOrgResult = piBusi.GetOriginLevelFourOrg(dataHelper);
            pduValidateResult.OriginEmpResult = piBusi.GetOriginEmpInfo(dataHelper);
            pduValidateResult.PduDepartmentResult = piBusi.GetPduDepartment(dataHelper);
            pduValidateResult.PduEmployeeResult = piBusi.GetPduEmployee(dataHelper);
            return pduValidateResult;
        }
        #endregion

        #region 构建全局表对象字段
        private DataTable CreateOrgTable()
        {
            //获取字段列
            string[] columns = GetOrgColumns()[0];
            //创建表
            DataTable dt = new DataTable();
            //添加序号列
            dt.Columns.Add("序号", typeof(string));
            //添加字段列
            foreach (string col in columns)
            {
                dt.Columns.Add(col);
            }
            //添加OrgNo，ParentNO，LeaderId列
            dt.Columns.Add("OrgNo", typeof(string));
            dt.Columns.Add("ParentNO", typeof(string));
            dt.Columns.Add("LeaderId", typeof(Int64));
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
            dt.Columns.Add("序号", typeof(string));
            //添加字段列
            foreach (string col in columns)
            {
                dt.Columns.Add(col);
            }
            //添加OrgNo，LeaderId
            dt.Columns.Add("OrgNo", typeof(string));
            dt.Columns.Add("LeaderId", typeof(Int64));
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
            string[] engColumns = new string[6] { "EmpNo", "EmpName", "OrgName", "BuName", "BuNo", "BeginDate" };
            string[] chnColumns = new string[6] { "* 员工工号", "* 员工姓名", "* 所属业务组织名称（末级组织）", "* 所属BU", "* 所属BU编码", "生效月" };
            return new string[2][] { engColumns, chnColumns };
        }
        #endregion

        #region 生成组织脚本
        private void btn_Org_Script_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            if (this.dv_Org.DvDataTable == null)
            {
                this.rtb_Org_SqlScript.Text = "error : 表没有数据";
                return;
            }
            DataTable dt = this.dv_Org.DvDataTable;
            foreach (DataRow row in dt.Rows)
            {
                string deptNo = $"{row["OrgNo"]}";
                string deptName = $"{row["OrgName"]}";
                string parentNo = $"{row["ParentNo"]}";
                string buNo = $"{row["BuNo"]}";
                Int64? leaderId = row["LeaderId"] != System.DBNull.Value ? Convert.ToInt64($"{row["LeaderId"]}") : null;
                string empNo = $"{row["EmpNo"]}";
                string empName = $"{row["EmpName"]}";
                string remark = $"{row["Remark"]}";
                //if (string.IsNullOrEmpty(remark))
                //{
                sb.AppendLine($@"INSERT INTO PSAData..mng_PduDepartment ( Dep_DeptNo, Dep_DeptName, Dep_DeptShortName, Dep_ParDeptNo, Dep_Level4DeptNo, Dep_Level, Dep_DeptEnglishName, Dep_DeptEnglishShortName, Dep_LeaderId, Dep_EmpNo, Dep_EmpName, Dep_BeginDate, Dep_EndDate, Creator, CreateDate, Modifier, ModifyDate, Dep_Status, Dep_Description ) VALUES('{deptNo}', '{deptName}', '', '{parentNo}', '{buNo}', 0, '', '', {leaderId}, '{empNo}', '{empName}', GETDATE(), GETDATE(), 'changls', GETDATE(), 'changls', GETDATE(), 0, '' );");
                //}
            }
            this.rtb_Org_SqlScript.Text = sb.ToString();
        }
        #endregion

        #region 生成人员脚本
        private void btn_Emp_Script_Click(object sender, EventArgs e)
        {
            if (this.dv_Emp.DvDataTable == null)
            {
                this.rtb_Emp_SqlScript.Text = "error : 表没有数据";
                return;
            }
            StringBuilder sb = new StringBuilder();
            DataTable dt = this.dv_Emp.DvDataTable;
            foreach (DataRow row in dt.Rows)
            {
                string deptNo = $"{row["OrgNo"]}";
                string empNo = $"{row["EmpNo"]}";
                string remark = $"{row["Remark"]}";
                //if (string.IsNullOrEmpty(remark))
                //{
                sb.AppendLine($@"INSERT INTO PSAData..mng_Pdu_Employee ( Dep_No, EmployeeNo, Dep_BeginDate, Dep_EndDate, Creator, CreateDate, Modifier, ModifyDate ) VALUES ('{deptNo}', '{empNo}', GETDATE(), GETDATE(), 'changls', GETDATE(), 'changls', GETDATE());");
                //}
            }
            this.rtb_Emp_SqlScript.Text = sb.ToString();
        }
        #endregion

    }
}