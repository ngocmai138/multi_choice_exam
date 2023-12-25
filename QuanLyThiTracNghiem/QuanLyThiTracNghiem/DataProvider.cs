using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThiTracNghiem
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance { 
            get { 
                if (instance == null)
                {
                    instance = new DataProvider();
                }
                return instance; 
            } 
        }
        string connectionString = @"Data Source=.\;Initial Catalog=NganHangCauHoi;User ID=sa;Password=123;TrustServerCertificate=True";
        /// <summary>
        /// Trả ra data table theo câu query
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public DataTable ExecuteQuery(String query, string[] paraName = null, object[] paraValue = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                DataTable table = new DataTable();
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
        /// <summary>
        /// Thực hiện thêm || sửa || xóa
        /// </summary>
        /// <param name="query"></param>
        /// <param name="paraName"></param>
        /// <param name="paraValue"></param>
        /// <returns></returns>
        public int ExecuteNonQuery(String query, string[] paraName=null, object[] paraValue = null)
        {
            int acceptedRow = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand(query, connection);
                if (paraName != null && paraValue != null)
                {
                    for (int i = 0; i < paraValue.Length; i++)
                    {
                        command.Parameters.AddWithValue(paraName[i], paraValue[i]);
                    }
                }
                acceptedRow = command.ExecuteNonQuery();
                connection.Close();
                return acceptedRow;
            }
        }
    }
}
