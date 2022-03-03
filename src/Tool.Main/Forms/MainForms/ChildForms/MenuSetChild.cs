using System.Data;
using System.Reflection;
using Tool.CusControls.DataGridViewEx;
using Tool.Data.DataHelper;
using Tool.Data.SqlConfig;
using Tool.Service.Common;

namespace Tool.Main.Forms.MainForms.ChildForms
{
    public partial class MenuSetChild : Form
    {
        private EnumSqlType _sqlType;
        private ICommonDataHelper _dataHelper;

        public MenuSetChild(ChildMenuType type, EnumSqlType sqlType)
        {
            InitializeComponent();
            //注入
            _dataHelper = Program.ServiceProvider.GetService(typeof(ICommonDataHelper)) as ICommonDataHelper;

            //初始化控件绑定
            GetParentMenu();
            GetProgram();

            //更改标题，绑定数据
            _sqlType = sqlType;
            if (type == ChildMenuType.Add)
            {
                this.Text = "新增菜单";
            }
            else if (type == ChildMenuType.Edit)
            {
                this.Text = "编辑菜单";

            }
        }

        #region 按钮

        #region 保存
        private void btn_Save_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region 退出
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
        #endregion

        #endregion

        #region 私有方法

        #region 查询父级菜单
        private void GetParentMenu()
        {
            //获取主sql
            Dictionary<string, string> sqlDic = SqlConfig.GetSql("SQLConfig/BaseForm/MenuSet/", _sqlType.ToString());
            DataTable dt = _dataHelper.GetDataTable(sqlDic["Query"].ToString(), sqlDic["Order"].ToString());
            //处理菜单
            DataTable newDt = new DataTable();
            newDt.Columns.Add("菜单编码");
            newDt.Columns.Add("菜单名称");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //原有数据
                DataRow dr = dt.Rows[i];
                int level = (int)dr["层级"];
                string strBegin = dr["是否末级"].ToString() == "是" ? "" : "-";
                //新拼装数据
                DataRow newRow = newDt.NewRow();
                newRow["菜单编码"] = dr["菜单编码"].ToString() + "///" + dr["层级"].ToString();
                newRow["菜单名称"] = strBegin + "".PadLeft((level - 1) * 5, ' ') + dr["菜单名称"].ToString();
                newDt.Rows.Add(newRow);
            }
            this.cbx_ParentName.DataSource = newDt;
            this.cbx_ParentName.ValueMember = "菜单编码";
            this.cbx_ParentName.DisplayMember = "菜单名称";
            this.cbx_ParentName.SelectedIndex = -1;
        }
        #endregion

        #region 获取程序集
        private void GetProgram()
        {
            //从dll文件中获取Assembly对象
            Assembly assembly = Assembly.Load("Tool.Main");
            //获取所有的类
            Type[] types = assembly.GetExportedTypes();
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Value");
            foreach (Type type in types)
            {
                DataRow dr = dt.NewRow();
                dr["Name"] = type.Name;
                dr["Value"] = type.Namespace;
                dt.Rows.Add(dr);
            }
            //绑定
            this.cbx_MenuProgram.DataSource = dt;
            this.cbx_MenuProgram.DisplayMember = "Name";
            this.cbx_MenuProgram.ValueMember = "Value";
        }
        #endregion

        #endregion


        #region 下拉框改变事件

        //父级菜单改变
        private void cbx_ParentName_SelectedValueChanged(object sender, EventArgs e)
        {
            //默认值
            this.tb_ParentCode.Text = String.Empty;
            this.tb_ParentLevel.Text = "-1";
            //赋值
            if (this.cbx_ParentName.SelectedValue != null)
            {
                string codeAndLevel = this.cbx_ParentName.SelectedValue.ToString();
                string[] clList = codeAndLevel.Split("///");
                if (clList.Length == 2)
                {
                    this.tb_ParentCode.Text = clList[0];
                    this.tb_ParentLevel.Text = clList[1];
                }
            }
            //当前菜单编号赋值
            string parentCode = this.tb_ParentCode.Text;
            this.tb_MenuCode.Text = String.IsNullOrEmpty(parentCode) ? "01" : parentCode + ".01";
        }
        #endregion
    }
}
