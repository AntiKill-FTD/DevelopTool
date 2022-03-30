using System.Data;
using Tool.CusControls.DataGridViewEx;
using Tool.Data.DataHelper;
using Tool.Data.SqlConfig;
using Tool.IService.Model.Common;
using Tool.IService.Model.Sys;
using Tool.Service.Common;
using static System.Windows.Forms.ComboBox;

namespace Tool.Main.Forms.SysConfig.ChildForms
{
    public partial class SysConfigChild : Form
    {
        private EnumSqlType _sqlType;
        private ICommonDataHelper _dataHelper;
        private ChildMenuType _childMenuType;
        private Dictionary<string, Dictionary<string, Dictionary<string, Dictionary<string, List<string>>>>> dicFull = new Dictionary<string, Dictionary<string, Dictionary<string, Dictionary<string, List<string>>>>>();

        #region Ctor

        public SysConfigChild(ChildMenuType type, EnumSqlType sqlType, PConfig pConfig = null)
        {
            InitializeComponent();
            //注入
            _dataHelper = Program.ServiceProvider.GetService(typeof(ICommonDataHelper)) as ICommonDataHelper;
            //更改标题，绑定数据
            _childMenuType = type;
            _sqlType = sqlType;

            //获取下拉框字典
            GetComboDic();

            //初始化控件绑定
            BindCombo(0);

            //更新菜单、修改数据绑定
            if (type == ChildMenuType.Add)
            {
                this.Text = "新增配置项";
            }
            else if (type == ChildMenuType.Edit)
            {
                this.Text = "编辑配置项";
                BindModifyData(pConfig);
            }
        }

        #endregion

        #region 获取下拉控件字典
        private void GetComboDic()
        {
            //获取主sql
            Dictionary<string, string> sqlDic = SqlConfig.GetSql("SQLConfig/SysConfigGroup/SysConfig/ComboBind/", _sqlType.ToString());
            DataTable dt = _dataHelper.GetDataTable(sqlDic["Query"].ToString(), sqlDic["Order"].ToString());
            //循环添加到字典
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                string level1CodeName = $"{dr["C1"]}.{dr["N1"]}";
                string level2CodeName = $"{dr["C2"]}.{dr["N2"]}";
                string level3CodeName = $"{dr["C3"]}.{dr["N3"]}";
                string level4CodeName = $"{dr["C4"]}.{dr["N4"]}";
                string level5CodeName = $"{dr["C5"]}.{dr["N5"]}";
                if (dicFull.Keys.Contains(level1CodeName))
                {
                    if (dicFull[level1CodeName].Keys.Contains(level2CodeName))
                    {
                        if (dicFull[level1CodeName][level2CodeName].Keys.Contains(level3CodeName))
                        {
                            if (dicFull[level1CodeName][level2CodeName][level3CodeName].Keys.Contains(level4CodeName))
                            {
                                if (dicFull[level1CodeName][level2CodeName][level3CodeName][level4CodeName].Contains(level5CodeName))
                                {
                                    continue;
                                }
                                else
                                {
                                    dicFull[level1CodeName][level2CodeName][level3CodeName][level4CodeName].Add(level5CodeName);
                                }
                            }
                            else
                            {
                                List<string> dic5 = new List<string>() { level5CodeName };
                                dicFull[level1CodeName][level2CodeName][level3CodeName].Add(level4CodeName, dic5);
                            }
                        }
                        else
                        {
                            List<string> dic5 = new List<string>() { level5CodeName };
                            Dictionary<string, List<string>> dic4 = new Dictionary<string, List<string>>() { { level4CodeName, dic5 } };
                            dicFull[level1CodeName][level2CodeName].Add(level3CodeName, dic4);
                        }
                    }
                    else
                    {
                        List<string> dic5 = new List<string>() { level5CodeName };
                        Dictionary<string, List<string>> dic4 = new Dictionary<string, List<string>>() { { level4CodeName, dic5 } };
                        Dictionary<string, Dictionary<string, List<string>>> dic3 = new Dictionary<string, Dictionary<string, List<string>>>() { { level3CodeName, dic4 } };
                        dicFull[level1CodeName].Add(level2CodeName, dic3);
                    }
                }
                else
                {
                    List<string> dic5 = new List<string>() { level5CodeName };
                    Dictionary<string, List<string>> dic4 = new Dictionary<string, List<string>>() { { level4CodeName, dic5 } };
                    Dictionary<string, Dictionary<string, List<string>>> dic3 = new Dictionary<string, Dictionary<string, List<string>>>() { { level3CodeName, dic4 } };
                    Dictionary<string, Dictionary<string, Dictionary<string, List<string>>>> dic2 = new Dictionary<string, Dictionary<string, Dictionary<string, List<string>>>>() { { level2CodeName, dic3 } };
                    dicFull.Add(level1CodeName, dic2);
                }
            }
        }
        #endregion

        #region 初始化控件绑定
        private void BindCombo(int level)
        {
            string level1CodeName = $"{cb_Level1Code.Text}.{cb_Level1Code.SelectedValue}";
            string level2CodeName = $"{cb_Level2Code.Text}.{cb_Level2Code.SelectedValue}";
            string level3CodeName = $"{cb_Level3Code.Text}.{cb_Level3Code.SelectedValue}";
            string level4CodeName = $"{cb_Level4Code.Text}.{cb_Level4Code.SelectedValue}";
            string level5CodeName = $"{cb_Level5Code.Text}.{cb_Level5Code.SelectedValue}";
            switch (level)
            {
                case 0:
                    //获取字典
                    if (dicFull.Keys == null) return;
                    List<string> dics1 = dicFull.Keys.ToList();
                    List<ComboBoxObject> items1 = new List<ComboBoxObject>();
                    items1.Add(new ComboBoxObject { Text = "", Value = "" });
                    dics1.ForEach(item =>
                    {
                        items1.Add(new ComboBoxObject { Text = item.Split(".")[0], Value = item.Split(".")[1] });
                    });
                    //绑定下级控件集合
                    cb_Level1Code.DataSource = items1;
                    cb_Level1Code.DisplayMember = "Text";
                    cb_Level1Code.ValueMember = "Value";
                    break;
                case 1:
                    //清除下级控件绑定集合
                    cb_Level5Code.DataSource = null;
                    cb_Level4Code.DataSource = null;
                    cb_Level3Code.DataSource = null;
                    cb_Level2Code.DataSource = null;
                    //清空Name
                    tb_Level5Name.Text = String.Empty;
                    tb_Level4Name.Text = String.Empty;
                    tb_Level3Name.Text = String.Empty;
                    tb_Level2Name.Text = String.Empty;
                    tb_Level1Name.Text = String.Empty;
                    //判断是否为空
                    if (level1CodeName.EndsWith(".")) return;
                    //赋值Name
                    tb_Level1Name.Text = cb_Level1Code.SelectedValue.ToString();
                    //获取字典
                    if (!dicFull.Keys.Contains(level1CodeName)) return;
                    List<string> dics2 = dicFull[level1CodeName].Keys.ToList();
                    List<ComboBoxObject> items2 = new List<ComboBoxObject>();
                    items2.Add(new ComboBoxObject { Text = "", Value = "" });
                    dics2.ForEach(item =>
                    {
                        items2.Add(new ComboBoxObject { Text = item.Split(".")[0], Value = item.Split(".")[1] });
                    });
                    //绑定下级控件集合
                    cb_Level2Code.DataSource = items2;
                    cb_Level2Code.DisplayMember = "Text";
                    cb_Level2Code.ValueMember = "Value";
                    break;
                case 2:
                    //清除下级控件绑定集合
                    cb_Level5Code.DataSource = null;
                    cb_Level4Code.DataSource = null;
                    cb_Level3Code.DataSource = null;
                    //清空Name
                    tb_Level5Name.Text = String.Empty;
                    tb_Level4Name.Text = String.Empty;
                    tb_Level3Name.Text = String.Empty;
                    tb_Level2Name.Text = String.Empty;
                    //判断是否为空
                    if (level2CodeName.EndsWith(".")) return;
                    //赋值Name
                    tb_Level2Name.Text = cb_Level2Code.SelectedValue.ToString();
                    //获取字典
                    if (!dicFull[level1CodeName].Keys.Contains(level2CodeName)) return;
                    List<string> dics3 = dicFull[level1CodeName][level2CodeName].Keys.ToList();
                    List<ComboBoxObject> items3 = new List<ComboBoxObject>();
                    items3.Add(new ComboBoxObject { Text = "", Value = "" });
                    dics3.ForEach(item =>
                    {
                        items3.Add(new ComboBoxObject { Text = item.Split(".")[0], Value = item.Split(".")[1] });
                    });
                    //绑定下级控件集合
                    cb_Level3Code.DataSource = items3;
                    cb_Level3Code.DisplayMember = "Text";
                    cb_Level3Code.ValueMember = "Value";
                    break;
                case 3:
                    //清除下级控件绑定集合
                    cb_Level5Code.DataSource = null;
                    cb_Level4Code.DataSource = null;
                    //清空Name
                    tb_Level5Name.Text = String.Empty;
                    tb_Level4Name.Text = String.Empty;
                    tb_Level3Name.Text = String.Empty;
                    //判断是否为空
                    if (level3CodeName.EndsWith(".")) return;
                    //赋值Name
                    tb_Level3Name.Text = cb_Level3Code.SelectedValue.ToString();
                    //获取字典
                    if (!dicFull[level1CodeName][level2CodeName].Keys.Contains(level3CodeName)) return;
                    List<string> dics4 = dicFull[level1CodeName][level2CodeName][level3CodeName].Keys.ToList();
                    List<ComboBoxObject> items4 = new List<ComboBoxObject>();
                    items4.Add(new ComboBoxObject { Text = "", Value = "" });
                    dics4.ForEach(item =>
                    {
                        items4.Add(new ComboBoxObject { Text = item.Split(".")[0], Value = item.Split(".")[1] });
                    });
                    //绑定下级控件集合
                    cb_Level4Code.DataSource = items4;
                    cb_Level4Code.DisplayMember = "Text";
                    cb_Level4Code.ValueMember = "Value";
                    break;
                case 4:
                    //清除下级控件绑定集合
                    cb_Level5Code.DataSource = null;
                    //清空Name
                    tb_Level5Name.Text = String.Empty;
                    tb_Level4Name.Text = String.Empty;
                    //判断是否为空
                    if (level4CodeName.EndsWith(".")) return;
                    //赋值Name
                    tb_Level4Name.Text = cb_Level4Code.SelectedValue.ToString();
                    //获取字典
                    if (!dicFull[level1CodeName][level2CodeName][level3CodeName].Keys.Contains(level4CodeName)) return;
                    List<string> dics5 = dicFull[level1CodeName][level2CodeName][level3CodeName][level4CodeName];
                    List<ComboBoxObject> items5 = new List<ComboBoxObject>();
                    items5.Add(new ComboBoxObject { Text = "", Value = "" });
                    dics5.ForEach(item =>
                    {
                        items5.Add(new ComboBoxObject { Text = item.Split(".")[0], Value = item.Split(".")[1] });
                    });
                    //绑定下级控件集合
                    cb_Level5Code.DataSource = items5;
                    cb_Level5Code.DisplayMember = "Text";
                    cb_Level5Code.ValueMember = "Value";
                    break;
                case 5:
                    //清空Name
                    tb_Level5Name.Text = String.Empty;
                    //判断是否为空
                    if (level5CodeName.EndsWith(".")) return;
                    //赋值Name
                    tb_Level5Name.Text = cb_Level5Code.SelectedValue.ToString();
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region 绑定编辑数据
        private void BindModifyData(PConfig pConfig)
        {

        }
        #endregion

        #region 按钮事件

        #region 保存按钮
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //必填校验
                if (string.IsNullOrEmpty(cb_Level1Code.Text)
                    || string.IsNullOrEmpty(tb_Level1Name.Text.Trim())
                    || string.IsNullOrEmpty(rtb_ConfigValue.Text.Trim()))
                {
                    MessageBox.Show("请填选必填项", "提示");
                    return;
                }

                //提取实例
                PConfig pConfig = new PConfig();
                //1.ID
                if (_childMenuType == ChildMenuType.Edit)
                {
                    pConfig.Id = Convert.ToInt32(lbl_ID.Text);
                }
                //2.配置信息
                pConfig.ConfigTypeCode1 = cb_Level1Code.Text.Trim();
                pConfig.ConfigTypeName1 = tb_Level1Name.Text.Trim();
                pConfig.ConfigTypeCode2 = cb_Level2Code.Text.Trim();
                pConfig.ConfigTypeName2 = tb_Level2Name.Text.Trim();
                pConfig.ConfigTypeCode3 = cb_Level3Code.Text.Trim();
                pConfig.ConfigTypeName3 = tb_Level3Name.Text.Trim();
                pConfig.ConfigTypeCode4 = cb_Level4Code.Text.Trim();
                pConfig.ConfigTypeName4 = tb_Level4Name.Text.Trim();
                pConfig.ConfigTypeCode5 = cb_Level5Code.Text.Trim();
                pConfig.ConfigTypeName5 = tb_Level5Name.Text.Trim();
                pConfig.ConfigValue = rtb_ConfigValue.Text.Trim();
                pConfig.Remark = rtb_Remark.Text.Trim();
                //校验所有输入不能包括.号
                if (pConfig.ConfigTypeCode1.Contains(".") || pConfig.ConfigTypeName1.Contains(".")
                    || pConfig.ConfigTypeCode2.Contains(".") || pConfig.ConfigTypeName2.Contains(".")
                    || pConfig.ConfigTypeCode3.Contains(".") || pConfig.ConfigTypeName3.Contains(".")
                    || pConfig.ConfigTypeCode4.Contains(".") || pConfig.ConfigTypeName4.Contains(".")
                    || pConfig.ConfigTypeCode5.Contains(".") || pConfig.ConfigTypeName5.Contains("."))
                {
                    MessageBox.Show("配置编号和名称不能包括【.】！", "提示");
                    return;
                }
                //校验配置编码不能重复
                string checkSql = $"select count(*) from P_Config where ConfigTypeCode1='{pConfig.ConfigTypeCode1}' AND ConfigTypeCode2='{pConfig.ConfigTypeCode2}' AND ConfigTypeCode3='{pConfig.ConfigTypeCode3}' AND ConfigTypeCode4='{pConfig.ConfigTypeCode4}' AND ConfigTypeCode5='{pConfig.ConfigTypeCode5}' AND ID <> {pConfig.Id};";
                bool checkResult = false;
                Int64 checkIResult = _dataHelper.ExcuteScalar<Int64>(checkSql, ref checkResult);
                if (checkIResult > 0)
                {
                    MessageBox.Show("配置编号重复！", "提示");
                    return;
                }
                //sql
                string sql = string.Empty;
                if (_childMenuType == ChildMenuType.Add)
                {
                    sql = $"Insert into P_Config (ConfigTypeCode1,ConfigTypeName1,ConfigTypeCode2,ConfigTypeName2,ConfigTypeCode3,ConfigTypeName3,ConfigTypeCode4,ConfigTypeName4,ConfigTypeCode5,ConfigTypeName5,ConfigValue,Remark) values ('{pConfig.ConfigTypeCode1}','{pConfig.ConfigTypeName1}','{pConfig.ConfigTypeCode2}','{pConfig.ConfigTypeName2}','{pConfig.ConfigTypeCode3}','{pConfig.ConfigTypeName3}','{pConfig.ConfigTypeCode4}','{pConfig.ConfigTypeName4}','{pConfig.ConfigTypeCode5}','{pConfig.ConfigTypeName5}','{pConfig.ConfigValue}','{pConfig.Remark}');";
                }
                else
                {
                    sql = $"Update P_Config set ConfigTypeCode1='{pConfig.ConfigTypeCode1}',ConfigTypeName1='{pConfig.ConfigTypeName1}',ConfigTypeCode2='{pConfig.ConfigTypeCode2}',ConfigTypeName2='{pConfig.ConfigTypeName2}',ConfigTypeCode3='{pConfig.ConfigTypeCode3}',ConfigTypeName3='{pConfig.ConfigTypeName3}',ConfigTypeCode4={pConfig.ConfigTypeCode4},ConfigTypeName4={pConfig.ConfigTypeName4},ConfigTypeCode5={pConfig.ConfigTypeCode5},ConfigTypeName5={pConfig.ConfigTypeName5},ConfigValue={pConfig.ConfigValue},Remark={pConfig.Remark} WHERE ID={pConfig.Id};";
                }
                //执行
                long result = _dataHelper.ExcuteNoQuery(sql);
                if (result > 0)
                {
                    MessageBox.Show("保存成功", "提示");
                    //刷新父界面
                    ((SysConfig)this.Tag).btnSearch_Click(null, null);
                    //关闭弹窗
                    btnExit_Click(null, null);
                }
                else
                {
                    MessageBox.Show("保存失败", "提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示");
            }
        }
        #endregion

        #region 退出按钮
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
        #endregion

        #endregion

        #region ComboBoxTextChanged

        private void cb_Level1Code_TextChanged(object sender, EventArgs e)
        {
            BindCombo(1);
        }

        private void cb_Level2Code_TextChanged(object sender, EventArgs e)
        {
            BindCombo(2);
        }

        private void cb_Level3Code_TextChanged(object sender, EventArgs e)
        {
            BindCombo(3);
        }

        private void cb_Level4Code_TextChanged(object sender, EventArgs e)
        {
            BindCombo(4);
        }

        private void cb_Level5Code_TextChanged(object sender, EventArgs e)
        {
            BindCombo(5);
        }

        #endregion
    }
}
