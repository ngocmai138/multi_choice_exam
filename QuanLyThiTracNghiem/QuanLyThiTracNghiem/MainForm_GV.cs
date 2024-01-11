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
    public partial class MainForm_GV : Form
    {
        private FormLogin dangNhap;
        public MainForm_GV(FormLogin dangNhap)
        {
            InitializeComponent();
            this.dangNhap = dangNhap;
        }

        private void btnQuestionBank_Click(object sender, EventArgs e)
        {
            NganHangCauHoi n = new NganHangCauHoi(this);
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
            NganHangDeThi n = new NganHangDeThi(this);
            this.Hide();
            n.Show();
        }

        private void btnExamManagement_Click(object sender, EventArgs e)
        {
            QuanLyBaiThi quanLyBaiThi = new QuanLyBaiThi(this);
            this.Hide();
            quanLyBaiThi.Show();
        }
    }
}
