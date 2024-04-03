namespace QuanLyThiTracNghiem
{
    partial class Form_XemLaiChiTietBaiLam
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
            this.dtgXemLaiCTBL = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgXemLaiCTBL)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgXemLaiCTBL
            // 
            this.dtgXemLaiCTBL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgXemLaiCTBL.Location = new System.Drawing.Point(13, 13);
            this.dtgXemLaiCTBL.Name = "dtgXemLaiCTBL";
            this.dtgXemLaiCTBL.RowHeadersWidth = 62;
            this.dtgXemLaiCTBL.RowTemplate.Height = 28;
            this.dtgXemLaiCTBL.Size = new System.Drawing.Size(775, 365);
            this.dtgXemLaiCTBL.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(344, 400);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 38);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form_XemLaiChiTietBaiLam
            // 
            this.AcceptButton = this.btnThoat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dtgXemLaiCTBL);
            this.Name = "Form_XemLaiChiTietBaiLam";
            this.Text = "Form_XemLaiChiTietBaiLam";
            this.Load += new System.EventHandler(this.Form_XemLaiChiTietBaiLam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgXemLaiCTBL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgXemLaiCTBL;
        private System.Windows.Forms.Button btnThoat;
    }
}