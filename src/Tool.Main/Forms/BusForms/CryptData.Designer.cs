namespace Tool.Main.Forms.BusForms
{
    partial class CryptData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CryptData));
            this.panelConnect = new System.Windows.Forms.Panel();
            this.tlp_Connect = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_IP = new System.Windows.Forms.Label();
            this.cmb_IP = new System.Windows.Forms.ComboBox();
            this.tlp_Info = new System.Windows.Forms.TableLayoutPanel();
            this.tb_LoginAccount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_LoginPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_DataBase = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.rtb_MainSql = new System.Windows.Forms.RichTextBox();
            this.btn_GetModelData = new System.Windows.Forms.Button();
            this.dvDataSource = new Tool.CusControls.DataGridViewEx.DataGridViewEx();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_DataInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Anayly = new System.Windows.Forms.Button();
            this.dvInputSource = new Tool.CusControls.DataGridViewEx.DataGridViewEx();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.rtbLogInfo = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_Key = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAnaly = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rbDeleteFalse = new System.Windows.Forms.RadioButton();
            this.rbDeleteTrue = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_IV = new System.Windows.Forms.TextBox();
            this.panelConnect.SuspendLayout();
            this.tlp_Connect.SuspendLayout();
            this.tlp_Info.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelConnect
            // 
            this.panelConnect.BackColor = System.Drawing.Color.Azure;
            this.panelConnect.Controls.Add(this.tlp_Connect);
            this.panelConnect.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelConnect.Location = new System.Drawing.Point(0, 0);
            this.panelConnect.Name = "panelConnect";
            this.panelConnect.Size = new System.Drawing.Size(1328, 75);
            this.panelConnect.TabIndex = 0;
            // 
            // tlp_Connect
            // 
            this.tlp_Connect.ColumnCount = 5;
            this.tlp_Connect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Connect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.52941F));
            this.tlp_Connect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.82353F));
            this.tlp_Connect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.64706F));
            this.tlp_Connect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Connect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Connect.Controls.Add(this.lbl_IP, 1, 0);
            this.tlp_Connect.Controls.Add(this.cmb_IP, 2, 0);
            this.tlp_Connect.Controls.Add(this.tlp_Info, 2, 1);
            this.tlp_Connect.Controls.Add(this.btnConnect, 3, 1);
            this.tlp_Connect.Controls.Add(this.label1, 1, 1);
            this.tlp_Connect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Connect.Location = new System.Drawing.Point(0, 0);
            this.tlp_Connect.Name = "tlp_Connect";
            this.tlp_Connect.RowCount = 2;
            this.tlp_Connect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlp_Connect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp_Connect.Size = new System.Drawing.Size(1328, 75);
            this.tlp_Connect.TabIndex = 0;
            // 
            // lbl_IP
            // 
            this.lbl_IP.AutoSize = true;
            this.lbl_IP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_IP.Location = new System.Drawing.Point(23, 0);
            this.lbl_IP.Name = "lbl_IP";
            this.lbl_IP.Size = new System.Drawing.Size(297, 33);
            this.lbl_IP.TabIndex = 0;
            this.lbl_IP.Text = "数据库地址：";
            this.lbl_IP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_IP
            // 
            this.cmb_IP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_IP.FormattingEnabled = true;
            this.cmb_IP.Location = new System.Drawing.Point(326, 3);
            this.cmb_IP.Name = "cmb_IP";
            this.cmb_IP.Size = new System.Drawing.Size(751, 28);
            this.cmb_IP.TabIndex = 1;
            this.cmb_IP.Text = "10.136.0.114";
            // 
            // tlp_Info
            // 
            this.tlp_Info.ColumnCount = 5;
            this.tlp_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_Info.Controls.Add(this.tb_LoginAccount, 0, 0);
            this.tlp_Info.Controls.Add(this.label2, 1, 0);
            this.tlp_Info.Controls.Add(this.tb_LoginPassword, 2, 0);
            this.tlp_Info.Controls.Add(this.label3, 3, 0);
            this.tlp_Info.Controls.Add(this.tb_DataBase, 4, 0);
            this.tlp_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Info.Location = new System.Drawing.Point(326, 36);
            this.tlp_Info.Name = "tlp_Info";
            this.tlp_Info.RowCount = 1;
            this.tlp_Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Info.Size = new System.Drawing.Size(751, 36);
            this.tlp_Info.TabIndex = 2;
            // 
            // tb_LoginAccount
            // 
            this.tb_LoginAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_LoginAccount.Location = new System.Drawing.Point(3, 3);
            this.tb_LoginAccount.Name = "tb_LoginAccount";
            this.tb_LoginAccount.Size = new System.Drawing.Size(144, 27);
            this.tb_LoginAccount.TabIndex = 1;
            this.tb_LoginAccount.Text = "ipsa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(153, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "登陆密码：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_LoginPassword
            // 
            this.tb_LoginPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_LoginPassword.Location = new System.Drawing.Point(303, 3);
            this.tb_LoginPassword.Name = "tb_LoginPassword";
            this.tb_LoginPassword.Size = new System.Drawing.Size(144, 27);
            this.tb_LoginPassword.TabIndex = 1;
            this.tb_LoginPassword.Text = "ipsa@20200705";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(453, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "数据库名称：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_DataBase
            // 
            this.tb_DataBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_DataBase.Location = new System.Drawing.Point(603, 3);
            this.tb_DataBase.Name = "tb_DataBase";
            this.tb_DataBase.Size = new System.Drawing.Size(145, 27);
            this.tb_DataBase.TabIndex = 3;
            this.tb_DataBase.Text = "IOA";
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnConnect.Location = new System.Drawing.Point(1210, 36);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(94, 36);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "测试连接";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "登陆账号：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Azure;
            this.panelMain.Controls.Add(this.tableLayoutPanel1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 75);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1328, 701);
            this.panelMain.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dvDataSource, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1328, 701);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.rtb_MainSql, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_GetModelData, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.24419F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.75581F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(656, 343);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // rtb_MainSql
            // 
            this.rtb_MainSql.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_MainSql.Location = new System.Drawing.Point(3, 3);
            this.rtb_MainSql.Name = "rtb_MainSql";
            this.rtb_MainSql.Size = new System.Drawing.Size(650, 300);
            this.rtb_MainSql.TabIndex = 0;
            this.rtb_MainSql.Text = resources.GetString("rtb_MainSql.Text");
            // 
            // btn_GetModelData
            // 
            this.btn_GetModelData.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_GetModelData.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_GetModelData.Location = new System.Drawing.Point(475, 309);
            this.btn_GetModelData.Name = "btn_GetModelData";
            this.btn_GetModelData.Size = new System.Drawing.Size(178, 31);
            this.btn_GetModelData.TabIndex = 1;
            this.btn_GetModelData.Text = "获取源数据";
            this.btn_GetModelData.UseVisualStyleBackColor = false;
            this.btn_GetModelData.Click += new System.EventHandler(this.btn_GetModelData_Click);
            // 
            // dvDataSource
            // 
            this.dvDataSource.DataHelper = null;
            this.dvDataSource.DataSourceSql = null;
            this.dvDataSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvDataSource.DvDataTable = null;
            this.dvDataSource.DvSelectionMode = System.Windows.Forms.DataGridViewSelectionMode.RowHeaderSelect;
            this.dvDataSource.IsPage = false;
            this.dvDataSource.IsShowFirstCheckBox = false;
            this.dvDataSource.Location = new System.Drawing.Point(667, 5);
            this.dvDataSource.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dvDataSource.Name = "dvDataSource";
            this.dvDataSource.RowEdit = false;
            this.dvDataSource.Size = new System.Drawing.Size(657, 341);
            this.dvDataSource.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dvInputSource, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 354);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.2449F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.7551F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(656, 343);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.76923F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.38462F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.84615F));
            this.tableLayoutPanel4.Controls.Add(this.tb_DataInput, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_Anayly, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(650, 36);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tb_DataInput
            // 
            this.tb_DataInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_DataInput.Location = new System.Drawing.Point(177, 3);
            this.tb_DataInput.Name = "tb_DataInput";
            this.tb_DataInput.Size = new System.Drawing.Size(289, 27);
            this.tb_DataInput.TabIndex = 1;
            this.tb_DataInput.Text = "EDA_RS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 36);
            this.label4.TabIndex = 2;
            this.label4.Text = "写入数据源：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Anayly
            // 
            this.btn_Anayly.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_Anayly.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Anayly.Location = new System.Drawing.Point(472, 3);
            this.btn_Anayly.Name = "btn_Anayly";
            this.btn_Anayly.Size = new System.Drawing.Size(175, 30);
            this.btn_Anayly.TabIndex = 3;
            this.btn_Anayly.Text = "解析写入数据源";
            this.btn_Anayly.UseVisualStyleBackColor = false;
            this.btn_Anayly.Click += new System.EventHandler(this.btn_Anayly_Click);
            // 
            // dvInputSource
            // 
            this.dvInputSource.DataHelper = null;
            this.dvInputSource.DataSourceSql = null;
            this.dvInputSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvInputSource.DvDataTable = null;
            this.dvInputSource.DvSelectionMode = System.Windows.Forms.DataGridViewSelectionMode.RowHeaderSelect;
            this.dvInputSource.IsPage = false;
            this.dvInputSource.IsShowFirstCheckBox = false;
            this.dvInputSource.Location = new System.Drawing.Point(3, 46);
            this.dvInputSource.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dvInputSource.Name = "dvInputSource";
            this.dvInputSource.RowEdit = true;
            this.dvInputSource.Size = new System.Drawing.Size(650, 293);
            this.dvInputSource.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.rtbLogInfo, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(667, 354);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.66181F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.3382F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(657, 343);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // rtbLogInfo
            // 
            this.rtbLogInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbLogInfo.Location = new System.Drawing.Point(3, 43);
            this.rtbLogInfo.Name = "rtbLogInfo";
            this.rtbLogInfo.ReadOnly = true;
            this.rtbLogInfo.Size = new System.Drawing.Size(651, 297);
            this.rtbLogInfo.TabIndex = 2;
            this.rtbLogInfo.Text = "";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 8;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel6.Controls.Add(this.tb_Key, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnAnaly, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label5, 5, 0);
            this.tableLayoutPanel6.Controls.Add(this.rbDeleteFalse, 7, 0);
            this.tableLayoutPanel6.Controls.Add(this.rbDeleteTrue, 6, 0);
            this.tableLayoutPanel6.Controls.Add(this.label7, 3, 0);
            this.tableLayoutPanel6.Controls.Add(this.tb_IV, 4, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(651, 34);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // tb_Key
            // 
            this.tb_Key.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Key.Location = new System.Drawing.Point(172, 3);
            this.tb_Key.Name = "tb_Key";
            this.tb_Key.Size = new System.Drawing.Size(91, 27);
            this.tb_Key.TabIndex = 16;
            this.tb_Key.Text = "omc4good";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(133, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 34);
            this.label6.TabIndex = 14;
            this.label6.Text = "Key：";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAnaly
            // 
            this.btnAnaly.BackColor = System.Drawing.Color.Crimson;
            this.btnAnaly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAnaly.Location = new System.Drawing.Point(3, 3);
            this.btnAnaly.Name = "btnAnaly";
            this.btnAnaly.Size = new System.Drawing.Size(124, 28);
            this.btnAnaly.TabIndex = 6;
            this.btnAnaly.Text = "开始解密";
            this.btnAnaly.UseVisualStyleBackColor = false;
            this.btnAnaly.Click += new System.EventHandler(this.btnAnaly_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(405, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 34);
            this.label5.TabIndex = 10;
            this.label5.Text = "是否删除写入源表：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbDeleteFalse
            // 
            this.rbDeleteFalse.AutoSize = true;
            this.rbDeleteFalse.Checked = true;
            this.rbDeleteFalse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbDeleteFalse.Location = new System.Drawing.Point(593, 3);
            this.rbDeleteFalse.Name = "rbDeleteFalse";
            this.rbDeleteFalse.Size = new System.Drawing.Size(55, 28);
            this.rbDeleteFalse.TabIndex = 8;
            this.rbDeleteFalse.TabStop = true;
            this.rbDeleteFalse.Text = "否";
            this.rbDeleteFalse.UseVisualStyleBackColor = true;
            // 
            // rbDeleteTrue
            // 
            this.rbDeleteTrue.AutoSize = true;
            this.rbDeleteTrue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbDeleteTrue.Location = new System.Drawing.Point(535, 3);
            this.rbDeleteTrue.Name = "rbDeleteTrue";
            this.rbDeleteTrue.Size = new System.Drawing.Size(52, 28);
            this.rbDeleteTrue.TabIndex = 7;
            this.rbDeleteTrue.Text = "是";
            this.rbDeleteTrue.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(269, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 34);
            this.label7.TabIndex = 12;
            this.label7.Text = "IV：";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_IV
            // 
            this.tb_IV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_IV.Location = new System.Drawing.Point(308, 3);
            this.tb_IV.Name = "tb_IV";
            this.tb_IV.Size = new System.Drawing.Size(91, 27);
            this.tb_IV.TabIndex = 15;
            this.tb_IV.Text = "1s2o4f5t";
            // 
            // CryptData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 776);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelConnect);
            this.Name = "CryptData";
            this.Text = "CryptData";
            this.Load += new System.EventHandler(this.CryptData_Load);
            this.panelConnect.ResumeLayout(false);
            this.tlp_Connect.ResumeLayout(false);
            this.tlp_Connect.PerformLayout();
            this.tlp_Info.ResumeLayout(false);
            this.tlp_Info.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelConnect;
        private TableLayoutPanel tlp_Connect;
        private Label lbl_IP;
        private ComboBox cmb_IP;
        private TableLayoutPanel tlp_Info;
        private Label label2;
        private TextBox tb_LoginAccount;
        private TextBox tb_LoginPassword;
        private Button btnConnect;
        private Label label1;
        private Label label3;
        private Panel panelMain;
        private TextBox tb_DataBase;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private RichTextBox rtb_MainSql;
        private Button btn_GetModelData;
        private CusControls.DataGridViewEx.DataGridViewEx dvDataSource;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox tb_DataInput;
        private Label label4;
        private Button btn_Anayly;
        private CusControls.DataGridViewEx.DataGridViewEx dvInputSource;
        private TableLayoutPanel tableLayoutPanel5;
        private RichTextBox rtbLogInfo;
        private TableLayoutPanel tableLayoutPanel6;
        private Button btnAnaly;
        private Label label7;
        private RadioButton rbDeleteTrue;
        private RadioButton rbDeleteFalse;
        private Label label5;
        private Label label6;
        private TextBox tb_Key;
        private TextBox tb_IV;
    }
}