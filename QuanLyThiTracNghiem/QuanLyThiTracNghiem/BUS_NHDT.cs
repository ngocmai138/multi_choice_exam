using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThiTracNghiem
{

    public class BUS_NHDT
    {
        private static BUS_NHDT instance;
        public static BUS_NHDT Instance { get { if (instance == null) instance = new BUS_NHDT(); return instance; } }
        public void Xem_DeThi(DataGridView dtgDeThi)
        {
            dtgDeThi.DataSource = DAO_NHDT.Instance.Xem_DeThi();
            dtgDeThi.Columns["Mã đề"].ReadOnly = true;
            dtgDeThi.AllowUserToAddRows = false;
            dtgDeThi.RowHeadersVisible=false;
        }
        public void Xem_CauHoi(DataGridView dtgDeThi, DataGridView dtgCauHoi, Form_NganHangDeThi nhdt)
        {
            DTO_DeThi de = new DTO_DeThi();
            DataTable table = new DataTable();
            if (dtgDeThi.SelectedCells.Count > 0)
            {
                string maDe = dtgDeThi.SelectedCells[0].Value.ToString();
                table =  DAO_NHDT.Instance.Xem_CH(maDe);
                dtgCauHoi.DataSource = table;
            }
            dtgCauHoi.AllowUserToAddRows = false;
            dtgCauHoi.RowHeadersVisible = false;
        }
        public string TaoDeThi(DataGridView dtgDeThi)
        {
            DTO_DeThi de = new DTO_DeThi();
            de.MaDe = DAO_NHDT.Instance.TaoMaDeThi();
            List<DTO_CauHoi> DSCauHoi = new List<DTO_CauHoi>();
            List<object> CHs = DAO_NHDT.Instance.TaoDeThi(de.MaDe);
            //Tạo danh sách câu hỏi
            for (int i = 0; i < CHs.Count; i += 2)
            {
                DTO_CauHoi ch = new DTO_CauHoi();
                ch.MaCH = CHs[i].ToString();
                ch.NoiDungCH = CHs[i + 1].ToString();
                // Tạo danh sách đáp án
                List<DTO_DapAn> DSDapAn = new List<DTO_DapAn>();
                List<object> DAs = DAO_NHDT.Instance.XemDapAn(ch.MaCH);
                for (int j = 0; j < DAs.Count; j += 4)
                {
                    DTO_DapAn da = new DTO_DapAn();
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

        public void Xoa_DeThi(DataGridView dtgDeThi)
        {
            if(dtgDeThi.SelectedCells.Count > 0)
            {
                string maDe = dtgDeThi.SelectedCells[0].Value.ToString();
                if (DAO_NHDT.Instance.XoaDeThi(maDe))
                {
                    MessageBox.Show("Xóa thành công");
                    Xem_DeThi(dtgDeThi);
                }
                else MessageBox.Show("Xóa không thành công");
            }
        }
    }
}
