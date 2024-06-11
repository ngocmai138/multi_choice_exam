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
    public partial class UC_NopBai : UserControl
    {
        String maKQ;
        public UC_NopBai(DTO_BaiThi baiThi, DTO_DeThi de)
        {
            InitializeComponent();
            lbKetQua.Text = BUS_ThiTN.Instance.LuuBaiThi(baiThi, de).ToString();
            maKQ = baiThi.MaKQ;
        }

        private void UC_NopBai_Load(object sender, EventArgs e)
        {
            BUS_ThiTN.Instance.ChiTietBaiLam(dtgvChiTietBaiLam, maKQ);
        }
    }
}
