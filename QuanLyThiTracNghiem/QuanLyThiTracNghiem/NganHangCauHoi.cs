using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThiTracNghiem
{
    public partial class NganHangCauHoi : Form
    {
        private MainForm mainForm;
        public NganHangCauHoi(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }
       
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Hide();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            NHCH_BUS.Instance.Xem(dtgNHCH);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (NHCH_BUS.Instance.XoaCH_MaCH(dtgNHCH))
            {
                MessageBox.Show("Xóa thành công");
                btnXem_Click(sender, e);
            }
            else
                MessageBox.Show("Xóa không thành công");
        }
     
        private void dtgNHCH_SelectionChanged(object sender, EventArgs e)
        {
                NHCH_BUS.Instance.Xem_DA(dtgNHCH,dtgChiTietCH);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            NHCH_BUS.Instance.TimKiem(dtgNHCH, cbbTimKiem, txtTimKiem);
        }

        
    }
}
