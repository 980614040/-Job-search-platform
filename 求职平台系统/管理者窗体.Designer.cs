namespace 求职平台系统
{
    partial class 管理者窗体
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.管理招聘信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除招聘信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.求职人员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除招聘信息ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.招聘信息审核ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.管理招聘信息ToolStripMenuItem,
            this.管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(415, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 管理招聘信息ToolStripMenuItem
            // 
            this.管理招聘信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除招聘信息ToolStripMenuItem,
            this.求职人员ToolStripMenuItem});
            this.管理招聘信息ToolStripMenuItem.Name = "管理招聘信息ToolStripMenuItem";
            this.管理招聘信息ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.管理招聘信息ToolStripMenuItem.Text = "查询";
            this.管理招聘信息ToolStripMenuItem.Click += new System.EventHandler(this.管理招聘信息ToolStripMenuItem_Click);
            // 
            // 删除招聘信息ToolStripMenuItem
            // 
            this.删除招聘信息ToolStripMenuItem.Name = "删除招聘信息ToolStripMenuItem";
            this.删除招聘信息ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.删除招聘信息ToolStripMenuItem.Text = "用人单位";
            this.删除招聘信息ToolStripMenuItem.Click += new System.EventHandler(this.删除招聘信息ToolStripMenuItem_Click);
            // 
            // 求职人员ToolStripMenuItem
            // 
            this.求职人员ToolStripMenuItem.Name = "求职人员ToolStripMenuItem";
            this.求职人员ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.求职人员ToolStripMenuItem.Text = "求职人员";
            this.求职人员ToolStripMenuItem.Click += new System.EventHandler(this.求职人员ToolStripMenuItem_Click);
            // 
            // 管理ToolStripMenuItem
            // 
            this.管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除招聘信息ToolStripMenuItem1,
            this.招聘信息审核ToolStripMenuItem});
            this.管理ToolStripMenuItem.Name = "管理ToolStripMenuItem";
            this.管理ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.管理ToolStripMenuItem.Text = "管理";
            // 
            // 删除招聘信息ToolStripMenuItem1
            // 
            this.删除招聘信息ToolStripMenuItem1.Name = "删除招聘信息ToolStripMenuItem1";
            this.删除招聘信息ToolStripMenuItem1.Size = new System.Drawing.Size(168, 24);
            this.删除招聘信息ToolStripMenuItem1.Text = "删除招聘信息";
            this.删除招聘信息ToolStripMenuItem1.Click += new System.EventHandler(this.删除招聘信息ToolStripMenuItem1_Click);
            // 
            // 招聘信息审核ToolStripMenuItem
            // 
            this.招聘信息审核ToolStripMenuItem.Name = "招聘信息审核ToolStripMenuItem";
            this.招聘信息审核ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.招聘信息审核ToolStripMenuItem.Text = "招聘信息审核";
            this.招聘信息审核ToolStripMenuItem.Click += new System.EventHandler(this.招聘信息审核ToolStripMenuItem_Click);
            // 
            // 管理者窗体
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 271);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "管理者窗体";
            this.Text = "管理者窗体";
            this.Load += new System.EventHandler(this.管理者窗体_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 管理招聘信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除招聘信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 求职人员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除招聘信息ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 招聘信息审核ToolStripMenuItem;
    }
}