using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThiTracNghiem
{
    internal class DAO_ThongKe
    {
        private static DAO_ThongKe instance;
        public static DAO_ThongKe Instance { 
            get {
                if(instance == null)
                {
                    instance = new DAO_ThongKe();
                }
                return instance; } 
        }
        public DataTable ThongKeDTBTheoLop(string maLop)
        {
            string query = "exec XemDTBLop @maLop";
            string[] paraName = { "@maLop" };
            object[] paraValue = { maLop };
            return DataProvider.Instance.ExecuteQuery(query, paraName, paraValue);
        }
        public DataTable TyLeDatTruotTheoLop(string maLop, int diemTruot)
        {
            string query = "exec p_TyLeDoRotTheoLop @maLop, @diem";
            string[] paraName = { "@maLop", "@diem" };
            object[] paraValue = { maLop, diemTruot };
            return DataProvider.Instance.ExecuteQuery(query, paraName, paraValue);
        }
        public DataTable DSMaLop()
        {
            string query = "exec p_DSMaLop";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
