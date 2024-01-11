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
    public partial class NopBai : Form
    {
        public NopBai(float diem, BaiThi_DTO baiThi)
        {
            InitializeComponent();
            ThiTN_BUS.Instance.LuuBaiThi(baiThi);
            lbKetQua.Text = diem.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
