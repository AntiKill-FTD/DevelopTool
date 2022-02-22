using Tool.CusControls.DataGridViewEx;
using Tool.Data.DataHelper;
using Tool.Data.SqlConfig;
using Tool.Main.Forms.MainForms.ChildForms;
using Tool.Service.Common;

namespace Tool.Main.Forms.MainForms
{
    public partial class MenuSet : Form
    {
        #region Ctor
        public MenuSet()
        {
            InitializeComponent();
            //注入
            ICommonDataHelper dataHelper = Program.ServiceProvider.GetService(typeof(ICommonDataHelper)) as ICommonDataHelper;
            this.dataViewMain.DataHelper = dataHelper;
        }
        #endregion

        #region PageLoad

        private void MenuSet_Load(object sender, EventArgs e)
        {
            Search_Click(null, null);
        }

        #endregion

        #region 按钮事件

        #region 查询
        private void Search_Click(object sender, EventArgs e)
        {
            //获取主sql
            Dictionary<string, string> sqlDic = SqlConfig.GetSql("SQLConfig/BaseForm/MenuSet/", this.dataViewMain.SqlType.ToString());

            //获取查询参数
            string menuCode = txtMenuCode.Text.ToString().Trim();
            string menuName = txtMenuName.Text.ToString().Trim();
            //拼接参数
            string sqlWhere = string.Empty;
            if (!string.IsNullOrEmpty(menuCode))
            {
                sqlWhere += "AND MenuCode LIKE '%" + menuCode + "%' ";
            }
            if (!string.IsNullOrEmpty(menuName))
            {
                sqlWhere += "AND MenuName LIKE '%" + menuName + "%' ";
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
        private void Reset_Click(object sender, EventArgs e)
        {
            this.txtMenuCode.Text = string.Empty;
            this.txtMenuName.Text = string.Empty;
        }
        #endregion

        #region 新增
        private void btnAdd_Click(object sender, EventArgs e)
        {
            MenuSetChild menuSetChild = new MenuSetChild(ChildMenuType.Add);
            menuSetChild.ShowDialog();
        }
        #endregion

        #region 修改
        private void btnEdit_Click(object sender, EventArgs e)
        {
            MenuSetChild menuSetChild = new MenuSetChild(ChildMenuType.Edit);
            menuSetChild.ShowDialog();
        }
        #endregion

        #region 删除

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow[] rows = this.dataViewMain.GetCheckRows();
            if (rows.Length > 0)
            {

            }
            else
            {
                MessageBox.Show("请选择需要删除的菜单！", "提醒");
            }
        }
        #endregion

        #endregion
    }
}
