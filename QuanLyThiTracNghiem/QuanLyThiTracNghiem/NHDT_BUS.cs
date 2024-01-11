using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThiTracNghiem
{

    public class NHDT_BUS
    {
        private static NHDT_BUS instance;
        public static NHDT_BUS Instance { get { if (instance == null) instance = new NHDT_BUS(); return instance; } }
        public void Xem_DeThi(DataGridView dtgDeThi)
        {
            dtgDeThi.DataSource = NHDT_DAO.Instance.Xem_DeThi();
            dtgDeThi.Columns["Mã đề"].ReadOnly = true;
            dtgDeThi.AllowUserToAddRows = false;
            dtgDeThi.RowHeadersVisible=false;
        }
        public void Xem_CauHoi(DataGridView dtgDeThi, DataGridView dtgCauHoi, NganHangDeThi nhdt)
        {
            DeThi_DTO de = new DeThi_DTO();
            DataTable table = new DataTable();
            if (dtgDeThi.SelectedCells.Count > 0)
            {
                string maDe = dtgDeThi.SelectedCells[0].Value.ToString();
                table =  NHDT_DAO.Instance.Xem_CH(maDe);
                dtgCauHoi.DataSource = table;
            }
            dtgCauHoi.AllowUserToAddRows = false;
            dtgCauHoi.RowHeadersVisible = false;
            nhdt.UpdateLbSoCH(table.Rows.Count);
        }
        public string TaoDeThi(DataGridView dtgDeThi)
        {
            DeThi_DTO de = new DeThi_DTO();
            de.MaDe = NHDT_DAO.Instance.TaoMaDeThi();
            List<CauHoi_DTO> DSCauHoi = new List<CauHoi_DTO>();
            List<object> CHs = NHDT_DAO.Instance.TaoDeThi(de.MaDe);
            //Tạo danh sách câu hỏi
            for (int i = 0; i < CHs.Count; i += 2)
            {
                CauHoi_DTO ch = new CauHoi_DTO();
                ch.MaCH = CHs[i].ToString();
                ch.NoiDungCH = CHs[i + 1].ToString();
                // Tạo danh sách đáp án
                List<DapAn_DTO> DSDapAn = new List<DapAn_DTO>();
                List<object> DAs = NHDT_DAO.Instance.XemDapAn(ch.MaCH);
                for (int j = 0; j < DAs.Count; j += 4)
                {
                    DapAn_DTO da = new DapAn_DTO();
                    da.MaCH = DAs[j].ToString();
                    da.MaDA = DAs[j + 1].ToString();
                    da.NoiDungDA = DAs[j + 2].ToString();
                    da.Dung = (bool)DAs[j + 3];
                    DSDapAn.Add(da);
                }
                ch.DapAns = DSDapAn;
                DSCauHoi.Add(ch);
            }
            de.CauHois = DSCauHoi;
            MessageBox.Show("Thêm mới thành công: " + de.MaDe);
            return de.MaDe;
        }
    }
}
