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
using Microsoft.VisualBasic;

namespace QuanLyThiTracNghiem
{
    public partial class ThiTracNghiem : Form
    {
        private MainForm_SV mainForm_SV;
        private SinhVien_DTO sv;
        private DeThi_DTO de;
        private BaiThi_DTO baiThi;
        private int count=0;
        List<CauHoi_DTO> DSCauHoi;
        public ThiTracNghiem(MainForm_SV mainForm_SV, string maSV)
        {
            InitializeComponent();
            this.mainForm_SV = mainForm_SV;
            this.sv = ThiTN_BUS.Instance.DangNhap(sv, maSV);
            this.de = ThiTN_BUS.Instance.DeThi();
            this.baiThi = ThiTN_BUS.Instance.TaoBaiThi(maSV,de.MaDe);
            this.DSCauHoi = de.CauHois;
            lbTen.Text = sv.TenSV;
            lbLop.Text = sv.MaLop;
            lbSoDE.Text = de.MaDe;
            

            ThiTN_BUS.Instance.HienThiCauHoi(count, DSCauHoi, pnNoiDungCH);
            pnDSCH = ThiTN_BUS.Instance.TaoButtonCauHoi(DSCauHoi ,pnNoiDungCH, pnDSCH, this);
            
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            if(count < DSCauHoi.Count)
            {
            ThiTN_BUS.Instance.LuuDapAn(DSCauHoi[count], rbDA1, rbDA2, rbDA3, rbDA4);
                ThiTN_BUS.Instance.CauDaLam(DSCauHoi, pnDSCH);
                count++;
            ThiTN_BUS.Instance.HienThiCauHoi(count, DSCauHoi, pnNoiDungCH);
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            if (count < DSCauHoi.Count)
            {
                ThiTN_BUS.Instance.LuuDapAn(DSCauHoi[count], rbDA1, rbDA2, rbDA3, rbDA4);
               ThiTN_BUS.Instance.CauDaLam(DSCauHoi, pnDSCH);
                count--;
                    ThiTN_BUS.Instance.HienThiCauHoi(count, DSCauHoi, pnNoiDungCH);
            }
        }

        private void btnNopBai_Click(object sender, EventArgs e)
        {
            ThiTN_BUS.Instance.LuuDapAn(DSCauHoi[count], rbDA1, rbDA2, rbDA3, rbDA4);
            float diem = ThiTN_BUS.Instance.TinhDiem(baiThi, de);
            NopBai nopbai = new NopBai(diem,baiThi);
            nopbai.Show();
            this.Hide();
        }
        public void UpdateCount(int newCount)
        {
            count = newCount;
        }

    }
}
