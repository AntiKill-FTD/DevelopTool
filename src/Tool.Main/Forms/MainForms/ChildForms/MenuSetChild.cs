using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tool.Service.Common;

namespace Tool.Main.Forms.MainForms.ChildForms
{
    public partial class MenuSetChild : Form
    {
        public MenuSetChild(ChildMenuType type)
        {
            InitializeComponent();

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
    }
}
