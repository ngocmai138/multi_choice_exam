using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThiTracNghiem
{
    public class BUS_BaiLam
    {
        private static BUS_BaiLam instance;
        public static BUS_BaiLam Instance { get  { if (instance == null) { instance = new BUS_BaiLam(); } return instance; } }

        public void XemDSBaiLam(DataGridView dtgDe)
        {
            dtgDe.DataSource = DAO_BaiLam.Instance.XemBaiLam();
            dtgDe.RowHeadersVisible = false;
            dtgDe.AllowUserToAddRows = false;
        /*    dtgDe.Columns["Mã bài thi"].Width = 60;
            dtgDe.Columns["Mã sinh viên"].Width = 60;
            dtgDe.Columns["Mã đề"].Width = 60;
            dtgDe.Columns["Điểm"].Width = 60;   */     
        }
        public void TimKiem(Panel panelBaiThi)
        {
            TextBox txtTimKiem = (TextBox) panelBaiThi.Controls.Find("txtTimKiem", true)[0];
            ComboBox cbbTimKiem = (ComboBox) panelBaiThi.Controls.Find("cbbTimKiem", true)[0];
            DataGridView dtgBaiLam = (DataGridView) panelBaiThi.Controls.Find("dtgBaiLam", true)[0];
            if(cbbTimKiem.Text == "Mã đề thi")
            {
            dtgBaiLam.DataSource = DAO_BaiLam.Instance.TimKiemTheoMaDe(txtTimKiem.Text);
            }
            else if(cbbTimKiem.Text == "Mã sinh viên")
            {
                dtgBaiLam.DataSource = DAO_BaiLam.Instance.TimKiemTheoMaSV(txtTimKiem.Text);
            }
            else
            {
                XemDSBaiLam(dtgBaiLam);
            }
        }
        public string LayMaBaiLam(DataGridView dtgBaiLam)
        {
            return dtgBaiLam.SelectedCells[0].OwningRow.Cells["Mã bài thi"].Value.ToString();
        }
        public DTO_BaiThi BaiLam(string maKQ)
        {
            DTO_BaiThi baiLam = new DTO_BaiThi();
            DataTable dt = DAO_BaiLam.Instance.TimKiemTheoMaKQ(maKQ);
            baiLam.MaKQ = maKQ;
            foreach(DataRow dr in dt.Rows)
            {
                baiLam.MaSV = dr["maSV"].ToString();
                baiLam.MaDe = dr["maDe"].ToString();
                baiLam.NgayThi = (DateTime) dr["ngayThi"];
                baiLam.Diem = Int32.Parse( dr["diem"].ToString() );
            }
            return baiLam;
        }
    }
}
