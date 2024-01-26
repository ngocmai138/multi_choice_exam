namespace QuanLyThiTracNghiem
{
    partial class UKQThiTheoSV
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
            this.pnMain = new System.Windows.Forms.Panel();
            this.btnXemTK = new System.Windows.Forms.Button();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.dtgThongKe = new System.Windows.Forms.DataGridView();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.dtgThongKe);
            this.pnMain.Controls.Add(this.btnXemTK);
            this.pnMain.Controls.Add(this.txtMaSV);
            this.pnMain.Location = new System.Drawing.Point(17, 24);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(501, 362);
            this.pnMain.TabIndex = 3;
            // 
            // btnXemTK
            // 
            this.btnXemTK.Location = new System.Drawing.Point(322, 22);
            this.btnXemTK.Name = "btnXemTK";
            this.btnXemTK.Size = new System.Drawing.Size(140, 30);
            this.btnXemTK.TabIndex = 2;
            this.btnXemTK.Text = "Xem thống kê";
            this.btnXemTK.UseVisualStyleBackColor = true;
            this.btnXemTK.Click += new System.EventHandler(this.btnXemTK_Click);
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(13, 22);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(289, 26);
            this.txtMaSV.TabIndex = 1;
            this.txtMaSV.Text = "(Nhập mã sinh viên)";
            // 
            // dtgThongKe
            // 
            this.dtgThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgThongKe.Location = new System.Drawing.Point(13, 55);
            this.dtgThongKe.Name = "dtgThongKe";
            this.dtgThongKe.RowHeadersWidth = 62;
            this.dtgThongKe.RowTemplate.Height = 28;
            this.dtgThongKe.Size = new System.Drawing.Size(449, 277);
            this.dtgThongKe.TabIndex = 3;
            // 
            // UKQThiTheoSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnMain);
            this.Name = "UKQThiTheoSV";
            this.Size = new System.Drawing.Size(530, 395);
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Button btnXemTK;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.DataGridView dtgThongKe;
    }
}
