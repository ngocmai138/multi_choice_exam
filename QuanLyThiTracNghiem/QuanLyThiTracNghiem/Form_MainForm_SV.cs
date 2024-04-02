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
    public partial class Form_MainForm_SV : Form
    {
        private string maSV;
        public Form_MainForm_SV(FormLogin formLogin, string maSV)
        {
            InitializeComponent();
            this.maSV = maSV;
        }

        private void btnLamBaiThi_Click(object sender, EventArgs e)
        {
            Form_ThiTracNghiem thiTracNghiem = new Form_ThiTracNghiem(this, maSV);
            thiTracNghiem.Show();
            this.Hide();
        }

        private void btnXemKetQua_Click(object sender, EventArgs e)
        {
            Form_DanhSachBaiLam dsbl = new Form_DanhSachBaiLam(this, maSV);
            dsbl.Show();
            this.Hide();
        }
    }
}
