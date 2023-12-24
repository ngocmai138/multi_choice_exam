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
    public partial class MainForm : Form
    {
        private FormLogin dangNhap;
        public MainForm(FormLogin dangNhap)
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
    }
}
