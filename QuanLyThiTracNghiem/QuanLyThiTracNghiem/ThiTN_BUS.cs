using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThiTracNghiem
{
    public class ThiTN_BUS
    {
        private static ThiTN_BUS instance;
        public static ThiTN_BUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ThiTN_BUS();
                }
                return instance;
            }
        }
        public SinhVien_DTO DangNhap(SinhVien_DTO sv, string maSV)
        {
            List<object> info = ThiTN_DAO.Instance.XemSV(maSV);
            sv = new SinhVien_DTO();
            sv.MaSV = maSV;
            if (info.Count >= 2)
            {
                sv.TenSV = (string)info[0];
                sv.MaLop = (string)info[1];
            }
            else
            {
                MessageBox.Show("Sinh viên thiếu thông tin");
            }
            return sv;
        }
        public string MaDe()
        {
            string maDe = "";
            return maDe;
        }
        public DeThi_DTO DeThi()
        {
            string maDe = ThiTN_DAO.Instance.MaDe();
            DeThi_DTO dethi = new DeThi_DTO();
            dethi.MaDe = maDe;
            List<CauHoi_DTO> DSCauHoi = new List<CauHoi_DTO>();
            List<object> CHs = NHDT_DAO.Instance.TaoDeThi(dethi.MaDe);
            if(CHs.Count <= 0)
            {
                MessageBox.Show("Chưa có đề");
            }
            for(int i = 0; i<CHs.Count-1; i+=2)
            {
                CauHoi_DTO ch = new CauHoi_DTO();
                ch.MaCH = CHs[i].ToString();
                ch.NoiDungCH = CHs[i+1].ToString();
                List<DapAn_DTO> DSDapAn = new List<DapAn_DTO>();
                List<object> DAs = NHDT_DAO.Instance.XemDapAn(ch.MaCH);
                for(int j = 0; j< DAs.Count; j+=4)
                {
                    DapAn_DTO da = new DapAn_DTO();
                    da.MaCH = DAs[j].ToString();
                    da.MaDA = DAs[j+1].ToString();
                    da.NoiDungDA = DAs[j+2].ToString();
                    da.Dung = (bool)DAs[j+3];
                    DSDapAn.Add(da);
                }
                ch.DapAns = DSDapAn;
                DSCauHoi.Add(ch);
            }
            dethi.CauHois = DSCauHoi;
            return dethi;
        }
        public BaiThi_DTO BaiThi(string maSV, string maDe)
        {
            BaiThi_DTO baithi = new BaiThi_DTO();
            List<object> bt = ThiTN_DAO.Instance.BaiThi(maSV, maDe);
            if (bt.Count <= 0)
            {
                return null;
                MessageBox.Show("Lỗi tạo bài thi");
            }
            baithi.MaSV = maSV;
            baithi.MaDe = maDe;
            baithi.MaKQ = bt[0].ToString();
            baithi.NgayThi = Convert.ToDateTime(bt[1]);
            if (Int32.TryParse(bt[2].ToString(), out int result))
            {
                baithi.Diem = result;
            }
            else { 
                baithi.Diem = 0; 
            }
            return baithi;
        }
        public BaiThi_DTO TaoBaiThi(string maSV, string maDe)
        {
            BaiThi_DTO baiThi = new BaiThi_DTO();
            var result = ThiTN_DAO.Instance.TaoBaiThi(maSV, maDe);
            baiThi.MaKQ = result.Item1;
            baiThi.MaSV = maSV;
            baiThi.MaDe = maDe;
            baiThi.NgayThi = result.Item2;
            return baiThi;
        }
        public void HienThiCauHoi(int count, List<CauHoi_DTO> dsCH, Panel pnNoiDungCH)
        {
            Label lbCauHoi = (Label) pnNoiDungCH.Controls.Find("lbNoiDungCH", true)[0];
            Label lbSTT = (Label) pnNoiDungCH.Controls.Find("lbSTTCauHoi", true)[0];
            RadioButton r1 = (RadioButton) pnNoiDungCH.Controls.Find("rbDA1", true)[0];
            RadioButton r2 = (RadioButton) pnNoiDungCH.Controls.Find("rbDA2", true)[0];
            RadioButton r3 = (RadioButton) pnNoiDungCH.Controls.Find("rbDA3", true)[0];
            RadioButton r4 = (RadioButton) pnNoiDungCH.Controls.Find("rbDA4", true)[0];
            Button btnTiepTheo = (Button) pnNoiDungCH.Controls.Find("btnTiep", true)[0];
            Button btnQuayLai = (Button) pnNoiDungCH.Controls.Find("btnQuayLai", true)[0];
            if (count < dsCH.Count)
            {
                lbCauHoi.Text = dsCH[count].NoiDungCH;
                lbSTT.Text = (count + 1).ToString();
                List<DapAn_DTO> dsDA = dsCH[count].DapAns;
                if (dsDA.Count > 0)
                {
                    r1.Text = dsDA[0].NoiDungDA.ToString();
                    r1.Checked = dsDA[0].SVChon;
                    r2.Text = dsDA[1].NoiDungDA.ToString();
                    r2.Checked = dsDA[1].SVChon;
                    r3.Text = dsDA[2].NoiDungDA.ToString();
                    r3.Checked = dsDA[2].SVChon;
                    r4.Text = dsDA[3].NoiDungDA.ToString();
                    r4.Checked = dsDA[3].SVChon;
                }
                else
                {
                    MessageBox.Show("Lỗi không có đáp án");
                }
            }
            if (count == 0)
            {
                btnQuayLai.Hide();
            }
            else if (count == dsCH.Count - 1)
            {
                btnTiepTheo.Hide();
            }
            else
            {
                btnQuayLai.Show();
                btnTiepTheo.Show();
            }
        }
        public void LuuDapAn(CauHoi_DTO cauHoi, RadioButton r1, RadioButton r2, RadioButton r3, RadioButton r4)
        {
            cauHoi.DapAns[0].SVChon = r1.Checked;
            cauHoi.DapAns[1].SVChon = r2.Checked;
            cauHoi.DapAns[2].SVChon = r3.Checked;
            cauHoi.DapAns[3].SVChon = r4.Checked;
        }
        public float TinhDiem(BaiThi_DTO baithi, DeThi_DTO dethi)
        {
            baithi.Diem = 0;
            List<CauHoi_DTO> dsCauHoi = dethi.CauHois;
            for(int i = 0; i<dsCauHoi.Count; i++)
            {
                List<DapAn_DTO> dsDA = dsCauHoi[i].DapAns;
                for(int j = 0; j<dsDA.Count; j++)
                {
                    if (dsDA[j].SVChon== true && dsDA[j].Dung==true)
                    {
                        baithi.Diem++;
                    }
                }
            }
            return baithi.Diem;
        }
        public void LuuBaiThi(BaiThi_DTO baiThi)
        {
            ThiTN_DAO.Instance.LuuBaiThi(baiThi);
        }
        public void CauDaLam(List<CauHoi_DTO> cauHois, FlowLayoutPanel pnDSCH) {
            List<Button> btns = new List<Button> ();
            bool dalam = false;
            foreach (Control control in pnDSCH.Controls)
            {
                if(control is Button)
                {
                    btns.Add(control as Button);
                }
            }
            
            for(int i = 0;i<cauHois.Count;i++)
            {
                List<DapAn_DTO> dsDA = cauHois[i].DapAns;
                for(int j = 0; j < dsDA.Count; j++)
                {
                    if (dsDA[j].SVChon == true)
                    {
                        btns[i].BackColor = Color.BlueViolet;
                        dalam = true;
                    }
                }
            }
        }
        public FlowLayoutPanel TaoButtonCauHoi(List<CauHoi_DTO> dsCauHoi, Panel pnNoiDungCH, FlowLayoutPanel pnDSCH, ThiTracNghiem thiTracNghiem)
        {
            int btnWidth = 30;
            int spacing = 5;
            for(int i = 0; i<dsCauHoi.Count;i++) { 
                Button btn = new Button();
                btn.Text = (i+1).ToString();
                btn.Name = "btn" + i.ToString();
                btn.Size = new Size(btnWidth, btnWidth);
                btn.Location = new Point(i * (btnWidth + spacing),0);
                int index = i;
                btn.Click += (sender, e) => Button_Click(sender,e,index, dsCauHoi, pnNoiDungCH, pnDSCH, thiTracNghiem);
                pnDSCH.Controls.Add(btn);
            }
            return pnDSCH;
        }
        private void Button_Click(object sender, EventArgs e, int index, List<CauHoi_DTO> dsCH, Panel pnNoiDungCH, FlowLayoutPanel pnDSCH, ThiTracNghiem thiTracNghiem)
        {
            Button clickedButton = (Button)sender;
            RadioButton rbDA1 = (RadioButton) pnNoiDungCH.Controls.Find("rbDA1", true)[0];
            RadioButton rbDA2 = (RadioButton)pnNoiDungCH.Controls.Find("rbDA2", true)[0];
            RadioButton rbDA3 = (RadioButton)pnNoiDungCH.Controls.Find("rbDA3", true)[0];
            RadioButton rbDA4 = (RadioButton)pnNoiDungCH.Controls.Find("rbDA4", true)[0];
            Label lbNoiDungCH = (Label)pnNoiDungCH.Controls.Find("lbNoiDungCH", true)[0];
            Label lbSTTCauHoi = (Label)pnNoiDungCH.Controls.Find("lbSTTCauHoi", true)[0];
            Button btnTiep = (Button)pnNoiDungCH.Controls.Find("btnTiep", true)[0];
            Button btnQuayLai = (Button)pnNoiDungCH.Controls.Find("btnQuayLai", true)[0];

            LuuDapAn(dsCH[int.Parse( lbSTTCauHoi.Text)-1], rbDA1, rbDA2, rbDA3, rbDA4);
            CauDaLam(dsCH, pnDSCH);
            thiTracNghiem.UpdateCount(index);
            HienThiCauHoi(index, dsCH, pnNoiDungCH);

        }
        
    }
}
