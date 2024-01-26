using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThiTracNghiem
{
    internal class DAO_SinhVien
    {
        private static DAO_SinhVien instance;
        public static DAO_SinhVien Instance { 
            get { 
                if (instance == null) { 
                    instance = new DAO_SinhVien(); 
                }
             return instance; 
            } 
        }
        public DataTable XemDSSV()
        {
            string query = "exec XemDSSV";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable ThongTinSV(string maSV)
        {
            string query = "exec XemThongTinSV_MaSV @maSV";
            string[] paraName = { "@maSV" };
            object[] paraValue = { maSV };
            return DataProvider.Instance.ExecuteQuery(query,paraName,paraValue);
        }
        public bool Sua(string maSV, string tenSV, string maLop)
        {
            string query = "exec p_SuaSV @maSV, @maLop, @tenSV";
            string[] paraName = { "@maSV", "@tenSV", "@maLop" };
            object[] paraValue = {maSV,tenSV, maLop };
            if(DataProvider.Instance.ExecuteNonQuery(query,paraName,paraValue)>0)
            {
                return true;
            }
            return false;
        }
    }
}
