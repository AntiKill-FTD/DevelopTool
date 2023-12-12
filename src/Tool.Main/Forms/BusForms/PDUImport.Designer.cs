namespace Tool.Main.Forms.BusForms
{
    partial class PduImport
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
            tlp_Main = new TableLayoutPanel();
            tlp_Connect = new TableLayoutPanel();
            lbl_IP = new Label();
            cmb_IP = new ComboBox();
            tlp_Info = new TableLayoutPanel();
            tb_LoginAccount = new TextBox();
            label2 = new Label();
            tb_LoginPassword = new TextBox();
            label3 = new Label();
            tb_DataBase = new TextBox();
            btnConnect = new Button();
            label1 = new Label();
            tlp_CheckSplit = new TableLayoutPanel();
            cb_IsProb = new CheckBox();
            cb_CheckEmpStatus = new CheckBox();
            tlp_Main_Org = new TableLayoutPanel();
            dv_Org = new CusControls.DataGridViewEx.DataGridViewEx();
            tlp_Org_Script = new TableLayoutPanel();
            rtb_Org_FullError = new RichTextBox();
            rtb_Org_RowError = new RichTextBox();
            rtb_Org_SqlScript = new RichTextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btn_Org_Import = new Button();
            btn_Org_Script = new Button();
            tlp_Main_Emp = new TableLayoutPanel();
            dv_Emp = new CusControls.DataGridViewEx.DataGridViewEx();
            tlp_Emp_Script = new TableLayoutPanel();
            rtb_Emp_FullError = new RichTextBox();
            rtb_Emp_RowError = new RichTextBox();
            rtb_Emp_SqlScript = new RichTextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            btn_Emp_Import = new Button();
            btn_Emp_Script = new Button();
            tlp_Main.SuspendLayout();
            tlp_Connect.SuspendLayout();
            tlp_Info.SuspendLayout();
            tlp_CheckSplit.SuspendLayout();
            tlp_Main_Org.SuspendLayout();
            tlp_Org_Script.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tlp_Main_Emp.SuspendLayout();
            tlp_Emp_Script.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tlp_Main
            // 
            tlp_Main.BackColor = Color.Azure;
            tlp_Main.ColumnCount = 1;
            tlp_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp_Main.Controls.Add(tlp_Connect, 0, 0);
            tlp_Main.Controls.Add(tlp_Main_Org, 0, 1);
            tlp_Main.Controls.Add(tlp_Main_Emp, 0, 2);
            tlp_Main.Dock = DockStyle.Fill;
            tlp_Main.ForeColor = Color.CornflowerBlue;
            tlp_Main.Location = new Point(0, 0);
            tlp_Main.Name = "tlp_Main";
            tlp_Main.RowCount = 3;
            tlp_Main.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tlp_Main.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_Main.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_Main.Size = new Size(1355, 942);
            tlp_Main.TabIndex = 0;
            // 
            // tlp_Connect
            // 
            tlp_Connect.ColumnCount = 5;
            tlp_Connect.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlp_Connect.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.52941F));
            tlp_Connect.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.82353F));
            tlp_Connect.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.64706F));
            tlp_Connect.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlp_Connect.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlp_Connect.Controls.Add(lbl_IP, 1, 0);
            tlp_Connect.Controls.Add(cmb_IP, 2, 0);
            tlp_Connect.Controls.Add(tlp_Info, 2, 1);
            tlp_Connect.Controls.Add(btnConnect, 3, 1);
            tlp_Connect.Controls.Add(label1, 1, 1);
            tlp_Connect.Controls.Add(tlp_CheckSplit, 3, 0);
            tlp_Connect.Dock = DockStyle.Fill;
            tlp_Connect.ForeColor = SystemColors.ControlText;
            tlp_Connect.Location = new Point(0, 0);
            tlp_Connect.Margin = new Padding(0);
            tlp_Connect.Name = "tlp_Connect";
            tlp_Connect.RowCount = 2;
            tlp_Connect.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tlp_Connect.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlp_Connect.Size = new Size(1355, 75);
            tlp_Connect.TabIndex = 1;
            // 
            // lbl_IP
            // 
            lbl_IP.AutoSize = true;
            lbl_IP.Dock = DockStyle.Fill;
            lbl_IP.Location = new Point(23, 0);
            lbl_IP.Name = "lbl_IP";
            lbl_IP.Size = new Size(303, 33);
            lbl_IP.TabIndex = 0;
            lbl_IP.Text = "数据库地址：";
            lbl_IP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmb_IP
            // 
            cmb_IP.Dock = DockStyle.Fill;
            cmb_IP.FormattingEnabled = true;
            cmb_IP.Location = new Point(332, 3);
            cmb_IP.Name = "cmb_IP";
            cmb_IP.Size = new Size(767, 28);
            cmb_IP.TabIndex = 1;
            cmb_IP.Text = "10.136.0.114";
            // 
            // tlp_Info
            // 
            tlp_Info.ColumnCount = 5;
            tlp_Info.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp_Info.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp_Info.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp_Info.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp_Info.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp_Info.Controls.Add(tb_LoginAccount, 0, 0);
            tlp_Info.Controls.Add(label2, 1, 0);
            tlp_Info.Controls.Add(tb_LoginPassword, 2, 0);
            tlp_Info.Controls.Add(label3, 3, 0);
            tlp_Info.Controls.Add(tb_DataBase, 4, 0);
            tlp_Info.Dock = DockStyle.Fill;
            tlp_Info.Location = new Point(332, 36);
            tlp_Info.Name = "tlp_Info";
            tlp_Info.RowCount = 1;
            tlp_Info.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_Info.Size = new Size(767, 36);
            tlp_Info.TabIndex = 2;
            // 
            // tb_LoginAccount
            // 
            tb_LoginAccount.Dock = DockStyle.Fill;
            tb_LoginAccount.Location = new Point(3, 3);
            tb_LoginAccount.Name = "tb_LoginAccount";
            tb_LoginAccount.Size = new Size(147, 27);
            tb_LoginAccount.TabIndex = 1;
            tb_LoginAccount.Text = "hruser";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(156, 0);
            label2.Name = "label2";
            label2.Size = new Size(147, 36);
            label2.TabIndex = 0;
            label2.Text = "登陆密码：";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tb_LoginPassword
            // 
            tb_LoginPassword.Dock = DockStyle.Fill;
            tb_LoginPassword.Location = new Point(309, 3);
            tb_LoginPassword.Name = "tb_LoginPassword";
            tb_LoginPassword.Size = new Size(147, 27);
            tb_LoginPassword.TabIndex = 1;
            tb_LoginPassword.Text = "rmohr123@abc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(462, 0);
            label3.Name = "label3";
            label3.Size = new Size(147, 36);
            label3.TabIndex = 0;
            label3.Text = "数据库名称：";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tb_DataBase
            // 
            tb_DataBase.Dock = DockStyle.Fill;
            tb_DataBase.Location = new Point(615, 3);
            tb_DataBase.Name = "tb_DataBase";
            tb_DataBase.Size = new Size(149, 27);
            tb_DataBase.TabIndex = 3;
            tb_DataBase.Text = "IOA";
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.DarkTurquoise;
            btnConnect.Dock = DockStyle.Right;
            btnConnect.Location = new Point(1237, 36);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(94, 36);
            btnConnect.TabIndex = 4;
            btnConnect.Text = "测试连接";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(23, 33);
            label1.Name = "label1";
            label1.Size = new Size(303, 42);
            label1.TabIndex = 5;
            label1.Text = "登陆账号：";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlp_CheckSplit
            // 
            tlp_CheckSplit.ColumnCount = 2;
            tlp_CheckSplit.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.56897F));
            tlp_CheckSplit.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.43103F));
            tlp_CheckSplit.Controls.Add(cb_IsProb, 0, 0);
            tlp_CheckSplit.Controls.Add(cb_CheckEmpStatus, 1, 0);
            tlp_CheckSplit.Dock = DockStyle.Fill;
            tlp_CheckSplit.Location = new Point(1102, 0);
            tlp_CheckSplit.Margin = new Padding(0);
            tlp_CheckSplit.Name = "tlp_CheckSplit";
            tlp_CheckSplit.RowCount = 1;
            tlp_CheckSplit.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_CheckSplit.Size = new Size(232, 33);
            tlp_CheckSplit.TabIndex = 6;
            // 
            // cb_IsProb
            // 
            cb_IsProb.AutoSize = true;
            cb_IsProb.Dock = DockStyle.Fill;
            cb_IsProb.Location = new Point(3, 3);
            cb_IsProb.Name = "cb_IsProb";
            cb_IsProb.Size = new Size(109, 27);
            cb_IsProb.TabIndex = 0;
            cb_IsProb.Text = "是否生产";
            cb_IsProb.UseVisualStyleBackColor = true;
            cb_IsProb.CheckedChanged += cb_IsProb_CheckedChanged;
            // 
            // cb_CheckEmpStatus
            // 
            cb_CheckEmpStatus.AutoSize = true;
            cb_CheckEmpStatus.Checked = true;
            cb_CheckEmpStatus.CheckState = CheckState.Checked;
            cb_CheckEmpStatus.Dock = DockStyle.Fill;
            cb_CheckEmpStatus.Location = new Point(118, 3);
            cb_CheckEmpStatus.Name = "cb_CheckEmpStatus";
            cb_CheckEmpStatus.Size = new Size(111, 27);
            cb_CheckEmpStatus.TabIndex = 1;
            cb_CheckEmpStatus.Text = "校验员工在职";
            cb_CheckEmpStatus.UseVisualStyleBackColor = true;
            // 
            // tlp_Main_Org
            // 
            tlp_Main_Org.BackColor = Color.FloralWhite;
            tlp_Main_Org.ColumnCount = 1;
            tlp_Main_Org.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp_Main_Org.Controls.Add(dv_Org, 0, 1);
            tlp_Main_Org.Controls.Add(tlp_Org_Script, 0, 2);
            tlp_Main_Org.Controls.Add(tableLayoutPanel1, 0, 0);
            tlp_Main_Org.Dock = DockStyle.Fill;
            tlp_Main_Org.Location = new Point(0, 75);
            tlp_Main_Org.Margin = new Padding(0);
            tlp_Main_Org.Name = "tlp_Main_Org";
            tlp_Main_Org.RowCount = 3;
            tlp_Main_Org.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlp_Main_Org.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tlp_Main_Org.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tlp_Main_Org.Size = new Size(1355, 433);
            tlp_Main_Org.TabIndex = 2;
            // 
            // dv_Org
            // 
            dv_Org.DataHelper = null;
            dv_Org.DataSourceSql = null;
            dv_Org.Dock = DockStyle.Fill;
            dv_Org.DvDataTable = null;
            dv_Org.DvSelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dv_Org.IsPage = false;
            dv_Org.IsShowFirstCheckBox = false;
            dv_Org.IsSort = false;
            dv_Org.Location = new Point(0, 50);
            dv_Org.Margin = new Padding(0);
            dv_Org.Name = "dv_Org";
            dv_Org.RowEdit = false;
            dv_Org.Size = new Size(1355, 268);
            dv_Org.TabIndex = 0;
            // 
            // tlp_Org_Script
            // 
            tlp_Org_Script.ColumnCount = 3;
            tlp_Org_Script.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tlp_Org_Script.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tlp_Org_Script.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tlp_Org_Script.Controls.Add(rtb_Org_FullError, 0, 0);
            tlp_Org_Script.Controls.Add(rtb_Org_RowError, 1, 0);
            tlp_Org_Script.Controls.Add(rtb_Org_SqlScript, 2, 0);
            tlp_Org_Script.Dock = DockStyle.Fill;
            tlp_Org_Script.Location = new Point(0, 318);
            tlp_Org_Script.Margin = new Padding(0);
            tlp_Org_Script.Name = "tlp_Org_Script";
            tlp_Org_Script.RowCount = 1;
            tlp_Org_Script.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_Org_Script.Size = new Size(1355, 115);
            tlp_Org_Script.TabIndex = 1;
            // 
            // rtb_Org_FullError
            // 
            rtb_Org_FullError.Dock = DockStyle.Fill;
            rtb_Org_FullError.ForeColor = SystemColors.WindowText;
            rtb_Org_FullError.Location = new Point(0, 0);
            rtb_Org_FullError.Margin = new Padding(0);
            rtb_Org_FullError.Name = "rtb_Org_FullError";
            rtb_Org_FullError.Size = new Size(451, 115);
            rtb_Org_FullError.TabIndex = 0;
            rtb_Org_FullError.Text = "";
            // 
            // rtb_Org_RowError
            // 
            rtb_Org_RowError.Dock = DockStyle.Fill;
            rtb_Org_RowError.ForeColor = SystemColors.WindowText;
            rtb_Org_RowError.Location = new Point(451, 0);
            rtb_Org_RowError.Margin = new Padding(0);
            rtb_Org_RowError.Name = "rtb_Org_RowError";
            rtb_Org_RowError.Size = new Size(451, 115);
            rtb_Org_RowError.TabIndex = 1;
            rtb_Org_RowError.Text = "";
            // 
            // rtb_Org_SqlScript
            // 
            rtb_Org_SqlScript.Dock = DockStyle.Fill;
            rtb_Org_SqlScript.Location = new Point(902, 0);
            rtb_Org_SqlScript.Margin = new Padding(0);
            rtb_Org_SqlScript.Name = "rtb_Org_SqlScript";
            rtb_Org_SqlScript.Size = new Size(453, 115);
            rtb_Org_SqlScript.TabIndex = 2;
            rtb_Org_SqlScript.Text = "";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(btn_Org_Import, 1, 0);
            tableLayoutPanel1.Controls.Add(btn_Org_Script, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.ForeColor = Color.Black;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1355, 50);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // btn_Org_Import
            // 
            btn_Org_Import.Dock = DockStyle.Fill;
            btn_Org_Import.Location = new Point(587, 0);
            btn_Org_Import.Margin = new Padding(0);
            btn_Org_Import.Name = "btn_Org_Import";
            btn_Org_Import.Size = new Size(80, 50);
            btn_Org_Import.TabIndex = 1;
            btn_Org_Import.Text = "导入";
            btn_Org_Import.UseVisualStyleBackColor = true;
            btn_Org_Import.Click += btn_Org_Import_Click;
            // 
            // btn_Org_Script
            // 
            btn_Org_Script.Dock = DockStyle.Fill;
            btn_Org_Script.Location = new Point(687, 0);
            btn_Org_Script.Margin = new Padding(0);
            btn_Org_Script.Name = "btn_Org_Script";
            btn_Org_Script.Size = new Size(80, 50);
            btn_Org_Script.TabIndex = 2;
            btn_Org_Script.Text = "生成";
            btn_Org_Script.UseVisualStyleBackColor = true;
            btn_Org_Script.Click += btn_Org_Script_Click;
            // 
            // tlp_Main_Emp
            // 
            tlp_Main_Emp.BackColor = Color.Beige;
            tlp_Main_Emp.ColumnCount = 1;
            tlp_Main_Emp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp_Main_Emp.Controls.Add(dv_Emp, 0, 1);
            tlp_Main_Emp.Controls.Add(tlp_Emp_Script, 0, 2);
            tlp_Main_Emp.Controls.Add(tableLayoutPanel2, 0, 0);
            tlp_Main_Emp.Dock = DockStyle.Fill;
            tlp_Main_Emp.Location = new Point(0, 508);
            tlp_Main_Emp.Margin = new Padding(0);
            tlp_Main_Emp.Name = "tlp_Main_Emp";
            tlp_Main_Emp.RowCount = 3;
            tlp_Main_Emp.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tlp_Main_Emp.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tlp_Main_Emp.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tlp_Main_Emp.Size = new Size(1355, 434);
            tlp_Main_Emp.TabIndex = 3;
            // 
            // dv_Emp
            // 
            dv_Emp.DataHelper = null;
            dv_Emp.DataSourceSql = null;
            dv_Emp.Dock = DockStyle.Fill;
            dv_Emp.DvDataTable = null;
            dv_Emp.DvSelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dv_Emp.IsPage = false;
            dv_Emp.IsShowFirstCheckBox = false;
            dv_Emp.IsSort = false;
            dv_Emp.Location = new Point(0, 62);
            dv_Emp.Margin = new Padding(0);
            dv_Emp.Name = "dv_Emp";
            dv_Emp.RowEdit = false;
            dv_Emp.Size = new Size(1355, 260);
            dv_Emp.TabIndex = 0;
            // 
            // tlp_Emp_Script
            // 
            tlp_Emp_Script.ColumnCount = 3;
            tlp_Emp_Script.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tlp_Emp_Script.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tlp_Emp_Script.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tlp_Emp_Script.Controls.Add(rtb_Emp_FullError, 0, 0);
            tlp_Emp_Script.Controls.Add(rtb_Emp_RowError, 1, 0);
            tlp_Emp_Script.Controls.Add(rtb_Emp_SqlScript, 2, 0);
            tlp_Emp_Script.Dock = DockStyle.Fill;
            tlp_Emp_Script.Location = new Point(0, 322);
            tlp_Emp_Script.Margin = new Padding(0);
            tlp_Emp_Script.Name = "tlp_Emp_Script";
            tlp_Emp_Script.RowCount = 1;
            tlp_Emp_Script.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_Emp_Script.Size = new Size(1355, 112);
            tlp_Emp_Script.TabIndex = 1;
            // 
            // rtb_Emp_FullError
            // 
            rtb_Emp_FullError.Dock = DockStyle.Fill;
            rtb_Emp_FullError.ForeColor = SystemColors.WindowText;
            rtb_Emp_FullError.Location = new Point(0, 0);
            rtb_Emp_FullError.Margin = new Padding(0);
            rtb_Emp_FullError.Name = "rtb_Emp_FullError";
            rtb_Emp_FullError.Size = new Size(451, 112);
            rtb_Emp_FullError.TabIndex = 0;
            rtb_Emp_FullError.Text = "";
            // 
            // rtb_Emp_RowError
            // 
            rtb_Emp_RowError.Dock = DockStyle.Fill;
            rtb_Emp_RowError.ForeColor = SystemColors.WindowText;
            rtb_Emp_RowError.Location = new Point(451, 0);
            rtb_Emp_RowError.Margin = new Padding(0);
            rtb_Emp_RowError.Name = "rtb_Emp_RowError";
            rtb_Emp_RowError.Size = new Size(451, 112);
            rtb_Emp_RowError.TabIndex = 1;
            rtb_Emp_RowError.Text = "";
            // 
            // rtb_Emp_SqlScript
            // 
            rtb_Emp_SqlScript.Dock = DockStyle.Fill;
            rtb_Emp_SqlScript.Location = new Point(902, 0);
            rtb_Emp_SqlScript.Margin = new Padding(0);
            rtb_Emp_SqlScript.Name = "rtb_Emp_SqlScript";
            rtb_Emp_SqlScript.Size = new Size(453, 112);
            rtb_Emp_SqlScript.TabIndex = 2;
            rtb_Emp_SqlScript.Text = "";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(btn_Emp_Import, 1, 0);
            tableLayoutPanel2.Controls.Add(btn_Emp_Script, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.ForeColor = Color.Black;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1355, 62);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // btn_Emp_Import
            // 
            btn_Emp_Import.Dock = DockStyle.Fill;
            btn_Emp_Import.Location = new Point(587, 0);
            btn_Emp_Import.Margin = new Padding(0);
            btn_Emp_Import.Name = "btn_Emp_Import";
            btn_Emp_Import.Size = new Size(80, 62);
            btn_Emp_Import.TabIndex = 1;
            btn_Emp_Import.Text = "导入";
            btn_Emp_Import.UseVisualStyleBackColor = true;
            btn_Emp_Import.Click += btn_Emp_Import_Click;
            // 
            // btn_Emp_Script
            // 
            btn_Emp_Script.Dock = DockStyle.Fill;
            btn_Emp_Script.Location = new Point(687, 0);
            btn_Emp_Script.Margin = new Padding(0);
            btn_Emp_Script.Name = "btn_Emp_Script";
            btn_Emp_Script.Size = new Size(80, 62);
            btn_Emp_Script.TabIndex = 2;
            btn_Emp_Script.Text = "生成";
            btn_Emp_Script.UseVisualStyleBackColor = true;
            btn_Emp_Script.Click += btn_Emp_Script_Click;
            // 
            // PduImport
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1355, 942);
            Controls.Add(tlp_Main);
            Name = "PduImport";
            Text = "PDUImport";
            Load += PDUImport_Load;
            tlp_Main.ResumeLayout(false);
            tlp_Connect.ResumeLayout(false);
            tlp_Connect.PerformLayout();
            tlp_Info.ResumeLayout(false);
            tlp_Info.PerformLayout();
            tlp_CheckSplit.ResumeLayout(false);
            tlp_CheckSplit.PerformLayout();
            tlp_Main_Org.ResumeLayout(false);
            tlp_Org_Script.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tlp_Main_Emp.ResumeLayout(false);
            tlp_Emp_Script.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlp_Main;
        private TableLayoutPanel tlp_Connect;
        private Label lbl_IP;
        private ComboBox cmb_IP;
        private TableLayoutPanel tlp_Info;
        private TextBox tb_LoginAccount;
        private Label label2;
        private TextBox tb_LoginPassword;
        private Label label3;
        private TextBox tb_DataBase;
        private Button btnConnect;
        private Label label1;
        private TableLayoutPanel tlp_Main_Org;
        private TableLayoutPanel tlp_Main_Emp;
        private CusControls.DataGridViewEx.DataGridViewEx dv_Org;
        private CusControls.DataGridViewEx.DataGridViewEx dv_Emp;
        private TableLayoutPanel tlp_Org_Script;
        private TableLayoutPanel tlp_Emp_Script;
        private RichTextBox rtb_Org_FullError;
        private RichTextBox rtb_Org_RowError;
        private RichTextBox rtb_Org_SqlScript;
        private RichTextBox rtb_Emp_FullError;
        private RichTextBox rtb_Emp_RowError;
        private RichTextBox rtb_Emp_SqlScript;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btn_Org_Import;
        private Button btn_Emp_Import;
        private Button btn_Org_Script;
        private Button btn_Emp_Script;
        private TableLayoutPanel tlp_CheckSplit;
        private CheckBox cb_IsProb;
        private CheckBox cb_CheckEmpStatus;
    }
}