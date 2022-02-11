namespace Tool.Main.Forms.ComForms
{
    partial class StringHelper
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
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tlp_StringList = new System.Windows.Forms.TableLayoutPanel();
            this.rtb_StringList_Source = new System.Windows.Forms.RichTextBox();
            this.rtb_StringList_Distination = new System.Windows.Forms.RichTextBox();
            this.tlp_StringList_Operate = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_StringList_Operate_SplitChar = new System.Windows.Forms.TableLayoutPanel();
            this.btn_StringList_SplitChar = new System.Windows.Forms.Button();
            this.tb_StringList_SplitChar = new System.Windows.Forms.TextBox();
            this.tlp_StringList_Operate_AddBEChar = new System.Windows.Forms.TableLayoutPanel();
            this.tb_StringList_AddBEChar = new System.Windows.Forms.TextBox();
            this.btn_StringList_AddBEChar = new System.Windows.Forms.Button();
            this.tlp_StringList_Operate_AddEndChar = new System.Windows.Forms.TableLayoutPanel();
            this.tb_StringList_AddEndChar = new System.Windows.Forms.TextBox();
            this.btn_StringList_AddEndChar = new System.Windows.Forms.Button();
            this.tlp_StringList_Operate_AddBeginChar = new System.Windows.Forms.TableLayoutPanel();
            this.tb_StringList_AddBeginChar = new System.Windows.Forms.TextBox();
            this.btn_StringList_AddBeginChar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tlp_Encrypt = new System.Windows.Forms.TableLayoutPanel();
            this.tb_Encrypt_Decode = new System.Windows.Forms.TextBox();
            this.btn_Encrypt_Encode = new System.Windows.Forms.Button();
            this.btn_Encrypt_Decode = new System.Windows.Forms.Button();
            this.lb_Encrypt_Encode = new System.Windows.Forms.TextBox();
            this.lb_Encrypt_Decode = new System.Windows.Forms.TextBox();
            this.tb_Encrypt_Key_De = new System.Windows.Forms.TextBox();
            this.tb_Encrypt_IV_De = new System.Windows.Forms.TextBox();
            this.tb_Encrypt_Encode = new System.Windows.Forms.TextBox();
            this.rtb_Encrypt_Source = new System.Windows.Forms.RichTextBox();
            this.rtb_Encrypt_Distination = new System.Windows.Forms.RichTextBox();
            this.tlp_Encrypt_PlButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnMuti_EncryptDecode = new System.Windows.Forms.Button();
            this.btnMuti_EncryptEncode = new System.Windows.Forms.Button();
            this.tlp_Encrypt_Key = new System.Windows.Forms.TableLayoutPanel();
            this.tb_Encrypt_Key_En = new System.Windows.Forms.TextBox();
            this.lbl_Encrypt_key = new System.Windows.Forms.Label();
            this.tlp_Encrypt_IV = new System.Windows.Forms.TableLayoutPanel();
            this.tb_Encrypt_IV_En = new System.Windows.Forms.TextBox();
            this.lbl_Encrypt_iv = new System.Windows.Forms.Label();
            this.lbl_Encrypt_Des1 = new System.Windows.Forms.Label();
            this.lbl_Encrypt_Des2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tlp_StringList.SuspendLayout();
            this.tlp_StringList_Operate.SuspendLayout();
            this.tlp_StringList_Operate_SplitChar.SuspendLayout();
            this.tlp_StringList_Operate_AddBEChar.SuspendLayout();
            this.tlp_StringList_Operate_AddEndChar.SuspendLayout();
            this.tlp_StringList_Operate_AddBeginChar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tlp_Encrypt.SuspendLayout();
            this.tlp_Encrypt_PlButton.SuspendLayout();
            this.tlp_Encrypt_Key.SuspendLayout();
            this.tlp_Encrypt_IV.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.ColumnCount = 2;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel.Controls.Add(this.panel1, 0, 0);
            this.mainPanel.Controls.Add(this.panel2, 1, 0);
            this.mainPanel.Controls.Add(this.panel3, 0, 1);
            this.mainPanel.Controls.Add(this.panel4, 1, 1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 2;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel.Size = new System.Drawing.Size(1280, 801);
            this.mainPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.tlp_StringList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 394);
            this.panel1.TabIndex = 0;
            // 
            // tlp_StringList
            // 
            this.tlp_StringList.ColumnCount = 3;
            this.tlp_StringList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlp_StringList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_StringList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlp_StringList.Controls.Add(this.rtb_StringList_Source, 0, 0);
            this.tlp_StringList.Controls.Add(this.rtb_StringList_Distination, 2, 0);
            this.tlp_StringList.Controls.Add(this.tlp_StringList_Operate, 1, 0);
            this.tlp_StringList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_StringList.Location = new System.Drawing.Point(0, 0);
            this.tlp_StringList.Name = "tlp_StringList";
            this.tlp_StringList.RowCount = 1;
            this.tlp_StringList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_StringList.Size = new System.Drawing.Size(634, 394);
            this.tlp_StringList.TabIndex = 0;
            // 
            // rtb_StringList_Source
            // 
            this.rtb_StringList_Source.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_StringList_Source.Location = new System.Drawing.Point(3, 3);
            this.rtb_StringList_Source.Name = "rtb_StringList_Source";
            this.rtb_StringList_Source.Size = new System.Drawing.Size(247, 388);
            this.rtb_StringList_Source.TabIndex = 0;
            this.rtb_StringList_Source.Text = "";
            // 
            // rtb_StringList_Distination
            // 
            this.rtb_StringList_Distination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_StringList_Distination.Location = new System.Drawing.Point(382, 3);
            this.rtb_StringList_Distination.Name = "rtb_StringList_Distination";
            this.rtb_StringList_Distination.Size = new System.Drawing.Size(249, 388);
            this.rtb_StringList_Distination.TabIndex = 1;
            this.rtb_StringList_Distination.Text = "";
            // 
            // tlp_StringList_Operate
            // 
            this.tlp_StringList_Operate.ColumnCount = 1;
            this.tlp_StringList_Operate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_StringList_Operate.Controls.Add(this.tlp_StringList_Operate_SplitChar, 0, 0);
            this.tlp_StringList_Operate.Controls.Add(this.tlp_StringList_Operate_AddBEChar, 0, 1);
            this.tlp_StringList_Operate.Controls.Add(this.tlp_StringList_Operate_AddEndChar, 0, 3);
            this.tlp_StringList_Operate.Controls.Add(this.tlp_StringList_Operate_AddBeginChar, 0, 2);
            this.tlp_StringList_Operate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_StringList_Operate.Location = new System.Drawing.Point(256, 3);
            this.tlp_StringList_Operate.Name = "tlp_StringList_Operate";
            this.tlp_StringList_Operate.RowCount = 10;
            this.tlp_StringList_Operate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_StringList_Operate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_StringList_Operate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_StringList_Operate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_StringList_Operate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_StringList_Operate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_StringList_Operate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_StringList_Operate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_StringList_Operate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_StringList_Operate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_StringList_Operate.Size = new System.Drawing.Size(120, 388);
            this.tlp_StringList_Operate.TabIndex = 2;
            // 
            // tlp_StringList_Operate_SplitChar
            // 
            this.tlp_StringList_Operate_SplitChar.ColumnCount = 2;
            this.tlp_StringList_Operate_SplitChar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_StringList_Operate_SplitChar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tlp_StringList_Operate_SplitChar.Controls.Add(this.btn_StringList_SplitChar, 1, 0);
            this.tlp_StringList_Operate_SplitChar.Controls.Add(this.tb_StringList_SplitChar, 0, 0);
            this.tlp_StringList_Operate_SplitChar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_StringList_Operate_SplitChar.Location = new System.Drawing.Point(3, 3);
            this.tlp_StringList_Operate_SplitChar.Name = "tlp_StringList_Operate_SplitChar";
            this.tlp_StringList_Operate_SplitChar.RowCount = 1;
            this.tlp_StringList_Operate_SplitChar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_StringList_Operate_SplitChar.Size = new System.Drawing.Size(114, 32);
            this.tlp_StringList_Operate_SplitChar.TabIndex = 0;
            // 
            // btn_StringList_SplitChar
            // 
            this.btn_StringList_SplitChar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_StringList_SplitChar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StringList_SplitChar.Location = new System.Drawing.Point(41, 3);
            this.btn_StringList_SplitChar.Name = "btn_StringList_SplitChar";
            this.btn_StringList_SplitChar.Size = new System.Drawing.Size(70, 26);
            this.btn_StringList_SplitChar.TabIndex = 2;
            this.btn_StringList_SplitChar.Text = "分割字符";
            this.btn_StringList_SplitChar.UseVisualStyleBackColor = true;
            this.btn_StringList_SplitChar.Click += new System.EventHandler(this.btn_StringList_SplitChar_Click);
            // 
            // tb_StringList_SplitChar
            // 
            this.tb_StringList_SplitChar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_StringList_SplitChar.Location = new System.Drawing.Point(3, 3);
            this.tb_StringList_SplitChar.Name = "tb_StringList_SplitChar";
            this.tb_StringList_SplitChar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_StringList_SplitChar.Size = new System.Drawing.Size(32, 27);
            this.tb_StringList_SplitChar.TabIndex = 3;
            this.tb_StringList_SplitChar.Text = "、";
            this.tb_StringList_SplitChar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tlp_StringList_Operate_AddBEChar
            // 
            this.tlp_StringList_Operate_AddBEChar.ColumnCount = 2;
            this.tlp_StringList_Operate_AddBEChar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlp_StringList_Operate_AddBEChar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.67F));
            this.tlp_StringList_Operate_AddBEChar.Controls.Add(this.tb_StringList_AddBEChar, 0, 0);
            this.tlp_StringList_Operate_AddBEChar.Controls.Add(this.btn_StringList_AddBEChar, 1, 0);
            this.tlp_StringList_Operate_AddBEChar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_StringList_Operate_AddBEChar.Location = new System.Drawing.Point(3, 41);
            this.tlp_StringList_Operate_AddBEChar.Name = "tlp_StringList_Operate_AddBEChar";
            this.tlp_StringList_Operate_AddBEChar.RowCount = 1;
            this.tlp_StringList_Operate_AddBEChar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_StringList_Operate_AddBEChar.Size = new System.Drawing.Size(114, 32);
            this.tlp_StringList_Operate_AddBEChar.TabIndex = 1;
            // 
            // tb_StringList_AddBEChar
            // 
            this.tb_StringList_AddBEChar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_StringList_AddBEChar.Location = new System.Drawing.Point(3, 3);
            this.tb_StringList_AddBEChar.Name = "tb_StringList_AddBEChar";
            this.tb_StringList_AddBEChar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_StringList_AddBEChar.Size = new System.Drawing.Size(31, 27);
            this.tb_StringList_AddBEChar.TabIndex = 4;
            this.tb_StringList_AddBEChar.Text = "\'";
            this.tb_StringList_AddBEChar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_StringList_AddBEChar
            // 
            this.btn_StringList_AddBEChar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_StringList_AddBEChar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StringList_AddBEChar.Location = new System.Drawing.Point(40, 3);
            this.btn_StringList_AddBEChar.Name = "btn_StringList_AddBEChar";
            this.btn_StringList_AddBEChar.Size = new System.Drawing.Size(71, 26);
            this.btn_StringList_AddBEChar.TabIndex = 5;
            this.btn_StringList_AddBEChar.Text = "首尾字符";
            this.btn_StringList_AddBEChar.UseVisualStyleBackColor = true;
            this.btn_StringList_AddBEChar.Click += new System.EventHandler(this.btn_StringList_AddBEChar_Click);
            // 
            // tlp_StringList_Operate_AddEndChar
            // 
            this.tlp_StringList_Operate_AddEndChar.ColumnCount = 2;
            this.tlp_StringList_Operate_AddEndChar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlp_StringList_Operate_AddEndChar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.67F));
            this.tlp_StringList_Operate_AddEndChar.Controls.Add(this.tb_StringList_AddEndChar, 0, 0);
            this.tlp_StringList_Operate_AddEndChar.Controls.Add(this.btn_StringList_AddEndChar, 1, 0);
            this.tlp_StringList_Operate_AddEndChar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_StringList_Operate_AddEndChar.Location = new System.Drawing.Point(3, 117);
            this.tlp_StringList_Operate_AddEndChar.Name = "tlp_StringList_Operate_AddEndChar";
            this.tlp_StringList_Operate_AddEndChar.RowCount = 1;
            this.tlp_StringList_Operate_AddEndChar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_StringList_Operate_AddEndChar.Size = new System.Drawing.Size(114, 32);
            this.tlp_StringList_Operate_AddEndChar.TabIndex = 2;
            // 
            // tb_StringList_AddEndChar
            // 
            this.tb_StringList_AddEndChar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_StringList_AddEndChar.Location = new System.Drawing.Point(3, 3);
            this.tb_StringList_AddEndChar.Name = "tb_StringList_AddEndChar";
            this.tb_StringList_AddEndChar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_StringList_AddEndChar.Size = new System.Drawing.Size(31, 27);
            this.tb_StringList_AddEndChar.TabIndex = 4;
            this.tb_StringList_AddEndChar.Text = ",";
            this.tb_StringList_AddEndChar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_StringList_AddEndChar
            // 
            this.btn_StringList_AddEndChar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_StringList_AddEndChar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StringList_AddEndChar.Location = new System.Drawing.Point(40, 3);
            this.btn_StringList_AddEndChar.Name = "btn_StringList_AddEndChar";
            this.btn_StringList_AddEndChar.Size = new System.Drawing.Size(71, 26);
            this.btn_StringList_AddEndChar.TabIndex = 5;
            this.btn_StringList_AddEndChar.Text = "结尾字符";
            this.btn_StringList_AddEndChar.UseVisualStyleBackColor = true;
            this.btn_StringList_AddEndChar.Click += new System.EventHandler(this.btn_StringList_AddEndChar_Click);
            // 
            // tlp_StringList_Operate_AddBeginChar
            // 
            this.tlp_StringList_Operate_AddBeginChar.ColumnCount = 2;
            this.tlp_StringList_Operate_AddBeginChar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlp_StringList_Operate_AddBeginChar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.67F));
            this.tlp_StringList_Operate_AddBeginChar.Controls.Add(this.tb_StringList_AddBeginChar, 0, 0);
            this.tlp_StringList_Operate_AddBeginChar.Controls.Add(this.btn_StringList_AddBeginChar, 1, 0);
            this.tlp_StringList_Operate_AddBeginChar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_StringList_Operate_AddBeginChar.Location = new System.Drawing.Point(3, 79);
            this.tlp_StringList_Operate_AddBeginChar.Name = "tlp_StringList_Operate_AddBeginChar";
            this.tlp_StringList_Operate_AddBeginChar.RowCount = 1;
            this.tlp_StringList_Operate_AddBeginChar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_StringList_Operate_AddBeginChar.Size = new System.Drawing.Size(114, 32);
            this.tlp_StringList_Operate_AddBeginChar.TabIndex = 3;
            // 
            // tb_StringList_AddBeginChar
            // 
            this.tb_StringList_AddBeginChar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_StringList_AddBeginChar.Location = new System.Drawing.Point(3, 3);
            this.tb_StringList_AddBeginChar.Name = "tb_StringList_AddBeginChar";
            this.tb_StringList_AddBeginChar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_StringList_AddBeginChar.Size = new System.Drawing.Size(31, 27);
            this.tb_StringList_AddBeginChar.TabIndex = 4;
            this.tb_StringList_AddBeginChar.Text = ",";
            this.tb_StringList_AddBeginChar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_StringList_AddBeginChar
            // 
            this.btn_StringList_AddBeginChar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_StringList_AddBeginChar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StringList_AddBeginChar.Location = new System.Drawing.Point(40, 3);
            this.btn_StringList_AddBeginChar.Name = "btn_StringList_AddBeginChar";
            this.btn_StringList_AddBeginChar.Size = new System.Drawing.Size(71, 26);
            this.btn_StringList_AddBeginChar.TabIndex = 5;
            this.btn_StringList_AddBeginChar.Text = "开始字符";
            this.btn_StringList_AddBeginChar.UseVisualStyleBackColor = true;
            this.btn_StringList_AddBeginChar.Click += new System.EventHandler(this.btn_StringList_AddBeginChar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.Controls.Add(this.tlp_Encrypt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(643, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(634, 394);
            this.panel2.TabIndex = 1;
            // 
            // tlp_Encrypt
            // 
            this.tlp_Encrypt.ColumnCount = 7;
            this.tlp_Encrypt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_Encrypt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tlp_Encrypt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_Encrypt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlp_Encrypt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_Encrypt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tlp_Encrypt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_Encrypt.Controls.Add(this.tb_Encrypt_Decode, 1, 5);
            this.tlp_Encrypt.Controls.Add(this.btn_Encrypt_Encode, 3, 5);
            this.tlp_Encrypt.Controls.Add(this.btn_Encrypt_Decode, 3, 7);
            this.tlp_Encrypt.Controls.Add(this.lb_Encrypt_Encode, 5, 5);
            this.tlp_Encrypt.Controls.Add(this.lb_Encrypt_Decode, 5, 7);
            this.tlp_Encrypt.Controls.Add(this.tb_Encrypt_Key_De, 5, 1);
            this.tlp_Encrypt.Controls.Add(this.tb_Encrypt_IV_De, 5, 3);
            this.tlp_Encrypt.Controls.Add(this.tb_Encrypt_Encode, 1, 7);
            this.tlp_Encrypt.Controls.Add(this.rtb_Encrypt_Source, 1, 9);
            this.tlp_Encrypt.Controls.Add(this.rtb_Encrypt_Distination, 5, 9);
            this.tlp_Encrypt.Controls.Add(this.tlp_Encrypt_PlButton, 3, 9);
            this.tlp_Encrypt.Controls.Add(this.tlp_Encrypt_Key, 1, 1);
            this.tlp_Encrypt.Controls.Add(this.tlp_Encrypt_IV, 1, 3);
            this.tlp_Encrypt.Controls.Add(this.lbl_Encrypt_Des1, 1, 0);
            this.tlp_Encrypt.Controls.Add(this.lbl_Encrypt_Des2, 5, 0);
            this.tlp_Encrypt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Encrypt.Location = new System.Drawing.Point(0, 0);
            this.tlp_Encrypt.Name = "tlp_Encrypt";
            this.tlp_Encrypt.RowCount = 11;
            this.tlp_Encrypt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlp_Encrypt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlp_Encrypt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_Encrypt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlp_Encrypt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_Encrypt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlp_Encrypt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_Encrypt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlp_Encrypt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_Encrypt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.tlp_Encrypt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_Encrypt.Size = new System.Drawing.Size(634, 394);
            this.tlp_Encrypt.TabIndex = 1;
            // 
            // tb_Encrypt_Decode
            // 
            this.tb_Encrypt_Decode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Encrypt_Decode.Location = new System.Drawing.Point(13, 124);
            this.tb_Encrypt_Decode.Name = "tb_Encrypt_Decode";
            this.tb_Encrypt_Decode.Size = new System.Drawing.Size(255, 27);
            this.tb_Encrypt_Decode.TabIndex = 1;
            // 
            // btn_Encrypt_Encode
            // 
            this.btn_Encrypt_Encode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Encrypt_Encode.Location = new System.Drawing.Point(284, 124);
            this.btn_Encrypt_Encode.Name = "btn_Encrypt_Encode";
            this.btn_Encrypt_Encode.Size = new System.Drawing.Size(65, 32);
            this.btn_Encrypt_Encode.TabIndex = 2;
            this.btn_Encrypt_Encode.Text = "加密";
            this.btn_Encrypt_Encode.UseVisualStyleBackColor = true;
            this.btn_Encrypt_Encode.Click += new System.EventHandler(this.btn_Encrypt_Encode_Click);
            // 
            // btn_Encrypt_Decode
            // 
            this.btn_Encrypt_Decode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Encrypt_Decode.Location = new System.Drawing.Point(284, 172);
            this.btn_Encrypt_Decode.Name = "btn_Encrypt_Decode";
            this.btn_Encrypt_Decode.Size = new System.Drawing.Size(65, 32);
            this.btn_Encrypt_Decode.TabIndex = 3;
            this.btn_Encrypt_Decode.Text = "解密";
            this.btn_Encrypt_Decode.UseVisualStyleBackColor = true;
            this.btn_Encrypt_Decode.Click += new System.EventHandler(this.btn_Encrypt_Decode_Click);
            // 
            // lb_Encrypt_Encode
            // 
            this.lb_Encrypt_Encode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Encrypt_Encode.Location = new System.Drawing.Point(365, 124);
            this.lb_Encrypt_Encode.Name = "lb_Encrypt_Encode";
            this.lb_Encrypt_Encode.ReadOnly = true;
            this.lb_Encrypt_Encode.Size = new System.Drawing.Size(255, 27);
            this.lb_Encrypt_Encode.TabIndex = 4;
            // 
            // lb_Encrypt_Decode
            // 
            this.lb_Encrypt_Decode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Encrypt_Decode.Location = new System.Drawing.Point(365, 172);
            this.lb_Encrypt_Decode.Name = "lb_Encrypt_Decode";
            this.lb_Encrypt_Decode.ReadOnly = true;
            this.lb_Encrypt_Decode.Size = new System.Drawing.Size(255, 27);
            this.lb_Encrypt_Decode.TabIndex = 5;
            // 
            // tb_Encrypt_Key_De
            // 
            this.tb_Encrypt_Key_De.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Encrypt_Key_De.Location = new System.Drawing.Point(365, 28);
            this.tb_Encrypt_Key_De.Name = "tb_Encrypt_Key_De";
            this.tb_Encrypt_Key_De.Size = new System.Drawing.Size(255, 27);
            this.tb_Encrypt_Key_De.TabIndex = 6;
            this.tb_Encrypt_Key_De.Text = "omc4good";
            // 
            // tb_Encrypt_IV_De
            // 
            this.tb_Encrypt_IV_De.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Encrypt_IV_De.Location = new System.Drawing.Point(365, 76);
            this.tb_Encrypt_IV_De.Name = "tb_Encrypt_IV_De";
            this.tb_Encrypt_IV_De.Size = new System.Drawing.Size(255, 27);
            this.tb_Encrypt_IV_De.TabIndex = 7;
            this.tb_Encrypt_IV_De.Text = "1s2o4f5t";
            // 
            // tb_Encrypt_Encode
            // 
            this.tb_Encrypt_Encode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Encrypt_Encode.Location = new System.Drawing.Point(13, 172);
            this.tb_Encrypt_Encode.Name = "tb_Encrypt_Encode";
            this.tb_Encrypt_Encode.Size = new System.Drawing.Size(255, 27);
            this.tb_Encrypt_Encode.TabIndex = 8;
            // 
            // rtb_Encrypt_Source
            // 
            this.rtb_Encrypt_Source.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Encrypt_Source.Location = new System.Drawing.Point(13, 220);
            this.rtb_Encrypt_Source.Name = "rtb_Encrypt_Source";
            this.rtb_Encrypt_Source.Size = new System.Drawing.Size(255, 159);
            this.rtb_Encrypt_Source.TabIndex = 9;
            this.rtb_Encrypt_Source.Text = "";
            // 
            // rtb_Encrypt_Distination
            // 
            this.rtb_Encrypt_Distination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Encrypt_Distination.Location = new System.Drawing.Point(365, 220);
            this.rtb_Encrypt_Distination.Name = "rtb_Encrypt_Distination";
            this.rtb_Encrypt_Distination.Size = new System.Drawing.Size(255, 159);
            this.rtb_Encrypt_Distination.TabIndex = 10;
            this.rtb_Encrypt_Distination.Text = "";
            // 
            // tlp_Encrypt_PlButton
            // 
            this.tlp_Encrypt_PlButton.ColumnCount = 1;
            this.tlp_Encrypt_PlButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Encrypt_PlButton.Controls.Add(this.btnMuti_EncryptDecode, 0, 3);
            this.tlp_Encrypt_PlButton.Controls.Add(this.btnMuti_EncryptEncode, 0, 1);
            this.tlp_Encrypt_PlButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Encrypt_PlButton.Location = new System.Drawing.Point(284, 220);
            this.tlp_Encrypt_PlButton.Name = "tlp_Encrypt_PlButton";
            this.tlp_Encrypt_PlButton.RowCount = 5;
            this.tlp_Encrypt_PlButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_Encrypt_PlButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_Encrypt_PlButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_Encrypt_PlButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_Encrypt_PlButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_Encrypt_PlButton.Size = new System.Drawing.Size(65, 159);
            this.tlp_Encrypt_PlButton.TabIndex = 16;
            // 
            // btnMuti_EncryptDecode
            // 
            this.btnMuti_EncryptDecode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMuti_EncryptDecode.Location = new System.Drawing.Point(3, 96);
            this.btnMuti_EncryptDecode.Name = "btnMuti_EncryptDecode";
            this.btnMuti_EncryptDecode.Size = new System.Drawing.Size(59, 25);
            this.btnMuti_EncryptDecode.TabIndex = 12;
            this.btnMuti_EncryptDecode.Text = "批量解密";
            this.btnMuti_EncryptDecode.UseVisualStyleBackColor = true;
            this.btnMuti_EncryptDecode.Click += new System.EventHandler(this.btnMuti_EncryptDecode_Click);
            // 
            // btnMuti_EncryptEncode
            // 
            this.btnMuti_EncryptEncode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMuti_EncryptEncode.Location = new System.Drawing.Point(3, 34);
            this.btnMuti_EncryptEncode.Name = "btnMuti_EncryptEncode";
            this.btnMuti_EncryptEncode.Size = new System.Drawing.Size(59, 25);
            this.btnMuti_EncryptEncode.TabIndex = 13;
            this.btnMuti_EncryptEncode.Text = "批量加密";
            this.btnMuti_EncryptEncode.UseVisualStyleBackColor = true;
            this.btnMuti_EncryptEncode.Click += new System.EventHandler(this.btnMuti_EncryptEncode_Click);
            // 
            // tlp_Encrypt_Key
            // 
            this.tlp_Encrypt_Key.ColumnCount = 2;
            this.tlp_Encrypt_Key.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.4902F));
            this.tlp_Encrypt_Key.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.5098F));
            this.tlp_Encrypt_Key.Controls.Add(this.tb_Encrypt_Key_En, 1, 0);
            this.tlp_Encrypt_Key.Controls.Add(this.lbl_Encrypt_key, 0, 0);
            this.tlp_Encrypt_Key.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Encrypt_Key.Location = new System.Drawing.Point(13, 28);
            this.tlp_Encrypt_Key.Name = "tlp_Encrypt_Key";
            this.tlp_Encrypt_Key.RowCount = 1;
            this.tlp_Encrypt_Key.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Encrypt_Key.Size = new System.Drawing.Size(255, 32);
            this.tlp_Encrypt_Key.TabIndex = 17;
            // 
            // tb_Encrypt_Key_En
            // 
            this.tb_Encrypt_Key_En.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Encrypt_Key_En.Location = new System.Drawing.Point(68, 3);
            this.tb_Encrypt_Key_En.Name = "tb_Encrypt_Key_En";
            this.tb_Encrypt_Key_En.Size = new System.Drawing.Size(184, 27);
            this.tb_Encrypt_Key_En.TabIndex = 13;
            this.tb_Encrypt_Key_En.Text = "omc4good";
            // 
            // lbl_Encrypt_key
            // 
            this.lbl_Encrypt_key.AutoSize = true;
            this.lbl_Encrypt_key.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Encrypt_key.Location = new System.Drawing.Point(3, 0);
            this.lbl_Encrypt_key.Name = "lbl_Encrypt_key";
            this.lbl_Encrypt_key.Size = new System.Drawing.Size(59, 32);
            this.lbl_Encrypt_key.TabIndex = 14;
            this.lbl_Encrypt_key.Text = "秘钥：";
            // 
            // tlp_Encrypt_IV
            // 
            this.tlp_Encrypt_IV.ColumnCount = 2;
            this.tlp_Encrypt_IV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.4902F));
            this.tlp_Encrypt_IV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.5098F));
            this.tlp_Encrypt_IV.Controls.Add(this.tb_Encrypt_IV_En, 1, 0);
            this.tlp_Encrypt_IV.Controls.Add(this.lbl_Encrypt_iv, 0, 0);
            this.tlp_Encrypt_IV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Encrypt_IV.Location = new System.Drawing.Point(13, 76);
            this.tlp_Encrypt_IV.Name = "tlp_Encrypt_IV";
            this.tlp_Encrypt_IV.RowCount = 1;
            this.tlp_Encrypt_IV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Encrypt_IV.Size = new System.Drawing.Size(255, 32);
            this.tlp_Encrypt_IV.TabIndex = 18;
            // 
            // tb_Encrypt_IV_En
            // 
            this.tb_Encrypt_IV_En.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Encrypt_IV_En.Location = new System.Drawing.Point(68, 3);
            this.tb_Encrypt_IV_En.Name = "tb_Encrypt_IV_En";
            this.tb_Encrypt_IV_En.Size = new System.Drawing.Size(184, 27);
            this.tb_Encrypt_IV_En.TabIndex = 14;
            this.tb_Encrypt_IV_En.Text = "1s2o4f5t";
            // 
            // lbl_Encrypt_iv
            // 
            this.lbl_Encrypt_iv.AutoSize = true;
            this.lbl_Encrypt_iv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Encrypt_iv.Location = new System.Drawing.Point(3, 0);
            this.lbl_Encrypt_iv.Name = "lbl_Encrypt_iv";
            this.lbl_Encrypt_iv.Size = new System.Drawing.Size(59, 32);
            this.lbl_Encrypt_iv.TabIndex = 15;
            this.lbl_Encrypt_iv.Text = "偏移：";
            // 
            // lbl_Encrypt_Des1
            // 
            this.lbl_Encrypt_Des1.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_Encrypt_Des1.Location = new System.Drawing.Point(68, 0);
            this.lbl_Encrypt_Des1.Name = "lbl_Encrypt_Des1";
            this.lbl_Encrypt_Des1.Size = new System.Drawing.Size(200, 25);
            this.lbl_Encrypt_Des1.TabIndex = 19;
            this.lbl_Encrypt_Des1.Text = "加密用（KEY IV）";
            this.lbl_Encrypt_Des1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Encrypt_Des2
            // 
            this.lbl_Encrypt_Des2.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_Encrypt_Des2.Location = new System.Drawing.Point(365, 0);
            this.lbl_Encrypt_Des2.Name = "lbl_Encrypt_Des2";
            this.lbl_Encrypt_Des2.Size = new System.Drawing.Size(200, 25);
            this.lbl_Encrypt_Des2.TabIndex = 20;
            this.lbl_Encrypt_Des2.Text = "解密用（KEY IV）";
            this.lbl_Encrypt_Des2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Lavender;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 403);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(634, 395);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightYellow;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(643, 403);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(634, 395);
            this.panel4.TabIndex = 3;
            // 
            // StringHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 801);
            this.Controls.Add(this.mainPanel);
            this.Name = "StringHelper";
            this.Text = "StringHelper";
            this.mainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tlp_StringList.ResumeLayout(false);
            this.tlp_StringList_Operate.ResumeLayout(false);
            this.tlp_StringList_Operate_SplitChar.ResumeLayout(false);
            this.tlp_StringList_Operate_SplitChar.PerformLayout();
            this.tlp_StringList_Operate_AddBEChar.ResumeLayout(false);
            this.tlp_StringList_Operate_AddBEChar.PerformLayout();
            this.tlp_StringList_Operate_AddEndChar.ResumeLayout(false);
            this.tlp_StringList_Operate_AddEndChar.PerformLayout();
            this.tlp_StringList_Operate_AddBeginChar.ResumeLayout(false);
            this.tlp_StringList_Operate_AddBeginChar.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tlp_Encrypt.ResumeLayout(false);
            this.tlp_Encrypt.PerformLayout();
            this.tlp_Encrypt_PlButton.ResumeLayout(false);
            this.tlp_Encrypt_Key.ResumeLayout(false);
            this.tlp_Encrypt_Key.PerformLayout();
            this.tlp_Encrypt_IV.ResumeLayout(false);
            this.tlp_Encrypt_IV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel mainPanel;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private TableLayoutPanel tlp_StringList;
        private RichTextBox rtb_StringList_Source;
        private RichTextBox rtb_StringList_Distination;
        private TableLayoutPanel tlp_StringList_Operate;
        private TableLayoutPanel tlp_StringList_Operate_SplitChar;
        private Button btn_StringList_SplitChar;
        private TextBox tb_StringList_SplitChar;
        private TableLayoutPanel tlp_StringList_Operate_AddBEChar;
        private TextBox tb_StringList_AddBEChar;
        private Button btn_StringList_AddBEChar;
        private TableLayoutPanel tlp_StringList_Operate_AddEndChar;
        private TextBox tb_StringList_AddEndChar;
        private Button btn_StringList_AddEndChar;
        private TableLayoutPanel tlp_StringList_Operate_AddBeginChar;
        private TextBox tb_StringList_AddBeginChar;
        private Button btn_StringList_AddBeginChar;
        private TableLayoutPanel tlp_Encrypt;
        private TextBox tb_Encrypt_Decode;
        private Button btn_Encrypt_Encode;
        private Button btn_Encrypt_Decode;
        private TextBox lb_Encrypt_Encode;
        private TextBox lb_Encrypt_Decode;
        private TextBox tb_Encrypt_Key_De;
        private TextBox tb_Encrypt_IV_De;
        private TextBox tb_Encrypt_Encode;
        private RichTextBox rtb_Encrypt_Source;
        private RichTextBox rtb_Encrypt_Distination;
        private Label lbl_Encrypt_key;
        private Label lbl_Encrypt_iv;
        private TableLayoutPanel tlp_Encrypt_PlButton;
        private Button btnMuti_EncryptDecode;
        private TableLayoutPanel tlp_Encrypt_Key;
        private TextBox tb_Encrypt_Key_En;
        private TableLayoutPanel tlp_Encrypt_IV;
        private TextBox tb_Encrypt_IV_En;
        private Button btnMuti_EncryptEncode;
        private Label lbl_Encrypt_Des1;
        private Label lbl_Encrypt_Des2;
    }
}