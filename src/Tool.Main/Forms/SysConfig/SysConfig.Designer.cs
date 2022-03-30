namespace Tool.Main.Forms.SysConfig
{
    partial class SysConfig
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
            this.lbl_Level1Code = new System.Windows.Forms.Label();
            this.lbl_Level1Name = new System.Windows.Forms.Label();
            this.tlpButton1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dataViewMain = new Tool.CusControls.DataGridViewEx.DataGridViewEx();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tlpButton2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tlpButton3 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSearch = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Level2Code = new System.Windows.Forms.Label();
            this.lbl_Level2Name = new System.Windows.Forms.Label();
            this.lbl_Level3Code = new System.Windows.Forms.Label();
            this.lbl_Level3Name = new System.Windows.Forms.Label();
            this.lbl_Level4Code = new System.Windows.Forms.Label();
            this.lbl_Level4Name = new System.Windows.Forms.Label();
            this.lbl_Level5Code = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_Level1Code = new System.Windows.Forms.ComboBox();
            this.cb_Level2Code = new System.Windows.Forms.ComboBox();
            this.cb_Level3Code = new System.Windows.Forms.ComboBox();
            this.cb_Level4Code = new System.Windows.Forms.ComboBox();
            this.cb_Level5Code = new System.Windows.Forms.ComboBox();
            this.tb_Level1Name = new System.Windows.Forms.TextBox();
            this.tb_Level3Name = new System.Windows.Forms.TextBox();
            this.tb_Level5Name = new System.Windows.Forms.TextBox();
            this.tb_Level2Name = new System.Windows.Forms.TextBox();
            this.tb_Level4Name = new System.Windows.Forms.TextBox();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.tlpButton1.SuspendLayout();
            this.panelGrid.SuspendLayout();
            this.tlpButton2.SuspendLayout();
            this.tlpButton3.SuspendLayout();
            this.tlpSearch.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Level1Code
            // 
            this.lbl_Level1Code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Level1Code.Location = new System.Drawing.Point(25, 3);
            this.lbl_Level1Code.Name = "lbl_Level1Code";
            this.lbl_Level1Code.Size = new System.Drawing.Size(151, 41);
            this.lbl_Level1Code.TabIndex = 0;
            this.lbl_Level1Code.Text = "一级编码：";
            this.lbl_Level1Code.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Level1Name
            // 
            this.lbl_Level1Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Level1Name.Location = new System.Drawing.Point(361, 3);
            this.lbl_Level1Name.Name = "lbl_Level1Name";
            this.lbl_Level1Name.Size = new System.Drawing.Size(151, 41);
            this.lbl_Level1Name.TabIndex = 1;
            this.lbl_Level1Name.Text = "一级名称：";
            this.lbl_Level1Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpButton1
            // 
            this.tlpButton1.ColumnCount = 2;
            this.tlpButton1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButton1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButton1.Controls.Add(this.btnSearch, 0, 0);
            this.tlpButton1.Controls.Add(this.btnReset, 1, 0);
            this.tlpButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButton1.Location = new System.Drawing.Point(851, 126);
            this.tlpButton1.Margin = new System.Windows.Forms.Padding(0);
            this.tlpButton1.Name = "tlpButton1";
            this.tlpButton1.RowCount = 1;
            this.tlpButton1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButton1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButton1.Size = new System.Drawing.Size(157, 41);
            this.tlpButton1.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Location = new System.Drawing.Point(3, 4);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 33);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReset.Location = new System.Drawing.Point(81, 4);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(73, 33);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.dataViewMain);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(0, 172);
            this.panelGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(1376, 599);
            this.panelGrid.TabIndex = 3;
            // 
            // dataViewMain
            // 
            this.dataViewMain.DataHelper = null;
            this.dataViewMain.DataSourceSql = null;
            this.dataViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataViewMain.DvDataTable = null;
            this.dataViewMain.DvSelectionMode = System.Windows.Forms.DataGridViewSelectionMode.RowHeaderSelect;
            this.dataViewMain.IsPage = true;
            this.dataViewMain.IsShowFirstCheckBox = true;
            this.dataViewMain.IsSort = false;
            this.dataViewMain.Location = new System.Drawing.Point(0, 0);
            this.dataViewMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataViewMain.Name = "dataViewMain";
            this.dataViewMain.RowEdit = false;
            this.dataViewMain.Size = new System.Drawing.Size(1376, 599);
            this.dataViewMain.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Location = new System.Drawing.Point(3, 4);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 33);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tlpButton2
            // 
            this.tlpButton2.ColumnCount = 2;
            this.tlpButton2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButton2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButton2.Controls.Add(this.btnEdit, 0, 0);
            this.tlpButton2.Controls.Add(this.btnAdd, 0, 0);
            this.tlpButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButton2.Location = new System.Drawing.Point(1030, 126);
            this.tlpButton2.Margin = new System.Windows.Forms.Padding(0);
            this.tlpButton2.Name = "tlpButton2";
            this.tlpButton2.RowCount = 1;
            this.tlpButton2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButton2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButton2.Size = new System.Drawing.Size(157, 41);
            this.tlpButton2.TabIndex = 6;
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.Location = new System.Drawing.Point(81, 4);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(73, 33);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "编辑";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Location = new System.Drawing.Point(3, 4);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 33);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tlpButton3
            // 
            this.tlpButton3.ColumnCount = 2;
            this.tlpButton3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButton3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButton3.Controls.Add(this.btnDelete, 0, 0);
            this.tlpButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButton3.Location = new System.Drawing.Point(1187, 126);
            this.tlpButton3.Margin = new System.Windows.Forms.Padding(0);
            this.tlpButton3.Name = "tlpButton3";
            this.tlpButton3.RowCount = 1;
            this.tlpButton3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButton3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButton3.Size = new System.Drawing.Size(157, 41);
            this.tlpButton3.TabIndex = 7;
            // 
            // tlpSearch
            // 
            this.tlpSearch.BackColor = System.Drawing.Color.Azure;
            this.tlpSearch.ColumnCount = 13;
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpSearch.Controls.Add(this.lbl_Level1Code, 1, 1);
            this.tlpSearch.Controls.Add(this.lbl_Level1Name, 4, 1);
            this.tlpSearch.Controls.Add(this.lbl_Level2Code, 7, 1);
            this.tlpSearch.Controls.Add(this.lbl_Level2Name, 10, 1);
            this.tlpSearch.Controls.Add(this.lbl_Level3Code, 1, 2);
            this.tlpSearch.Controls.Add(this.lbl_Level3Name, 4, 2);
            this.tlpSearch.Controls.Add(this.lbl_Level4Code, 7, 2);
            this.tlpSearch.Controls.Add(this.tlpButton1, 8, 4);
            this.tlpSearch.Controls.Add(this.tlpButton2, 10, 4);
            this.tlpSearch.Controls.Add(this.tlpButton3, 11, 4);
            this.tlpSearch.Controls.Add(this.lbl_Level4Name, 10, 2);
            this.tlpSearch.Controls.Add(this.lbl_Level5Code, 1, 3);
            this.tlpSearch.Controls.Add(this.label8, 4, 3);
            this.tlpSearch.Controls.Add(this.cb_Level1Code, 2, 1);
            this.tlpSearch.Controls.Add(this.cb_Level2Code, 8, 1);
            this.tlpSearch.Controls.Add(this.cb_Level3Code, 2, 2);
            this.tlpSearch.Controls.Add(this.cb_Level4Code, 8, 2);
            this.tlpSearch.Controls.Add(this.cb_Level5Code, 2, 3);
            this.tlpSearch.Controls.Add(this.tb_Level1Name, 5, 1);
            this.tlpSearch.Controls.Add(this.tb_Level3Name, 5, 2);
            this.tlpSearch.Controls.Add(this.tb_Level5Name, 5, 3);
            this.tlpSearch.Controls.Add(this.tb_Level2Name, 11, 1);
            this.tlpSearch.Controls.Add(this.tb_Level4Name, 11, 2);
            this.tlpSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSearch.Location = new System.Drawing.Point(0, 0);
            this.tlpSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpSearch.Name = "tlpSearch";
            this.tlpSearch.RowCount = 6;
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tlpSearch.Size = new System.Drawing.Size(1376, 172);
            this.tlpSearch.TabIndex = 0;
            // 
            // lbl_Level2Code
            // 
            this.lbl_Level2Code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Level2Code.Location = new System.Drawing.Point(697, 3);
            this.lbl_Level2Code.Name = "lbl_Level2Code";
            this.lbl_Level2Code.Size = new System.Drawing.Size(151, 41);
            this.lbl_Level2Code.TabIndex = 8;
            this.lbl_Level2Code.Text = "二级编码：";
            this.lbl_Level2Code.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Level2Name
            // 
            this.lbl_Level2Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Level2Name.Location = new System.Drawing.Point(1033, 3);
            this.lbl_Level2Name.Name = "lbl_Level2Name";
            this.lbl_Level2Name.Size = new System.Drawing.Size(151, 41);
            this.lbl_Level2Name.TabIndex = 9;
            this.lbl_Level2Name.Text = "二级名称：";
            this.lbl_Level2Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Level3Code
            // 
            this.lbl_Level3Code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Level3Code.Location = new System.Drawing.Point(25, 44);
            this.lbl_Level3Code.Name = "lbl_Level3Code";
            this.lbl_Level3Code.Size = new System.Drawing.Size(151, 41);
            this.lbl_Level3Code.TabIndex = 10;
            this.lbl_Level3Code.Text = "三级编码：";
            this.lbl_Level3Code.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Level3Name
            // 
            this.lbl_Level3Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Level3Name.Location = new System.Drawing.Point(361, 44);
            this.lbl_Level3Name.Name = "lbl_Level3Name";
            this.lbl_Level3Name.Size = new System.Drawing.Size(151, 41);
            this.lbl_Level3Name.TabIndex = 10;
            this.lbl_Level3Name.Text = "三级名称：";
            this.lbl_Level3Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Level4Code
            // 
            this.lbl_Level4Code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Level4Code.Location = new System.Drawing.Point(697, 44);
            this.lbl_Level4Code.Name = "lbl_Level4Code";
            this.lbl_Level4Code.Size = new System.Drawing.Size(151, 41);
            this.lbl_Level4Code.TabIndex = 10;
            this.lbl_Level4Code.Text = "四级编码：";
            this.lbl_Level4Code.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Level4Name
            // 
            this.lbl_Level4Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Level4Name.Location = new System.Drawing.Point(1033, 44);
            this.lbl_Level4Name.Name = "lbl_Level4Name";
            this.lbl_Level4Name.Size = new System.Drawing.Size(151, 41);
            this.lbl_Level4Name.TabIndex = 10;
            this.lbl_Level4Name.Text = "四级名称：";
            this.lbl_Level4Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Level5Code
            // 
            this.lbl_Level5Code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Level5Code.Location = new System.Drawing.Point(25, 85);
            this.lbl_Level5Code.Name = "lbl_Level5Code";
            this.lbl_Level5Code.Size = new System.Drawing.Size(151, 41);
            this.lbl_Level5Code.TabIndex = 10;
            this.lbl_Level5Code.Text = "五级编码：";
            this.lbl_Level5Code.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(361, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 41);
            this.label8.TabIndex = 10;
            this.label8.Text = "五级名称：";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_Level1Code
            // 
            this.cb_Level1Code.DisplayMember = "Text";
            this.cb_Level1Code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_Level1Code.FormattingEnabled = true;
            this.cb_Level1Code.Location = new System.Drawing.Point(182, 6);
            this.cb_Level1Code.Name = "cb_Level1Code";
            this.cb_Level1Code.Size = new System.Drawing.Size(151, 28);
            this.cb_Level1Code.TabIndex = 11;
            this.cb_Level1Code.ValueMember = "Value";
            this.cb_Level1Code.TextChanged += new System.EventHandler(this.cb_Level1Code_TextChanged);
            // 
            // cb_Level2Code
            // 
            this.cb_Level2Code.DisplayMember = "Text";
            this.cb_Level2Code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_Level2Code.FormattingEnabled = true;
            this.cb_Level2Code.Location = new System.Drawing.Point(854, 6);
            this.cb_Level2Code.Name = "cb_Level2Code";
            this.cb_Level2Code.Size = new System.Drawing.Size(151, 28);
            this.cb_Level2Code.TabIndex = 11;
            this.cb_Level2Code.ValueMember = "Value";
            this.cb_Level2Code.TextChanged += new System.EventHandler(this.cb_Level2Code_TextChanged);
            // 
            // cb_Level3Code
            // 
            this.cb_Level3Code.DisplayMember = "Text";
            this.cb_Level3Code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_Level3Code.FormattingEnabled = true;
            this.cb_Level3Code.Location = new System.Drawing.Point(182, 47);
            this.cb_Level3Code.Name = "cb_Level3Code";
            this.cb_Level3Code.Size = new System.Drawing.Size(151, 28);
            this.cb_Level3Code.TabIndex = 11;
            this.cb_Level3Code.ValueMember = "Value";
            this.cb_Level3Code.TextChanged += new System.EventHandler(this.cb_Level3Code_TextChanged);
            // 
            // cb_Level4Code
            // 
            this.cb_Level4Code.DisplayMember = "Text";
            this.cb_Level4Code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_Level4Code.FormattingEnabled = true;
            this.cb_Level4Code.Location = new System.Drawing.Point(854, 47);
            this.cb_Level4Code.Name = "cb_Level4Code";
            this.cb_Level4Code.Size = new System.Drawing.Size(151, 28);
            this.cb_Level4Code.TabIndex = 11;
            this.cb_Level4Code.ValueMember = "Value";
            this.cb_Level4Code.TextChanged += new System.EventHandler(this.cb_Level4Code_TextChanged);
            // 
            // cb_Level5Code
            // 
            this.cb_Level5Code.DisplayMember = "Text";
            this.cb_Level5Code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_Level5Code.FormattingEnabled = true;
            this.cb_Level5Code.Location = new System.Drawing.Point(182, 88);
            this.cb_Level5Code.Name = "cb_Level5Code";
            this.cb_Level5Code.Size = new System.Drawing.Size(151, 28);
            this.cb_Level5Code.TabIndex = 11;
            this.cb_Level5Code.ValueMember = "Value";
            this.cb_Level5Code.TextChanged += new System.EventHandler(this.cb_Level5Code_TextChanged);
            // 
            // tb_Level1Name
            // 
            this.tb_Level1Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Level1Name.Location = new System.Drawing.Point(518, 6);
            this.tb_Level1Name.Name = "tb_Level1Name";
            this.tb_Level1Name.Size = new System.Drawing.Size(151, 27);
            this.tb_Level1Name.TabIndex = 12;
            // 
            // tb_Level3Name
            // 
            this.tb_Level3Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Level3Name.Location = new System.Drawing.Point(518, 47);
            this.tb_Level3Name.Name = "tb_Level3Name";
            this.tb_Level3Name.Size = new System.Drawing.Size(151, 27);
            this.tb_Level3Name.TabIndex = 12;
            // 
            // tb_Level5Name
            // 
            this.tb_Level5Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Level5Name.Location = new System.Drawing.Point(518, 88);
            this.tb_Level5Name.Name = "tb_Level5Name";
            this.tb_Level5Name.Size = new System.Drawing.Size(151, 27);
            this.tb_Level5Name.TabIndex = 12;
            // 
            // tb_Level2Name
            // 
            this.tb_Level2Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Level2Name.Location = new System.Drawing.Point(1190, 6);
            this.tb_Level2Name.Name = "tb_Level2Name";
            this.tb_Level2Name.Size = new System.Drawing.Size(151, 27);
            this.tb_Level2Name.TabIndex = 12;
            // 
            // tb_Level4Name
            // 
            this.tb_Level4Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Level4Name.Location = new System.Drawing.Point(1190, 47);
            this.tb_Level4Name.Name = "tb_Level4Name";
            this.tb_Level4Name.Size = new System.Drawing.Size(151, 27);
            this.tb_Level4Name.TabIndex = 12;
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.tlpSearch);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(1376, 172);
            this.panelSearch.TabIndex = 2;
            // 
            // SysConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 771);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelSearch);
            this.Name = "SysConfig";
            this.Text = "SysConfig";
            this.Load += new System.EventHandler(this.SysConfig_Load);
            this.tlpButton1.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            this.tlpButton2.ResumeLayout(false);
            this.tlpButton3.ResumeLayout(false);
            this.tlpSearch.ResumeLayout(false);
            this.tlpSearch.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Label lbl_Level1Code;
        private Label lbl_Level1Name;
        private TableLayoutPanel tlpButton1;
        private Button btnSearch;
        private Button btnReset;
        private Panel panelGrid;
        private Button btnDelete;
        private TableLayoutPanel tlpButton2;
        private Button btnEdit;
        private Button btnAdd;
        private TableLayoutPanel tlpButton3;
        private TableLayoutPanel tlpSearch;
        private Panel panelSearch;
        private CusControls.DataGridViewEx.DataGridViewEx dataViewMain;
        private Label lbl_Level2Code;
        private Label lbl_Level2Name;
        private Label lbl_Level3Code;
        private Label lbl_Level3Name;
        private Label lbl_Level4Code;
        private Label lbl_Level4Name;
        private Label lbl_Level5Code;
        private Label label8;
        private ComboBox cb_Level1Code;
        private ComboBox cb_Level2Code;
        private ComboBox cb_Level3Code;
        private ComboBox cb_Level4Code;
        private ComboBox cb_Level5Code;
        private TextBox tb_Level1Name;
        private TextBox tb_Level3Name;
        private TextBox tb_Level5Name;
        private TextBox tb_Level2Name;
        private TextBox tb_Level4Name;
    }
}