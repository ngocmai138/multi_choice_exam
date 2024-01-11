namespace QuanLyThiTracNghiem
{
    partial class QuanLyBaiThi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnXemBaiLam = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.cbbMaDe = new System.Windows.Forms.ComboBox();
            this.cbbMaSV = new System.Windows.Forms.ComboBox();
            this.lbMaDe = new System.Windows.Forms.Label();
            this.lbMaSV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBaiLam)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgBaiLam
            // 
            this.dtgBaiLam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBaiLam.Location = new System.Drawing.Point(13, 95);
            this.dtgBaiLam.Name = "dtgBaiLam";
            this.dtgBaiLam.RowHeadersWidth = 62;
            this.dtgBaiLam.RowTemplate.Height = 28;
            this.dtgBaiLam.Size = new System.Drawing.Size(526, 343);
            this.dtgBaiLam.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(556, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã đề thi: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(556, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã sinh viên: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã đề thi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã sinh viên";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(560, 220);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(174, 38);
            this.btnQuayLai.TabIndex = 4;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXemBaiLam
            // 
            this.btnXemBaiLam.Location = new System.Drawing.Point(560, 176);
            this.btnXemBaiLam.Name = "btnXemBaiLam";
            this.btnXemBaiLam.Size = new System.Drawing.Size(174, 38);
            this.btnXemBaiLam.TabIndex = 4;
            this.btnXemBaiLam.Text = "Xem chi tiết";
            this.btnXemBaiLam.UseVisualStyleBackColor = true;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(560, 47);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(174, 34);
            this.btnXem.TabIndex = 6;
            this.btnXem.Text = "Xem tất cả";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // cbbMaDe
            // 
            this.cbbMaDe.FormattingEnabled = true;
            this.cbbMaDe.Location = new System.Drawing.Point(17, 53);
            this.cbbMaDe.Name = "cbbMaDe";
            this.cbbMaDe.Size = new System.Drawing.Size(171, 28);
            this.cbbMaDe.TabIndex = 7;
            this.cbbMaDe.Text = "(Tìm mã đề thi)";
            this.cbbMaDe.SelectedIndexChanged += new System.EventHandler(this.cbbMaDe_SelectedIndexChanged);
            // 
            // cbbMaSV
            // 
            this.cbbMaSV.FormattingEnabled = true;
            this.cbbMaSV.Location = new System.Drawing.Point(224, 53);
            this.cbbMaSV.Name = "cbbMaSV";
            this.cbbMaSV.Size = new System.Drawing.Size(174, 28);
            this.cbbMaSV.TabIndex = 7;
            this.cbbMaSV.Text = "(Tìm mã sinh viên)";
            this.cbbMaSV.SelectedIndexChanged += new System.EventHandler(this.cbbMaSV_SelectedIndexChanged);
            // 
            // lbMaDe
            // 
            this.lbMaDe.AutoSize = true;
            this.lbMaDe.Location = new System.Drawing.Point(665, 99);
            this.lbMaDe.Name = "lbMaDe";
            this.lbMaDe.Size = new System.Drawing.Size(53, 20);
            this.lbMaDe.TabIndex = 8;
            this.lbMaDe.Text = "mã đề";
            // 
            // lbMaSV
            // 
            this.lbMaSV.AutoSize = true;
            this.lbMaSV.Location = new System.Drawing.Point(666, 139);
            this.lbMaSV.Name = "lbMaSV";
            this.lbMaSV.Size = new System.Drawing.Size(50, 20);
            this.lbMaSV.TabIndex = 8;
            this.lbMaSV.Text = "mã sv";
            // 
            // QuanLyBaiThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.lbMaSV);
            this.Controls.Add(this.lbMaDe);
            this.Controls.Add(this.cbbMaSV);
            this.Controls.Add(this.cbbMaDe);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnXemBaiLam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgBaiLam);
            this.Name = "QuanLyBaiThi";
            this.Text = "QuanLyBaiThi";
            ((System.ComponentModel.ISupportInitialize)(this.dtgBaiLam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgBaiLam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnXemBaiLam;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.ComboBox cbbMaDe;
        private System.Windows.Forms.ComboBox cbbMaSV;
        private System.Windows.Forms.Label lbMaDe;
        private System.Windows.Forms.Label lbMaSV;
    }
}