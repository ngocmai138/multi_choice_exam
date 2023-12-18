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
            UserBUS.Instance.Xem(dtgData);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (UserBUS.Instance.Xoa_ID(dtgData))
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
            UserBUS.Instance.Tim_ID(dtgData, txtTim.Text);
        }

    }
}
