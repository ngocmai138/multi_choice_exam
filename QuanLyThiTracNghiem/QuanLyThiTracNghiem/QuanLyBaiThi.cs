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
    public partial class QuanLyBaiThi : Form
    {
        private MainForm_GV mainForm_GV;
        private string tenDN;
        public QuanLyBaiThi(MainForm_GV mainForm_GV, string tenDN)
        {
            InitializeComponent();
            this.mainForm_GV = mainForm_GV;
            this.tenDN = tenDN;
            btnXem_Click(this, new EventArgs());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            mainForm_GV.Show();
            this.Hide();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            BUS_BaiLam.Instance.XemDSBaiLam(dtgBaiLam);
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            BUS_BaiLam.Instance.TimKiem(pnBaiThi);
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            string maKQ = BUS_BaiLam.Instance.LayMaBaiLam(dtgBaiLam);
            ChiTietBaiLam chiTietBaiLam = new ChiTietBaiLam(maKQ, tenDN);
            chiTietBaiLam.Show();
        }
    }
}
