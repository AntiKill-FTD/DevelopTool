namespace Tool.CusControls.DataGridViewEx
{
    partial class DataGridViewEx
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelPage = new System.Windows.Forms.Panel();
            this.tlpPage = new System.Windows.Forms.TableLayoutPanel();
            this.labA = new System.Windows.Forms.Label();
            this.labC = new System.Windows.Forms.Label();
            this.labE = new System.Windows.Forms.Label();
            this.labDataCount = new System.Windows.Forms.Label();
            this.labD = new System.Windows.Forms.Label();
            this.txtPerPageCount = new System.Windows.Forms.TextBox();
            this.txtCurrentPageIndex = new System.Windows.Forms.TextBox();
            this.labPageCount = new System.Windows.Forms.Label();
            this.labB = new System.Windows.Forms.Label();
            this.btnFirstPage = new System.Windows.Forms.Label();
            this.btnPreviewPage = new System.Windows.Forms.Label();
            this.btnNextPage = new System.Windows.Forms.Label();
            this.btnLastPage = new System.Windows.Forms.Label();
            this.dataGridView1 = new Tool.CusControls.DataGridViewEx.DataGridViewCommonEx();
            this.panelPage.SuspendLayout();
            this.tlpPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPage
            // 
            this.panelPage.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelPage.Controls.Add(this.tlpPage);
            this.panelPage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPage.Location = new System.Drawing.Point(0, 610);
            this.panelPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelPage.Name = "panelPage";
            this.panelPage.Size = new System.Drawing.Size(898, 41);
            this.panelPage.TabIndex = 1;
            // 
            // tlpPage
            // 
            this.tlpPage.ColumnCount = 14;
            this.tlpPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tlpPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tlpPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tlpPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tlpPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tlpPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tlpPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tlpPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tlpPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tlpPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tlpPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tlpPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tlpPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tlpPage.Controls.Add(this.labA, 0, 0);
            this.tlpPage.Controls.Add(this.labC, 5, 0);
            this.tlpPage.Controls.Add(this.labE, 8, 0);
            this.tlpPage.Controls.Add(this.labDataCount, 7, 0);
            this.tlpPage.Controls.Add(this.labD, 6, 0);
            this.tlpPage.Controls.Add(this.txtPerPageCount, 4, 0);
            this.tlpPage.Controls.Add(this.txtCurrentPageIndex, 1, 0);
            this.tlpPage.Controls.Add(this.labPageCount, 2, 0);
            this.tlpPage.Controls.Add(this.labB, 3, 0);
            this.tlpPage.Controls.Add(this.btnFirstPage, 10, 0);
            this.tlpPage.Controls.Add(this.btnPreviewPage, 11, 0);
            this.tlpPage.Controls.Add(this.btnNextPage, 12, 0);
            this.tlpPage.Controls.Add(this.btnLastPage, 13, 0);
            this.tlpPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPage.Location = new System.Drawing.Point(0, 0);
            this.tlpPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpPage.Name = "tlpPage";
            this.tlpPage.RowCount = 1;
            this.tlpPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPage.Size = new System.Drawing.Size(898, 41);
            this.tlpPage.TabIndex = 0;
            // 
            // labA
            // 
            this.labA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labA.Location = new System.Drawing.Point(0, 0);
            this.labA.Margin = new System.Windows.Forms.Padding(0);
            this.labA.Name = "labA";
            this.labA.Size = new System.Drawing.Size(51, 41);
            this.labA.TabIndex = 9;
            this.labA.Text = "页次";
            this.labA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labC
            // 
            this.labC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labC.Location = new System.Drawing.Point(269, 0);
            this.labC.Name = "labC";
            this.labC.Size = new System.Drawing.Size(45, 41);
            this.labC.TabIndex = 8;
            this.labC.Text = "条";
            this.labC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labE
            // 
            this.labE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labE.Location = new System.Drawing.Point(433, 0);
            this.labE.Name = "labE";
            this.labE.Size = new System.Drawing.Size(45, 41);
            this.labE.TabIndex = 7;
            this.labE.Text = "条";
            this.labE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labDataCount
            // 
            this.labDataCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labDataCount.Location = new System.Drawing.Point(371, 0);
            this.labDataCount.Name = "labDataCount";
            this.labDataCount.Size = new System.Drawing.Size(56, 41);
            this.labDataCount.TabIndex = 6;
            this.labDataCount.Text = "0";
            this.labDataCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labD
            // 
            this.labD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labD.Location = new System.Drawing.Point(320, 0);
            this.labD.Name = "labD";
            this.labD.Size = new System.Drawing.Size(45, 41);
            this.labD.TabIndex = 5;
            this.labD.Text = "共";
            this.labD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPerPageCount
            // 
            this.txtPerPageCount.BackColor = System.Drawing.SystemColors.Control;
            this.txtPerPageCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPerPageCount.Location = new System.Drawing.Point(218, 4);
            this.txtPerPageCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPerPageCount.Name = "txtPerPageCount";
            this.txtPerPageCount.Size = new System.Drawing.Size(45, 27);
            this.txtPerPageCount.TabIndex = 4;
            this.txtPerPageCount.Text = "100";
            this.txtPerPageCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPerPageCount.TextChanged += new System.EventHandler(this.txtPerPageCount_TextChanged);
            this.txtPerPageCount.Leave += new System.EventHandler(this.txtPerPageCount_Leave);
            // 
            // txtCurrentPageIndex
            // 
            this.txtCurrentPageIndex.BackColor = System.Drawing.SystemColors.Control;
            this.txtCurrentPageIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCurrentPageIndex.Location = new System.Drawing.Point(54, 4);
            this.txtCurrentPageIndex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCurrentPageIndex.Name = "txtCurrentPageIndex";
            this.txtCurrentPageIndex.Size = new System.Drawing.Size(45, 27);
            this.txtCurrentPageIndex.TabIndex = 1;
            this.txtCurrentPageIndex.Text = "1";
            this.txtCurrentPageIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCurrentPageIndex.TextChanged += new System.EventHandler(this.txtCurrentPageIndex_TextChanged);
            this.txtCurrentPageIndex.Leave += new System.EventHandler(this.txtCurrentPageIndex_Leave);
            // 
            // labPageCount
            // 
            this.labPageCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labPageCount.Location = new System.Drawing.Point(105, 0);
            this.labPageCount.Name = "labPageCount";
            this.labPageCount.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.labPageCount.Size = new System.Drawing.Size(56, 41);
            this.labPageCount.TabIndex = 2;
            this.labPageCount.Text = "/1";
            this.labPageCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labB
            // 
            this.labB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labB.Location = new System.Drawing.Point(167, 0);
            this.labB.Name = "labB";
            this.labB.Size = new System.Drawing.Size(45, 41);
            this.labB.TabIndex = 3;
            this.labB.Text = "每页";
            this.labB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.AutoSize = true;
            this.btnFirstPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirstPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFirstPage.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFirstPage.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFirstPage.Location = new System.Drawing.Point(629, 0);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(62, 41);
            this.btnFirstPage.TabIndex = 10;
            this.btnFirstPage.Text = "[首页]";
            this.btnFirstPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // btnPreviewPage
            // 
            this.btnPreviewPage.AutoSize = true;
            this.btnPreviewPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreviewPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPreviewPage.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPreviewPage.Location = new System.Drawing.Point(697, 0);
            this.btnPreviewPage.Name = "btnPreviewPage";
            this.btnPreviewPage.Size = new System.Drawing.Size(62, 41);
            this.btnPreviewPage.TabIndex = 11;
            this.btnPreviewPage.Text = "[上页]";
            this.btnPreviewPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPreviewPage.Click += new System.EventHandler(this.btnPreviewPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.AutoSize = true;
            this.btnNextPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNextPage.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNextPage.Location = new System.Drawing.Point(765, 0);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(62, 41);
            this.btnNextPage.TabIndex = 12;
            this.btnNextPage.Text = "[下页]";
            this.btnNextPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnLastPage
            // 
            this.btnLastPage.AutoSize = true;
            this.btnLastPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLastPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLastPage.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLastPage.Location = new System.Drawing.Point(833, 0);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(62, 41);
            this.btnLastPage.TabIndex = 13;
            this.btnLastPage.Text = "[末页]";
            this.btnLastPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.LightBlue;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(898, 610);
            this.dataGridView1.TabIndex = 2;
            // 
            // DataGridViewEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelPage);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DataGridViewEx";
            this.Size = new System.Drawing.Size(898, 651);
            this.panelPage.ResumeLayout(false);
            this.tlpPage.ResumeLayout(false);
            this.tlpPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelPage;
        private System.Windows.Forms.TableLayoutPanel tlpPage;
        private System.Windows.Forms.TextBox txtCurrentPageIndex;
        private System.Windows.Forms.Label labPageCount;
        private System.Windows.Forms.Label labB;
        private System.Windows.Forms.TextBox txtPerPageCount;
        private System.Windows.Forms.Label labD;
        private System.Windows.Forms.Label labE;
        private System.Windows.Forms.Label labDataCount;
        private System.Windows.Forms.Label labC;
        private System.Windows.Forms.Label labA;
        private System.Windows.Forms.Label btnFirstPage;
        private System.Windows.Forms.Label btnPreviewPage;
        private System.Windows.Forms.Label btnNextPage;
        private System.Windows.Forms.Label btnLastPage;
        private DataGridViewCommonEx dataGridView1;
    }
}
