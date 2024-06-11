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
    public partial class UC_NganHangCauHoi : UserControl
    {
        public UC_NganHangCauHoi()
        {
            InitializeComponent();
            btnXem_Click();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            BUS_NHCH.Instance.Xem(dtgNHCH);
        }
        private void btnXem_Click()
        {
            BUS_NHCH.Instance.Xem(dtgNHCH);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (BUS_NHCH.Instance.Them(txtCauHoi, txtAnswer1, txtAnswer2, txtAnswer3, txtAnswer4, cb1, cb2, cb3, cb4))
            {
                MessageBox.Show("Thêm mới thành công");
                btnXem_Click(sender, e);
            }
            else
                MessageBox.Show("Thêm mới thất bại");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (BUS_NHCH.Instance.Sua(dtgNHCH, dtgDA))
            {
                MessageBox.Show("Sửa thành công");
                btnXem_Click(sender, e);
            }
            else
                MessageBox.Show("Sửa thất bại");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (BUS_NHCH.Instance.XoaCH_MaCH(dtgNHCH))
                {
                    MessageBox.Show("Xóa thành công");
                    btnXem_Click(sender, e);
                }
            }
            catch
            {
                MessageBox.Show("Xóa không thành công");
            }
        }

        private void dtgNHCH_SelectionChanged(object sender, EventArgs e)
        {
            BUS_NHCH.Instance.Xem_DA(dtgNHCH, dtgDA);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            BUS_NHCH.Instance.TimKiem(dtgNHCH, cbbTimKiem, txtTimKiem);
        }
    }
    
}
