using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            string query = "select PK_sHangID as ID, sTenHang as N'Tên hàng hóa', FK_sNhacungcapID as N'Nhà cung cấp', sDonvitinh as N'Đơn vị tính', sQuycach as N'Quy cách' from tblHang";
            dtgData.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string query = "select PK_sHangID as ID, sTenHang as N'Tên hàng hóa', FK_sNhacungcapID as N'Nhà cung cấp', sDonvitinh as N'Đơn vị tính', sQuycach as N'Quy cách' from tblHang where PK_sHangID like @ID";
            string[] paramNames = new string[] {"@ID"};
            object[] paramValues = new object[]{txtTim.Text};
            dtgData.DataSource = DataProvider.Instance.ExecuteQuery(query,paramNames,paramValues);

        }

    }
}
