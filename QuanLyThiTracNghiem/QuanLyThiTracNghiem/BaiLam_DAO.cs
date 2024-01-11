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
    public class BaiLam_DAO
    {
        private static BaiLam_DAO instance;
        public static BaiLam_DAO Instance { get { if (instance == null) instance = new BaiLam_DAO(); return instance; } }

        public DataTable XemBaiLam() {
            string query = "exec p_XemBaiThi";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable XemMaDe()
        {
            string query= "exec p_XemMaDe";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable XemMaSV()
        {
            string query = "exec p_XemMaSV";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
