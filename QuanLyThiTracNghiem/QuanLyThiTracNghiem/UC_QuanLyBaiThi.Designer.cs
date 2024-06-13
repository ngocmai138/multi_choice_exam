namespace QuanLyThiTracNghiem
{
    partial class UC_QuanLyBaiThi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnBaiThi = new System.Windows.Forms.Panel();
            this.cbbTimKiem = new System.Windows.Forms.ComboBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnXemBaiLam = new System.Windows.Forms.Button();
            this.dtgBaiLam = new System.Windows.Forms.DataGridView();
            this.pnBaiThi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBaiLam)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBaiThi
            // 
            this.pnBaiThi.Controls.Add(this.cbbTimKiem);
            this.pnBaiThi.Controls.Add(this.btnXem);
            this.pnBaiThi.Controls.Add(this.btnTimKiem);
            this.pnBaiThi.Controls.Add(this.txtTimKiem);
            this.pnBaiThi.Controls.Add(this.btnXemBaiLam);
            this.pnBaiThi.Controls.Add(this.dtgBaiLam);
            this.pnBaiThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBaiThi.Location = new System.Drawing.Point(0, 0);
            this.pnBaiThi.Name = "pnBaiThi";
            this.pnBaiThi.Size = new System.Drawing.Size(1166, 588);
            this.pnBaiThi.TabIndex = 1;
            // 
            // cbbTimKiem
            // 
            this.cbbTimKiem.FormattingEnabled = true;
            this.cbbTimKiem.Items.AddRange(new object[] {
            "Mã đề thi",
            "Mã sinh viên"});
            this.cbbTimKiem.Location = new System.Drawing.Point(12, 19);
            this.cbbTimKiem.Name = "cbbTimKiem";
            this.cbbTimKiem.Size = new System.Drawing.Size(182, 28);
            this.cbbTimKiem.TabIndex = 0;
            this.cbbTimKiem.Text = "(Tìm kiếm theo)";
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(652, 15);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(146, 34);
            this.btnXem.TabIndex = 3;
            this.btnXem.Text = "Xem tất cả";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(472, 15);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(158, 34);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(200, 19);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(247, 26);
            this.txtTimKiem.TabIndex = 1;
            // 
            // btnXemBaiLam
            // 
            this.btnXemBaiLam.Location = new System.Drawing.Point(821, 13);
            this.btnXemBaiLam.Name = "btnXemBaiLam";
            this.btnXemBaiLam.Size = new System.Drawing.Size(146, 38);
            this.btnXemBaiLam.TabIndex = 4;
            this.btnXemBaiLam.Text = "Xem chi tiết";
            this.btnXemBaiLam.UseVisualStyleBackColor = true;
            this.btnXemBaiLam.Click += new System.EventHandler(this.btnXemBaiLam_Click);
            // 
            // dtgBaiLam
            // 
            this.dtgBaiLam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgBaiLam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBaiLam.Location = new System.Drawing.Point(12, 66);
            this.dtgBaiLam.Name = "dtgBaiLam";
            this.dtgBaiLam.RowHeadersWidth = 62;
            this.dtgBaiLam.RowTemplate.Height = 28;
            this.dtgBaiLam.Size = new System.Drawing.Size(1139, 504);
            this.dtgBaiLam.TabIndex = 6;
            // 
            // UC_QuanLyBaiThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnBaiThi);
            this.Name = "UC_QuanLyBaiThi";
            this.Size = new System.Drawing.Size(1166, 588);
            this.pnBaiThi.ResumeLayout(false);
            this.pnBaiThi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBaiLam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBaiThi;
        private System.Windows.Forms.ComboBox cbbTimKiem;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnXemBaiLam;
        private System.Windows.Forms.DataGridView dtgBaiLam;
    }
}
