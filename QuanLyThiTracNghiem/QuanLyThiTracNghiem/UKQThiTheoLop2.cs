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
    public partial class UKQThiTheoLop2 : UserControl
    {
        public UKQThiTheoLop2()
        {
            InitializeComponent();
            cbbMaLop.DataSource = DAO_ThongKe.Instance.DSMaLop();
            cbbMaLop.DisplayMember = "maLop";
            cbbMaLop.ValueMember = "maLop";
        }

        private void btnXemTK_Click(object sender, EventArgs e)
        {
            BUS_ThongKe.Instance.ThongKeDTBTheoLop(rpvDiemTB, cbbMaLop.Text);
        }

        private void btnTyLeDoTruot_Click(object sender, EventArgs e)
        {
            BUS_ThongKe.Instance.TyLeDatTruotTheoLop(dtgTyLeDoTruot, cbbMaLop.Text, Int32.Parse(cbbDiemTruot.Text));
        }
    }
}
