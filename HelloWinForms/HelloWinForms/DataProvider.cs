using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWinForms
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataProvider();
                }
                return instance;
            }
        }
        string connectionString= @"Data Source=.\;Initial Catalog=QlyHangHoaNhap;User ID=sa;Password=123;TrustServerCertificate=True";
        public DataTable ExecuteQuery(string query, string[] paraNames = null, object[] paraValues = null) { 
            DataTable dt = new DataTable();
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                if(paraNames != null && paraValues!=null) { 
                    for(int i = 0; i<paraNames.Length; i++)
                    {
                        command.Parameters.AddWithValue(paraNames[i], paraValues[i]);
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                conn.Close();
            }
            return dt;
        }
    }
}
