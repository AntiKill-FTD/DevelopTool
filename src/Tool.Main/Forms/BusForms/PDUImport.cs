using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tool.Data;
using Tool.Data.DataHelper;

namespace Tool.Main.Forms.BusForms
{
    public partial class PduImport : Form
    {
        #region 全局变量

        private ICommonDataHelper dataHelper;   //数据库操作类
        private bool isConnect = false;         //判断是否连接成功

        #endregion

        #region Ctor
        public PduImport()
        {
            InitializeComponent();
        }

        #endregion

        #region PageLoad
        private void PDUImport_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region 测试连接按钮
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                //获取连接数据
                string strIP = cmb_IP.Text.Trim();
                string strAccount = tb_LoginAccount.Text.Trim();
                string strPassword = tb_LoginPassword.Text.Trim();
                string strDataBase = tb_DataBase.Text.Trim();
                string connectString = $"{strIP};Initial Catalog={strDataBase};User id={strAccount};Password={strPassword};Connection Timeout=30;Pooling=true;Max Pool Size=100;";
                //创建数据连接
                DbContextOptionsBuilder<DeveloperToolContext> dbOptionBuild = new DbContextOptionsBuilder<DeveloperToolContext>();
                dbOptionBuild.UseSqlServer($"Data Source={connectString}");
                DeveloperToolContext dbContext = new DeveloperToolContext(dbOptionBuild.Options);
                dataHelper = new MSSqlDataHelper(dbContext);
                //测试连接
                bool connectResult = dataHelper.CheckConnect();
                if (connectResult)
                {
                    MessageBox.Show("连接成功", "提示");
                    isConnect = true;
                }
                else
                {
                    MessageBox.Show("连接失败", "提示");
                    isConnect = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("连接失败：" + ex.Message, "提示");
                isConnect = false;
            }
        }
        #endregion
    }
}
