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
            this.tlp_Main = new System.Windows.Forms.TableLayoutPanel();
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
            this.tlp_Main_Org = new System.Windows.Forms.TableLayoutPanel();
            this.dv_Org = new Tool.CusControls.DataGridViewEx.DataGridViewEx();
            this.tlp_Org_Script = new System.Windows.Forms.TableLayoutPanel();
            this.rtb_Org_FullError = new System.Windows.Forms.RichTextBox();
            this.rtb_Org_RowError = new System.Windows.Forms.RichTextBox();
            this.rtb_Org_SqlScript = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Org_Import = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tlp_Main_Emp = new System.Windows.Forms.TableLayoutPanel();
            this.dv_Emp = new Tool.CusControls.DataGridViewEx.DataGridViewEx();
            this.tlp_Emp_Script = new System.Windows.Forms.TableLayoutPanel();
            this.rtb_Emp_FullError = new System.Windows.Forms.RichTextBox();
            this.rtb_Emp_RowError = new System.Windows.Forms.RichTextBox();
            this.rtb_Emp_SqlScript = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Emp_Import = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tlp_Main.SuspendLayout();
            this.tlp_Connect.SuspendLayout();
            this.tlp_Info.SuspendLayout();
            this.tlp_Main_Org.SuspendLayout();
            this.tlp_Org_Script.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlp_Main_Emp.SuspendLayout();
            this.tlp_Emp_Script.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_Main
            // 
            this.tlp_Main.BackColor = System.Drawing.Color.Azure;
            this.tlp_Main.ColumnCount = 1;
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Main.Controls.Add(this.tlp_Connect, 0, 0);
            this.tlp_Main.Controls.Add(this.tlp_Main_Org, 0, 1);
            this.tlp_Main.Controls.Add(this.tlp_Main_Emp, 0, 2);
            this.tlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Main.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tlp_Main.Location = new System.Drawing.Point(0, 0);
            this.tlp_Main.Name = "tlp_Main";
            this.tlp_Main.RowCount = 3;
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Main.Size = new System.Drawing.Size(1355, 942);
            this.tlp_Main.TabIndex = 0;
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
            this.tlp_Connect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tlp_Connect.Location = new System.Drawing.Point(0, 0);
            this.tlp_Connect.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Connect.Name = "tlp_Connect";
            this.tlp_Connect.RowCount = 2;
            this.tlp_Connect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlp_Connect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp_Connect.Size = new System.Drawing.Size(1355, 75);
            this.tlp_Connect.TabIndex = 1;
            // 
            // lbl_IP
            // 
            this.lbl_IP.AutoSize = true;
            this.lbl_IP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_IP.Location = new System.Drawing.Point(23, 0);
            this.lbl_IP.Name = "lbl_IP";
            this.lbl_IP.Size = new System.Drawing.Size(303, 33);
            this.lbl_IP.TabIndex = 0;
            this.lbl_IP.Text = "数据库地址：";
            this.lbl_IP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_IP
            // 
            this.cmb_IP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_IP.FormattingEnabled = true;
            this.cmb_IP.Location = new System.Drawing.Point(332, 3);
            this.cmb_IP.Name = "cmb_IP";
            this.cmb_IP.Size = new System.Drawing.Size(767, 28);
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
            this.tlp_Info.Location = new System.Drawing.Point(332, 36);
            this.tlp_Info.Name = "tlp_Info";
            this.tlp_Info.RowCount = 1;
            this.tlp_Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Info.Size = new System.Drawing.Size(767, 36);
            this.tlp_Info.TabIndex = 2;
            // 
            // tb_LoginAccount
            // 
            this.tb_LoginAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_LoginAccount.Location = new System.Drawing.Point(3, 3);
            this.tb_LoginAccount.Name = "tb_LoginAccount";
            this.tb_LoginAccount.Size = new System.Drawing.Size(147, 27);
            this.tb_LoginAccount.TabIndex = 1;
            this.tb_LoginAccount.Text = "hruser";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(156, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "登陆密码：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_LoginPassword
            // 
            this.tb_LoginPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_LoginPassword.Location = new System.Drawing.Point(309, 3);
            this.tb_LoginPassword.Name = "tb_LoginPassword";
            this.tb_LoginPassword.Size = new System.Drawing.Size(147, 27);
            this.tb_LoginPassword.TabIndex = 1;
            this.tb_LoginPassword.Text = "rmohr123@abc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(462, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "数据库名称：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_DataBase
            // 
            this.tb_DataBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_DataBase.Location = new System.Drawing.Point(615, 3);
            this.tb_DataBase.Name = "tb_DataBase";
            this.tb_DataBase.Size = new System.Drawing.Size(149, 27);
            this.tb_DataBase.TabIndex = 3;
            this.tb_DataBase.Text = "IOA";
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnConnect.Location = new System.Drawing.Point(1237, 36);
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
            this.label1.Size = new System.Drawing.Size(303, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "登陆账号：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlp_Main_Org
            // 
            this.tlp_Main_Org.BackColor = System.Drawing.Color.FloralWhite;
            this.tlp_Main_Org.ColumnCount = 1;
            this.tlp_Main_Org.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Main_Org.Controls.Add(this.dv_Org, 0, 1);
            this.tlp_Main_Org.Controls.Add(this.tlp_Org_Script, 0, 2);
            this.tlp_Main_Org.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tlp_Main_Org.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Main_Org.Location = new System.Drawing.Point(0, 75);
            this.tlp_Main_Org.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Main_Org.Name = "tlp_Main_Org";
            this.tlp_Main_Org.RowCount = 3;
            this.tlp_Main_Org.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlp_Main_Org.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlp_Main_Org.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_Main_Org.Size = new System.Drawing.Size(1355, 433);
            this.tlp_Main_Org.TabIndex = 2;
            // 
            // dv_Org
            // 
            this.dv_Org.DataHelper = null;
            this.dv_Org.DataSourceSql = null;
            this.dv_Org.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dv_Org.DvDataTable = null;
            this.dv_Org.DvSelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dv_Org.IsPage = false;
            this.dv_Org.IsShowFirstCheckBox = false;
            this.dv_Org.IsSort = false;
            this.dv_Org.Location = new System.Drawing.Point(0, 50);
            this.dv_Org.Margin = new System.Windows.Forms.Padding(0);
            this.dv_Org.Name = "dv_Org";
            this.dv_Org.RowEdit = false;
            this.dv_Org.Size = new System.Drawing.Size(1355, 268);
            this.dv_Org.TabIndex = 0;
            // 
            // tlp_Org_Script
            // 
            this.tlp_Org_Script.ColumnCount = 3;
            this.tlp_Org_Script.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Org_Script.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_Org_Script.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_Org_Script.Controls.Add(this.rtb_Org_FullError, 0, 0);
            this.tlp_Org_Script.Controls.Add(this.rtb_Org_RowError, 1, 0);
            this.tlp_Org_Script.Controls.Add(this.rtb_Org_SqlScript, 2, 0);
            this.tlp_Org_Script.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Org_Script.Location = new System.Drawing.Point(0, 318);
            this.tlp_Org_Script.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Org_Script.Name = "tlp_Org_Script";
            this.tlp_Org_Script.RowCount = 1;
            this.tlp_Org_Script.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Org_Script.Size = new System.Drawing.Size(1355, 115);
            this.tlp_Org_Script.TabIndex = 1;
            // 
            // rtb_Org_FullError
            // 
            this.rtb_Org_FullError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Org_FullError.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rtb_Org_FullError.Location = new System.Drawing.Point(0, 0);
            this.rtb_Org_FullError.Margin = new System.Windows.Forms.Padding(0);
            this.rtb_Org_FullError.Name = "rtb_Org_FullError";
            this.rtb_Org_FullError.Size = new System.Drawing.Size(677, 115);
            this.rtb_Org_FullError.TabIndex = 0;
            this.rtb_Org_FullError.Text = "";
            // 
            // rtb_Org_RowError
            // 
            this.rtb_Org_RowError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Org_RowError.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rtb_Org_RowError.Location = new System.Drawing.Point(677, 0);
            this.rtb_Org_RowError.Margin = new System.Windows.Forms.Padding(0);
            this.rtb_Org_RowError.Name = "rtb_Org_RowError";
            this.rtb_Org_RowError.Size = new System.Drawing.Size(338, 115);
            this.rtb_Org_RowError.TabIndex = 1;
            this.rtb_Org_RowError.Text = "";
            // 
            // rtb_Org_SqlScript
            // 
            this.rtb_Org_SqlScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Org_SqlScript.Location = new System.Drawing.Point(1015, 0);
            this.rtb_Org_SqlScript.Margin = new System.Windows.Forms.Padding(0);
            this.rtb_Org_SqlScript.Name = "rtb_Org_SqlScript";
            this.rtb_Org_SqlScript.Size = new System.Drawing.Size(340, 115);
            this.rtb_Org_SqlScript.TabIndex = 2;
            this.rtb_Org_SqlScript.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Org_Import, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1355, 50);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btn_Org_Import
            // 
            this.btn_Org_Import.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Org_Import.Location = new System.Drawing.Point(587, 0);
            this.btn_Org_Import.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Org_Import.Name = "btn_Org_Import";
            this.btn_Org_Import.Size = new System.Drawing.Size(80, 50);
            this.btn_Org_Import.TabIndex = 1;
            this.btn_Org_Import.Text = "导入";
            this.btn_Org_Import.UseVisualStyleBackColor = true;
            this.btn_Org_Import.Click += new System.EventHandler(this.btn_Org_Import_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(687, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "生成";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tlp_Main_Emp
            // 
            this.tlp_Main_Emp.BackColor = System.Drawing.Color.Beige;
            this.tlp_Main_Emp.ColumnCount = 1;
            this.tlp_Main_Emp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Main_Emp.Controls.Add(this.dv_Emp, 0, 1);
            this.tlp_Main_Emp.Controls.Add(this.tlp_Emp_Script, 0, 2);
            this.tlp_Main_Emp.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tlp_Main_Emp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Main_Emp.Location = new System.Drawing.Point(0, 508);
            this.tlp_Main_Emp.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Main_Emp.Name = "tlp_Main_Emp";
            this.tlp_Main_Emp.RowCount = 3;
            this.tlp_Main_Emp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tlp_Main_Emp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlp_Main_Emp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_Main_Emp.Size = new System.Drawing.Size(1355, 434);
            this.tlp_Main_Emp.TabIndex = 3;
            // 
            // dv_Emp
            // 
            this.dv_Emp.DataHelper = null;
            this.dv_Emp.DataSourceSql = null;
            this.dv_Emp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dv_Emp.DvDataTable = null;
            this.dv_Emp.DvSelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dv_Emp.IsPage = false;
            this.dv_Emp.IsShowFirstCheckBox = false;
            this.dv_Emp.IsSort = false;
            this.dv_Emp.Location = new System.Drawing.Point(0, 62);
            this.dv_Emp.Margin = new System.Windows.Forms.Padding(0);
            this.dv_Emp.Name = "dv_Emp";
            this.dv_Emp.RowEdit = false;
            this.dv_Emp.Size = new System.Drawing.Size(1355, 260);
            this.dv_Emp.TabIndex = 0;
            // 
            // tlp_Emp_Script
            // 
            this.tlp_Emp_Script.ColumnCount = 3;
            this.tlp_Emp_Script.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Emp_Script.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_Emp_Script.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_Emp_Script.Controls.Add(this.rtb_Emp_FullError, 0, 0);
            this.tlp_Emp_Script.Controls.Add(this.rtb_Emp_RowError, 1, 0);
            this.tlp_Emp_Script.Controls.Add(this.rtb_Emp_SqlScript, 2, 0);
            this.tlp_Emp_Script.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Emp_Script.Location = new System.Drawing.Point(0, 322);
            this.tlp_Emp_Script.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Emp_Script.Name = "tlp_Emp_Script";
            this.tlp_Emp_Script.RowCount = 1;
            this.tlp_Emp_Script.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Emp_Script.Size = new System.Drawing.Size(1355, 112);
            this.tlp_Emp_Script.TabIndex = 1;
            // 
            // rtb_Emp_FullError
            // 
            this.rtb_Emp_FullError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Emp_FullError.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rtb_Emp_FullError.Location = new System.Drawing.Point(0, 0);
            this.rtb_Emp_FullError.Margin = new System.Windows.Forms.Padding(0);
            this.rtb_Emp_FullError.Name = "rtb_Emp_FullError";
            this.rtb_Emp_FullError.Size = new System.Drawing.Size(677, 112);
            this.rtb_Emp_FullError.TabIndex = 0;
            this.rtb_Emp_FullError.Text = "";
            // 
            // rtb_Emp_RowError
            // 
            this.rtb_Emp_RowError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Emp_RowError.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rtb_Emp_RowError.Location = new System.Drawing.Point(677, 0);
            this.rtb_Emp_RowError.Margin = new System.Windows.Forms.Padding(0);
            this.rtb_Emp_RowError.Name = "rtb_Emp_RowError";
            this.rtb_Emp_RowError.Size = new System.Drawing.Size(338, 112);
            this.rtb_Emp_RowError.TabIndex = 1;
            this.rtb_Emp_RowError.Text = "";
            // 
            // rtb_Emp_SqlScript
            // 
            this.rtb_Emp_SqlScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Emp_SqlScript.Location = new System.Drawing.Point(1015, 0);
            this.rtb_Emp_SqlScript.Margin = new System.Windows.Forms.Padding(0);
            this.rtb_Emp_SqlScript.Name = "rtb_Emp_SqlScript";
            this.rtb_Emp_SqlScript.Size = new System.Drawing.Size(340, 112);
            this.rtb_Emp_SqlScript.TabIndex = 2;
            this.rtb_Emp_SqlScript.Text = "";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btn_Emp_Import, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button4, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.ForeColor = System.Drawing.Color.Black;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1355, 62);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btn_Emp_Import
            // 
            this.btn_Emp_Import.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Emp_Import.Location = new System.Drawing.Point(587, 0);
            this.btn_Emp_Import.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Emp_Import.Name = "btn_Emp_Import";
            this.btn_Emp_Import.Size = new System.Drawing.Size(80, 62);
            this.btn_Emp_Import.TabIndex = 1;
            this.btn_Emp_Import.Text = "导入";
            this.btn_Emp_Import.UseVisualStyleBackColor = true;
            this.btn_Emp_Import.Click += new System.EventHandler(this.btn_Emp_Import_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(687, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 62);
            this.button4.TabIndex = 2;
            this.button4.Text = "生成";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // PduImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 942);
            this.Controls.Add(this.tlp_Main);
            this.Name = "PduImport";
            this.Text = "PDUImport";
            this.Load += new System.EventHandler(this.PDUImport_Load);
            this.tlp_Main.ResumeLayout(false);
            this.tlp_Connect.ResumeLayout(false);
            this.tlp_Connect.PerformLayout();
            this.tlp_Info.ResumeLayout(false);
            this.tlp_Info.PerformLayout();
            this.tlp_Main_Org.ResumeLayout(false);
            this.tlp_Org_Script.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tlp_Main_Emp.ResumeLayout(false);
            this.tlp_Emp_Script.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private Button button3;
        private Button button4;
    }
}