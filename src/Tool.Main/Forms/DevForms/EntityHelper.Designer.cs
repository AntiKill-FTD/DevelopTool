namespace Tool.Main.Forms.DevForms
{
    partial class EntityHelper
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
            this.labTableEngName = new System.Windows.Forms.Label();
            this.labColumnEngName = new System.Windows.Forms.Label();
            this.txtTableEngName = new System.Windows.Forms.TextBox();
            this.txtColumnEngName = new System.Windows.Forms.TextBox();
            this.tlpButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.tbpGrid = new System.Windows.Forms.TableLayoutPanel();
            this.rtbEntity = new System.Windows.Forms.RichTextBox();
            this.dataViewDataTable = new Tool.CusControls.DataGridViewEx.DataGridViewEx();
            this.dataViewColumn = new Tool.CusControls.DataGridViewEx.DataGridViewEx();
            this.panelSearch.SuspendLayout();
            this.tlpSearch.SuspendLayout();
            this.tlpButton.SuspendLayout();
            this.panelGrid.SuspendLayout();
            this.tbpGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.tlpSearch);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(1343, 125);
            this.panelSearch.TabIndex = 1;
            // 
            // tlpSearch
            // 
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
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpSearch.Controls.Add(this.labTableEngName, 1, 1);
            this.tlpSearch.Controls.Add(this.labColumnEngName, 4, 1);
            this.tlpSearch.Controls.Add(this.txtTableEngName, 2, 1);
            this.tlpSearch.Controls.Add(this.txtColumnEngName, 5, 1);
            this.tlpSearch.Controls.Add(this.tlpButton, 10, 2);
            this.tlpSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSearch.Location = new System.Drawing.Point(0, 0);
            this.tlpSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpSearch.Name = "tlpSearch";
            this.tlpSearch.RowCount = 4;
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpSearch.Size = new System.Drawing.Size(1343, 125);
            this.tlpSearch.TabIndex = 0;
            // 
            // labTableEngName
            // 
            this.labTableEngName.AutoSize = true;
            this.labTableEngName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labTableEngName.Location = new System.Drawing.Point(25, 12);
            this.labTableEngName.Name = "labTableEngName";
            this.labTableEngName.Size = new System.Drawing.Size(147, 50);
            this.labTableEngName.TabIndex = 0;
            this.labTableEngName.Text = "表名称：";
            this.labTableEngName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labColumnEngName
            // 
            this.labColumnEngName.AutoSize = true;
            this.labColumnEngName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labColumnEngName.Location = new System.Drawing.Point(353, 12);
            this.labColumnEngName.Name = "labColumnEngName";
            this.labColumnEngName.Size = new System.Drawing.Size(147, 50);
            this.labColumnEngName.TabIndex = 1;
            this.labColumnEngName.Text = "列名称：";
            this.labColumnEngName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTableEngName
            // 
            this.txtTableEngName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTableEngName.Location = new System.Drawing.Point(178, 16);
            this.txtTableEngName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTableEngName.Name = "txtTableEngName";
            this.txtTableEngName.Size = new System.Drawing.Size(147, 27);
            this.txtTableEngName.TabIndex = 2;
            // 
            // txtColumnEngName
            // 
            this.txtColumnEngName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtColumnEngName.Location = new System.Drawing.Point(506, 16);
            this.txtColumnEngName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtColumnEngName.Name = "txtColumnEngName";
            this.txtColumnEngName.Size = new System.Drawing.Size(147, 27);
            this.txtColumnEngName.TabIndex = 3;
            // 
            // tlpButton
            // 
            this.tlpButton.ColumnCount = 2;
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButton.Controls.Add(this.btnSearch, 0, 0);
            this.tlpButton.Controls.Add(this.btnReset, 1, 0);
            this.tlpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButton.Location = new System.Drawing.Point(1009, 66);
            this.tlpButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpButton.Name = "tlpButton";
            this.tlpButton.RowCount = 1;
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButton.Size = new System.Drawing.Size(147, 42);
            this.tlpButton.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Location = new System.Drawing.Point(3, 4);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(67, 34);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.Search_Click);
            // 
            // btnReset
            // 
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReset.Location = new System.Drawing.Point(76, 4);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(68, 34);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.tbpGrid);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(0, 125);
            this.panelGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(1343, 736);
            this.panelGrid.TabIndex = 2;
            // 
            // tbpGrid
            // 
            this.tbpGrid.ColumnCount = 3;
            this.tbpGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbpGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tbpGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tbpGrid.Controls.Add(this.rtbEntity, 2, 0);
            this.tbpGrid.Controls.Add(this.dataViewDataTable, 0, 0);
            this.tbpGrid.Controls.Add(this.dataViewColumn, 1, 0);
            this.tbpGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpGrid.Location = new System.Drawing.Point(0, 0);
            this.tbpGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbpGrid.Name = "tbpGrid";
            this.tbpGrid.RowCount = 1;
            this.tbpGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbpGrid.Size = new System.Drawing.Size(1343, 736);
            this.tbpGrid.TabIndex = 0;
            // 
            // rtbEntity
            // 
            this.rtbEntity.BackColor = System.Drawing.Color.AliceBlue;
            this.rtbEntity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbEntity.Location = new System.Drawing.Point(808, 4);
            this.rtbEntity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbEntity.Name = "rtbEntity";
            this.rtbEntity.ReadOnly = true;
            this.rtbEntity.Size = new System.Drawing.Size(532, 728);
            this.rtbEntity.TabIndex = 3;
            this.rtbEntity.Text = "";
            // 
            // dataViewDataTable
            // 
            this.dataViewDataTable.DataSourceSql = null;
            this.dataViewDataTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataViewDataTable.DvDataTable = null;
            this.dataViewDataTable.IsPage = true;
            this.dataViewDataTable.IsShowFirstCheckBox = false;
            this.dataViewDataTable.Location = new System.Drawing.Point(3, 5);
            this.dataViewDataTable.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dataViewDataTable.Name = "dataViewDataTable";
            this.dataViewDataTable.RowEdit = false;
            this.dataViewDataTable.Size = new System.Drawing.Size(262, 726);
            this.dataViewDataTable.TabIndex = 4;
            // 
            // dataViewColumn
            // 
            this.dataViewColumn.DataSourceSql = null;
            this.dataViewColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataViewColumn.DvDataTable = null;
            this.dataViewColumn.IsPage = true;
            this.dataViewColumn.IsShowFirstCheckBox = false;
            this.dataViewColumn.Location = new System.Drawing.Point(271, 5);
            this.dataViewColumn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dataViewColumn.Name = "dataViewColumn";
            this.dataViewColumn.RowEdit = false;
            this.dataViewColumn.Size = new System.Drawing.Size(531, 726);
            this.dataViewColumn.TabIndex = 5;
            // 
            // EntityHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 861);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelSearch);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EntityHelper";
            this.Text = "EntityHelper";
            this.Load += new System.EventHandler(this.EntityHelper_Load);
            this.panelSearch.ResumeLayout(false);
            this.tlpSearch.ResumeLayout(false);
            this.tlpSearch.PerformLayout();
            this.tlpButton.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            this.tbpGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TableLayoutPanel tlpSearch;
        private System.Windows.Forms.Label labTableEngName;
        private System.Windows.Forms.TextBox txtTableEngName;
        private System.Windows.Forms.TextBox txtColumnEngName;
        private System.Windows.Forms.TableLayoutPanel tlpButton;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.TableLayoutPanel tbpGrid;
        private System.Windows.Forms.RichTextBox rtbEntity;
        private System.Windows.Forms.Label labColumnEngName;
        private CusControls.DataGridViewEx.DataGridViewEx dataViewDataTable;
        private CusControls.DataGridViewEx.DataGridViewEx dataViewColumn;
    }
}