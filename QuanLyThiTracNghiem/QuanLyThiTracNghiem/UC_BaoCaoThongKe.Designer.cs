﻿namespace QuanLyThiTracNghiem
{
    partial class UC_BaoCaoThongKe
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnTK_NHCH = new System.Windows.Forms.Panel();
            this.btnKQTheoSV = new System.Windows.Forms.Button();
            this.pnKQTheoLop = new System.Windows.Forms.Panel();
            this.btnKQTheoLop = new System.Windows.Forms.Button();
            this.pnKQTheoSV = new System.Windows.Forms.Panel();
            this.btnTK_NHCH = new System.Windows.Forms.Button();
            this.pnMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnTK_NHCH.SuspendLayout();
            this.pnKQTheoLop.SuspendLayout();
            this.pnKQTheoSV.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33344F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33311F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33344F));
            this.tableLayoutPanel1.Controls.Add(this.pnTK_NHCH, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnKQTheoLop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnKQTheoSV, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1188, 100);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pnTK_NHCH
            // 
            this.pnTK_NHCH.BackColor = System.Drawing.Color.Silver;
            this.pnTK_NHCH.Controls.Add(this.btnKQTheoSV);
            this.pnTK_NHCH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTK_NHCH.Location = new System.Drawing.Point(399, 3);
            this.pnTK_NHCH.Name = "pnTK_NHCH";
            this.pnTK_NHCH.Size = new System.Drawing.Size(389, 94);
            this.pnTK_NHCH.TabIndex = 5;
            // 
            // btnKQTheoSV
            // 
            this.btnKQTheoSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKQTheoSV.FlatAppearance.BorderSize = 0;
            this.btnKQTheoSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKQTheoSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKQTheoSV.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnKQTheoSV.Location = new System.Drawing.Point(0, 0);
            this.btnKQTheoSV.Name = "btnKQTheoSV";
            this.btnKQTheoSV.Size = new System.Drawing.Size(389, 94);
            this.btnKQTheoSV.TabIndex = 4;
            this.btnKQTheoSV.Text = "Kết quả thi theo SINH VIÊN";
            this.btnKQTheoSV.UseVisualStyleBackColor = true;
            this.btnKQTheoSV.Click += new System.EventHandler(this.btnKQTheoSV_Click);
            // 
            // pnKQTheoLop
            // 
            this.pnKQTheoLop.BackColor = System.Drawing.Color.Silver;
            this.pnKQTheoLop.Controls.Add(this.btnKQTheoLop);
            this.pnKQTheoLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnKQTheoLop.Location = new System.Drawing.Point(3, 3);
            this.pnKQTheoLop.Name = "pnKQTheoLop";
            this.pnKQTheoLop.Size = new System.Drawing.Size(390, 94);
            this.pnKQTheoLop.TabIndex = 2;
            // 
            // btnKQTheoLop
            // 
            this.btnKQTheoLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKQTheoLop.FlatAppearance.BorderSize = 0;
            this.btnKQTheoLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKQTheoLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKQTheoLop.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnKQTheoLop.Location = new System.Drawing.Point(0, 0);
            this.btnKQTheoLop.Name = "btnKQTheoLop";
            this.btnKQTheoLop.Size = new System.Drawing.Size(390, 94);
            this.btnKQTheoLop.TabIndex = 1;
            this.btnKQTheoLop.Text = "Kết quả thi theo LỚP";
            this.btnKQTheoLop.UseVisualStyleBackColor = true;
            this.btnKQTheoLop.Click += new System.EventHandler(this.btnKQTheoLop_Click);
            // 
            // pnKQTheoSV
            // 
            this.pnKQTheoSV.BackColor = System.Drawing.Color.Silver;
            this.pnKQTheoSV.Controls.Add(this.btnTK_NHCH);
            this.pnKQTheoSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnKQTheoSV.Location = new System.Drawing.Point(794, 3);
            this.pnKQTheoSV.Name = "pnKQTheoSV";
            this.pnKQTheoSV.Size = new System.Drawing.Size(391, 94);
            this.pnKQTheoSV.TabIndex = 4;
            // 
            // btnTK_NHCH
            // 
            this.btnTK_NHCH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTK_NHCH.FlatAppearance.BorderSize = 0;
            this.btnTK_NHCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTK_NHCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTK_NHCH.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnTK_NHCH.Location = new System.Drawing.Point(0, 0);
            this.btnTK_NHCH.Name = "btnTK_NHCH";
            this.btnTK_NHCH.Size = new System.Drawing.Size(391, 94);
            this.btnTK_NHCH.TabIndex = 2;
            this.btnTK_NHCH.Text = "Thống kê ngân hàng câu hỏi";
            this.btnTK_NHCH.UseVisualStyleBackColor = true;
            this.btnTK_NHCH.Click += new System.EventHandler(this.btnTK_NHCH_Click);
            // 
            // pnMain
            // 
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 100);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1188, 577);
            this.pnMain.TabIndex = 2;
            // 
            // UC_BaoCaoThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UC_BaoCaoThongKe";
            this.Size = new System.Drawing.Size(1188, 677);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnTK_NHCH.ResumeLayout(false);
            this.pnKQTheoLop.ResumeLayout(false);
            this.pnKQTheoSV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnKQTheoLop;
        private System.Windows.Forms.Button btnKQTheoLop;
        private System.Windows.Forms.Panel pnKQTheoSV;
        private System.Windows.Forms.Button btnTK_NHCH;
        private System.Windows.Forms.Panel pnTK_NHCH;
        private System.Windows.Forms.Button btnKQTheoSV;
        private System.Windows.Forms.Panel pnMain;
    }
}
