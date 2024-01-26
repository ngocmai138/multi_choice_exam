using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic;

namespace QuanLyThiTracNghiem
{
    public partial class ThiTracNghiem : Form
    {
        private MainForm_SV mainForm_SV;
        private DTO_SinhVien sv;
        private DTO_DeThi de;
        private DTO_BaiThi baiThi;
        private int count=0;
        List<DTO_CauHoi> DSCauHoi;
        public ThiTracNghiem(MainForm_SV mainForm_SV, string maSV)
        {
            InitializeComponent();
            this.mainForm_SV = mainForm_SV;
            this.sv = BUS_ThiTN.Instance.DangNhap(sv, maSV);
            this.de = BUS_ThiTN.Instance.DeThi();
            this.baiThi = BUS_ThiTN.Instance.TaoBaiThi(maSV,de.MaDe);
            this.DSCauHoi = de.CauHois;
            lbTen.Text = sv.TenSV;
            lbLop.Text = sv.MaLop;
            lbSoDE.Text = de.MaDe;
            

            BUS_ThiTN.Instance.HienThiCauHoi(count, DSCauHoi, pnNoiDungCH);
            pnDSCH = BUS_ThiTN.Instance.TaoButtonCauHoi(DSCauHoi ,pnNoiDungCH, pnDSCH, this);
            
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            if(count < DSCauHoi.Count)
            {
            BUS_ThiTN.Instance.LuuDapAn(DSCauHoi[count], rbDA1, rbDA2, rbDA3, rbDA4);
                BUS_ThiTN.Instance.CauDaLam(DSCauHoi, pnDSCH);
                count++;
            BUS_ThiTN.Instance.HienThiCauHoi(count, DSCauHoi, pnNoiDungCH);
            }
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

        private void btnNopBai_Click(object sender, EventArgs e)
        {
            bool lamXong = true;
            BUS_ThiTN.Instance.LuuDapAn(DSCauHoi[count], rbDA1, rbDA2, rbDA3, rbDA4);
            for(int i = 0; i< de.CauHois.Count; i++)
            {
                bool coDA = false;
                DTO_CauHoi ch = de.CauHois[i];
                for(int j = 0; j<ch.DapAns.Count; j++)
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
            if(lamXong)
            {
            NopBai nopbai = new NopBai(baiThi,de);
            nopbai.Show();
            this.Hide();
            }
        }
        public void UpdateCount(int newCount)
        {
            count = newCount;
        }

    }
}
