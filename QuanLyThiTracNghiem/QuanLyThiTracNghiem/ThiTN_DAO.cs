using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThiTracNghiem
{
    public class ThiTN_DAO
    {
        private static ThiTN_DAO instance;
        public static ThiTN_DAO Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new ThiTN_DAO();
                }
                return instance;
            }
        }
        public List<object> XemSV(string maSV)
        {
            SinhVien_DTO sv = new SinhVien_DTO();
            string query = "exec p_SinhVien @maSV";
            string[] paraName = new string[] { "@maSV" };
            object[] paraValue = new object[] { maSV };
            return DataProvider.Instance.ExecuteReader(query, paraName, paraValue);
        }

        public List<object> BaiThi(string maSV, string maDe) {
            string query = "exec p_XemKetQua @maSV, @maDe";
            string[] paraName = new string[] { "@maSV", "@maDe" };
            object[] paraValue = new object[] { maSV, maDe };
            List<object> baithi = DataProvider.Instance.ExecuteReader(query, paraName, paraValue);
            return baithi;
        }
        public string MaDe()
        {
            string query = "exec p_LayMaDeNgauNhien";
            string made = DataProvider.Instance.ExecuteScalar(query, null);
            return made;
        }

        public bool LuuBaiThi(BaiThi_DTO baithi)
        {
            string query = "exec p_CapNhatDiem @maKQ, @diem";
            string[] paraName = { "@maKQ", "@diem" };
            object[] paraValue = { baithi.MaKQ, baithi.Diem };
            if (DataProvider.Instance.ExecuteNonQuery(query, paraName, paraValue) > 0)
            {
                return true;
            }
            return false;
        }
        public (string, DateTime) TaoBaiThi(string maSV, string maDe)
        {
            string query = "exec p_ThemBaiThiMoi @maDe, @maSV, @maKQ output, @ngaythi output";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maDe",maDe),
                new SqlParameter("@maSV", maSV),
                new SqlParameter("@maKQ", SqlDbType.NVarChar, 6)
                {
                    Direction = ParameterDirection.Output
                },
                new SqlParameter("@ngaythi", SqlDbType.DateTime)
                {
                    Direction = ParameterDirection.Output
                }
            };
            DataProvider.Instance.ExecuteScalar(query, parameters);
            string maKQ = parameters[2].Value.ToString();
            DateTime ngaythi = Convert.ToDateTime(parameters[3].Value);
            return (maKQ, ngaythi);
        }
    }
}
