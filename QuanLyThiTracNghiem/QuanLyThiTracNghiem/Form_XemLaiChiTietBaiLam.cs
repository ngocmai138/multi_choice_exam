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
    public partial class Form_XemLaiChiTietBaiLam : Form
    {
        private String maKQ;
        Form_DanhSachBaiLam dsbl;
        public Form_XemLaiChiTietBaiLam(Form_DanhSachBaiLam dsbl,String maKQ)
        {
            InitializeComponent();
            this.maKQ = maKQ;
            this.dsbl = dsbl;
        }

        private void Form_XemLaiChiTietBaiLam_Load(object sender, EventArgs e)
        {
            BUS_ThiTN.Instance.XemLaiChiTietBaiLam(dtgXemLaiCTBL,maKQ);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            dsbl.Show();
        }
    }
}
