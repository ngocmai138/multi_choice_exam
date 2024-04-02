using Microsoft.Reporting.WinForms;
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
    public partial class Form_ChiTietBaiLam : Form
    {
        private string tenDN;
        private DTO_BaiThi baiLam;
        public Form_ChiTietBaiLam(string maKQ, string tenDN)
        {
            InitializeComponent();
            this.tenDN = tenDN;
            baiLam = BUS_BaiLam.Instance.BaiLam(maKQ);
        }
        private void ChiTietBaiLam_Load(object sender, EventArgs e)
        {
            DataTable dt1 = DAO_BaiLam.Instance.TenNguoiDung(tenDN);
            DataTable dt2 = DAO_BaiLam.Instance.TimKiemTheoMaKQ(baiLam.MaKQ);
            DataTable dt3 = DAO_BaiLam.Instance.XemDeThi_CauHoi(baiLam.MaDe);
            ReportDataSource rds1 = new ReportDataSource();
            rds1.Name = "DataSet1";
            rds1.Value = dt1;
            ReportDataSource rds2 = new ReportDataSource();
            rds2.Name = "DataSet2";
            rds2.Value = dt2;
            ReportDataSource rds3 = new ReportDataSource();
            rds3.Name = "DataSet3";
            rds3.Value = dt3;
            reportViewer1.Visible = true;
            reportViewer1.LocalReport.ReportPath = "rptChiTietBaiLam.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds2);
            reportViewer1.LocalReport.DataSources.Add(rds1);
            reportViewer1.LocalReport.DataSources.Add(rds3);
            ReportParameter[] parameters = new ReportParameter[3];
            parameters[0] = new ReportParameter("maKQ", baiLam.MaKQ);
            parameters[1] = new ReportParameter("maGV", baiLam.MaSV);
            parameters[2] = new ReportParameter("maDe", baiLam.MaSV);
            this.reportViewer1.LocalReport.SetParameters(parameters);
            this.reportViewer1.RefreshReport();
        }

    }
}
