using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThiTracNghiem
{
    public partial class NganHangCauHoi : Form
    {
        private MainForm mainForm;
        public NganHangCauHoi(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }
        string connectionString = @"Data Source=.\;Initial Catalog=NganHangCauHoi;User ID=sa;Password=123;TrustServerCertificate=True";
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Hide();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string query = "exec p_DanhSachCH";
            dtgNHCH.DataSource = ExecuteQuery(query);
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
     
        private void dtgNHCH_SelectionChanged(object sender, EventArgs e)
        {
            if(dtgNHCH.SelectedRows.Count > 0)
            {
                string maCH = dtgNHCH.SelectedRows[0].Cells["Mã câu hỏi"].Value.ToString();
                string query = "exec p_ChiTietDA @maCH";
                string[] paraName = { "@maCH" };
                object[] paraValue = { maCH};
                dtgChiTietCH.DataSource = ExecuteQuery(query,paraName,paraValue);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(cbbTimKiem.SelectedItem == null)
            {
                btnXem_Click(sender, e);
            }
            else 
            if (cbbTimKiem.SelectedItem.ToString()== "mã câu hỏi")
            {
                string query = "exec p_TimCHTheoMaCH @maCH";
                string[] paraName = { "@maCH" };
                object[] paraValue = {txtTimKiem.Text};
                dtgNHCH.DataSource = ExecuteQuery(query,paraName,paraValue);
            }else if (cbbTimKiem.SelectedItem.ToString()=="nội dung câu hỏi")
            {
                string query = "exec p_TimCHTheoND @noiDungCH";
                string[] paraName = { "@noiDungCH" };
                object[] paraValue = {txtTimKiem.Text };
                dtgNHCH.DataSource = ExecuteQuery(query,paraName,paraValue);
            }
        }

        /// <summary>
        /// Trả ra datatable theo câu query
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        DataTable ExecuteQuery(String query, string[] paraName = null, object[] paraValue = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataTable table = new DataTable();
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (paraName != null && paraValue != null)
                {
                    for (int i = 0; i < paraValue.Length; i++)
                    {
                        command.Parameters.AddWithValue(paraName[i], paraValue[i]);
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                connection.Close();
                return table;
            }
        }
    }
}
