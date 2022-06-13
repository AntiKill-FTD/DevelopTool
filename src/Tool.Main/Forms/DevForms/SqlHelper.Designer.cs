﻿namespace Tool.Main.Forms.DevForms
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
            this.rtbScript = new System.Windows.Forms.RichTextBox();
            this.dv_AddColumn = new Tool.CusControls.DataGridViewEx.DataGridViewEx();
            this.tlp_Query = new System.Windows.Forms.TableLayoutPanel();
            this.lbTChn = new System.Windows.Forms.Label();
            this.lbTEng = new System.Windows.Forms.Label();
            this.tbTChn = new System.Windows.Forms.TextBox();
            this.tbTEng = new System.Windows.Forms.TextBox();
            this.lbDataBaseType = new System.Windows.Forms.Label();
            this.tlp_Query_DataBaseType = new System.Windows.Forms.TableLayoutPanel();
            this.rb_DataBase_SqlServer = new System.Windows.Forms.RadioButton();
            this.rb_DataBase_Sqlite = new System.Windows.Forms.RadioButton();
            this.tlp_Button = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBuild = new System.Windows.Forms.Button();
            this.btnDelRow = new System.Windows.Forms.Button();
            this.btnExcute = new System.Windows.Forms.Button();
            this.tlp_Main = new System.Windows.Forms.TableLayoutPanel();
            this.dv_AddIndex = new Tool.CusControls.DataGridViewEx.DataGridViewEx();
            this.tlp_Query.SuspendLayout();
            this.tlp_Query_DataBaseType.SuspendLayout();
            this.tlp_Button.SuspendLayout();
            this.tlp_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbScript
            // 
            this.rtbScript.BackColor = System.Drawing.Color.AliceBlue;
            this.rtbScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbScript.Location = new System.Drawing.Point(0, 582);
            this.rtbScript.Margin = new System.Windows.Forms.Padding(0);
            this.rtbScript.Name = "rtbScript";
            this.rtbScript.ReadOnly = true;
            this.rtbScript.Size = new System.Drawing.Size(1343, 228);
            this.rtbScript.TabIndex = 0;
            this.rtbScript.Text = "";
            // 
            // dv_AddColumn
            // 
            this.dv_AddColumn.DataHelper = null;
            this.dv_AddColumn.DataSourceSql = null;
            this.dv_AddColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dv_AddColumn.DvDataTable = null;
            this.dv_AddColumn.DvSelectionMode = System.Windows.Forms.DataGridViewSelectionMode.RowHeaderSelect;
            this.dv_AddColumn.IsPage = true;
            this.dv_AddColumn.IsShowFirstCheckBox = false;
            this.dv_AddColumn.IsSort = false;
            this.dv_AddColumn.Location = new System.Drawing.Point(0, 50);
            this.dv_AddColumn.Margin = new System.Windows.Forms.Padding(0);
            this.dv_AddColumn.Name = "dv_AddColumn";
            this.dv_AddColumn.RowEdit = false;
            this.dv_AddColumn.Size = new System.Drawing.Size(1343, 304);
            this.dv_AddColumn.TabIndex = 0;
            // 
            // tlp_Query
            // 
            this.tlp_Query.BackColor = System.Drawing.Color.Azure;
            this.tlp_Query.ColumnCount = 8;
            this.tlp_Query.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Query.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlp_Query.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tlp_Query.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlp_Query.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.tlp_Query.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlp_Query.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.tlp_Query.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Query.Controls.Add(this.lbTChn, 3, 0);
            this.tlp_Query.Controls.Add(this.lbTEng, 5, 0);
            this.tlp_Query.Controls.Add(this.tbTChn, 4, 0);
            this.tlp_Query.Controls.Add(this.tbTEng, 6, 0);
            this.tlp_Query.Controls.Add(this.lbDataBaseType, 1, 0);
            this.tlp_Query.Controls.Add(this.tlp_Query_DataBaseType, 2, 0);
            this.tlp_Query.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Query.Location = new System.Drawing.Point(0, 0);
            this.tlp_Query.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Query.Name = "tlp_Query";
            this.tlp_Query.RowCount = 1;
            this.tlp_Query.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Query.Size = new System.Drawing.Size(1343, 50);
            this.tlp_Query.TabIndex = 0;
            // 
            // lbTChn
            // 
            this.lbTChn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTChn.Location = new System.Drawing.Point(529, 0);
            this.lbTChn.Name = "lbTChn";
            this.lbTChn.Size = new System.Drawing.Size(84, 50);
            this.lbTChn.TabIndex = 0;
            this.lbTChn.Text = "表中文：";
            this.lbTChn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTEng
            // 
            this.lbTEng.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTEng.Location = new System.Drawing.Point(844, 0);
            this.lbTEng.Name = "lbTEng";
            this.lbTEng.Size = new System.Drawing.Size(84, 50);
            this.lbTEng.TabIndex = 1;
            this.lbTEng.Text = "表英文：";
            this.lbTEng.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbTChn
            // 
            this.tbTChn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTChn.Location = new System.Drawing.Point(619, 4);
            this.tbTChn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTChn.Name = "tbTChn";
            this.tbTChn.Size = new System.Drawing.Size(219, 27);
            this.tbTChn.TabIndex = 2;
            // 
            // tbTEng
            // 
            this.tbTEng.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTEng.Location = new System.Drawing.Point(934, 4);
            this.tbTEng.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTEng.Name = "tbTEng";
            this.tbTEng.Size = new System.Drawing.Size(219, 27);
            this.tbTEng.TabIndex = 3;
            // 
            // lbDataBaseType
            // 
            this.lbDataBaseType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDataBaseType.Location = new System.Drawing.Point(189, 0);
            this.lbDataBaseType.Name = "lbDataBaseType";
            this.lbDataBaseType.Size = new System.Drawing.Size(84, 50);
            this.lbDataBaseType.TabIndex = 4;
            this.lbDataBaseType.Text = "数据库：";
            this.lbDataBaseType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlp_Query_DataBaseType
            // 
            this.tlp_Query_DataBaseType.ColumnCount = 2;
            this.tlp_Query_DataBaseType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Query_DataBaseType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Query_DataBaseType.Controls.Add(this.rb_DataBase_SqlServer, 0, 0);
            this.tlp_Query_DataBaseType.Controls.Add(this.rb_DataBase_Sqlite, 1, 0);
            this.tlp_Query_DataBaseType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Query_DataBaseType.Location = new System.Drawing.Point(279, 3);
            this.tlp_Query_DataBaseType.Name = "tlp_Query_DataBaseType";
            this.tlp_Query_DataBaseType.RowCount = 1;
            this.tlp_Query_DataBaseType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Query_DataBaseType.Size = new System.Drawing.Size(244, 44);
            this.tlp_Query_DataBaseType.TabIndex = 5;
            // 
            // rb_DataBase_SqlServer
            // 
            this.rb_DataBase_SqlServer.AutoSize = true;
            this.rb_DataBase_SqlServer.Checked = true;
            this.rb_DataBase_SqlServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rb_DataBase_SqlServer.Location = new System.Drawing.Point(3, 3);
            this.rb_DataBase_SqlServer.Name = "rb_DataBase_SqlServer";
            this.rb_DataBase_SqlServer.Size = new System.Drawing.Size(116, 38);
            this.rb_DataBase_SqlServer.TabIndex = 0;
            this.rb_DataBase_SqlServer.TabStop = true;
            this.rb_DataBase_SqlServer.Text = "SqlServer";
            this.rb_DataBase_SqlServer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_DataBase_SqlServer.UseVisualStyleBackColor = true;
            this.rb_DataBase_SqlServer.CheckedChanged += new System.EventHandler(this.rb_DataBase_SqlServer_CheckedChanged);
            // 
            // rb_DataBase_Sqlite
            // 
            this.rb_DataBase_Sqlite.AutoSize = true;
            this.rb_DataBase_Sqlite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rb_DataBase_Sqlite.Location = new System.Drawing.Point(125, 3);
            this.rb_DataBase_Sqlite.Name = "rb_DataBase_Sqlite";
            this.rb_DataBase_Sqlite.Size = new System.Drawing.Size(116, 38);
            this.rb_DataBase_Sqlite.TabIndex = 1;
            this.rb_DataBase_Sqlite.TabStop = true;
            this.rb_DataBase_Sqlite.Text = "Sqlite";
            this.rb_DataBase_Sqlite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_DataBase_Sqlite.UseVisualStyleBackColor = true;
            // 
            // tlp_Button
            // 
            this.tlp_Button.BackColor = System.Drawing.Color.Azure;
            this.tlp_Button.ColumnCount = 7;
            this.tlp_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tlp_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tlp_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tlp_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tlp_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tlp_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Button.Controls.Add(this.btnAddRow, 1, 0);
            this.tlp_Button.Controls.Add(this.btnReset, 3, 0);
            this.tlp_Button.Controls.Add(this.btnBuild, 4, 0);
            this.tlp_Button.Controls.Add(this.btnDelRow, 2, 0);
            this.tlp_Button.Controls.Add(this.btnExcute, 5, 0);
            this.tlp_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Button.Location = new System.Drawing.Point(0, 810);
            this.tlp_Button.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Button.Name = "tlp_Button";
            this.tlp_Button.RowCount = 1;
            this.tlp_Button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Button.Size = new System.Drawing.Size(1343, 51);
            this.tlp_Button.TabIndex = 0;
            // 
            // btnAddRow
            // 
            this.btnAddRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddRow.Location = new System.Drawing.Point(426, 4);
            this.btnAddRow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(78, 43);
            this.btnAddRow.TabIndex = 0;
            this.btnAddRow.Text = "插入行";
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // btnReset
            // 
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReset.Location = new System.Drawing.Point(594, 4);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(78, 43);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBuild
            // 
            this.btnBuild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBuild.Location = new System.Drawing.Point(678, 4);
            this.btnBuild.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(78, 43);
            this.btnBuild.TabIndex = 0;
            this.btnBuild.Text = "生成";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // btnDelRow
            // 
            this.btnDelRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelRow.Location = new System.Drawing.Point(510, 4);
            this.btnDelRow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelRow.Name = "btnDelRow";
            this.btnDelRow.Size = new System.Drawing.Size(78, 43);
            this.btnDelRow.TabIndex = 0;
            this.btnDelRow.Text = "删除行";
            this.btnDelRow.UseVisualStyleBackColor = true;
            this.btnDelRow.Click += new System.EventHandler(this.btnDelRow_Click);
            // 
            // btnExcute
            // 
            this.btnExcute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExcute.Location = new System.Drawing.Point(762, 3);
            this.btnExcute.Name = "btnExcute";
            this.btnExcute.Size = new System.Drawing.Size(154, 45);
            this.btnExcute.TabIndex = 1;
            this.btnExcute.Text = "在当前数据库执行";
            this.btnExcute.UseVisualStyleBackColor = true;
            this.btnExcute.Click += new System.EventHandler(this.btnExcute_Click);
            // 
            // tlp_Main
            // 
            this.tlp_Main.ColumnCount = 1;
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Main.Controls.Add(this.tlp_Query, 0, 0);
            this.tlp_Main.Controls.Add(this.tlp_Button, 0, 4);
            this.tlp_Main.Controls.Add(this.dv_AddColumn, 0, 1);
            this.tlp_Main.Controls.Add(this.rtbScript, 0, 3);
            this.tlp_Main.Controls.Add(this.dv_AddIndex, 0, 2);
            this.tlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Main.Location = new System.Drawing.Point(0, 0);
            this.tlp_Main.Name = "tlp_Main";
            this.tlp_Main.RowCount = 5;
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlp_Main.Size = new System.Drawing.Size(1343, 861);
            this.tlp_Main.TabIndex = 1;
            // 
            // dv_AddIndex
            // 
            this.dv_AddIndex.DataHelper = null;
            this.dv_AddIndex.DataSourceSql = null;
            this.dv_AddIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dv_AddIndex.DvDataTable = null;
            this.dv_AddIndex.DvSelectionMode = System.Windows.Forms.DataGridViewSelectionMode.RowHeaderSelect;
            this.dv_AddIndex.IsPage = false;
            this.dv_AddIndex.IsShowFirstCheckBox = false;
            this.dv_AddIndex.IsSort = false;
            this.dv_AddIndex.Location = new System.Drawing.Point(0, 354);
            this.dv_AddIndex.Margin = new System.Windows.Forms.Padding(0);
            this.dv_AddIndex.Name = "dv_AddIndex";
            this.dv_AddIndex.RowEdit = false;
            this.dv_AddIndex.Size = new System.Drawing.Size(1343, 228);
            this.dv_AddIndex.TabIndex = 1;
            // 
            // SqlHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 861);
            this.Controls.Add(this.tlp_Main);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SqlHelper";
            this.Text = "SqlHelper";
            this.Load += new System.EventHandler(this.SqlHelper_Load);
            this.tlp_Query.ResumeLayout(false);
            this.tlp_Query.PerformLayout();
            this.tlp_Query_DataBaseType.ResumeLayout(false);
            this.tlp_Query_DataBaseType.PerformLayout();
            this.tlp_Button.ResumeLayout(false);
            this.tlp_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlp_Button;
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.Button btnDelRow;
        private System.Windows.Forms.RichTextBox rtbScript;
        private CusControls.DataGridViewEx.DataGridViewEx dv_AddColumn;
        private System.Windows.Forms.TableLayoutPanel tlp_Query;
        private System.Windows.Forms.Label lbTChn;
        private System.Windows.Forms.Label lbTEng;
        private System.Windows.Forms.TextBox tbTChn;
        private System.Windows.Forms.TextBox tbTEng;
        private Label lbDataBaseType;
        private TableLayoutPanel tlp_Query_DataBaseType;
        private RadioButton rb_DataBase_SqlServer;
        private RadioButton rb_DataBase_Sqlite;
        private Button btnExcute;
        private TableLayoutPanel tlp_Main;
        private CusControls.DataGridViewEx.DataGridViewEx dv_AddIndex;
    }
}