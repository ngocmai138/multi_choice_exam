namespace QuanLyThiTracNghiem
{
    partial class UThongKe_NHCH
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
            this.dtgThongKeNHCH = new System.Windows.Forms.DataGridView();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgThongKeNHCH)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.dtgThongKeNHCH);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1157, 473);
            this.pnMain.TabIndex = 4;
            // 
            // dtgThongKeNHCH
            // 
            this.dtgThongKeNHCH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgThongKeNHCH.Location = new System.Drawing.Point(12, 14);
            this.dtgThongKeNHCH.Name = "dtgThongKeNHCH";
            this.dtgThongKeNHCH.RowHeadersWidth = 62;
            this.dtgThongKeNHCH.RowTemplate.Height = 28;
            this.dtgThongKeNHCH.Size = new System.Drawing.Size(1129, 441);
            this.dtgThongKeNHCH.TabIndex = 0;
            // 
            // UThongKe_NHCH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnMain);
            this.Name = "UThongKe_NHCH";
            this.Size = new System.Drawing.Size(1157, 473);
            this.Load += new System.EventHandler(this.UThongKe_NHCH_Load);
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgThongKeNHCH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.DataGridView dtgThongKeNHCH;
    }
}
