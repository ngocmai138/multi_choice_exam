namespace QuanLyThiTracNghiem
{
    partial class Form_NganHangDeThi
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
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cbbTimKiem = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThemTuDong = new System.Windows.Forms.Button();
            this.pnNHDT = new System.Windows.Forms.Panel();
            this.pnDSCH = new System.Windows.Forms.FlowLayoutPanel();
            this.lbSoCH = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgCauHoi = new System.Windows.Forms.DataGridView();
            this.dtgDeThi = new System.Windows.Forms.DataGridView();
            this.btnXoaDe = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.pnNHDT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCauHoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDeThi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(175, 3);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(206, 26);
            this.txtTimKiem.TabIndex = 0;
            // 
            // cbbTimKiem
            // 
            this.cbbTimKiem.FormattingEnabled = true;
            this.cbbTimKiem.Items.AddRange(new object[] {
            "Mã đề",
            "Nội dung câu hỏi"});
            this.cbbTimKiem.Location = new System.Drawing.Point(3, 3);
            this.cbbTimKiem.Name = "cbbTimKiem";
            this.cbbTimKiem.Size = new System.Drawing.Size(166, 28);
            this.cbbTimKiem.TabIndex = 1;
            this.cbbTimKiem.Text = "(Nội dung tìm kiếm)";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(387, 3);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(114, 33);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnThemTuDong
            // 
            this.btnThemTuDong.Location = new System.Drawing.Point(520, 317);
            this.btnThemTuDong.Name = "btnThemTuDong";
            this.btnThemTuDong.Size = new System.Drawing.Size(139, 34);
            this.btnThemTuDong.TabIndex = 2;
            this.btnThemTuDong.Text = "Thêm tự động";
            this.btnThemTuDong.UseVisualStyleBackColor = true;
            this.btnThemTuDong.Click += new System.EventHandler(this.btnThemTuDong_Click);
            // 
            // pnNHDT
            // 
            this.pnNHDT.Controls.Add(this.pnDSCH);
            this.pnNHDT.Controls.Add(this.lbSoCH);
            this.pnNHDT.Controls.Add(this.label2);
            this.pnNHDT.Controls.Add(this.label1);
            this.pnNHDT.Controls.Add(this.dtgCauHoi);
            this.pnNHDT.Controls.Add(this.dtgDeThi);
            this.pnNHDT.Controls.Add(this.cbbTimKiem);
            this.pnNHDT.Controls.Add(this.btnXoaDe);
            this.pnNHDT.Controls.Add(this.btnThem);
            this.pnNHDT.Controls.Add(this.btnXem);
            this.pnNHDT.Controls.Add(this.btnThemTuDong);
            this.pnNHDT.Controls.Add(this.txtTimKiem);
            this.pnNHDT.Controls.Add(this.btnQuayLai);
            this.pnNHDT.Controls.Add(this.btnTimKiem);
            this.pnNHDT.Location = new System.Drawing.Point(12, 12);
            this.pnNHDT.Name = "pnNHDT";
            this.pnNHDT.Size = new System.Drawing.Size(790, 435);
            this.pnNHDT.TabIndex = 3;
            // 
            // pnDSCH
            // 
            this.pnDSCH.Location = new System.Drawing.Point(520, 145);
            this.pnDSCH.Name = "pnDSCH";
            this.pnDSCH.Size = new System.Drawing.Size(246, 126);
            this.pnDSCH.TabIndex = 9;
            // 
            // lbSoCH
            // 
            this.lbSoCH.AutoSize = true;
            this.lbSoCH.Location = new System.Drawing.Point(603, 84);
            this.lbSoCH.Name = "lbSoCH";
            this.lbSoCH.Size = new System.Drawing.Size(56, 20);
            this.lbSoCH.TabIndex = 8;
            this.lbSoCH.Text = "số câu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(516, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Danh sách câu hỏi: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(516, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Số câu hỏi:";
            // 
            // dtgCauHoi
            // 
            this.dtgCauHoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCauHoi.Location = new System.Drawing.Point(176, 84);
            this.dtgCauHoi.Name = "dtgCauHoi";
            this.dtgCauHoi.RowHeadersWidth = 62;
            this.dtgCauHoi.RowTemplate.Height = 28;
            this.dtgCauHoi.Size = new System.Drawing.Size(321, 342);
            this.dtgCauHoi.TabIndex = 6;
            // 
            // dtgDeThi
            // 
            this.dtgDeThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDeThi.Location = new System.Drawing.Point(4, 84);
            this.dtgDeThi.Name = "dtgDeThi";
            this.dtgDeThi.RowHeadersWidth = 62;
            this.dtgDeThi.RowTemplate.Height = 28;
            this.dtgDeThi.Size = new System.Drawing.Size(165, 342);
            this.dtgDeThi.TabIndex = 3;
            this.dtgDeThi.SelectionChanged += new System.EventHandler(this.dtgDeThi_SelectionChanged);
            // 
            // btnXoaDe
            // 
            this.btnXoaDe.Location = new System.Drawing.Point(520, 357);
            this.btnXoaDe.Name = "btnXoaDe";
            this.btnXoaDe.Size = new System.Drawing.Size(139, 34);
            this.btnXoaDe.TabIndex = 2;
            this.btnXoaDe.Text = "Xóa Đề thi";
            this.btnXoaDe.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(520, 277);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(139, 34);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(507, 3);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(139, 34);
            this.btnXem.TabIndex = 2;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(652, 3);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(114, 33);
            this.btnQuayLai.TabIndex = 2;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // NganHangDeThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.pnNHDT);
            this.Name = "NganHangDeThi";
            this.Text = "NganHangDeThi";
            this.pnNHDT.ResumeLayout(false);
            this.pnNHDT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCauHoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDeThi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cbbTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThemTuDong;
        private System.Windows.Forms.Panel pnNHDT;
        private System.Windows.Forms.DataGridView dtgDeThi;
        private System.Windows.Forms.DataGridView dtgCauHoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoaDe;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSoCH;
        private System.Windows.Forms.FlowLayoutPanel pnDSCH;
        private System.Windows.Forms.Label label2;
    }
}