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
    public partial class UKQThiTheoSV : UserControl
    {
        public UKQThiTheoSV()
        {
            InitializeComponent();
        }

        private void btnXemTK_Click(object sender, EventArgs e)
        {
            BUS_ThongKe.Instance.ThongKeTheoMaSV(dtgThongKe, txtMaSV.Text);
        }

        private void txtMaSV_Click(object sender, EventArgs e)
        {
            if(txtMaSV.Text == "(Nhập mã sinh viên)")
            {
                txtMaSV.Text = "";
                txtMaSV.ForeColor= Color.Black;
            }
        }

        private void txtMaSV_Leave(object sender, EventArgs e)
        {
            if(txtMaSV.Text == "")
            {
                txtMaSV.Text = "(Nhập mã sinh viên)";
            }
        }

        private void txtMaSV_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnXemTK_Click(sender, e);
            }
        }
    }
}
