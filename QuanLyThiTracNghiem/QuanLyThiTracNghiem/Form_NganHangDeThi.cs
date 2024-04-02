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
    public partial class Form_NganHangDeThi : Form
    {
        private Form_MainForm_GV mainForm;
        public Form_NganHangDeThi(Form_MainForm_GV mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            btnXem_Click();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Hide();
        }
        private void btnXem_Click()
        {
            BUS_NHDT.Instance.Xem_DeThi(dtgDeThi);
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            BUS_NHDT.Instance.Xem_DeThi(dtgDeThi);
        }

        private void btnThemTuDong_Click(object sender, EventArgs e)
        {
            string maDe = BUS_NHDT.Instance.TaoDeThi(dtgDeThi);
            btnXem_Click(sender, e);
            int rowIndex = dtgDeThi.Rows.Cast<DataGridViewRow>().Where(r => r.Cells["Mã đề"].Value.ToString().Equals(maDe)).First().Index;
            dtgDeThi.ClearSelection();
            dtgDeThi.Rows[rowIndex].Selected = true;
        }

        private void dtgDeThi_SelectionChanged(object sender, EventArgs e)
        {
            BUS_NHDT.Instance.Xem_CauHoi(dtgDeThi, dtgCauHoi, this);
        }
        public void UpdateLbSoCH(int i)
        {
            lbSoCH.Text = i.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}
