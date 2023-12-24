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

namespace QuanLyThiTracNghiem
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=.\;Initial Catalog=NganHangCauHoi;User ID=sa;Password=123;TrustServerCertificate=True");
            try {
                sqlConnection.Open();
                string query = "exec p_DangNhap @id= @id, @mk = @mk";
                SqlCommand command = new SqlCommand(query, sqlConnection);
                command.Parameters.AddWithValue("@id",txtTenDN.Text);
                command.Parameters.AddWithValue("@mk", txtMatKhau.Text);
                string[] paraNames = new string[] {"@id","@mk" };
                object[] paraValues = new object[] { txtTenDN, txtMatKhau};
                string tk = txtTenDN.Text;
                string mk = txtMatKhau.Text;
                
                SqlDataReader dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    MainForm f = new MainForm(this);
                    f.Show();
                    this.Hide();
                    
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công");
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Lỗi kết nối");
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
