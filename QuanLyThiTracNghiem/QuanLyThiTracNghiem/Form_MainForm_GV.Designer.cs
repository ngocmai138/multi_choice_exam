namespace QuanLyThiTracNghiem
{
    partial class Form_MainForm_GV
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
            this.btnQuestionBank = new System.Windows.Forms.Button();
            this.btnExamManagement = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnQuanLyDeThi = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuestionBank
            // 
            this.btnQuestionBank.Location = new System.Drawing.Point(40, 48);
            this.btnQuestionBank.Name = "btnQuestionBank";
            this.btnQuestionBank.Size = new System.Drawing.Size(171, 109);
            this.btnQuestionBank.TabIndex = 0;
            this.btnQuestionBank.Text = "Ngân hàng câu hỏi";
            this.btnQuestionBank.UseVisualStyleBackColor = true;
            this.btnQuestionBank.Click += new System.EventHandler(this.btnQuestionBank_Click);
            // 
            // btnExamManagement
            // 
            this.btnExamManagement.Location = new System.Drawing.Point(307, 48);
            this.btnExamManagement.Name = "btnExamManagement";
            this.btnExamManagement.Size = new System.Drawing.Size(171, 109);
            this.btnExamManagement.TabIndex = 1;
            this.btnExamManagement.Text = "Quản lý bài thi";
            this.btnExamManagement.UseVisualStyleBackColor = true;
            this.btnExamManagement.Click += new System.EventHandler(this.btnExamManagement_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(40, 178);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(171, 109);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "Báo cáo thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(587, 178);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(171, 109);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnQuanLyDeThi
            // 
            this.btnQuanLyDeThi.Location = new System.Drawing.Point(587, 48);
            this.btnQuanLyDeThi.Name = "btnQuanLyDeThi";
            this.btnQuanLyDeThi.Size = new System.Drawing.Size(171, 109);
            this.btnQuanLyDeThi.TabIndex = 2;
            this.btnQuanLyDeThi.Text = "Quản lý đề thi";
            this.btnQuanLyDeThi.UseVisualStyleBackColor = true;
            this.btnQuanLyDeThi.Click += new System.EventHandler(this.btnQuanLyDeThi_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(307, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 109);
            this.button2.TabIndex = 4;
            this.button2.Text = "Quản lý sinh viên";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm_GV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 322);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnQuanLyDeThi);
            this.Controls.Add(this.btnExamManagement);
            this.Controls.Add(this.btnQuestionBank);
            this.Name = "MainForm_GV";
            this.Text = "Chức năng chính của Giáo Viên";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuestionBank;
        private System.Windows.Forms.Button btnExamManagement;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnQuanLyDeThi;
        private System.Windows.Forms.Button button2;
    }
}