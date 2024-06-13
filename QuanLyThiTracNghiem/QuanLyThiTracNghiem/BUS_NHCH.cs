using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThiTracNghiem
{
    public class BUS_NHCH
    {
        private static BUS_NHCH instance;
        public static BUS_NHCH Instance {  
            get {
                if (instance == null)
                {
                    instance = new BUS_NHCH();
                }
                return instance; } }
        public void DangNhap(FormLogin formLogin, TextBox tenDN, TextBox mk)
        {
            string loaiTK = DAO_NHCH.Instance.DangNhap(tenDN.Text,mk.Text);
            if (loaiTK == "GiaoVien")
            {
                Form_MainForm_GV2 f = new Form_MainForm_GV2(formLogin, tenDN.Text);
                f.Show();
                formLogin.Hide();

            }
            else if (loaiTK == "SinhVien")
            {

                Form_MainForm_SV m = new Form_MainForm_SV(formLogin, tenDN.Text);
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
            dtgNHCH.DataSource = DAO_NHCH.Instance.Xem();
            dtgNHCH.AllowUserToAddRows = false;
            dtgNHCH.Columns["Mã câu hỏi"].ReadOnly = true;
         /*   dtgNHCH.Columns["Mã câu hỏi"].Width = 60;
            dtgNHCH.Columns["Nội dung câu hỏi"].Width = 240;*/
        }
        public void Xem_DA(DataGridView dtgNHCH, DataGridView dtgDA) {
            if (dtgNHCH.SelectedRows.Count > 0)
            {                
                string maCH = dtgNHCH.SelectedRows[0].Cells["Mã câu hỏi"].Value.ToString();
                dtgDA.DataSource = DAO_NHCH.Instance.Xem_DA(maCH);
                dtgDA.AllowUserToAddRows=false;
                dtgDA.Columns["Mã câu hỏi"].ReadOnly = true;
                dtgDA.Columns["Mã đáp án"].ReadOnly = true;
           /*     dtgDA.Columns["Mã câu hỏi"].Width = 70;
                dtgDA.Columns["Mã đáp án"].Width = 60;*/
            }                
        }

        public void TimKiem(DataGridView dataGridView, ComboBox cbbTimKiem, TextBox tuKhoa)
        {
            if (cbbTimKiem.Text == "mã câu hỏi")
                dataGridView.DataSource = DAO_NHCH.Instance.TimKiem_MaCH(tuKhoa.Text);
            else if (cbbTimKiem.Text == "nội dung câu hỏi")
                dataGridView.DataSource = DAO_NHCH.Instance.TimKiem_NoiDung(tuKhoa.Text);
            else
                dataGridView.DataSource = DAO_NHCH.Instance.TimKiem_MaCH_ND(tuKhoa.Text);

        }
        public bool XoaCH_MaCH(DataGridView dtgNHCH)
        {
            string maCH = dtgNHCH.SelectedRows[0].Cells["Mã câu hỏi"].Value.ToString();
            return DAO_NHCH.Instance.XoaCH_MaCH(maCH);
        }
        public bool Sua(DataGridView dtgNHCH, DataGridView dtgDA)
        {
            DataGridViewRow rowCH = dtgNHCH.SelectedCells[0].OwningRow;
            string maCH = rowCH.Cells["Mã câu hỏi"].Value.ToString();
            string noiDungCH = rowCH.Cells["Nội dung câu hỏi"].Value.ToString();
            DTO_NHCH cauHoi = new DTO_NHCH();
            cauHoi.MaCH = maCH;
            cauHoi.NoiDungCH = noiDungCH;
            cauHoi.DA = new List<DTO_DapAn>();
            bool b = false;
            for(int i = 0;i<dtgDA.Rows.Count-1;i++) {
                cauHoi.DA.Add(new DTO_DapAn());
                cauHoi.DA[i].MaCH = cauHoi.MaCH;
                cauHoi.DA[i].MaDA = dtgDA.Rows[i].Cells["Mã đáp án"].Value.ToString();
                cauHoi.DA[i].NoiDungDA = dtgDA.Rows[i].Cells["Câu trả lời"].Value.ToString();
                cauHoi.DA[i].Dung = (bool)dtgDA.Rows[i].Cells["Đáp án đúng"].Value;
                b = DAO_NHCH.Instance.Sua_DA(cauHoi.DA[i]);
            }
            return DAO_NHCH.Instance.Sua_CH(maCH,cauHoi)|| b;
        }

        public bool Them(RichTextBox noiDungCH, TextBox da1, TextBox da2, TextBox da3, TextBox da4, CheckBox dung1, CheckBox dung2, CheckBox dung3, CheckBox dung4)
        {
            DTO_NHCH cauHoi = new DTO_NHCH();
            cauHoi.NoiDungCH = noiDungCH.Text;
            cauHoi.DA = new List<DTO_DapAn>();
            var inputs = new (TextBox, CheckBox)[]
            {(da1,dung1),(da2,dung2),(da3,dung3),(da4,dung4)};
            foreach(var input in inputs)
            {
                cauHoi.DA.Add(new DTO_DapAn()
                {
                    NoiDungDA = input.Item1.Text,
                    Dung = input.Item2.Checked
                });
            }
            if (DAO_NHCH.Instance.Them_CH(cauHoi))
            {
                return true;
            }
            
            return false;
        }
    }
}
