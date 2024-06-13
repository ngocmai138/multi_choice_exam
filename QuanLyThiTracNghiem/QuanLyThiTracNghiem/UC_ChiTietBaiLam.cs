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
    public partial class UC_ChiTietBaiLam : UserControl
    {
        private String maKQ;
        UC_KetQuaThi dsbl;
        public UC_ChiTietBaiLam(String maKQ)
        {
            InitializeComponent();
            this.maKQ = maKQ;
        }

        private void UC_ChiTietBaiLam_Load(object sender, EventArgs e)
        {
            BUS_ThiTN.Instance.XemLaiChiTietBaiLam(dtgXemLaiCTBL, maKQ);
        }
    }
}
