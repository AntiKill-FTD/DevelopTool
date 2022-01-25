namespace Tool.Main.Forms.MainForms
{
    partial class MenuSet
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
            this.panelSearch = new System.Windows.Forms.Panel();
            this.tlpSearch = new System.Windows.Forms.TableLayoutPanel();
            this.labMenuCode = new System.Windows.Forms.Label();
            this.labMenuName = new System.Windows.Forms.Label();
            this.txtMenuCode = new System.Windows.Forms.TextBox();
            this.txtMenuName = new System.Windows.Forms.TextBox();
            this.tlpButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dataViewMain = new Tool.CusControls.DataGridViewEx.DataGridViewEx();
            this.panelSearch.SuspendLayout();
            this.tlpSearch.SuspendLayout();
            this.tlpButton.SuspendLayout();
            this.panelGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.tlpSearch);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(1394, 125);
            this.panelSearch.TabIndex = 0;
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
            this.tlpSearch.Controls.Add(this.tlpButton, 10, 2);
            this.tlpSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSearch.Location = new System.Drawing.Point(0, 0);
            this.tlpSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpSearch.Name = "tlpSearch";
            this.tlpSearch.RowCount = 4;
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.2F));
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.8F));
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpSearch.Size = new System.Drawing.Size(1394, 125);
            this.tlpSearch.TabIndex = 0;
            // 
            // labMenuCode
            // 
            this.labMenuCode.AutoSize = true;
            this.labMenuCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labMenuCode.Location = new System.Drawing.Point(25, 12);
            this.labMenuCode.Name = "labMenuCode";
            this.labMenuCode.Size = new System.Drawing.Size(154, 49);
            this.labMenuCode.TabIndex = 0;
            this.labMenuCode.Text = "菜单编码：";
            this.labMenuCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labMenuName
            // 
            this.labMenuName.AutoSize = true;
            this.labMenuName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labMenuName.Location = new System.Drawing.Point(367, 12);
            this.labMenuName.Name = "labMenuName";
            this.labMenuName.Size = new System.Drawing.Size(154, 49);
            this.labMenuName.TabIndex = 1;
            this.labMenuName.Text = "菜单名称：";
            this.labMenuName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMenuCode
            // 
            this.txtMenuCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMenuCode.Location = new System.Drawing.Point(185, 16);
            this.txtMenuCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMenuCode.Name = "txtMenuCode";
            this.txtMenuCode.Size = new System.Drawing.Size(154, 27);
            this.txtMenuCode.TabIndex = 2;
            // 
            // txtMenuName
            // 
            this.txtMenuName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMenuName.Location = new System.Drawing.Point(527, 16);
            this.txtMenuName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMenuName.Name = "txtMenuName";
            this.txtMenuName.Size = new System.Drawing.Size(154, 27);
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
            this.tlpButton.Location = new System.Drawing.Point(1051, 65);
            this.tlpButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpButton.Name = "tlpButton";
            this.tlpButton.RowCount = 1;
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButton.Size = new System.Drawing.Size(154, 43);
            this.tlpButton.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Location = new System.Drawing.Point(3, 4);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(71, 35);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.Search_Click);
            // 
            // btnReset
            // 
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReset.Location = new System.Drawing.Point(80, 4);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(71, 35);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.dataViewMain);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(0, 125);
            this.panelGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(1394, 718);
            this.panelGrid.TabIndex = 1;
            // 
            // dataViewMain
            // 
            this.dataViewMain.DataHelper = null;
            this.dataViewMain.DataSourceSql = null;
            this.dataViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataViewMain.DvDataTable = null;
            this.dataViewMain.DvSelectionMode = System.Windows.Forms.DataGridViewSelectionMode.RowHeaderSelect;
            this.dataViewMain.IsPage = true;
            this.dataViewMain.IsShowFirstCheckBox = false;
            this.dataViewMain.Location = new System.Drawing.Point(0, 0);
            this.dataViewMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataViewMain.Name = "dataViewMain";
            this.dataViewMain.RowEdit = false;
            this.dataViewMain.Size = new System.Drawing.Size(1394, 718);
            this.dataViewMain.TabIndex = 0;
            // 
            // MenuSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 843);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelSearch);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MenuSet";
            this.Text = "MenuSet";
            this.Load += new System.EventHandler(this.MenuSet_Load);
            this.panelSearch.ResumeLayout(false);
            this.tlpSearch.ResumeLayout(false);
            this.tlpSearch.PerformLayout();
            this.tlpButton.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.TableLayoutPanel tlpSearch;
        private System.Windows.Forms.Label labMenuCode;
        private System.Windows.Forms.Label labMenuName;
        private System.Windows.Forms.TextBox txtMenuCode;
        private System.Windows.Forms.TextBox txtMenuName;
        private System.Windows.Forms.TableLayoutPanel tlpButton;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private CusControls.DataGridViewEx.DataGridViewEx dataViewMain;
    }
}