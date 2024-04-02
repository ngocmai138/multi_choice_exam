using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThiTracNghiem
{
    public partial class Form_MainForm_GV : Form
    {
        static Form_MainForm_GV mainForm_GV;
        private string tenDN;
        private FormLogin dangNhap;
        public Form_MainForm_GV(FormLogin dangNhap, string tenDN)
        {
            InitializeComponent();
            this.dangNhap = dangNhap;
            this.tenDN = tenDN;
        }

        private void btnQuestionBank_Click(object sender, EventArgs e)
        {
            Form_NganHangCauHoi n = new Form_NganHangCauHoi(this);
            this.Hide();
            n.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            dangNhap.Show();
        }

        private void btnQuanLyDeThi_Click(object sender, EventArgs e)
        {
            Form_NganHangDeThi n = new Form_NganHangDeThi(this);
            this.Hide();
            n.Show();
        }

        private void btnExamManagement_Click(object sender, EventArgs e)
        {
            Form_QuanLyBaiThi quanLyBaiThi = new Form_QuanLyBaiThi(this, tenDN);
            this.Hide();
            quanLyBaiThi.Show();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            Form_BaoCaoThongKe baoCaoThongKe = new Form_BaoCaoThongKe(this);
            this.Hide();
            baoCaoThongKe.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_QLSinhVien qlSV = new Form_QLSinhVien(this);
            this.Hide();
            qlSV.Show();
        }
    }
}
