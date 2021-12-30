using Tool.IService.SysMenu;
using Tool.Main.Config;

namespace Tool.Main.Forms.MainForms
{
    public partial class MainForm : Form
    {
        //ע��ӿ�
        IMenuService ms;

        #region ���庯������
        public const int WM_SYSCOMMAND = 0x112; //ϵͳ����
        public const int SC_MOVE = 0xF012; //�ƶ�����
        public const int WM_BUTTON = 0xA3; //��ť����
        public const int SC_DOUBLECLICK = 0x0002; //˫���˵���
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
            //ע��
            ms = Program.ServiceProvider.GetService(typeof(IMenuService)) as IMenuService;
            ms.MainForm = this;

            #region ������󻯡�ȡ�������С����ť����������
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = false;
            this.IsMdiContainer = true;
            #endregion

            #region  ���5��ˢ��һ������״̬����ʾ
            GetNetStatShow(null, null);
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 5000;
            timer.Tick += GetNetStatShow;
            timer.Start();
            #endregion

            #region �˵�����
            ms.CreateMenu();
            ms.toolStripMenuItems.Reverse();

            foreach (var item in ms.toolStripMenuItems)
            {
                this.menuStrip1.Items.Insert(0, item);
            }
            #endregion
        }
        #endregion

        #region ��ȡ����״̬����ʾ
        private void GetNetStatShow(object sender, EventArgs e)
        {
            if (BaseConfig.NetStat)
            {
                this.labelNetStat.Text = "���磺����";
                this.labelNetStat.ForeColor = Color.Blue;
            }
            else
            {
                this.labelNetStat.Text = "���磺ʧ��";
                this.labelNetStat.ForeColor = Color.Red;
            }
        }
        #endregion

        #region ��д���� ��ֹ�϶����塢��ֹ˫���˵���
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

        #region �˵��¼�
        private void �˵�����ToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void �˳�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ȷ���˳������", "�˳�", MessageBoxButtons.YesNo);
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