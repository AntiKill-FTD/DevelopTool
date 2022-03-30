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
            this.labMenuCode = new System.Windows.Forms.Label();
            this.labMenuName = new System.Windows.Forms.Label();
            this.txtMenuCode = new System.Windows.Forms.TextBox();
            this.txtMenuName = new System.Windows.Forms.TextBox();
            this.tlpButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dataViewMain = new Tool.CusControls.DataGridViewEx.DataGridViewEx();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSearch = new System.Windows.Forms.TableLayoutPanel();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.tlpButton.SuspendLayout();
            this.panelGrid.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tlpSearch.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // labMenuCode
            // 
            this.labMenuCode.AutoSize = true;
            this.labMenuCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labMenuCode.Location = new System.Drawing.Point(25, 12);
            this.labMenuCode.Name = "labMenuCode";
            this.labMenuCode.Size = new System.Drawing.Size(151, 49);
            this.labMenuCode.TabIndex = 0;
            this.labMenuCode.Text = "配置大类：";
            this.labMenuCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labMenuName
            // 
            this.labMenuName.AutoSize = true;
            this.labMenuName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labMenuName.Location = new System.Drawing.Point(361, 12);
            this.labMenuName.Name = "labMenuName";
            this.labMenuName.Size = new System.Drawing.Size(151, 49);
            this.labMenuName.TabIndex = 1;
            this.labMenuName.Text = "配置小类：";
            this.labMenuName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMenuCode
            // 
            this.txtMenuCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMenuCode.Location = new System.Drawing.Point(182, 16);
            this.txtMenuCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMenuCode.Name = "txtMenuCode";
            this.txtMenuCode.Size = new System.Drawing.Size(151, 27);
            this.txtMenuCode.TabIndex = 2;
            // 
            // txtMenuName
            // 
            this.txtMenuName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMenuName.Location = new System.Drawing.Point(518, 16);
            this.txtMenuName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMenuName.Name = "txtMenuName";
            this.txtMenuName.Size = new System.Drawing.Size(151, 27);
            this.txtMenuName.TabIndex = 3;
            // 
            // tlpButton
            // 
            this.tlpButton.ColumnCount = 2;
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButton.Controls.Add(this.btnSearch, 0, 0);
            this.tlpButton.Controls.Add(this.btnReset, 1, 0);
            this.tlpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButton.Location = new System.Drawing.Point(854, 65);
            this.tlpButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpButton.Name = "tlpButton";
            this.tlpButton.RowCount = 1;
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButton.Size = new System.Drawing.Size(151, 43);
            this.tlpButton.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Location = new System.Drawing.Point(3, 4);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(69, 35);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReset.Location = new System.Drawing.Point(78, 4);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(70, 35);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.dataViewMain);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(0, 125);
            this.panelGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(1376, 646);
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
            this.dataViewMain.Size = new System.Drawing.Size(1376, 646);
            this.dataViewMain.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Location = new System.Drawing.Point(3, 4);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(69, 35);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnEdit, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1033, 65);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(151, 43);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.Location = new System.Drawing.Point(78, 4);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(70, 35);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "编辑";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Location = new System.Drawing.Point(3, 4);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(69, 35);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnDelete, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1190, 65);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(151, 43);
            this.tableLayoutPanel2.TabIndex = 7;
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
            this.tlpSearch.Controls.Add(this.labMenuCode, 1, 1);
            this.tlpSearch.Controls.Add(this.labMenuName, 4, 1);
            this.tlpSearch.Controls.Add(this.txtMenuCode, 2, 1);
            this.tlpSearch.Controls.Add(this.txtMenuName, 5, 1);
            this.tlpSearch.Controls.Add(this.tlpButton, 8, 2);
            this.tlpSearch.Controls.Add(this.tableLayoutPanel1, 10, 2);
            this.tlpSearch.Controls.Add(this.tableLayoutPanel2, 11, 2);
            this.tlpSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSearch.Location = new System.Drawing.Point(0, 0);
            this.tlpSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpSearch.Name = "tlpSearch";
            this.tlpSearch.RowCount = 4;
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.2F));
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.8F));
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpSearch.Size = new System.Drawing.Size(1376, 125);
            this.tlpSearch.TabIndex = 0;
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.tlpSearch);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(1376, 125);
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
            this.tlpButton.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tlpSearch.ResumeLayout(false);
            this.tlpSearch.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Label labMenuCode;
        private Label labMenuName;
        private TextBox txtMenuCode;
        private TextBox txtMenuName;
        private TableLayoutPanel tlpButton;
        private Button btnSearch;
        private Button btnReset;
        private Panel panelGrid;
        private CusControls.DataGridViewEx.DataGridViewEx dataViewMain;
        private Button btnDelete;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnEdit;
        private Button btnAdd;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tlpSearch;
        private Panel panelSearch;
    }
}