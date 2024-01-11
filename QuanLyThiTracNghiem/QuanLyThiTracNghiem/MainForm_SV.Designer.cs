namespace QuanLyThiTracNghiem
{
    partial class MainForm_SV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLamBaiThi = new System.Windows.Forms.Button();
            this.btnXemKetQua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLamBaiThi
            // 
            this.btnLamBaiThi.Location = new System.Drawing.Point(63, 58);
            this.btnLamBaiThi.Name = "btnLamBaiThi";
            this.btnLamBaiThi.Size = new System.Drawing.Size(163, 64);
            this.btnLamBaiThi.TabIndex = 0;
            this.btnLamBaiThi.Text = "Làm bài thi";
            this.btnLamBaiThi.UseVisualStyleBackColor = true;
            this.btnLamBaiThi.Click += new System.EventHandler(this.btnLamBaiThi_Click);
            // 
            // btnXemKetQua
            // 
            this.btnXemKetQua.Location = new System.Drawing.Point(269, 58);
            this.btnXemKetQua.Name = "btnXemKetQua";
            this.btnXemKetQua.Size = new System.Drawing.Size(163, 64);
            this.btnXemKetQua.TabIndex = 0;
            this.btnXemKetQua.Text = "Xem kết quả";
            this.btnXemKetQua.UseVisualStyleBackColor = true;
            // 
            // MainForm_SV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 170);
            this.Controls.Add(this.btnXemKetQua);
            this.Controls.Add(this.btnLamBaiThi);
            this.Name = "MainForm_SV";
            this.Text = "MainForm_SV";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLamBaiThi;
        private System.Windows.Forms.Button btnXemKetQua;
    }
}