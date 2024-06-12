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
    public partial class UThongKe_NHCH2 : UserControl
    {
        public UThongKe_NHCH2()
        {
            InitializeComponent();
        }

        private void UThongKe_NHCH2_Load(object sender, EventArgs e)
        {
            DataTable dt = DAO_ThongKe.Instance.ThongKeNHCH();
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = dt;
            reportViewer1.Visible = true;
            reportViewer1.LocalReport.ReportPath = "rpt_ThongKeNHCH.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
