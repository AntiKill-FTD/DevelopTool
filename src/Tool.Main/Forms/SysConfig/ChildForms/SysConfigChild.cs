using Tool.CusControls.DataGridViewEx;
using Tool.Data.DataHelper;
using Tool.IService.Model.Sys;
using Tool.Service.Common;

namespace Tool.Main.Forms.SysConfig.ChildForms
{
    public partial class SysConfigChild : Form
    {
        private EnumSqlType _sqlType;
        private ICommonDataHelper _dataHelper;
        private ChildMenuType _childMenuType;

        #region Ctor

        public SysConfigChild(ChildMenuType type, EnumSqlType sqlType, PConfig pConfig = null)
        {
            InitializeComponent();
            //注入
            _dataHelper = Program.ServiceProvider.GetService(typeof(ICommonDataHelper)) as ICommonDataHelper;
            //更改标题，绑定数据
            _childMenuType = type;
            _sqlType = sqlType;

            //初始化控件绑定

            //更新菜单、修改数据绑定
            if (type == ChildMenuType.Add)
            {
                this.Text = "新增菜单";
            }
            else if (type == ChildMenuType.Edit)
            {
                this.Text = "编辑菜单";
                BindModifyData(pConfig);
            }
        }

        #endregion

        #region 绑定编辑数据
        private void BindModifyData(PConfig pConfig)
        {

        }
        #endregion
    }
}
