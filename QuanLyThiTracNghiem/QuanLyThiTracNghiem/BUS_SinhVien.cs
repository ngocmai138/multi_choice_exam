using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThiTracNghiem
{
    internal class BUS_SinhVien
    {
        private static BUS_SinhVien instance;
        public static BUS_SinhVien Instance { get { if (instance == null) { instance = new BUS_SinhVien(); } return instance; } }
        public void XemDSSV(DataGridView dtg)
        {
            DataTable data = DAO_SinhVien.Instance.XemDSSV();
            dtg.DataSource = data;
            dtg.Columns[0].ReadOnly = true;
            dtg.Columns[0].Width = 50;
            dtg.Columns[1].ReadOnly = true;
            dtg.Columns[1].Width = 100;
            dtg.Columns[2].ReadOnly = true;
            dtg.Columns[2].Width = 50;
        }
        public void HienThiThongTinSV(DataGridView dtgDSSV, DataGridView dtgChiTiet, Label lbMaSV, Label lbTenSV, Label lbMaLop)
        {
            if (dtgDSSV.SelectedRows.Count > 0 && dtgDSSV.SelectedRows[0].Cells["Mã sinh viên"].Value !=null)
            {
                
                string maSV = dtgDSSV.SelectedRows[0].Cells["Mã sinh viên"].Value.ToString();
                dtgChiTiet.DataSource = DAO_SinhVien.Instance.ThongTinSV(maSV);
                dtgChiTiet.Columns[0].Visible = false;
                dtgChiTiet.Columns[1].Visible = false;
                dtgChiTiet.Columns[2].Visible = false;
                dtgChiTiet.Columns[3].Width = 50;
                dtgChiTiet.Columns[4].Width = 50;
                dtgChiTiet.Columns[6].Width = 50;
                lbMaSV.Text = maSV;
                lbMaSV.Visible = true;
                lbTenSV.Text = dtgDSSV.SelectedRows[0].Cells[1].Value.ToString();
                lbTenSV.Visible = true;
                lbMaLop.Text = dtgDSSV.SelectedRows[0].Cells[2].Value.ToString();
                lbMaLop.Visible = true;
            }
        }
        public bool Sua(string maSV, string tenSV, string maLop)
        {
             return DAO_SinhVien.Instance.Sua(maSV, tenSV, maLop) ;
        }
    }
}
