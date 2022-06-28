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
            this.tlp_Main.SuspendLayout();
            this.tlp_Connect.SuspendLayout();
            this.tlp_Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_Main
            // 
            this.tlp_Main.BackColor = System.Drawing.Color.Azure;
            this.tlp_Main.ColumnCount = 1;
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Main.Controls.Add(this.tlp_Connect, 0, 0);
            this.tlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Main.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tlp_Main.Location = new System.Drawing.Point(0, 0);
            this.tlp_Main.Name = "tlp_Main";
            this.tlp_Main.RowCount = 2;
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Main.Size = new System.Drawing.Size(1209, 733);
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
            this.tlp_Connect.Size = new System.Drawing.Size(1209, 75);
            this.tlp_Connect.TabIndex = 1;
            // 
            // lbl_IP
            // 
            this.lbl_IP.AutoSize = true;
            this.lbl_IP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_IP.Location = new System.Drawing.Point(23, 0);
            this.lbl_IP.Name = "lbl_IP";
            this.lbl_IP.Size = new System.Drawing.Size(269, 33);
            this.lbl_IP.TabIndex = 0;
            this.lbl_IP.Text = "数据库地址：";
            this.lbl_IP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_IP
            // 
            this.cmb_IP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_IP.FormattingEnabled = true;
            this.cmb_IP.Location = new System.Drawing.Point(298, 3);
            this.cmb_IP.Name = "cmb_IP";
            this.cmb_IP.Size = new System.Drawing.Size(681, 28);
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
            this.tlp_Info.Location = new System.Drawing.Point(298, 36);
            this.tlp_Info.Name = "tlp_Info";
            this.tlp_Info.RowCount = 1;
            this.tlp_Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Info.Size = new System.Drawing.Size(681, 36);
            this.tlp_Info.TabIndex = 2;
            // 
            // tb_LoginAccount
            // 
            this.tb_LoginAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_LoginAccount.Location = new System.Drawing.Point(3, 3);
            this.tb_LoginAccount.Name = "tb_LoginAccount";
            this.tb_LoginAccount.Size = new System.Drawing.Size(130, 27);
            this.tb_LoginAccount.TabIndex = 1;
            this.tb_LoginAccount.Text = "hruser";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(139, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "登陆密码：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_LoginPassword
            // 
            this.tb_LoginPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_LoginPassword.Location = new System.Drawing.Point(275, 3);
            this.tb_LoginPassword.Name = "tb_LoginPassword";
            this.tb_LoginPassword.Size = new System.Drawing.Size(130, 27);
            this.tb_LoginPassword.TabIndex = 1;
            this.tb_LoginPassword.Text = "rmohr123@abc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(411, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "数据库名称：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_DataBase
            // 
            this.tb_DataBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_DataBase.Location = new System.Drawing.Point(547, 3);
            this.tb_DataBase.Name = "tb_DataBase";
            this.tb_DataBase.Size = new System.Drawing.Size(131, 27);
            this.tb_DataBase.TabIndex = 3;
            this.tb_DataBase.Text = "IOA";
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnConnect.Location = new System.Drawing.Point(1091, 36);
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
            this.label1.Size = new System.Drawing.Size(269, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "登陆账号：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PduImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 733);
            this.Controls.Add(this.tlp_Main);
            this.Name = "PduImport";
            this.Text = "PDUImport";
            this.Load += new System.EventHandler(this.PDUImport_Load);
            this.tlp_Main.ResumeLayout(false);
            this.tlp_Connect.ResumeLayout(false);
            this.tlp_Connect.PerformLayout();
            this.tlp_Info.ResumeLayout(false);
            this.tlp_Info.PerformLayout();
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
    }
}