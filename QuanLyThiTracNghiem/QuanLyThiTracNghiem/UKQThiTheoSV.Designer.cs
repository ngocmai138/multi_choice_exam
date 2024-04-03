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
            this.dtgThongKe = new System.Windows.Forms.DataGridView();
            this.btnXemTK = new System.Windows.Forms.Button();
            this.txtMaSV = new System.Windows.Forms.TextBox();
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
            this.pnMain.Size = new System.Drawing.Size(741, 453);
            this.pnMain.TabIndex = 3;
            // 
            // dtgThongKe
            // 
            this.dtgThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgThongKe.Location = new System.Drawing.Point(13, 75);
            this.dtgThongKe.Name = "dtgThongKe";
            this.dtgThongKe.RowHeadersWidth = 62;
            this.dtgThongKe.RowTemplate.Height = 28;
            this.dtgThongKe.Size = new System.Drawing.Size(725, 375);
            this.dtgThongKe.TabIndex = 2;
            // 
            // btnXemTK
            // 
            this.btnXemTK.Location = new System.Drawing.Point(322, 22);
            this.btnXemTK.Name = "btnXemTK";
            this.btnXemTK.Size = new System.Drawing.Size(140, 35);
            this.btnXemTK.TabIndex = 1;
            this.btnXemTK.Text = "Xem thống kê";
            this.btnXemTK.UseVisualStyleBackColor = true;
            this.btnXemTK.Click += new System.EventHandler(this.btnXemTK_Click);
            // 
            // txtMaSV
            // 
            this.txtMaSV.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtMaSV.Location = new System.Drawing.Point(13, 22);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(289, 26);
            this.txtMaSV.TabIndex = 0;
            this.txtMaSV.Text = "(Nhập mã sinh viên)";
            this.txtMaSV.Click += new System.EventHandler(this.txtMaSV_Click);
            this.txtMaSV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaSV_KeyDown);
            this.txtMaSV.Leave += new System.EventHandler(this.txtMaSV_Leave);
            // 
            // UKQThiTheoSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnMain);
            this.Name = "UKQThiTheoSV";
            this.Size = new System.Drawing.Size(779, 500);
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
