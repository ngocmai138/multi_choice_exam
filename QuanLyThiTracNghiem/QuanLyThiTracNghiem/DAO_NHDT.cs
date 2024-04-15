using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThiTracNghiem
{
    public class DAO_NHDT
    {
        private static DAO_NHDT instance;
        public static DAO_NHDT Instance { get { if (instance == null) instance = new DAO_NHDT(); return instance; } }
        public DataTable Xem_DeThi()
        {
            string query = "exec p_XemDeThi";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable Xem_CH(string maDe)
        {
            string query = "exec p_DeThi_CauHoi @maDe";
            string[] paraName = { "@maDe" };
            object[] paraValue = { maDe };
            return DataProvider.Instance.ExecuteQuery(query, paraName, paraValue);
        }
        public string TaoMaDeThi()
        {
            string query = "exec p_TaoDeThi @socau, @maDe output";
            string de = "";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@socau",10),
                new SqlParameter("@maDe", SqlDbType.NVarChar, 6)
                {
                    Direction = ParameterDirection.Output
                }
            };
            DataProvider.Instance.ExecuteScalar(query, parameters);
            de = parameters[1].Value.ToString();
            return de;
        }
        public List<object> TaoDeThi(string maDe)
        {
            string query = "exec p_DeThi_CauHoi @maDe";
            string[] paraName = new string[] { "@maDe" };
            object[] paraValue = new object[] { maDe };
            List<object> objs = DataProvider.Instance.ExecuteReader(query, paraName, paraValue);
            return objs;
        }
        public List<object> XemDapAn(string maCH)
        {
            string query = "exec p_ChiTietDA @maCH";
            string[] paraName = { "@maCH" };
            object[] paraValue = { maCH };
            List<object> objs = DataProvider.Instance.ExecuteReader(query, paraName, paraValue);
            return objs;
        }
        public bool XoaDeThi(string maDe)
        {
            string query = "exec p_XoaDeThi @maDe";
            string[] paraName = { "@maDe" };
            object[] paraValue = {maDe};
            if(DataProvider.Instance.ExecuteNonQuery(query, paraName, paraValue) > 0)
            {
                return true;
            }else 
                return false;
        }
    }
}
