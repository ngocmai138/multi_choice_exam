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
    public partial class UThongKe_NHCH : UserControl
    {
        public UThongKe_NHCH()
        {
            InitializeComponent();
        }

        private void UThongKe_NHCH_Load(object sender, EventArgs e)
        {
            BUS_ThongKe.Instance.ThongKeTheoNHCH(dtgThongKeNHCH);
        }
    }
}
