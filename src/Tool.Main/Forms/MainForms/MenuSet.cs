using System.Text;
using Tool.CusControls.DataGridViewEx;
using Tool.Data.DataHelper;
using Tool.Data.SqlConfig;
using Tool.IService.Model.Sys;
using Tool.Main.Forms.MainForms.ChildForms;
using Tool.Service.Common;

namespace Tool.Main.Forms.MainForms
{
    public partial class MenuSet : Form
    {
        #region 私有变量

        private ICommonDataHelper _dataHelper;

        #endregion

        #region Ctor
        public MenuSet()
        {
            InitializeComponent();
            //注入
            _dataHelper = Program.ServiceProvider.GetService(typeof(ICommonDataHelper)) as ICommonDataHelper;
            this.dataViewMain.DataHelper = _dataHelper;
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
        internal void Search_Click(object sender, EventArgs e)
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

            //根据层级控制菜单名称编码缩进显示
            DataGridViewRow[] rows = this.dataViewMain.GetAllRows();
            foreach (DataGridViewRow row in rows)
            {
                int level = (int)row.Cells["层级"].Value;
                string ifEnd = row.Cells["是否末级"].Value.ToString();
                string strBegin = ifEnd == "是" ? "" : "-";
                row.Cells["菜单编码"].Value = "".PadLeft((level - 1) * 3, ' ') + strBegin + row.Cells["菜单编码"].Value.ToString();
                row.Cells["菜单名称"].Value = "".PadLeft((level - 1) * 3, ' ') + strBegin + row.Cells["菜单名称"].Value.ToString();
            }
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
            MenuSetChild menuSetChild = new MenuSetChild(ChildMenuType.Add, this.dataViewMain.SqlType);
            menuSetChild.Tag = this;
            menuSetChild.ShowDialog();
        }
        #endregion

        #region 修改
        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow[] rows = this.dataViewMain.GetCheckRows();
            if (rows.Length == 1)
            {
                Menu menu = new Menu();
                menu.Id = Convert.ToInt32(rows[0].Cells["菜单序号"].Value);
                menu.MenuCode = rows[0].Cells["菜单编码"].Value.ToString().TrimStart(new char[] { ' ', '-' });
                menu.MenuName = rows[0].Cells["菜单名称"].Value.ToString().TrimStart(new char[] { ' ', '-' });
                menu.ParentCode = rows[0].Cells["父级编码"].Value.ToString();
                menu.Assembly = rows[0].Cells["程序集"].Value.ToString();
                menu.NameSpace = rows[0].Cells["命名空间"].Value.ToString();
                menu.EntityName = rows[0].Cells["实体名称"].Value.ToString();
                menu.Level = Convert.ToInt32(rows[0].Cells["层级"].Value);
                menu.IfEnd = rows[0].Cells["是否末级"].Value.ToString() == "是" ? 1 : 0;
                MenuSetChild menuSetChild = new MenuSetChild(ChildMenuType.Edit, this.dataViewMain.SqlType, menu);
                menuSetChild.Tag = this;
                menuSetChild.ShowDialog();
            }
            else
            {
                MessageBox.Show("请选择需要编辑的菜单,仅可选择一条！", "提醒");
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
                        idList.Add(row.Cells["菜单序号"].Value.ToString());
                    }
                    string strId = $"'{ string.Join("','", idList)}'";
                    //sql
                    string sql = string.Empty;
                    sql = $"DELETE FROM P_Menu WHERE ID IN ({strId});";
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
                    MessageBox.Show("请选择需要删除的菜单！", "提醒");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提醒");
            }
            finally
            {
                Search_Click(null, null);
            }
        }
        #endregion

        #endregion

        #region 导出脚本
        private void btn_ExportScript_Click(object sender, EventArgs e)
        {
            DataGridViewRow[] rows = this.dataViewMain.GetCheckRows();
            if (rows.Length > 0)
            {
                List<Menu> menus = new List<Menu>();
                foreach (DataGridViewRow row in rows)
                {
                    Menu menu = new Menu();
                    menu.Id = Convert.ToInt32(row.Cells["菜单序号"].Value);
                    menu.MenuCode = row.Cells["菜单编码"].Value.ToString().TrimStart(new char[] { ' ', '-' });
                    menu.MenuName = row.Cells["菜单名称"].Value.ToString().TrimStart(new char[] { ' ', '-' });
                    menu.ParentCode = row.Cells["父级编码"].Value.ToString();
                    menu.Assembly = row.Cells["程序集"].Value.ToString();
                    menu.NameSpace = row.Cells["命名空间"].Value.ToString();
                    menu.EntityName = row.Cells["实体名称"].Value.ToString();
                    menu.Level = Convert.ToInt32(row.Cells["层级"].Value);
                    menu.IfEnd = row.Cells["是否末级"].Value.ToString() == "是" ? 1 : 0;
                    menus.Add(menu);
                }
                //拼接
                StringBuilder sbMysql = new StringBuilder();
                StringBuilder sbMSSql = new StringBuilder();
                foreach (Menu menu in menus)
                {
                    sbMysql.Append($"INSERT INTO P_Menu (\n    MenuCode\n    ,MenuName\n    ,ParentCode\n    ,Assembly\n    ,NameSpace\n    ,EntityName\n    ,Level\n    ,IfEnd\n    )\nValues (\n    '{menu.MenuCode}'\n    ,-- MenuCode - varchar(100)\n    '{menu.MenuName}'\n    ,-- MenuName - varchar(100)\n    '{menu.ParentCode}'\n    ,-- ParentCode - varchar(100)\n    '{menu.Assembly}'\n    ,-- Assembly - varchar(200)\n    '{menu.NameSpace}'    \n    ,-- NameSpace - varchar(200)\n    '{menu.EntityName}'\n    ,--EntityName - varchar(200)\n    {menu.Level}\n    ,-- Level - int\n    {menu.IfEnd}\n    --IfEnd - tinyint    \n    );\n\n");
                    sbMSSql.Append($"INSERT INTO P_Menu ( MenuCode, MenuName, ParentCode, Assembly, NameSpace, EntityName, Level, IfEnd) VALUES ( N'{menu.MenuCode}', N'{menu.MenuName}', N'{menu.ParentCode}', N'{menu.Assembly}', N'{menu.NameSpace}', N'{menu.EntityName}', {menu.Level}, {menu.IfEnd});\n");
                }
                //赋值
                this.rtb_ExportScript_MySql.Text = sbMysql.ToString();
                this.rtb_ExportScript_MSSql.Text = sbMSSql.ToString();
            }
            else
            {
                MessageBox.Show("请选择需要导出的脚本！", "提醒");
            }
        }
        #endregion 导出脚本
    }
}
