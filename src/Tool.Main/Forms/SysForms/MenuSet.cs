namespace Tool.Main.Forms.SysForms
{
    public partial class MenuSet : Form
    {
        public MenuSet()
        {
            InitializeComponent();
        }

        private void MenuSet_Load(object sender, EventArgs e)
        {
            Search_Click(null, null);
        }

        #region 按钮事件
        private void Search_Click(object sender, EventArgs e)
        {
            ////获取主sql
            //Dictionary<string, string> sqlDic = SqlConfig.GetSql("SQLConfig/BaseForm/MenuSet/");

            //////////////////////////////////////////!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            ////获取查询参数
            //string menuCode = txtMenuCode.Text.ToString().Trim();
            //string menuName = txtMenuName.Text.ToString().Trim();
            ////拼接参数
            //string sqlWhere = string.Empty;
            //if (!string.IsNullOrEmpty(menuCode))
            //{
            //    sqlWhere += "AND MenuCode LIKE '%" + menuCode + "%' ";
            //}
            //if (!string.IsNullOrEmpty(menuName))
            //{
            //    sqlWhere += "AND MenuName LIKE '%" + menuName + "%' ";
            //}
            ////拼接SQL
            //if (!string.IsNullOrEmpty(sqlWhere))
            //{
            //    sqlWhere = sqlWhere.Substring(0, 3) == "AND" ? sqlWhere.Substring(3) : sqlWhere;
            //    //组装SQL
            //    sqlDic["Query"] = sqlDic["Query"].Replace("1=1", sqlWhere);
            //}
            //else
            //{
            //    sqlDic["Query"] = sqlDic["Query"];
            //}
            //////////////////////////////////////////!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

            ////dv绑定数据
            //this.dataViewMain.DataSourceSql = sqlDic;
            //this.dataViewMain.ViewDataBind(DataGridViewBindType.DicSql);
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            this.txtMenuCode.Text = string.Empty;
            this.txtMenuName.Text = string.Empty;
        }
        #endregion
    }
}
