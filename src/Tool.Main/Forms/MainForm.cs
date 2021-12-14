using Tool.IService.SysMenu;
using Tool.Main.Config;

namespace Tool.Main.Forms
{
    public partial class MainForm : Form
    {
        IMenuService ms;

        public MainForm()
        {
            InitializeComponent();
        }

        //基础配置
        private BaseConfig baseConfig;

        #region PageLoad
        private void MainForm_Load(object sender, EventArgs e)
        {
            ms = Program.ServiceProvider.GetService(typeof(IMenuService)) as IMenuService;

            #region 窗体最大化、取消最大最小化按钮
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = false;
            #endregion

            this.IsMdiContainer = true;
            ms.MainForm = this;

            #region 初始化配置对象
            if (baseConfig == null)
            {
                baseConfig = new BaseConfig();
            }
            #endregion

            #region  间隔5秒刷新一次网络状态的显示
            GetNetStatShow(null, null);
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 5000;
            timer.Tick += GetNetStatShow;
            timer.Start();
            #endregion

            #region 菜单加载
            ms.CreateMenu();
            ms.toolStripMenuItems.Reverse();

            foreach (var item in ms.toolStripMenuItems)
            {
                this.menuStrip1.Items.Insert(0, (ToolStripItem)item);
            }
            #endregion
        }
        #endregion

        #region 获取网络状态的显示
        private void GetNetStatShow(object sender, EventArgs e)
        {
            bool netStat = baseConfig.NetStat;

            if (netStat)
            {
                this.labelNetStat.Text = "网络：连接";
                this.labelNetStat.ForeColor = Color.Blue;
            }
            else
            {
                this.labelNetStat.Text = "网络：失败";
                this.labelNetStat.ForeColor = Color.Red;
            }
        }
        #endregion

        #region 菜单事件

        private void 菜单管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    //转换为菜单
            //    ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            //    //菜单管理的menuCode定义为00.01
            //    menuItem.Name = "00.01";
            //    menuItem.Text = "菜单管理";

            //    //调用公共事件打开窗体
            //    MenuEvent.MenuClick(menuItem, e);
            //}
            //catch (Exception ex)
            //{
            //    return;
            //}
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("确认退出软件？", "退出", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        #endregion
    }
}