using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThiTracNghiem
{
    public class BaiLam_BUS
    {
        private static BaiLam_BUS instance;
        public static BaiLam_BUS Instance { get  { if (instance == null) { instance = new BaiLam_BUS(); } return instance; } }

        public void XemDSBaiLam(DataGridView dtgDe)
        {
            dtgDe.DataSource = BaiLam_DAO.Instance.XemBaiLam();
            dtgDe.RowHeadersVisible = false;
            dtgDe.AllowUserToAddRows = false;
            dtgDe.Columns["Mã bài thi"].Width = 60;
            dtgDe.Columns["Mã sinh viên"].Width = 60;
            dtgDe.Columns["Mã đề"].Width = 60;
            dtgDe.Columns["Điểm"].Width = 60;        
        }
        public void XemMaDe_MaSV(ComboBox cbbMaDe, ComboBox cbbMaSV)
        {
            cbbMaDe.DataSource = BaiLam_DAO.Instance.XemMaDe();
            cbbMaDe.DisplayMember = "Mã đề";
            cbbMaSV.DataSource = BaiLam_DAO.Instance.XemMaSV();
            cbbMaSV.DisplayMember = "Mã sinh viên";
        }

    }
}
