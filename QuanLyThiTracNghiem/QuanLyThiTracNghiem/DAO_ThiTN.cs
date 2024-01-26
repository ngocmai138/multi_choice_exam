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
    public class DAO_ThiTN
    {
        private static DAO_ThiTN instance;
        public static DAO_ThiTN Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new DAO_ThiTN();
                }
                return instance;
            }
        }
        public List<object> XemSV(string maSV)
        {
            DTO_SinhVien sv = new DTO_SinhVien();
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

        public bool LuuCauTraLoi(string maKQ, string maCH, string maDA)
        {
            string query = "exec p_ThemBaiLamMoi @maKQ, @maCH, @maDA";
            string[] paraName = { "@maKQ", "@maCH", "@maDA" };
            object[] paraValue = { maKQ, maCH, maDA};
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

        public int Diem(string maKQ)
        {
            string query = "exec p_XemDiem @maKQ";
            string[] paraName = { "@maKQ" };
            object[] paraValue = { maKQ };
            return Int32.Parse(DataProvider.Instance.ExecuteScalar(query, paraName, paraValue).ToString());
        }
    }
}
