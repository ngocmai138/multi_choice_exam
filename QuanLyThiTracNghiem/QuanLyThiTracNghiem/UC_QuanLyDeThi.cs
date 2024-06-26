﻿using System;
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
    public partial class UC_QuanLyDeThi : UserControl
    {
        public UC_QuanLyDeThi()
        {
            InitializeComponent();
            btnXem_Click(this, EventArgs.Empty);
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

        private void btnXoaDe_Click(object sender, EventArgs e)
        {
            BUS_NHDT.Instance.Xoa_DeThi(dtgDeThi);
        }

        private void dtgDeThi_SelectionChanged(object sender, EventArgs e)
        {
            BUS_NHDT.Instance.Xem_CauHoi(dtgDeThi, dtgCauHoi);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            BUS_NHDT.Instance.TimKiem(dtgDeThi, cbbTimKiem, txtTimKiem);
        }
    }
}
