using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThiTracNghiem
{
    internal class BUS_ThongKe
    {
        private static BUS_ThongKe instance;
        public static BUS_ThongKe Instance { get { 
                if(instance == null) { instance = new BUS_ThongKe();}
                return instance; } }

        public void ThongKeDTBTheoLop(DataGridView dtg, string maLop)
        {
            dtg.DataSource = DAO_ThongKe.Instance.ThongKeDTBTheoLop(maLop);
            /*  DataTable dt =  DAO_ThongKe.Instance.ThongKeDTBTheoLop(maLop);
              ReportDataSource rds = new ReportDataSource();
              rds.Name = "ds_ThongKeDTB";
              rds.Value = dt;
              rpv.Visible = true;
              rpv.LocalReport.ReportPath = "prt_ThongKeDTBTheoLop.rdlc";
              rpv.LocalReport.DataSources.Clear();
              rpv.LocalReport.DataSources.Add(rds);
              ReportParameter para = new ReportParameter("maLop",maLop);
              rpv.LocalReport.SetParameters(para);
              rpv.RefreshReport();*/
        }
        public void TyLeDatTruotTheoLop(DataGridView dtg, string maLop, int diemTruot)
        {
            dtg.DataSource = DAO_ThongKe.Instance.TyLeDatTruotTheoLop(maLop, diemTruot); 
        }
        public void ThongKeTheoMaSV(DataGridView dtg, string maSV)
        {
            dtg.DataSource = DAO_ThongKe.Instance.ThongKeTheoMaSV(maSV);
        }
        public void ThongKeTheoNHCH(DataGridView dtg)
        {
            dtg.DataSource = DAO_ThongKe.Instance.ThongKeNHCH();
        }
    }
}
