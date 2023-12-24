namespace QuanLyThiTracNghiem
{
    partial class MainForm
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
            this.btnStatistic = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuestionBank
            // 
            this.btnQuestionBank.Location = new System.Drawing.Point(50, 54);
            this.btnQuestionBank.Name = "btnQuestionBank";
            this.btnQuestionBank.Size = new System.Drawing.Size(163, 90);
            this.btnQuestionBank.TabIndex = 0;
            this.btnQuestionBank.Text = "Ngân hàng câu hỏi";
            this.btnQuestionBank.UseVisualStyleBackColor = true;
            this.btnQuestionBank.Click += new System.EventHandler(this.btnQuestionBank_Click);
            // 
            // btnExamManagement
            // 
            this.btnExamManagement.Location = new System.Drawing.Point(317, 54);
            this.btnExamManagement.Name = "btnExamManagement";
            this.btnExamManagement.Size = new System.Drawing.Size(163, 90);
            this.btnExamManagement.TabIndex = 0;
            this.btnExamManagement.Text = "Quản lý bài thi";
            this.btnExamManagement.UseVisualStyleBackColor = true;
            // 
            // btnStatistic
            // 
            this.btnStatistic.Location = new System.Drawing.Point(50, 195);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(163, 90);
            this.btnStatistic.TabIndex = 0;
            this.btnStatistic.Text = "Báo cáo thống kê";
            this.btnStatistic.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(317, 195);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(163, 90);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 344);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnStatistic);
            this.Controls.Add(this.btnExamManagement);
            this.Controls.Add(this.btnQuestionBank);
            this.Name = "MainForm";
            this.Text = "Chức năng chính";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuestionBank;
        private System.Windows.Forms.Button btnExamManagement;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.Button btnThoat;
    }
}