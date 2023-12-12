using Microsoft.EntityFrameworkCore;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.Data;
using System.Text;
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
            //清除历史日志
            this.rtb_Org_FullError.Text = string.Empty;
            this.rtb_Org_FullError.ForeColor = Color.Black;
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
                //原始数据
                List<ImportOrg> orgList = new List<ImportOrg>();
                //开始读取数据
                bool validateSheetResult = GetExcelData(ImportType.Org, orgList, null, ref errorMessage);
                if (!validateSheetResult)
                {
                    this.rtb_Org_FullError.Text = $"{DateTime.Now}:{errorMessage}\r\n";
                    this.rtb_Org_FullError.ForeColor = Color.Red;
                    return;
                }
                //准备校验数据
                AppendLog(ImportType.Org, $"Excel取数已完成，开始校验数据");
                //DT 序号+原始数据+Remark
                ValidateData(ImportType.Org, orgList, null);
                //校验数据完成
                AppendLog(ImportType.Org, $"Excel校验已完成");
                //绑定网格，展示数据校验明细
                this.dv_Org.SetDvObject(orgList);
                this.dv_Org.ViewDataBind(CusControls.DataGridViewEx.DataGridViewBindType.Object, false, false);
                //禁止排序
                this.dv_Org.IsSort = false;
            }
            catch (Exception ex)
            {
                this.rtb_Org_FullError.Text = $"程序异常,错误如下===>\r{ex.Message}\r\n";
                this.rtb_Org_FullError.ForeColor = Color.Red;
                this.rtb_Org_FullError.Refresh();
                return;
            }
        }
        #endregion

        #region 人员导入按钮
        private void btn_Emp_Import_Click(object sender, EventArgs e)
        {
            //清除历史日志
            this.rtb_Emp_FullError.Text = string.Empty;
            this.rtb_Emp_FullError.ForeColor = Color.Black;
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
                //原始数据
                List<ImportEmp> empList = new List<ImportEmp>();
                //开始读取数据
                bool validateSheetResult = GetExcelData(ImportType.Emp, null, empList, ref errorMessage);
                if (!validateSheetResult)
                {
                    this.rtb_Emp_FullError.Text = $"{DateTime.Now}:{errorMessage}\r\n";
                    this.rtb_Emp_FullError.ForeColor = Color.Red;
                    return;
                }
                //准备校验数据
                AppendLog(ImportType.Emp, $"Excel取数已完成，开始校验数据");
                //DT 序号+原始数据+Remark
                ValidateData(ImportType.Emp, null, empList);
                //校验数据完成
                AppendLog(ImportType.Emp, $"Excel校验已完成");
                //绑定网格，展示数据校验明细
                this.dv_Emp.SetDvObject(empList);
                this.dv_Emp.ViewDataBind(CusControls.DataGridViewEx.DataGridViewBindType.Object, false, false);
                //禁止排序
                this.dv_Emp.IsSort = false;
            }
            catch (Exception ex)
            {
                this.rtb_Emp_FullError.Text = $"程序异常,错误如下===>\r{ex.Message}\r\n";
                this.rtb_Emp_FullError.Text += $"";
                this.rtb_Emp_FullError.ForeColor = Color.Red;
                this.rtb_Emp_FullError.Refresh();
                return;
            }
        }
        #endregion

        #region 校验Excel并读取数据
        /// <summary>
        /// 此方法只校验Excel格式，列字段信息;
        /// </summary>
        /// <param name="type"></param>
        /// <param name="dt"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        private bool GetExcelData(ImportType type, List<ImportOrg>? listOrg, List<ImportEmp>? listEmp, ref string message)
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
                ofd.InitialDirectory = @"E:\00任务\任务00010_业务交付组织\10.准备完整开发导数工具+业务新导数excel\2.第二版\2.开发调整列导数excel";
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

                #region 根据导入类型获取文档规定列

                string[] columns = type == ImportType.Org ? GetOrgColumns()[1] : GetEmpColumns()[1];

                #endregion

                //记录日志
                AppendLog(type, $"开始读取Excel");

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

                            //获取最后一行
                            int rowNum = sheet.LastRowNum;
                            //循环有效数据行
                            for (int j = 2; j <= rowNum; j++)
                            {
                                //组织
                                if (type == ImportType.Org)
                                {
                                    //定义组织数据
                                    ImportOrg orgInfo = new ImportOrg();
                                    //写入序号列
                                    orgInfo.SheetIndex = $"{sheetName}:{j + 1}";
                                    orgInfo.Index = j - 1;
                                    //添加字段列
                                    orgInfo.OrgName = sheet.GetRow(j).GetCell(0)?.ToString();
                                    orgInfo.ParentName = sheet.GetRow(j).GetCell(1)?.ToString();
                                    orgInfo.BuName = sheet.GetRow(j).GetCell(2)?.ToString();
                                    orgInfo.BuNo = sheet.GetRow(j).GetCell(3)?.ToString();
                                    orgInfo.EmpName = sheet.GetRow(j).GetCell(4)?.ToString();
                                    orgInfo.EmpNo = sheet.GetRow(j).GetCell(5)?.ToString();
                                    orgInfo.BeginDate = sheet.GetRow(j).GetCell(6)?.ToString();
                                    //添加到集合
                                    listOrg.Add(orgInfo);
                                }
                                //人员
                                if (type == ImportType.Emp)
                                {
                                    //定义人员数据
                                    ImportEmp empInfo = new ImportEmp();
                                    //写入序号列
                                    empInfo.SheetIndex = $"{sheetName}:{j + 1}";
                                    empInfo.Index = j - 1;
                                    //添加字段列
                                    empInfo.EmpNo = sheet.GetRow(j).GetCell(0)?.ToString();
                                    empInfo.EmpName = sheet.GetRow(j).GetCell(1)?.ToString();
                                    empInfo.OrgName = sheet.GetRow(j).GetCell(2)?.ToString();
                                    empInfo.BuName = sheet.GetRow(j).GetCell(3)?.ToString();
                                    empInfo.BuNo = sheet.GetRow(j).GetCell(4)?.ToString();
                                    empInfo.BeginDate = sheet.GetRow(j).GetCell(5)?.ToString();
                                    //添加到集合
                                    listEmp.Add(empInfo);
                                }
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
        private void ValidateData(ImportType type, List<ImportOrg>? listOrg, List<ImportEmp>? listEmp)
        {
            #region 判断文档重复数据

            //1.判断重复：
            AppendLog(type, $"开始校验文档重复数据");
            bool hasRepeat = false;
            //1.1 组织清单：业务组织名称 + 所属BU编码 是否重复
            if (type == ImportType.Org)
            {
                listOrg.GroupBy(item => (item.OrgName, item.BuNo))
                    .ToList().ForEach(s =>
                    {
                        if (s.ToList().Count > 1)
                        {
                            hasRepeat = true;
                            string tempRemark = $"【{string.Join("】【", s.ToList().Select(list => list.SheetIndex).ToList())}】存在相同的业务组织名称和BU编号;";
                            s.ToList().ForEach(repeatItem =>
                            {
                                listOrg.Where(findRepeat => findRepeat.SheetIndex.Equals(repeatItem.SheetIndex)).ToList().ForEach(setItem =>
                                {
                                    setItem.Remark += tempRemark;
                                });
                            });
                            AppendError(ImportType.Org, tempRemark);
                        }
                    });
            }
            //1.2 人员清单：员工工号 是否重复
            if (type == ImportType.Emp)
            {
                listEmp.GroupBy(item => (item.EmpNo))
                    .ToList().ForEach(s =>
                    {
                        if (s.ToList().Count > 1)
                        {
                            hasRepeat = true;
                            string tempRemark = $"【{string.Join("】【", s.ToList().Select(list => list.SheetIndex).ToList())}】存在相同的员工编号;";
                            s.ToList().ForEach(repeatItem =>
                            {
                                listEmp.Where(findRepeat => findRepeat.SheetIndex.Equals(repeatItem.SheetIndex)).ToList().ForEach(setItem =>
                                {
                                    setItem.Remark += tempRemark;
                                });
                            });
                            AppendError(ImportType.Emp, tempRemark);
                        }
                    });
            }
            string strHasRepeat = hasRepeat ? "【是】存在重复数据;" : "【否】不存在重复数据";
            AppendLog(type, $"文档重复数据校验完成;{strHasRepeat}");
            if (hasRepeat) return;

            #endregion

            #region 获取业务数据

            //2.获取业务数据
            AppendLog(type, $"开始获取业务数据");
            BusinessData pduValidateResult = GetBusinessData();
            AppendLog(type, $"业务数据获取完成");

            #endregion

            #region 校验业务数据匹配相关

            //3.判断数据正确：
            //3.1 组织清单：
            AppendLog(type, $"开始校验业务数据匹配相关");
            bool dataResultHasError = false;
            if (type == ImportType.Org)
            {
                listOrg.ForEach(item =>
                {
                    //3.1.1 所属BU编码 是否存在
                    BusiOriginOrgFourResult buInfo = pduValidateResult.OriginLevelFourOrgResult.Where(originItem => item.BuNo.Equals(originItem.OrgNo)).FirstOrDefault();
                    if (buInfo == null)
                    {
                        dataResultHasError = true;
                        item.Remark += $"所属BU编号在系统不存在;\r\n";
                        AppendError(type, $"{item.SheetIndex}:所属BU编号在系统不存在;");
                    }
                    //3.1.2 所属BU编码 + 所属BU 是否一致
                    //3.1.3 所属BU编码 是否是人事4级组织
                    else
                    {
                        if (!item.BuName.Equals(buInfo.OrgName))
                        {
                            dataResultHasError = true;
                            item.Remark += $"所属BU编号和BU名称不一致;\r\n";
                            AppendError(type, $"{item.SheetIndex}:所属BU编号和BU名称不一致;");
                        }
                        if (buInfo.OrgLevel != 4)
                        {
                            dataResultHasError = true;
                            item.Remark += $"所属BU编号和BU名称不一致;\r\n";
                            AppendError(type, $"{item.SheetIndex}:所属BU编号和BU名称不一致;");
                        }
                    }

                    //3.1.4 判定父级是否存在(只有【直接上层组织】不为空需要判断);
                    //      判定条件 所属BU编码 + 直接上层业务组织 在当前文档、或者数据库存在
                    if (!string.IsNullOrEmpty(item.ParentName))
                    {
                        int countParent = listOrg.Where(parentItem => item.BuNo.Equals(parentItem.BuNo) && item.ParentName.Equals(parentItem.OrgName)).ToList().Count();
                        if (countParent == 0)
                        {
                            countParent = pduValidateResult.PduDepartmentResult.Where(parentItem => item.BuNo.Equals(parentItem.BuNo) && item.ParentName.Equals(parentItem.OrgName)).ToList().Count();
                            if (countParent == 0)
                            {
                                dataResultHasError = true;
                                item.Remark += $"在当前文档以及数据库均未找到父级组织;\r\n";
                                AppendError(type, $"{item.SheetIndex}:在当前文档以及数据库均未找到父级组织;");
                            }
                        }
                    }

                    //3.1.5 部门负责人工号 是否存在
                    BusiOriginEmpResult empInfo = pduValidateResult.OriginEmpResult.Where(originItem => item.EmpNo.Equals(originItem.EmpNo)).FirstOrDefault();
                    if (empInfo == null)
                    {
                        dataResultHasError = true;
                        item.Remark += $"部门负责人工号在系统不存在;\r\n";
                        AppendError(type, $"{item.SheetIndex}:部门负责人工号在系统不存在;");
                    }
                    //3.1.6 部门负责人工号 + 部门负责人姓名 是否一致
                    //3.1.7 部门负责人工号 是否在职（根据勾选区分是否判断）
                    else
                    {
                        if (!item.EmpName.Equals(empInfo.EmpName))
                        {
                            dataResultHasError = true;
                            item.Remark += $"部门负责人工号和部门负责人姓名不一致;\r\n";
                            AppendError(type, $"{item.SheetIndex}:部门负责人工号和部门负责人姓名不一致;");
                        }
                        if (cb_CheckEmpStatus.Checked)
                        {
                            if (!"1".Equals(empInfo.EmpStatus))
                            {
                                dataResultHasError = true;
                                item.Remark += $"部门负责人不在职;\r\n";
                                AppendError(type, $"{item.SheetIndex}:部门负责人不在职;");
                            }
                        }
                    }
                    if (!dataResultHasError)
                    {
                        item.LeaderId = empInfo.EmpId.ToString();
                    }

                    //3.1.8 判定该条数据是新增还是插入
                    BusiPduDepartmentResult orgResult = pduValidateResult.PduDepartmentResult.Where(originItem => item.OrgName.Equals(originItem.OrgName) && item.BuNo.Equals(originItem.BuNo)).FirstOrDefault();
                    if (orgResult == null)
                    {
                        item.SqlType = SqlType.Insert;
                    }
                    else
                    {
                        //绑定以前的OrgNo
                        item.OrgNo = orgResult.OrgNo;
                        item.SqlType = SqlType.Update;
                    }
                });
            }
            //3.2 人员清单：
            if (type == ImportType.Emp)
            {
                listEmp.ForEach(item =>
                {
                    //3.2.1 所属业务组织名称 + 所属BU 是否存在
                    BusiPduDepartmentResult orgInfo = pduValidateResult.PduDepartmentResult.Where(originItem => item.OrgName.Equals(originItem.OrgName) && item.BuNo.Equals(originItem.BuNo)).FirstOrDefault();
                    if (orgInfo == null)
                    {
                        dataResultHasError = true;
                        item.Remark += $"所属业务组织名称和所属BU在系统不存在;\r\n";
                        AppendError(type, $"{item.SheetIndex}:所属业务组织名称和所属BU在系统不存在;");
                    }
                    //3.2.2 所属业务组织名称 + 所属BU 是否是末级PDU组织
                    else
                    {
                        if (orgInfo.ChildCount != 0)
                        {
                            dataResultHasError = true;
                            item.Remark += $"所属业务组织名称和所属BU不是末级PDU组织;\r\n";
                            AppendError(type, $"{item.SheetIndex}:所属业务组织名称和所属BU不是末级PDU组织;");
                        }
                    }
                    if (!dataResultHasError)
                    {
                        item.OrgNo = orgInfo.OrgNo;
                    }

                    //3.2.3 员工工号 是否存在
                    BusiOriginEmpResult empInfo = pduValidateResult.OriginEmpResult.Where(originItem => item.EmpNo.Equals(originItem.EmpNo)).FirstOrDefault();
                    if (empInfo == null)
                    {
                        dataResultHasError = true;
                        item.Remark += $"员工工号在系统不存在;\r\n";
                        AppendError(type, $"{item.SheetIndex}:员工工号在系统不存在;");
                    }
                    //3.2.4 员工工号 + 员工姓名 是否一致
                    //3.2.5 员工工号 是否在职（根据勾选区分是否判断）
                    else
                    {
                        if (!item.EmpName.Equals(empInfo.EmpName))
                        {
                            dataResultHasError = true;
                            item.Remark += $"员工工号和员工姓名不一致;\r\n";
                            AppendError(type, $"{item.SheetIndex}:员工工号和员工姓名不一致;");
                        }
                        if (cb_CheckEmpStatus.Checked)
                        {
                            if (!"1".Equals(empInfo.EmpStatus))
                            {
                                dataResultHasError = true;
                                item.Remark += $"部门负责人不在职;\r\n";
                                AppendError(type, $"{item.SheetIndex}:部门负责人不在职;");
                            }
                        }
                    }
                    if (!dataResultHasError)
                    {
                        item.LeaderId = empInfo.EmpId.ToString();
                    }

                    //3.2.6 判定该条数据是新增还是插入
                    BusiPduEmployeeResult empResult = pduValidateResult.PduEmployeeResult.Where(originItem => item.EmpNo.Equals(originItem.EmpNo)).FirstOrDefault();
                    if (empResult == null)
                    {
                        item.SqlType = SqlType.Insert;
                    }
                    else
                    {
                        item.SqlType = SqlType.Update;
                    }
                });
            }
            //记录日志
            string strDataResultHasError = dataResultHasError ? "【是】数据存在错误;" : "【否】数据正确;";
            AppendLog(type, $"业务数据匹配相关校验完成;{strDataResultHasError}");
            if (dataResultHasError) return;

            #endregion

            #region 生成PDU编号、绑定父级编号

            //4.组织导入:生成PDU编号、绑定父级编号
            AppendLog(type, $"组织导入,开始处理PDU编号、父级编号;");
            if (type == ImportType.Org)
            {
                listOrg.ForEach(item =>
                {

                });
            }
            AppendLog(type, $"组织导入,处理PDU编号、父级编号完成;");

            #endregion

        }

        #endregion

        #region 获取定义导入文档的字段清单
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

        #region 获取业务数据
        private BusinessData GetBusinessData()
        {
            //获取业务数据
            BusinessData pduValidateResult = new BusinessData();
            PduImportBusiness piBusi = new PduImportBusiness();
            pduValidateResult.OriginLevelFourOrgResult = piBusi.GetOriginLevelFourOrg(dataHelper);
            pduValidateResult.OriginEmpResult = piBusi.GetOriginEmpInfo(dataHelper);
            pduValidateResult.PduDepartmentResult = piBusi.GetPduDepartment(dataHelper);
            pduValidateResult.PduEmployeeResult = piBusi.GetPduEmployee(dataHelper);
            return pduValidateResult;
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

        #region 记录日志
        private void AppendLog(ImportType type, string message)
        {
            if (type == ImportType.Org)
            {
                this.rtb_Org_FullError.Text += $"{DateTime.Now}:{message}\r\n";
                this.rtb_Org_FullError.ForeColor = this.rtb_Org_FullError.ForeColor == Color.Red ? Color.Red : Color.Blue;
                this.rtb_Org_FullError.SelectionStart = this.rtb_Org_FullError.Text.Length;
                this.rtb_Org_FullError.ScrollToCaret();
                this.rtb_Org_FullError.Refresh();
            }
            else if (type == ImportType.Emp)
            {
                this.rtb_Emp_FullError.Text += $"{DateTime.Now}:{message}\r\n";
                this.rtb_Emp_FullError.ForeColor = this.rtb_Emp_FullError.ForeColor == Color.Red ? Color.Red : Color.Blue;
                this.rtb_Emp_FullError.SelectionStart = this.rtb_Emp_FullError.Text.Length;
                this.rtb_Emp_FullError.ScrollToCaret();
                this.rtb_Emp_FullError.Refresh();
            }
        }

        private void AppendError(ImportType type, string message)
        {
            if (type == ImportType.Org)
            {
                this.rtb_Org_FullError.Text += $"{DateTime.Now}:{message}\r\n";
                this.rtb_Org_FullError.ForeColor = Color.Red;
                this.rtb_Org_FullError.SelectionStart = this.rtb_Org_FullError.Text.Length;
                this.rtb_Org_FullError.ScrollToCaret();
                this.rtb_Org_FullError.Refresh();
            }
            else if (type == ImportType.Emp)
            {
                this.rtb_Emp_FullError.Text += $"{DateTime.Now}:{message}\r\n";
                this.rtb_Emp_FullError.ForeColor = Color.Red;
                this.rtb_Emp_FullError.SelectionStart = this.rtb_Emp_FullError.Text.Length;
                this.rtb_Emp_FullError.ScrollToCaret();
                this.rtb_Emp_FullError.Refresh();
            }
        }
        #endregion

    }
}