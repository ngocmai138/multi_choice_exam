namespace QuanLyThiTracNghiem
{
    partial class UC_DanhSachBaiLam
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
            this.dtgvDSBL = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSBL)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvDSBL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1166, 585);
            this.panel1.TabIndex = 0;
            // 
            // dtgvDSBL
            // 
            this.dtgvDSBL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSBL.Location = new System.Drawing.Point(18, 21);
            this.dtgvDSBL.Name = "dtgvDSBL";
            this.dtgvDSBL.RowHeadersWidth = 62;
            this.dtgvDSBL.RowTemplate.Height = 28;
            this.dtgvDSBL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDSBL.Size = new System.Drawing.Size(1127, 534);
            this.dtgvDSBL.TabIndex = 2;
            this.dtgvDSBL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDSBL_CellClick);
            // 
            // UC_DanhSachBaiLam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UC_DanhSachBaiLam";
            this.Size = new System.Drawing.Size(1166, 585);
            this.Load += new System.EventHandler(this.UC_DanhSachBaiLam_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSBL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvDSBL;
    }
}
