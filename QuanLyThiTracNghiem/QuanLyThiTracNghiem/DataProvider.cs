﻿using System;
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
                try
                {
                    acceptedRow = command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                      throw new Exception(ex.Message);
                    //return -1;
                }
                connection.Close();
                return acceptedRow;
            }
        }
        public string ExecuteScalar(String query, SqlParameter[] parameters = null)
        {
            string outputValue = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {                
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameters!=null)
                {
                        command.Parameters.AddRange(parameters);
                    
                }
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    outputValue = result.ToString();
                }
                connection.Close();
            }
            return outputValue;
        }
        /// <summary>
        /// Trả về đối tượng từ câu lệnh query
        /// </summary>
        /// <param name="query"></param>
        /// <param name="paraName"></param>
        /// <param name="paraValue"></param>
        /// <returns></returns>
        public object ExecuteScalar(String query, string[] paraName=null, object[] paraValue = null)
        {
            object obj = null;
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                if(paraName != null && paraValue != null)
                {
                    for(int i = 0;i < paraValue.Length; i++)
                    {
                        sqlCommand.Parameters.AddWithValue(paraName[i], paraValue[i]);
                    }
                }
                obj = sqlCommand.ExecuteScalar();
                connection.Close();
                return obj;
            }
        }
        /// <summary>
        /// Trả về danh sách đối tượng từ câu query
        /// </summary>
        /// <param name="query"></param>
        /// <param name="paraName"></param>
        /// <param name="paraValue"></param>
        /// <returns></returns>
        public List<object> ExecuteReader(string query, string[] paraName, object[] paraValue)
        {
            List<object> obj = new List<object>();
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                if( paraName != null && paraValue != null)
                {
                    for(int i = 0; i< paraValue.Length; i++)
                    {
                        sqlCommand.Parameters.AddWithValue(paraName[i], paraValue[i]);
                    }
                }
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    for(int i = 0; i<reader.FieldCount; i++)
                    {
                        obj.Add( reader.GetValue(i));
                    }
                }
            }
            return obj;
        }
    }
}
