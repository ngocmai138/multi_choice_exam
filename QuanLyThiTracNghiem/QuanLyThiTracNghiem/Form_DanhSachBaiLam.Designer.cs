namespace QuanLyThiTracNghiem
{
    partial class Form_DanhSachBaiLam
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
            this.dtgvDSBL = new System.Windows.Forms.DataGridView();
            this.btnQuayLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSBL)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvDSBL
            // 
            this.dtgvDSBL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSBL.Location = new System.Drawing.Point(13, 13);
            this.dtgvDSBL.Name = "dtgvDSBL";
            this.dtgvDSBL.RowHeadersWidth = 62;
            this.dtgvDSBL.RowTemplate.Height = 28;
            this.dtgvDSBL.Size = new System.Drawing.Size(775, 337);
            this.dtgvDSBL.TabIndex = 0;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(364, 380);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(95, 35);
            this.btnQuayLai.TabIndex = 1;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // Form_DanhSachBaiLam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.dtgvDSBL);
            this.Name = "Form_DanhSachBaiLam";
            this.Text = "DanhSachBaiLam";
            this.Load += new System.EventHandler(this.Form_DanhSachBaiLam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSBL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDSBL;
        private System.Windows.Forms.Button btnQuayLai;
    }
}