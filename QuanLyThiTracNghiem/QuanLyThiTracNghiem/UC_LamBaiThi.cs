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
    public partial class UC_LamBaiThi : UserControl
    {
        private DTO_SinhVien sv;
        private DTO_DeThi de;
        private DTO_BaiThi baiThi;
        private int count = 0;
        List<DTO_CauHoi> DSCauHoi;
        public delegate void NopBaiHandler(DTO_BaiThi baiThi, DTO_DeThi de);
        public event NopBaiHandler NopBai;
        public UC_LamBaiThi(string maSV)
        {
            InitializeComponent();
            this.sv = BUS_ThiTN.Instance.DangNhap(maSV);
            this.de = BUS_ThiTN.Instance.DeThi();
            this.baiThi = BUS_ThiTN.Instance.TaoBaiThi(maSV, de.MaDe);
            this.DSCauHoi = de.CauHois;
            lbTen.Text = sv.TenSV;
            lbLop.Text = sv.MaLop;
            lbSoDE.Text = de.MaDe;

            BUS_ThiTN.Instance.HienThiCauHoi(count, DSCauHoi, pnNoiDungCH);
            pnDSCH = BUS_ThiTN.Instance.TaoButtonCauHoi(DSCauHoi, pnNoiDungCH, pnDSCH, this);
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            if (count < DSCauHoi.Count)
            {
                BUS_ThiTN.Instance.LuuDapAn(DSCauHoi[count], rbDA1, rbDA2, rbDA3, rbDA4);
                BUS_ThiTN.Instance.CauDaLam(DSCauHoi, pnDSCH);
                count--;
                BUS_ThiTN.Instance.HienThiCauHoi(count, DSCauHoi, pnNoiDungCH);
            }
        }
        public void UpdateCount(int newCount)
        {
            count = newCount;
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            if (count < DSCauHoi.Count)
            {
                BUS_ThiTN.Instance.LuuDapAn(DSCauHoi[count], rbDA1, rbDA2, rbDA3, rbDA4);
                BUS_ThiTN.Instance.CauDaLam(DSCauHoi, pnDSCH);
                count++;
                BUS_ThiTN.Instance.HienThiCauHoi(count, DSCauHoi, pnNoiDungCH);
            }
        }

        private void btnNopBai_Click(object sender, EventArgs e)
        {
            bool lamXong = true;
            BUS_ThiTN.Instance.LuuDapAn(DSCauHoi[count], rbDA1, rbDA2, rbDA3, rbDA4);
            for (int i = 0; i < de.CauHois.Count; i++)
            {
                bool coDA = false;
                DTO_CauHoi ch = de.CauHois[i];
                for (int j = 0; j < ch.DapAns.Count; j++)
                {
                    DTO_DapAn da = ch.DapAns[j];
                    if (da.Dung)
                    {
                        coDA = true;
                        break;
                    }
                }
                if (!coDA)
                {
                    lamXong = false;
                    MessageBox.Show("Bạn chưa trả lời hết câu hỏi");
                    break;
                }
            }
            if (lamXong)
            {
                NopBai?.Invoke(this.baiThi, this.de);
                this.Hide();
            }
        }
    }
}
