using System.Data;
using Tool.CusControls.DataGridViewEx;
using Tool.Data.DataHelper;
using Tool.Data.SqlConfig;
using Tool.IService.Model.Common;
using Tool.IService.Model.Sys;
using Tool.Main.Forms.SysConfig.ChildForms;
using Tool.Service.Common;

namespace Tool.Main.Forms.SysConfig
{
    public partial class SysConfig : Form
    {
        #region 私有变量

        private ICommonDataHelper _dataHelper;
        private Dictionary<string, Dictionary<string, Dictionary<string, Dictionary<string, List<string>>>>> dicFull = new Dictionary<string, Dictionary<string, Dictionary<string, Dictionary<string, List<string>>>>>();

        #endregion

        #region Ctor
        public SysConfig()
        {
            InitializeComponent();
            //注入
            _dataHelper = Program.ServiceProvider.GetService(typeof(ICommonDataHelper)) as ICommonDataHelper;
            this.dataViewMain.DataHelper = _dataHelper;
        }
        #endregion

        #region PageLoad

        private void SysConfig_Load(object sender, EventArgs e)
        {
            //获取下拉框字典
            GetComboDic();

            //初始化控件绑定
            BindCombo(0);

            //查询
            btnSearch_Click(null, null);
        }
        #endregion

        #region 按钮事件

        #region 查询
        public void btnSearch_Click(object sender, EventArgs e)
        {
            //获取主sql
            Dictionary<string, string> sqlDic = SqlConfig.GetSql("SQLConfig/SysConfigGroup/SysConfig/GridQuery/", this.dataViewMain.SqlType.ToString());

            //获取查询参数
            string code1 = cb_Level1Code.Text.Trim();
            string name1 = tb_Level1Name.Text.Trim();
            string code2 = cb_Level2Code.Text.Trim();
            string name2 = tb_Level2Name.Text.Trim();
            string code3 = cb_Level3Code.Text.Trim();
            string name3 = tb_Level3Name.Text.Trim();
            string code4 = cb_Level4Code.Text.Trim();
            string name4 = tb_Level4Name.Text.Trim();
            string code5 = cb_Level5Code.Text.Trim();
            string name5 = tb_Level5Name.Text.Trim();
            //拼接参数
            string sqlWhere = string.Empty;
            if (!string.IsNullOrEmpty(code1))
            {
                sqlWhere += "AND ConfigTypeCode1 LIKE '%" + code1 + "%' ";
            }
            if (!string.IsNullOrEmpty(name1))
            {
                sqlWhere += "AND ConfigTypeName1 LIKE '%" + name1 + "%' ";
            }
            if (!string.IsNullOrEmpty(code2))
            {
                sqlWhere += "AND ConfigTypeCode2 LIKE '%" + code2 + "%' ";
            }
            if (!string.IsNullOrEmpty(name2))
            {
                sqlWhere += "AND ConfigTypeName2 LIKE '%" + name2 + "%' ";
            }
            if (!string.IsNullOrEmpty(code3))
            {
                sqlWhere += "AND ConfigTypeCode3 LIKE '%" + code3 + "%' ";
            }
            if (!string.IsNullOrEmpty(name3))
            {
                sqlWhere += "AND ConfigTypeName3 LIKE '%" + name3 + "%' ";
            }
            if (!string.IsNullOrEmpty(code4))
            {
                sqlWhere += "AND ConfigTypeCode4 LIKE '%" + code4 + "%' ";
            }
            if (!string.IsNullOrEmpty(name4))
            {
                sqlWhere += "AND ConfigTypeName4 LIKE '%" + name4 + "%' ";
            }
            if (!string.IsNullOrEmpty(code5))
            {
                sqlWhere += "AND ConfigTypeCode5 LIKE '%" + code5 + "%' ";
            }
            if (!string.IsNullOrEmpty(name5))
            {
                sqlWhere += "AND ConfigTypeName5 LIKE '%" + name5 + "%' ";
            }
            //拼接SQL
            if (!string.IsNullOrEmpty(sqlWhere))
            {
                sqlWhere = sqlWhere.Substring(0, 3) == "AND" ? sqlWhere.Substring(3) : sqlWhere;
                //组装SQL
                sqlDic["Query"] = sqlDic["Query"].Replace("1=1", sqlWhere);
            }
            else
            {
                sqlDic["Query"] = sqlDic["Query"];
            }

            //dv绑定数据
            this.dataViewMain.DataSourceSql = sqlDic;
            this.dataViewMain.ViewDataBind(DataGridViewBindType.DicSql);
        }
        #endregion

        #region 重置
        private void btnReset_Click(object sender, EventArgs e)
        {
            this.cb_Level1Code.SelectedIndex = -1;
            this.cb_Level2Code.SelectedIndex = -1;
            this.cb_Level3Code.SelectedIndex = -1;
            this.cb_Level4Code.SelectedIndex = -1;
            this.cb_Level5Code.SelectedIndex = -1;
            this.tb_Level1Name.Text = String.Empty;
            this.tb_Level2Name.Text = String.Empty;
            this.tb_Level3Name.Text = String.Empty;
            this.tb_Level4Name.Text = String.Empty;
            this.tb_Level5Name.Text = String.Empty;
        }
        #endregion

        #region 新增
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SysConfigChild sysConfigChild = new SysConfigChild(ChildMenuType.Add, this.dataViewMain.SqlType);
            sysConfigChild.Tag = this;
            sysConfigChild.ShowDialog();
        }
        #endregion

        #region 编辑
        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow[] rows = this.dataViewMain.GetCheckRows();
            if (rows.Length == 1)
            {
                PConfig config = new PConfig();
                config.Id = Convert.ToInt32(rows[0].Cells["配置序号"].Value);
                config.ConfigTypeCode1 = rows[0].Cells["1级编码"].Value.ToString();
                config.ConfigTypeName1 = rows[0].Cells["1级名称"].Value.ToString();
                config.ConfigTypeCode2 = rows[0].Cells["2级编码"].Value.ToString();
                config.ConfigTypeName2 = rows[0].Cells["2级名称"].Value.ToString();
                config.ConfigTypeCode3 = rows[0].Cells["3级编码"].Value.ToString();
                config.ConfigTypeName3 = rows[0].Cells["3级名称"].Value.ToString();
                config.ConfigTypeCode4 = rows[0].Cells["4级编码"].Value.ToString();
                config.ConfigTypeName4 = rows[0].Cells["4级名称"].Value.ToString();
                config.ConfigTypeCode5 = rows[0].Cells["5级编码"].Value.ToString();
                config.ConfigTypeName5 = rows[0].Cells["5级名称"].Value.ToString();
                config.ConfigValue = rows[0].Cells["配置项值"].Value.ToString();
                config.Remark = rows[0].Cells["备注"].Value.ToString();
                SysConfigChild sysConfigChild = new SysConfigChild(ChildMenuType.Edit, this.dataViewMain.SqlType, config);
                sysConfigChild.Tag = this;
                sysConfigChild.ShowDialog();
            }
            else
            {
                MessageBox.Show("请选择需要编辑的配置项,仅可选择一条！", "提醒");
            }
        }
        #endregion

        #region 删除
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow[] rows = this.dataViewMain.GetCheckRows();
                if (rows.Length > 0)
                {
                    //id处理
                    List<string> idList = new List<string>();
                    foreach (DataGridViewRow row in rows)
                    {
                        idList.Add(row.Cells["配置序号"].Value.ToString());
                    }
                    string strId = $"'{ string.Join("','", idList)}'";
                    //sql
                    string sql = string.Empty;
                    sql = $"DELETE FROM P_Config WHERE ID IN ({strId});";
                    long result = _dataHelper.ExcuteNoQuery(sql);
                    if (result > 0)
                    {
                        MessageBox.Show("删除成功", "提示");
                    }
                    else
                    {
                        MessageBox.Show("删除失败", "提示");
                    }
                }
                else
                {
                    MessageBox.Show("请选择需要删除的配置项！", "提醒");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提醒");
            }
            finally
            {
                btnSearch_Click(null, null);
            }
        }
        #endregion

        #endregion

        #region 获取下拉控件字典
        private void GetComboDic()
        {
            //获取主sql
            Dictionary<string, string> sqlDic = SqlConfig.GetSql("SQLConfig/SysConfigGroup/SysConfig/ComboBind/", dataViewMain.SqlType.ToString());
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

        #region SelectIndexChange
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
