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
    public class DAO_BaiLam
    {
        private static DAO_BaiLam instance;
        public static DAO_BaiLam Instance { get { if (instance == null) instance = new DAO_BaiLam(); return instance; } }

        public DataTable XemBaiLam() {
            string query = "exec p_XemBaiThi";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable TimKiemTheoMaSV(string tukhoa)
        {
            string query = "exec p_TimKiemKetQuaMaSV @maSV";
            string[] paraName = { "@maSV" };
            object[] paraValue = { tukhoa };
            return DataProvider.Instance.ExecuteQuery (query,paraName,paraValue);
        }public DataTable TimKiemTheoMaDe(string tukhoa)
        {
            string query = "exec p_TimKiemKetQuaMaDe @maDe";
            string[] paraName = { "@maDe" };
            object[] paraValue = { tukhoa };
            return DataProvider.Instance.ExecuteQuery (query,paraName,paraValue);
        }
        public DataTable TimKiemTheoMaKQ(string tukhoa)
        {
            string query = "exec p_TimKiemKetQuaMaKQ @maKQ";
            string[] paraName = { "@maKQ" };
            object[] paraValue = { tukhoa };
            return DataProvider.Instance.ExecuteQuery(query, paraName, paraValue);
        }
        public DataTable TenNguoiDung(string tenDN)
        {
            string query = "exec p_GiaoVien @maGV";
            string[] paraName = { "@maGV" };
            object[] paraValue = { tenDN };
            return DataProvider.Instance.ExecuteQuery(query, paraName, paraValue);
        }
        public DataTable XemDeThi_CauHoi(string maDe)
        {
            string query = "exec p_DeThi_CauHoi @maDe";
            string[] paraName = { "@maDe" };
            object[] paraValue = { maDe };
            return DataProvider.Instance.ExecuteQuery(query,paraName,paraValue);
        }
    }
}
