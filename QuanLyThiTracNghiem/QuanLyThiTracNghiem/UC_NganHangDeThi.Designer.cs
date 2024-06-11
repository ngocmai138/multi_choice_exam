namespace QuanLyThiTracNghiem
{
    partial class UC_NganHangDeThi
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
            this.pnNHDT = new System.Windows.Forms.Panel();
            this.dtgCauHoi = new System.Windows.Forms.DataGridView();
            this.dtgDeThi = new System.Windows.Forms.DataGridView();
            this.cbbTimKiem = new System.Windows.Forms.ComboBox();
            this.btnXoaDe = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnThemTuDong = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.pnNHDT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCauHoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDeThi)).BeginInit();
            this.SuspendLayout();
            // 
            // pnNHDT
            // 
            this.pnNHDT.Controls.Add(this.dtgCauHoi);
            this.pnNHDT.Controls.Add(this.dtgDeThi);
            this.pnNHDT.Controls.Add(this.cbbTimKiem);
            this.pnNHDT.Controls.Add(this.btnXoaDe);
            this.pnNHDT.Controls.Add(this.btnXem);
            this.pnNHDT.Controls.Add(this.btnThemTuDong);
            this.pnNHDT.Controls.Add(this.txtTimKiem);
            this.pnNHDT.Controls.Add(this.btnTimKiem);
            this.pnNHDT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnNHDT.Location = new System.Drawing.Point(0, 0);
            this.pnNHDT.Name = "pnNHDT";
            this.pnNHDT.Size = new System.Drawing.Size(1166, 588);
            this.pnNHDT.TabIndex = 4;
            // 
            // dtgCauHoi
            // 
            this.dtgCauHoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCauHoi.Location = new System.Drawing.Point(309, 84);
            this.dtgCauHoi.Name = "dtgCauHoi";
            this.dtgCauHoi.RowHeadersWidth = 62;
            this.dtgCauHoi.RowTemplate.Height = 28;
            this.dtgCauHoi.Size = new System.Drawing.Size(838, 490);
            this.dtgCauHoi.TabIndex = 10;
            // 
            // dtgDeThi
            // 
            this.dtgDeThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDeThi.Location = new System.Drawing.Point(18, 84);
            this.dtgDeThi.Name = "dtgDeThi";
            this.dtgDeThi.RowHeadersWidth = 62;
            this.dtgDeThi.RowTemplate.Height = 28;
            this.dtgDeThi.Size = new System.Drawing.Size(285, 490);
            this.dtgDeThi.TabIndex = 11;
            this.dtgDeThi.SelectionChanged += new System.EventHandler(this.dtgDeThi_SelectionChanged);
            // 
            // cbbTimKiem
            // 
            this.cbbTimKiem.FormattingEnabled = true;
            this.cbbTimKiem.Items.AddRange(new object[] {
            "Mã đề",
            "Nội dung câu hỏi"});
            this.cbbTimKiem.Location = new System.Drawing.Point(17, 36);
            this.cbbTimKiem.Name = "cbbTimKiem";
            this.cbbTimKiem.Size = new System.Drawing.Size(166, 28);
            this.cbbTimKiem.TabIndex = 0;
            this.cbbTimKiem.Text = "(Nội dung tìm kiếm)";
            // 
            // btnXoaDe
            // 
            this.btnXoaDe.Location = new System.Drawing.Point(810, 36);
            this.btnXoaDe.Name = "btnXoaDe";
            this.btnXoaDe.Size = new System.Drawing.Size(139, 34);
            this.btnXoaDe.TabIndex = 7;
            this.btnXoaDe.Text = "Xóa Đề thi";
            this.btnXoaDe.UseVisualStyleBackColor = true;
            this.btnXoaDe.Click += new System.EventHandler(this.btnXoaDe_Click);
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(521, 36);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(139, 34);
            this.btnXem.TabIndex = 3;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnThemTuDong
            // 
            this.btnThemTuDong.Location = new System.Drawing.Point(665, 36);
            this.btnThemTuDong.Name = "btnThemTuDong";
            this.btnThemTuDong.Size = new System.Drawing.Size(139, 34);
            this.btnThemTuDong.TabIndex = 6;
            this.btnThemTuDong.Text = "Thêm tự động";
            this.btnThemTuDong.UseVisualStyleBackColor = true;
            this.btnThemTuDong.Click += new System.EventHandler(this.btnThemTuDong_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(189, 36);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(206, 26);
            this.txtTimKiem.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(401, 36);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(114, 33);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // UC_NganHangDeThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnNHDT);
            this.Name = "UC_NganHangDeThi";
            this.Size = new System.Drawing.Size(1166, 588);
            this.pnNHDT.ResumeLayout(false);
            this.pnNHDT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCauHoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDeThi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnNHDT;
        private System.Windows.Forms.DataGridView dtgCauHoi;
        private System.Windows.Forms.DataGridView dtgDeThi;
        private System.Windows.Forms.ComboBox cbbTimKiem;
        private System.Windows.Forms.Button btnXoaDe;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnThemTuDong;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
    }
}
