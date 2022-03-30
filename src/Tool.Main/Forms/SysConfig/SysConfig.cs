using Tool.CusControls.DataGridViewEx;
using Tool.Data.DataHelper;
using Tool.Data.SqlConfig;
using Tool.IService.Model.Sys;
using Tool.Main.Forms.SysConfig.ChildForms;
using Tool.Service.Common;

namespace Tool.Main.Forms.SysConfig
{
    public partial class SysConfig : Form
    {
        #region 私有变量

        private ICommonDataHelper _dataHelper;

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
            btnSearch_Click(null, null);
        }
        #endregion

        #region 按钮事件

        #region 查询
        private void btnSearch_Click(object sender, EventArgs e)
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
    }
}
