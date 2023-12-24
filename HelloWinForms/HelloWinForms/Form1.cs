using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            HangBUS.Instance.Xem(dtgData);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (HangBUS.Instance.Them(dtgData))
            {
                MessageBox.Show("Thêm thành công");
                btnXem_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (HangBUS.Instance.Sua_ID(dtgData))
            {
                MessageBox.Show("Sửa thành công");
                btnXem_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Sửa không thành công");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (HangBUS.Instance.Xoa_ID(dtgData))
            {
                MessageBox.Show("Xóa thành công");
                btnXem_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Xóa không thành công");
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            HangBUS.Instance.Tim_ID(dtgData, txtTim.Text);
        }

    }
}
