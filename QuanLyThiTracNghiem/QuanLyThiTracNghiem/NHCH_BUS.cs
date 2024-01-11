using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
        public void DangNhap(FormLogin formLogin, TextBox tenDN, TextBox mk)
        {
            string loaiTK = NHCH_DAO.Instance.DangNhap(tenDN.Text,mk.Text);
            if (loaiTK == "GiaoVien")
            {
                MainForm_GV f = new MainForm_GV(formLogin);
                f.Show();
                formLogin.Hide();

            }
            else if (loaiTK == "SinhVien")
            {

                MainForm_SV m = new MainForm_SV(formLogin, tenDN.Text);
                m.Show();
                formLogin.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công");
            }
        }

        public void Xem(DataGridView dtgNHCH)
        {
            dtgNHCH.DataSource = NHCH_DAO.Instance.Xem();
            dtgNHCH.Columns["Mã câu hỏi"].ReadOnly = true;
            dtgNHCH.Columns["Mã câu hỏi"].Width = 60;
            dtgNHCH.Columns["Nội dung câu hỏi"].Width = 240;
            dtgNHCH.AllowUserToAddRows = false;
        }
        public void Xem_DA(DataGridView dtgNHCH, DataGridView dtgDA) {
            if (dtgNHCH.SelectedRows.Count > 0)
            {                
                string maCH = dtgNHCH.SelectedRows[0].Cells["Mã câu hỏi"].Value.ToString();
                dtgDA.DataSource = NHCH_DAO.Instance.Xem_DA(maCH);
                dtgDA.Columns["Mã câu hỏi"].ReadOnly = true;
                dtgDA.Columns["Mã đáp án"].ReadOnly = true;
                dtgDA.Columns["Mã câu hỏi"].Width = 70;
                dtgDA.Columns["Mã đáp án"].Width = 60;
                dtgDA.AllowUserToAddRows=false;
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
        public bool Sua(DataGridView dtgNHCH, DataGridView dtgDA)
        {
            DataGridViewRow rowCH = dtgNHCH.SelectedCells[0].OwningRow;
            string maCH = rowCH.Cells["Mã câu hỏi"].Value.ToString();
            string noiDungCH = rowCH.Cells["Nội dung câu hỏi"].Value.ToString();
            NHCH_DTO cauHoi = new NHCH_DTO();
            cauHoi.MaCH = maCH;
            cauHoi.NoiDungCH = noiDungCH;
            cauHoi.DA = new List<DapAn_DTO>();
            bool b = false;
            for(int i = 0;i<dtgDA.Rows.Count-1;i++) {
                cauHoi.DA.Add(new DapAn_DTO());
                cauHoi.DA[i].MaCH = cauHoi.MaCH;
                cauHoi.DA[i].MaDA = dtgDA.Rows[i].Cells["Mã đáp án"].Value.ToString();
                cauHoi.DA[i].NoiDungDA = dtgDA.Rows[i].Cells["Câu trả lời"].Value.ToString();
                cauHoi.DA[i].Dung = (bool)dtgDA.Rows[i].Cells["Đáp án đúng"].Value;
                b = NHCH_DAO.Instance.Sua_DA(cauHoi.DA[i]);
            }
            return NHCH_DAO.Instance.Sua_CH(maCH,cauHoi)|| b;
        }

        public bool Them(RichTextBox noiDungCH, TextBox da1, TextBox da2, TextBox da3, TextBox da4, CheckBox dung1, CheckBox dung2, CheckBox dung3, CheckBox dung4)
        {
            MessageBox.Show(noiDungCH.Text);
            MessageBox.Show(da1.Text);
            NHCH_DTO cauHoi = new NHCH_DTO();
            cauHoi.NoiDungCH = noiDungCH.Text;
            cauHoi.DA = new List<DapAn_DTO>();
            var inputs = new (TextBox, CheckBox)[]
            {(da1,dung1),(da2,dung2),(da3,dung3),(da4,dung4)};
            foreach(var input in inputs)
            {
                cauHoi.DA.Add(new DapAn_DTO()
                {
                    NoiDungDA = input.Item1.Text,
                    Dung = input.Item2.Checked
                });
            }
            if (NHCH_DAO.Instance.Them_CH(cauHoi))
            {
                return true;
            }
            
            return false;
        }
    }
}
