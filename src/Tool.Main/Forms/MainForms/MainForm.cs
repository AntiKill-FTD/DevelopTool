using Tool.IService.SysMenu;
using Tool.Main.Config;

namespace Tool.Main.Forms.MainForms
{
    public partial class MainForm : Form
    {
        //注入接口
        IMenuService ms;

        #region 窗体函数参数
        public const int WM_SYSCOMMAND = 0x112; //系统操纵
        public const int SC_MOVE = 0xF012; //移动窗体
        public const int WM_BUTTON = 0xA3; //按钮操作
        public const int SC_DOUBLECLICK = 0x0002; //双击菜单栏
        #endregion

        #region Ctor
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region PageLoad
        private void MainForm_Load(object sender, EventArgs e)
        {
            //注入
            ms = Program.ServiceProvider.GetService(typeof(IMenuService)) as IMenuService;
            ms.MainForm = this;

            #region 窗体最大化、取消最大最小化按钮、启用容器
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = false;
            this.IsMdiContainer = true;
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
                this.menuStrip1.Items.Insert(0, item);
            }
            #endregion
        }
        #endregion

        #region 获取网络状态的显示
        private void GetNetStatShow(object sender, EventArgs e)
        {
            if (BaseConfig.NetStat)
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

        #region 重写方法 禁止拖动窗体、禁止双击菜单栏
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_SYSCOMMAND)
            {
                if ((int)m.WParam == SC_MOVE)
                    return;
            }
            if (m.Msg == WM_BUTTON)
            {
                if ((int)m.WParam == SC_DOUBLECLICK)
                    return;
            }
            base.WndProc(ref m);
        }
        #endregion

        #region 菜单事件
        private void 菜单管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ms.OpenMenuManage();
            }
            catch (Exception ex)
            {
                return;
            }
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