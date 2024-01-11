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
    public partial class QuanLyBaiThi : Form
    {
        private MainForm_GV mainForm_GV;
        public QuanLyBaiThi(MainForm_GV mainForm_GV)
        {
            InitializeComponent();
            this.mainForm_GV = mainForm_GV;
            btnXem_Click(this, new EventArgs());
            BaiLam_BUS.Instance.XemMaDe_MaSV(cbbMaDe, cbbMaSV);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            mainForm_GV.Show();
            this.Hide();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            BaiLam_BUS.Instance.XemDSBaiLam(dtgBaiLam);
        }

        private void cbbMaDe_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView) cbbMaDe.SelectedItem;
            string text = drv["Mã đề"].ToString();
            lbMaDe.Text = text;
        }

        private void cbbMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView) cbbMaSV.SelectedItem;
            string text = drv["Mã sinh viên"].ToString();
            lbMaSV.Text = text;
        }
    }
}
