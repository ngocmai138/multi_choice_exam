namespace QuanLyThiTracNghiem
{
    partial class UC_NopBai
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvChiTietBaiLam = new System.Windows.Forms.DataGridView();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietBaiLam)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvChiTietBaiLam);
            this.panel1.Controls.Add(this.lbKetQua);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1166, 585);
            this.panel1.TabIndex = 0;
            // 
            // dtgvChiTietBaiLam
            // 
            this.dtgvChiTietBaiLam.AllowUserToAddRows = false;
            this.dtgvChiTietBaiLam.AllowUserToDeleteRows = false;
            this.dtgvChiTietBaiLam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvChiTietBaiLam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiTietBaiLam.Location = new System.Drawing.Point(28, 169);
            this.dtgvChiTietBaiLam.Name = "dtgvChiTietBaiLam";
            this.dtgvChiTietBaiLam.ReadOnly = true;
            this.dtgvChiTietBaiLam.RowHeadersWidth = 62;
            this.dtgvChiTietBaiLam.Size = new System.Drawing.Size(1114, 397);
            this.dtgvChiTietBaiLam.TabIndex = 9;
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Location = new System.Drawing.Point(614, 86);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(46, 20);
            this.lbKetQua.TabIndex = 8;
            this.lbKetQua.Text = "Điểm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Điểm của bạn: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(484, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nộp bài thành công!";
            // 
            // UC_NopBai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UC_NopBai";
            this.Size = new System.Drawing.Size(1166, 585);
            this.Load += new System.EventHandler(this.UC_NopBai_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietBaiLam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvChiTietBaiLam;
        private System.Windows.Forms.Label lbKetQua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
