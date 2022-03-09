namespace Tool.Main.Forms.MainForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelStatus = new System.Windows.Forms.Panel();
            this.panelNetStat = new System.Windows.Forms.Panel();
            this.labelNetStat = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMdiContainer = new System.Windows.Forms.Panel();
            this.panelMenuList = new System.Windows.Forms.Panel();
            this.toolStripMenuList = new System.Windows.Forms.ToolStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmi00 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi00_01 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi00_02 = new System.Windows.Forms.ToolStripMenuItem();
            this.系统设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.菜单管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.panelStatus.SuspendLayout();
            this.panelNetStat.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelMenuList.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStatus
            // 
            this.panelStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStatus.Controls.Add(this.panelNetStat);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStatus.Location = new System.Drawing.Point(0, 568);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(1168, 40);
            this.panelStatus.TabIndex = 0;
            // 
            // panelNetStat
            // 
            this.panelNetStat.Controls.Add(this.labelNetStat);
            this.panelNetStat.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNetStat.Location = new System.Drawing.Point(0, 0);
            this.panelNetStat.Name = "panelNetStat";
            this.panelNetStat.Size = new System.Drawing.Size(143, 38);
            this.panelNetStat.TabIndex = 0;
            // 
            // labelNetStat
            // 
            this.labelNetStat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNetStat.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNetStat.ForeColor = System.Drawing.SystemColors.Control;
            this.labelNetStat.Location = new System.Drawing.Point(0, 0);
            this.labelNetStat.Name = "labelNetStat";
            this.labelNetStat.Size = new System.Drawing.Size(143, 38);
            this.labelNetStat.TabIndex = 0;
            this.labelNetStat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.panelMdiContainer);
            this.panelMain.Controls.Add(this.panelMenuList);
            this.panelMain.Controls.Add(this.menuStrip1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1168, 568);
            this.panelMain.TabIndex = 1;
            // 
            // panelMdiContainer
            // 
            this.panelMdiContainer.BackColor = System.Drawing.Color.LightBlue;
            this.panelMdiContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMdiContainer.Location = new System.Drawing.Point(0, 28);
            this.panelMdiContainer.Name = "panelMdiContainer";
            this.panelMdiContainer.Size = new System.Drawing.Size(1166, 508);
            this.panelMdiContainer.TabIndex = 2;
            // 
            // panelMenuList
            // 
            this.panelMenuList.Controls.Add(this.toolStripMenuList);
            this.panelMenuList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMenuList.Location = new System.Drawing.Point(0, 536);
            this.panelMenuList.Name = "panelMenuList";
            this.panelMenuList.Size = new System.Drawing.Size(1166, 30);
            this.panelMenuList.TabIndex = 1;
            // 
            // toolStripMenuList
            // 
            this.toolStripMenuList.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStripMenuList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripMenuList.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMenuList.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMenuList.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenuList.Name = "toolStripMenuList";
            this.toolStripMenuList.Size = new System.Drawing.Size(1166, 30);
            this.toolStripMenuList.TabIndex = 0;
            this.toolStripMenuList.Text = "toolStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi00});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1166, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmi00
            // 
            this.tsmi00.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi00_01,
            this.tsmi00_02});
            this.tsmi00.Name = "tsmi00";
            this.tsmi00.Size = new System.Drawing.Size(83, 24);
            this.tsmi00.Text = "系统设置";
            // 
            // tsmi00_01
            // 
            this.tsmi00_01.ForeColor = System.Drawing.Color.DarkBlue;
            this.tsmi00_01.Name = "tsmi00_01";
            this.tsmi00_01.Size = new System.Drawing.Size(224, 26);
            this.tsmi00_01.Text = "菜单管理";
            this.tsmi00_01.Click += new System.EventHandler(this.菜单管理ToolStripMenuItem_Click);
            // 
            // tsmi00_02
            // 
            this.tsmi00_02.ForeColor = System.Drawing.Color.DarkBlue;
            this.tsmi00_02.Name = "tsmi00_02";
            this.tsmi00_02.Size = new System.Drawing.Size(224, 26);
            this.tsmi00_02.Text = "退出";
            this.tsmi00_02.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 系统设置ToolStripMenuItem
            // 
            this.系统设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单管理ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.系统设置ToolStripMenuItem.Name = "系统设置ToolStripMenuItem";
            this.系统设置ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.系统设置ToolStripMenuItem.Text = "系统设置";
            // 
            // 菜单管理ToolStripMenuItem
            // 
            this.菜单管理ToolStripMenuItem.Name = "菜单管理ToolStripMenuItem";
            this.菜单管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.菜单管理ToolStripMenuItem.Text = "菜单管理";
            this.菜单管理ToolStripMenuItem.Click += new System.EventHandler(this.菜单管理ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 608);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelStatus);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeveloperTool";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelStatus.ResumeLayout(false);
            this.panelNetStat.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelMenuList.ResumeLayout(false);
            this.panelMenuList.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelNetStat;
        private System.Windows.Forms.Label labelNetStat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 菜单管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.Panel panelMdiContainer;
        private System.Windows.Forms.Panel panelMenuList;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStrip toolStripMenuList;
        private System.Windows.Forms.ToolStripMenuItem tsmi00;
        private System.Windows.Forms.ToolStripMenuItem tsmi00_01;
        private System.Windows.Forms.ToolStripMenuItem tsmi00_02;
    }
}