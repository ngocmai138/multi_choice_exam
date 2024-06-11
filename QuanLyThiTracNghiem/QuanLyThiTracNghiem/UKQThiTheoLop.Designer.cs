namespace QuanLyThiTracNghiem
{
    partial class UKQThiTheoLop
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
            this.cbbMaLop = new System.Windows.Forms.ComboBox();
            this.tabTKTheoLop = new System.Windows.Forms.TabControl();
            this.tabDiemTB = new System.Windows.Forms.TabPage();
            this.dtgDiemTB = new System.Windows.Forms.DataGridView();
            this.tabTyLeDoTruot = new System.Windows.Forms.TabPage();
            this.cbbDiemTruot = new System.Windows.Forms.ComboBox();
            this.dtgTyLeDoTruot = new System.Windows.Forms.DataGridView();
            this.lbDiemTruot = new System.Windows.Forms.Label();
            this.btnTyLeDoTruot = new System.Windows.Forms.Button();
            this.btnXemTK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabTKTheoLop.SuspendLayout();
            this.tabDiemTB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDiemTB)).BeginInit();
            this.tabTyLeDoTruot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTyLeDoTruot)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbMaLop);
            this.panel1.Controls.Add(this.tabTKTheoLop);
            this.panel1.Controls.Add(this.btnXemTK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1157, 473);
            this.panel1.TabIndex = 2;
            // 
            // cbbMaLop
            // 
            this.cbbMaLop.FormattingEnabled = true;
            this.cbbMaLop.Location = new System.Drawing.Point(23, 22);
            this.cbbMaLop.Name = "cbbMaLop";
            this.cbbMaLop.Size = new System.Drawing.Size(276, 28);
            this.cbbMaLop.TabIndex = 1;
            this.cbbMaLop.Text = "(Nhập mã lớp)";
            // 
            // tabTKTheoLop
            // 
            this.tabTKTheoLop.Controls.Add(this.tabDiemTB);
            this.tabTKTheoLop.Controls.Add(this.tabTyLeDoTruot);
            this.tabTKTheoLop.Location = new System.Drawing.Point(13, 64);
            this.tabTKTheoLop.Name = "tabTKTheoLop";
            this.tabTKTheoLop.SelectedIndex = 0;
            this.tabTKTheoLop.Size = new System.Drawing.Size(1125, 388);
            this.tabTKTheoLop.TabIndex = 4;
            // 
            // tabDiemTB
            // 
            this.tabDiemTB.Controls.Add(this.dtgDiemTB);
            this.tabDiemTB.Location = new System.Drawing.Point(4, 29);
            this.tabDiemTB.Name = "tabDiemTB";
            this.tabDiemTB.Padding = new System.Windows.Forms.Padding(3);
            this.tabDiemTB.Size = new System.Drawing.Size(1117, 355);
            this.tabDiemTB.TabIndex = 0;
            this.tabDiemTB.Text = "Điểm trung bình";
            this.tabDiemTB.UseVisualStyleBackColor = true;
            // 
            // dtgDiemTB
            // 
            this.dtgDiemTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDiemTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDiemTB.Location = new System.Drawing.Point(3, 3);
            this.dtgDiemTB.Name = "dtgDiemTB";
            this.dtgDiemTB.RowHeadersWidth = 62;
            this.dtgDiemTB.RowTemplate.Height = 28;
            this.dtgDiemTB.Size = new System.Drawing.Size(1111, 349);
            this.dtgDiemTB.TabIndex = 3;
            // 
            // tabTyLeDoTruot
            // 
            this.tabTyLeDoTruot.Controls.Add(this.cbbDiemTruot);
            this.tabTyLeDoTruot.Controls.Add(this.dtgTyLeDoTruot);
            this.tabTyLeDoTruot.Controls.Add(this.lbDiemTruot);
            this.tabTyLeDoTruot.Controls.Add(this.btnTyLeDoTruot);
            this.tabTyLeDoTruot.Location = new System.Drawing.Point(4, 29);
            this.tabTyLeDoTruot.Name = "tabTyLeDoTruot";
            this.tabTyLeDoTruot.Padding = new System.Windows.Forms.Padding(3);
            this.tabTyLeDoTruot.Size = new System.Drawing.Size(1117, 355);
            this.tabTyLeDoTruot.TabIndex = 1;
            this.tabTyLeDoTruot.Text = "Tỷ lệ đỗ/trượt";
            this.tabTyLeDoTruot.UseVisualStyleBackColor = true;
            // 
            // cbbDiemTruot
            // 
            this.cbbDiemTruot.FormattingEnabled = true;
            this.cbbDiemTruot.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbbDiemTruot.Location = new System.Drawing.Point(101, 8);
            this.cbbDiemTruot.Name = "cbbDiemTruot";
            this.cbbDiemTruot.Size = new System.Drawing.Size(121, 28);
            this.cbbDiemTruot.TabIndex = 5;
            this.cbbDiemTruot.Text = "4";
            // 
            // dtgTyLeDoTruot
            // 
            this.dtgTyLeDoTruot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTyLeDoTruot.Location = new System.Drawing.Point(11, 59);
            this.dtgTyLeDoTruot.Name = "dtgTyLeDoTruot";
            this.dtgTyLeDoTruot.RowHeadersWidth = 62;
            this.dtgTyLeDoTruot.RowTemplate.Height = 28;
            this.dtgTyLeDoTruot.Size = new System.Drawing.Size(1092, 290);
            this.dtgTyLeDoTruot.TabIndex = 4;
            // 
            // lbDiemTruot
            // 
            this.lbDiemTruot.AutoSize = true;
            this.lbDiemTruot.Location = new System.Drawing.Point(7, 11);
            this.lbDiemTruot.Name = "lbDiemTruot";
            this.lbDiemTruot.Size = new System.Drawing.Size(87, 20);
            this.lbDiemTruot.TabIndex = 3;
            this.lbDiemTruot.Text = "Điểm trượt:";
            // 
            // btnTyLeDoTruot
            // 
            this.btnTyLeDoTruot.Location = new System.Drawing.Point(228, 6);
            this.btnTyLeDoTruot.Name = "btnTyLeDoTruot";
            this.btnTyLeDoTruot.Size = new System.Drawing.Size(140, 30);
            this.btnTyLeDoTruot.TabIndex = 6;
            this.btnTyLeDoTruot.Text = "Xem thống kê";
            this.btnTyLeDoTruot.UseVisualStyleBackColor = true;
            this.btnTyLeDoTruot.Click += new System.EventHandler(this.btnTyLeDoTruot_Click);
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
            // UKQThiTheoLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UKQThiTheoLop";
            this.Size = new System.Drawing.Size(1157, 473);
            this.panel1.ResumeLayout(false);
            this.tabTKTheoLop.ResumeLayout(false);
            this.tabDiemTB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDiemTB)).EndInit();
            this.tabTyLeDoTruot.ResumeLayout(false);
            this.tabTyLeDoTruot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTyLeDoTruot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXemTK;
        private System.Windows.Forms.DataGridView dtgDiemTB;
        private System.Windows.Forms.TabControl tabTKTheoLop;
        private System.Windows.Forms.TabPage tabDiemTB;
        private System.Windows.Forms.TabPage tabTyLeDoTruot;
        private System.Windows.Forms.ComboBox cbbDiemTruot;
        private System.Windows.Forms.DataGridView dtgTyLeDoTruot;
        private System.Windows.Forms.Label lbDiemTruot;
        private System.Windows.Forms.Button btnTyLeDoTruot;
        private System.Windows.Forms.ComboBox cbbMaLop;
    }
}
