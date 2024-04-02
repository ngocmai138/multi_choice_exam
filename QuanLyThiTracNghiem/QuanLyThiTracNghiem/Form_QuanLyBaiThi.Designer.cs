namespace QuanLyThiTracNghiem
{
    partial class Form_QuanLyBaiThi
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
            this.dtgBaiLam = new System.Windows.Forms.DataGridView();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnXemBaiLam = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.cbbTimKiem = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.pnBaiThi = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBaiLam)).BeginInit();
            this.pnBaiThi.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgBaiLam
            // 
            this.dtgBaiLam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBaiLam.Location = new System.Drawing.Point(12, 66);
            this.dtgBaiLam.Name = "dtgBaiLam";
            this.dtgBaiLam.RowHeadersWidth = 62;
            this.dtgBaiLam.RowTemplate.Height = 28;
            this.dtgBaiLam.Size = new System.Drawing.Size(526, 343);
            this.dtgBaiLam.TabIndex = 0;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(562, 150);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(174, 38);
            this.btnQuayLai.TabIndex = 4;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXemBaiLam
            // 
            this.btnXemBaiLam.Location = new System.Drawing.Point(562, 106);
            this.btnXemBaiLam.Name = "btnXemBaiLam";
            this.btnXemBaiLam.Size = new System.Drawing.Size(174, 38);
            this.btnXemBaiLam.TabIndex = 4;
            this.btnXemBaiLam.Text = "Xem chi tiết";
            this.btnXemBaiLam.UseVisualStyleBackColor = true;
            this.btnXemBaiLam.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(562, 66);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(174, 34);
            this.btnXem.TabIndex = 6;
            this.btnXem.Text = "Xem tất cả";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // cbbTimKiem
            // 
            this.cbbTimKiem.FormattingEnabled = true;
            this.cbbTimKiem.Items.AddRange(new object[] {
            "Mã đề thi",
            "Mã sinh viên"});
            this.cbbTimKiem.Location = new System.Drawing.Point(12, 19);
            this.cbbTimKiem.Name = "cbbTimKiem";
            this.cbbTimKiem.Size = new System.Drawing.Size(145, 28);
            this.cbbTimKiem.TabIndex = 7;
            this.cbbTimKiem.Text = "(Tìm kiếm theo)";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(175, 19);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(201, 26);
            this.txtTimKiem.TabIndex = 8;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(428, 15);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(110, 34);
            this.btnTimKiem.TabIndex = 9;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // pnBaiThi
            // 
            this.pnBaiThi.Controls.Add(this.cbbTimKiem);
            this.pnBaiThi.Controls.Add(this.btnXem);
            this.pnBaiThi.Controls.Add(this.btnTimKiem);
            this.pnBaiThi.Controls.Add(this.btnQuayLai);
            this.pnBaiThi.Controls.Add(this.txtTimKiem);
            this.pnBaiThi.Controls.Add(this.btnXemBaiLam);
            this.pnBaiThi.Controls.Add(this.dtgBaiLam);
            this.pnBaiThi.Location = new System.Drawing.Point(12, 12);
            this.pnBaiThi.Name = "pnBaiThi";
            this.pnBaiThi.Size = new System.Drawing.Size(790, 426);
            this.pnBaiThi.TabIndex = 10;
            // 
            // QuanLyBaiThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.pnBaiThi);
            this.Name = "QuanLyBaiThi";
            this.Text = "QuanLyBaiThi";
            ((System.ComponentModel.ISupportInitialize)(this.dtgBaiLam)).EndInit();
            this.pnBaiThi.ResumeLayout(false);
            this.pnBaiThi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgBaiLam;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnXemBaiLam;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.ComboBox cbbTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Panel pnBaiThi;
    }
}