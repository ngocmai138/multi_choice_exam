﻿namespace QuanLyThiTracNghiem
{
    partial class UC_NganHangCauHoi
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
            this.txtCauHoi = new System.Windows.Forms.RichTextBox();
            this.dtgDA = new System.Windows.Forms.DataGridView();
            this.dtgNHCH = new System.Windows.Forms.DataGridView();
            this.cbbTimKiem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.cb4 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.txtAnswer4 = new System.Windows.Forms.TextBox();
            this.lbAnswer4 = new System.Windows.Forms.Label();
            this.txtAnswer3 = new System.Windows.Forms.TextBox();
            this.lbAnswer3 = new System.Windows.Forms.Label();
            this.txtAnswer2 = new System.Windows.Forms.TextBox();
            this.lbAnswer2 = new System.Windows.Forms.Label();
            this.txtAnswer1 = new System.Windows.Forms.TextBox();
            this.lbAnswer1 = new System.Windows.Forms.Label();
            this.lbQuestion = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNHCH)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCauHoi);
            this.panel1.Controls.Add(this.dtgDA);
            this.panel1.Controls.Add(this.dtgNHCH);
            this.panel1.Controls.Add(this.cbbTimKiem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cb3);
            this.panel1.Controls.Add(this.cb4);
            this.panel1.Controls.Add(this.cb2);
            this.panel1.Controls.Add(this.cb1);
            this.panel1.Controls.Add(this.txtAnswer4);
            this.panel1.Controls.Add(this.lbAnswer4);
            this.panel1.Controls.Add(this.txtAnswer3);
            this.panel1.Controls.Add(this.lbAnswer3);
            this.panel1.Controls.Add(this.txtAnswer2);
            this.panel1.Controls.Add(this.lbAnswer2);
            this.panel1.Controls.Add(this.txtAnswer1);
            this.panel1.Controls.Add(this.lbAnswer1);
            this.panel1.Controls.Add(this.lbQuestion);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.btnXem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1166, 588);
            this.panel1.TabIndex = 1;
            // 
            // txtCauHoi
            // 
            this.txtCauHoi.Location = new System.Drawing.Point(760, 76);
            this.txtCauHoi.Name = "txtCauHoi";
            this.txtCauHoi.Size = new System.Drawing.Size(332, 171);
            this.txtCauHoi.TabIndex = 4;
            this.txtCauHoi.Text = "";
            // 
            // dtgDA
            // 
            this.dtgDA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDA.Location = new System.Drawing.Point(24, 323);
            this.dtgDA.Name = "dtgDA";
            this.dtgDA.RowHeadersWidth = 62;
            this.dtgDA.RowTemplate.Height = 28;
            this.dtgDA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDA.Size = new System.Drawing.Size(585, 249);
            this.dtgDA.TabIndex = 17;
            // 
            // dtgNHCH
            // 
            this.dtgNHCH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgNHCH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNHCH.Location = new System.Drawing.Point(24, 76);
            this.dtgNHCH.Name = "dtgNHCH";
            this.dtgNHCH.RowHeadersWidth = 62;
            this.dtgNHCH.RowTemplate.Height = 28;
            this.dtgNHCH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgNHCH.Size = new System.Drawing.Size(585, 235);
            this.dtgNHCH.TabIndex = 19;
            this.dtgNHCH.SelectionChanged += new System.EventHandler(this.dtgNHCH_SelectionChanged);
            // 
            // cbbTimKiem
            // 
            this.cbbTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimKiem.FormattingEnabled = true;
            this.cbbTimKiem.Items.AddRange(new object[] {
            "mã câu hỏi",
            "nội dung câu hỏi"});
            this.cbbTimKiem.Location = new System.Drawing.Point(15, 15);
            this.cbbTimKiem.Name = "cbbTimKiem";
            this.cbbTimKiem.Size = new System.Drawing.Size(207, 28);
            this.cbbTimKiem.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1098, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Đúng";
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.Location = new System.Drawing.Point(1102, 324);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(22, 21);
            this.cb3.TabIndex = 10;
            this.cb3.UseVisualStyleBackColor = true;
            // 
            // cb4
            // 
            this.cb4.AutoSize = true;
            this.cb4.Location = new System.Drawing.Point(1102, 359);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(22, 21);
            this.cb4.TabIndex = 12;
            this.cb4.UseVisualStyleBackColor = true;
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Location = new System.Drawing.Point(1102, 295);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(22, 21);
            this.cb2.TabIndex = 8;
            this.cb2.UseVisualStyleBackColor = true;
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(1102, 260);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(22, 21);
            this.cb1.TabIndex = 6;
            this.cb1.UseVisualStyleBackColor = true;
            // 
            // txtAnswer4
            // 
            this.txtAnswer4.Location = new System.Drawing.Point(760, 355);
            this.txtAnswer4.Name = "txtAnswer4";
            this.txtAnswer4.Size = new System.Drawing.Size(332, 26);
            this.txtAnswer4.TabIndex = 11;
            // 
            // lbAnswer4
            // 
            this.lbAnswer4.AutoSize = true;
            this.lbAnswer4.Location = new System.Drawing.Point(683, 355);
            this.lbAnswer4.Name = "lbAnswer4";
            this.lbAnswer4.Size = new System.Drawing.Size(74, 20);
            this.lbAnswer4.TabIndex = 4;
            this.lbAnswer4.Text = "Đáp án 4";
            // 
            // txtAnswer3
            // 
            this.txtAnswer3.Location = new System.Drawing.Point(760, 323);
            this.txtAnswer3.Name = "txtAnswer3";
            this.txtAnswer3.Size = new System.Drawing.Size(332, 26);
            this.txtAnswer3.TabIndex = 9;
            // 
            // lbAnswer3
            // 
            this.lbAnswer3.AutoSize = true;
            this.lbAnswer3.Location = new System.Drawing.Point(683, 323);
            this.lbAnswer3.Name = "lbAnswer3";
            this.lbAnswer3.Size = new System.Drawing.Size(74, 20);
            this.lbAnswer3.TabIndex = 4;
            this.lbAnswer3.Text = "Đáp án 3";
            // 
            // txtAnswer2
            // 
            this.txtAnswer2.Location = new System.Drawing.Point(760, 291);
            this.txtAnswer2.Name = "txtAnswer2";
            this.txtAnswer2.Size = new System.Drawing.Size(332, 26);
            this.txtAnswer2.TabIndex = 7;
            // 
            // lbAnswer2
            // 
            this.lbAnswer2.AutoSize = true;
            this.lbAnswer2.Location = new System.Drawing.Point(683, 291);
            this.lbAnswer2.Name = "lbAnswer2";
            this.lbAnswer2.Size = new System.Drawing.Size(74, 20);
            this.lbAnswer2.TabIndex = 4;
            this.lbAnswer2.Text = "Đáp án 2";
            // 
            // txtAnswer1
            // 
            this.txtAnswer1.Location = new System.Drawing.Point(760, 259);
            this.txtAnswer1.Name = "txtAnswer1";
            this.txtAnswer1.Size = new System.Drawing.Size(332, 26);
            this.txtAnswer1.TabIndex = 5;
            // 
            // lbAnswer1
            // 
            this.lbAnswer1.AutoSize = true;
            this.lbAnswer1.Location = new System.Drawing.Point(683, 259);
            this.lbAnswer1.Name = "lbAnswer1";
            this.lbAnswer1.Size = new System.Drawing.Size(74, 20);
            this.lbAnswer1.TabIndex = 4;
            this.lbAnswer1.Text = "Đáp án 1";
            // 
            // lbQuestion
            // 
            this.lbQuestion.AutoSize = true;
            this.lbQuestion.Location = new System.Drawing.Point(683, 79);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(63, 20);
            this.lbQuestion.TabIndex = 4;
            this.lbQuestion.Text = "Câu hỏi";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(228, 15);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(278, 26);
            this.txtTimKiem.TabIndex = 1;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(971, 399);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(88, 34);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(877, 399);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(88, 34);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(783, 399);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(88, 34);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(526, 11);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(129, 34);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(679, 399);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(98, 34);
            this.btnXem.TabIndex = 13;
            this.btnXem.Text = "Xem tất cả";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // UC_NganHangCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UC_NganHangCauHoi";
            this.Size = new System.Drawing.Size(1166, 588);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNHCH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox txtCauHoi;
        private System.Windows.Forms.DataGridView dtgDA;
        private System.Windows.Forms.DataGridView dtgNHCH;
        private System.Windows.Forms.ComboBox cbbTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb3;
        private System.Windows.Forms.CheckBox cb4;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.TextBox txtAnswer4;
        private System.Windows.Forms.Label lbAnswer4;
        private System.Windows.Forms.TextBox txtAnswer3;
        private System.Windows.Forms.Label lbAnswer3;
        private System.Windows.Forms.TextBox txtAnswer2;
        private System.Windows.Forms.Label lbAnswer2;
        private System.Windows.Forms.TextBox txtAnswer1;
        private System.Windows.Forms.Label lbAnswer1;
        private System.Windows.Forms.Label lbQuestion;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXem;
    }
}
