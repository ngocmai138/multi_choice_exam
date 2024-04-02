namespace QuanLyThiTracNghiem
{
    partial class Form_NopBai
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.dtgvChiTietBaiLam = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietBaiLam)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nộp bài thành công!";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(351, 404);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 34);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Điểm của bạn: ";
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Location = new System.Drawing.Point(436, 73);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(46, 20);
            this.lbKetQua.TabIndex = 3;
            this.lbKetQua.Text = "Điểm";
            // 
            // dtgvChiTietBaiLam
            // 
            this.dtgvChiTietBaiLam.AllowUserToAddRows = false;
            this.dtgvChiTietBaiLam.AllowUserToDeleteRows = false;
            this.dtgvChiTietBaiLam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiTietBaiLam.Location = new System.Drawing.Point(60, 108);
            this.dtgvChiTietBaiLam.Name = "dtgvChiTietBaiLam";
            this.dtgvChiTietBaiLam.ReadOnly = true;
            this.dtgvChiTietBaiLam.RowHeadersWidth = 62;
            this.dtgvChiTietBaiLam.Size = new System.Drawing.Size(700, 259);
            this.dtgvChiTietBaiLam.TabIndex = 4;
            // 
            // NopBai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgvChiTietBaiLam);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label1);
            this.Name = "NopBai";
            this.Text = "NopBai";
            this.Load += new System.EventHandler(this.NopBai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietBaiLam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbKetQua;
        private System.Windows.Forms.DataGridView dtgvChiTietBaiLam;
    }
}