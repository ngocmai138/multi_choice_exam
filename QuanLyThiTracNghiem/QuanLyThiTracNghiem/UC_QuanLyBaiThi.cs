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
    public partial class UC_QuanLyBaiThi : UserControl
    {
        private string tenDN;
        public UC_QuanLyBaiThi(string tenDN)
        {
            InitializeComponent();
            this.tenDN = tenDN;
            btnXem_Click(this, new EventArgs());
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            BUS_BaiLam.Instance.TimKiem(pnBaiThi);
        }

        private void btnXemBaiLam_Click(object sender, EventArgs e)
        {
            string maKQ = BUS_BaiLam.Instance.LayMaBaiLam(dtgBaiLam);
            Form_ChiTietBaiLam chiTietBaiLam = new Form_ChiTietBaiLam(maKQ, tenDN);
            chiTietBaiLam.Show();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            BUS_BaiLam.Instance.XemDSBaiLam(dtgBaiLam);
        }
    }
}
