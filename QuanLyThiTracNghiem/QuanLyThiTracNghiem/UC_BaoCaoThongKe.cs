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
    public partial class UC_BaoCaoThongKe : UserControl
    {
        private string btnFocus;
        public UC_BaoCaoThongKe(string btnFocus)
        {
            InitializeComponent();
            this.btnFocus = btnFocus;
            openPanel(btnFocus);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnMain.Controls.Clear();
            pnMain.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void openPanel(string btnFocus)
        {
            switch(btnFocus)
            {
                case "Lop":
                    btnKQTheoLop_Click(this, EventArgs.Empty); break;
                case "SV":
                    btnKQTheoSV_Click(this, EventArgs.Empty); break;
                case "NHCH":
                    btnTK_NHCH_Click(this, EventArgs.Empty); break;
            }
        }
        private void btnKQTheoLop_Click(object sender, EventArgs e)
        {
            UKQThiTheoLop uc = new UKQThiTheoLop();
            addUserControl(uc);
        }

        private void btnKQTheoSV_Click(object sender, EventArgs e)
        {
            UKQThiTheoSV uc = new UKQThiTheoSV();
            addUserControl(uc);
        }

        private void btnTK_NHCH_Click(object sender, EventArgs e)
        {
            UThongKe_NHCH2 uc = new UThongKe_NHCH2();
            addUserControl(uc);
        }
    }
}
