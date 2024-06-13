namespace QuanLyThiTracNghiem
{
    partial class UC_ChiTietBaiLam
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
            this.dtgXemLaiCTBL = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgXemLaiCTBL)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgXemLaiCTBL
            // 
            this.dtgXemLaiCTBL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgXemLaiCTBL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgXemLaiCTBL.Location = new System.Drawing.Point(0, 0);
            this.dtgXemLaiCTBL.Name = "dtgXemLaiCTBL";
            this.dtgXemLaiCTBL.RowHeadersWidth = 62;
            this.dtgXemLaiCTBL.RowTemplate.Height = 28;
            this.dtgXemLaiCTBL.Size = new System.Drawing.Size(1127, 534);
            this.dtgXemLaiCTBL.TabIndex = 1;
            // 
            // UC_ChiTietBaiLam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtgXemLaiCTBL);
            this.Name = "UC_ChiTietBaiLam";
            this.Size = new System.Drawing.Size(1127, 534);
            this.Load += new System.EventHandler(this.UC_ChiTietBaiLam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgXemLaiCTBL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgXemLaiCTBL;
    }
}
