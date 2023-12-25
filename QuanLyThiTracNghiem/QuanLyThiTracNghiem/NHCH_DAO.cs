using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThiTracNghiem
{
    public class NHCH_DAO
    {
        private static NHCH_DAO instance;
        public static NHCH_DAO Instance { 
            get { 
                if (instance == null)
                {
                    instance = new NHCH_DAO();
                }
                return instance; 
            } 
        }

        public DataTable Xem()
        {
            string query = "exec p_DanhSachCH";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable Xem_DA(string maCH)
        {
            string query = "exec p_ChiTietDA @maCH";
            string[] paraName = { "@maCH" };
            object[] paraValue = { maCH };
            return DataProvider.Instance.ExecuteQuery(query,paraName, paraValue);
        }

        public DataTable TimKiem_MaCH(string tuKhoa)
        {
                string query = "exec p_TimCHTheoMaCH @maCH";
                string[] paraName = { "@maCH" };
                object[] paraValue = { tuKhoa };
                return DataProvider.Instance.ExecuteQuery(query, paraName, paraValue);     
        }
        public DataTable TimKiem_NoiDung(string tuKhoa) {
            string query = "exec p_TimCHTheoND @noiDungCH";
            string[] paraName = { "@noiDungCH" };
            object[] paraValue = { tuKhoa };
            return DataProvider.Instance.ExecuteQuery(query, paraName, paraValue);
        }

        public bool XoaCH_MaCH(string maCH)
        {
            string query = "exec p_XoaCauHoi @maCH";
            string[] paraName = { "@maCH" };
            object[] paraValue = { maCH };
            if (DataProvider.Instance.ExecuteNonQuery(query, paraName, paraValue) > 0)
                return true;
            else
                return false;
        }
    }
}
