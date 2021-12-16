namespace Tool.Main.Forms.DevForms
{
    partial class SqlHelper
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelGridMain = new System.Windows.Forms.Panel();
            this.panelScript = new System.Windows.Forms.Panel();
            this.rtbScript = new System.Windows.Forms.RichTextBox();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dvEX = new Tool.CusControls.DataGridViewEx.DataGridViewEx();
            this.panelTableMain = new System.Windows.Forms.Panel();
            this.tlpTable = new System.Windows.Forms.TableLayoutPanel();
            this.lbTChn = new System.Windows.Forms.Label();
            this.lbTEng = new System.Windows.Forms.Label();
            this.tbTChn = new System.Windows.Forms.TextBox();
            this.tbTEng = new System.Windows.Forms.TextBox();
            this.panelButtonMain = new System.Windows.Forms.Panel();
            this.tlpButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBuild = new System.Windows.Forms.Button();
            this.btnDelRow = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.panelGridMain.SuspendLayout();
            this.panelScript.SuspendLayout();
            this.panelGrid.SuspendLayout();
            this.panelTableMain.SuspendLayout();
            this.tlpTable.SuspendLayout();
            this.panelButtonMain.SuspendLayout();
            this.tlpButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelGridMain);
            this.panelMain.Controls.Add(this.panelTableMain);
            this.panelMain.Controls.Add(this.panelButtonMain);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1343, 861);
            this.panelMain.TabIndex = 0;
            // 
            // panelGridMain
            // 
            this.panelGridMain.Controls.Add(this.panelScript);
            this.panelGridMain.Controls.Add(this.panelGrid);
            this.panelGridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGridMain.Location = new System.Drawing.Point(0, 45);
            this.panelGridMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelGridMain.Name = "panelGridMain";
            this.panelGridMain.Size = new System.Drawing.Size(1343, 771);
            this.panelGridMain.TabIndex = 4;
            // 
            // panelScript
            // 
            this.panelScript.Controls.Add(this.rtbScript);
            this.panelScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelScript.Location = new System.Drawing.Point(0, 419);
            this.panelScript.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelScript.Name = "panelScript";
            this.panelScript.Size = new System.Drawing.Size(1343, 352);
            this.panelScript.TabIndex = 1;
            // 
            // rtbScript
            // 
            this.rtbScript.BackColor = System.Drawing.Color.AliceBlue;
            this.rtbScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbScript.Location = new System.Drawing.Point(0, 0);
            this.rtbScript.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbScript.Name = "rtbScript";
            this.rtbScript.ReadOnly = true;
            this.rtbScript.Size = new System.Drawing.Size(1343, 352);
            this.rtbScript.TabIndex = 0;
            this.rtbScript.Text = "";
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.dvEX);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGrid.Location = new System.Drawing.Point(0, 0);
            this.panelGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(1343, 419);
            this.panelGrid.TabIndex = 0;
            // 
            // dvEX
            // 
            this.dvEX.DataSourceSql = null;
            this.dvEX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvEX.DvDataTable = null;
            this.dvEX.IsPage = true;
            this.dvEX.IsShowFirstCheckBox = false;
            this.dvEX.Location = new System.Drawing.Point(0, 0);
            this.dvEX.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dvEX.Name = "dvEX";
            this.dvEX.RowEdit = false;
            this.dvEX.Size = new System.Drawing.Size(1343, 419);
            this.dvEX.TabIndex = 0;
            // 
            // panelTableMain
            // 
            this.panelTableMain.Controls.Add(this.tlpTable);
            this.panelTableMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTableMain.Location = new System.Drawing.Point(0, 0);
            this.panelTableMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTableMain.Name = "panelTableMain";
            this.panelTableMain.Size = new System.Drawing.Size(1343, 45);
            this.panelTableMain.TabIndex = 3;
            // 
            // tlpTable
            // 
            this.tlpTable.BackColor = System.Drawing.Color.Azure;
            this.tlpTable.ColumnCount = 6;
            this.tlpTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.tlpTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.tlpTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTable.Controls.Add(this.lbTChn, 1, 0);
            this.tlpTable.Controls.Add(this.lbTEng, 3, 0);
            this.tlpTable.Controls.Add(this.tbTChn, 2, 0);
            this.tlpTable.Controls.Add(this.tbTEng, 4, 0);
            this.tlpTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTable.Location = new System.Drawing.Point(0, 0);
            this.tlpTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpTable.Name = "tlpTable";
            this.tlpTable.RowCount = 1;
            this.tlpTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTable.Size = new System.Drawing.Size(1343, 45);
            this.tlpTable.TabIndex = 0;
            // 
            // lbTChn
            // 
            this.lbTChn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTChn.Location = new System.Drawing.Point(359, 0);
            this.lbTChn.Name = "lbTChn";
            this.lbTChn.Size = new System.Drawing.Size(84, 45);
            this.lbTChn.TabIndex = 0;
            this.lbTChn.Text = "表中文：";
            this.lbTChn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTEng
            // 
            this.lbTEng.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTEng.Location = new System.Drawing.Point(674, 0);
            this.lbTEng.Name = "lbTEng";
            this.lbTEng.Size = new System.Drawing.Size(84, 45);
            this.lbTEng.TabIndex = 1;
            this.lbTEng.Text = "表英文：";
            this.lbTEng.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbTChn
            // 
            this.tbTChn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTChn.Location = new System.Drawing.Point(449, 4);
            this.tbTChn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTChn.Name = "tbTChn";
            this.tbTChn.Size = new System.Drawing.Size(219, 27);
            this.tbTChn.TabIndex = 2;
            // 
            // tbTEng
            // 
            this.tbTEng.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTEng.Location = new System.Drawing.Point(764, 4);
            this.tbTEng.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTEng.Name = "tbTEng";
            this.tbTEng.Size = new System.Drawing.Size(219, 27);
            this.tbTEng.TabIndex = 3;
            // 
            // panelButtonMain
            // 
            this.panelButtonMain.Controls.Add(this.tlpButton);
            this.panelButtonMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtonMain.Location = new System.Drawing.Point(0, 816);
            this.panelButtonMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelButtonMain.Name = "panelButtonMain";
            this.panelButtonMain.Size = new System.Drawing.Size(1343, 45);
            this.panelButtonMain.TabIndex = 2;
            // 
            // tlpButton
            // 
            this.tlpButton.BackColor = System.Drawing.Color.Azure;
            this.tlpButton.ColumnCount = 6;
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButton.Controls.Add(this.btnAddRow, 1, 0);
            this.tlpButton.Controls.Add(this.btnReset, 3, 0);
            this.tlpButton.Controls.Add(this.btnBuild, 4, 0);
            this.tlpButton.Controls.Add(this.btnDelRow, 2, 0);
            this.tlpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButton.Location = new System.Drawing.Point(0, 0);
            this.tlpButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpButton.Name = "tlpButton";
            this.tlpButton.RowCount = 1;
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButton.Size = new System.Drawing.Size(1343, 45);
            this.tlpButton.TabIndex = 0;
            // 
            // btnAddRow
            // 
            this.btnAddRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddRow.Location = new System.Drawing.Point(506, 4);
            this.btnAddRow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(78, 37);
            this.btnAddRow.TabIndex = 0;
            this.btnAddRow.Text = "插入行";
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // btnReset
            // 
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReset.Location = new System.Drawing.Point(674, 4);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(78, 37);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBuild
            // 
            this.btnBuild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBuild.Location = new System.Drawing.Point(758, 4);
            this.btnBuild.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(78, 37);
            this.btnBuild.TabIndex = 0;
            this.btnBuild.Text = "生成";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // btnDelRow
            // 
            this.btnDelRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelRow.Location = new System.Drawing.Point(590, 4);
            this.btnDelRow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelRow.Name = "btnDelRow";
            this.btnDelRow.Size = new System.Drawing.Size(78, 37);
            this.btnDelRow.TabIndex = 0;
            this.btnDelRow.Text = "删除行";
            this.btnDelRow.UseVisualStyleBackColor = true;
            this.btnDelRow.Click += new System.EventHandler(this.btnDelRow_Click);
            // 
            // SqlHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 861);
            this.Controls.Add(this.panelMain);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SqlHelper";
            this.Text = "SqlHelper";
            this.Load += new System.EventHandler(this.SqlHelper_Load);
            this.panelMain.ResumeLayout(false);
            this.panelGridMain.ResumeLayout(false);
            this.panelScript.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            this.panelTableMain.ResumeLayout(false);
            this.tlpTable.ResumeLayout(false);
            this.tlpTable.PerformLayout();
            this.panelButtonMain.ResumeLayout(false);
            this.tlpButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelButtonMain;
        private System.Windows.Forms.TableLayoutPanel tlpButton;
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.Button btnDelRow;
        private System.Windows.Forms.Panel panelGridMain;
        private System.Windows.Forms.Panel panelScript;
        private System.Windows.Forms.RichTextBox rtbScript;
        private System.Windows.Forms.Panel panelGrid;
        private CusControls.DataGridViewEx.DataGridViewEx dvEX;
        private System.Windows.Forms.Panel panelTableMain;
        private System.Windows.Forms.TableLayoutPanel tlpTable;
        private System.Windows.Forms.Label lbTChn;
        private System.Windows.Forms.Label lbTEng;
        private System.Windows.Forms.TextBox tbTChn;
        private System.Windows.Forms.TextBox tbTEng;
    }
}