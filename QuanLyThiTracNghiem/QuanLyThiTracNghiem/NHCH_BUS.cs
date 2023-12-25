using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThiTracNghiem
{
    public class NHCH_BUS
    {
        private static NHCH_BUS instance;
        public static NHCH_BUS Instance {  
            get {
                if (instance == null)
                {
                    instance = new NHCH_BUS();
                }
                return instance; } }

        public void Xem(DataGridView dataGridView)
        {
            dataGridView.DataSource = NHCH_DAO.Instance.Xem();
        }
        public void Xem_DA(DataGridView dtgNHCH, DataGridView dtgDA) {
            if (dtgNHCH.SelectedRows.Count > 0)
            {                
                string maCH = dtgNHCH.SelectedRows[0].Cells["Mã câu hỏi"].Value.ToString();
                dtgDA.DataSource = NHCH_DAO.Instance.Xem_DA(maCH);
            }                
        }

        public void TimKiem(DataGridView dataGridView, ComboBox cbbTimKiem, TextBox tuKhoa)
        {
            if (cbbTimKiem.Text == "mã câu hỏi")
                dataGridView.DataSource = NHCH_DAO.Instance.TimKiem_MaCH(tuKhoa.Text);
            else if (cbbTimKiem.Text == "nội dung câu hỏi")
                dataGridView.DataSource = NHCH_DAO.Instance.TimKiem_NoiDung(tuKhoa.Text);
            else
                Xem(dataGridView);

        }
        public bool XoaCH_MaCH(DataGridView dtgNHCH)
        {
            string maCH = dtgNHCH.SelectedRows[0].Cells["Mã câu hỏi"].Value.ToString();
            return NHCH_DAO.Instance.XoaCH_MaCH(maCH);
        }
    }
}
