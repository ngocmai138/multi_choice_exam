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
        public NopBai(DTO_BaiThi baiThi, DTO_DeThi de)
        {
            InitializeComponent();
            lbKetQua.Text = BUS_ThiTN.Instance.LuuBaiThi(baiThi, de).ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
