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
    public partial class UC_KetQuaThi : UserControl
    {
        String maSV;
        public UC_KetQuaThi(string maSV)
        {
            InitializeComponent();
            this.maSV = maSV;
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnMain.Controls.Clear();
            pnMain.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void UC_DanhSachBaiLam_Load(object sender, EventArgs e)
        {
            BUS_ThiTN.Instance.DanhSachBaiLam(dtgvDSBL, maSV);
        }

        private void dtgvDSBL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maKQ = dtgvDSBL.SelectedRows[0].Cells["maKQ"].Value.ToString();
                Form_XemLaiChiTietBaiLam xemCT = new Form_XemLaiChiTietBaiLam(this, maKQ);
                xemCT.Show();
                this.Hide();
            }
        }
    }
}
