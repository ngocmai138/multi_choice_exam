namespace QuanLyThiTracNghiem
{
    partial class UC_KetQuaThi
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
            this.dtgvDSBL = new System.Windows.Forms.DataGridView();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSBL)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.dtgvDSBL);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1166, 585);
            this.pnMain.TabIndex = 0;
            // 
            // dtgvDSBL
            // 
            this.dtgvDSBL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            // UC_KetQuaThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnMain);
            this.Name = "UC_KetQuaThi";
            this.Size = new System.Drawing.Size(1166, 585);
            this.Load += new System.EventHandler(this.UC_DanhSachBaiLam_Load);
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSBL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.DataGridView dtgvDSBL;
    }
}
