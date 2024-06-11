namespace QuanLyThiTracNghiem
{
    partial class Form_MainForm_SV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MainForm_SV));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.làmBàiThiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kếtQuảThiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnMain = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.làmBàiThiToolStripMenuItem,
            this.kếtQuảThiToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1166, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // làmBàiThiToolStripMenuItem
            // 
            this.làmBàiThiToolStripMenuItem.Name = "làmBàiThiToolStripMenuItem";
            this.làmBàiThiToolStripMenuItem.Size = new System.Drawing.Size(115, 29);
            this.làmBàiThiToolStripMenuItem.Text = "Làm bài thi";
            this.làmBàiThiToolStripMenuItem.Click += new System.EventHandler(this.làmBàiThiToolStripMenuItem_Click);
            // 
            // kếtQuảThiToolStripMenuItem
            // 
            this.kếtQuảThiToolStripMenuItem.Name = "kếtQuảThiToolStripMenuItem";
            this.kếtQuảThiToolStripMenuItem.Size = new System.Drawing.Size(113, 29);
            this.kếtQuảThiToolStripMenuItem.Text = "Kết quả thi";
            this.kếtQuảThiToolStripMenuItem.Click += new System.EventHandler(this.kếtQuảThiToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // pnMain
            // 
            this.pnMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnMain.BackgroundImage")));
            this.pnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 33);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1166, 588);
            this.pnMain.TabIndex = 3;
            // 
            // Form_MainForm_SV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1166, 621);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_MainForm_SV";
            this.Text = "MainForm_SV";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem làmBàiThiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kếtQuảThiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Panel pnMain;
    }
}