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
        public bool Sua_CH(string maCH, NHCH_DTO c)
        {
            string query = "exec p_SuaCauHoi @maCH, @noiDungCH";
            string[] paraName = { "@maCH", "@noiDungCH" };
            object[] paraValue = {maCH, c.NoiDungCH};
            if (DataProvider.Instance.ExecuteNonQuery(query, paraName, paraValue) >0){
                return true;
            }
            return false;
        }
        public bool Sua_DA(DapAn_DTO d) {
            string query = "exec p_SuaDapAn @maCH, @maDA, @noiDungDA, @dung";
            string[] paraName = { "@maCH", "@maDA", "@noiDungDA","@dung" };
            object[] paraValue = {d.MaCH, d.MaDA, d.NoiDungDA,d.Dung};
            if(DataProvider.Instance.ExecuteNonQuery (query, paraName, paraValue) > 0) {
                return true;
            }
            return false;
        }
        public bool Them_CH(NHCH_DTO c)
        {
            //MessageBox.Show(c.NoiDungCH);
            //MessageBox.Show(c.DA[0].NoiDungDA);
            //MessageBox.Show(c.DA[0].Dung.ToString());

            string query = "exec p_ThemCauHoivaDapAn @noiDungCH, @noidungda1, @dung1, @noidungda2, @dung2, @noidungda3, @dung3, @noidungda4, @dung4";
            string[] paraName = { "@noiDungCH", "@noidungda1", "@dung1", "@noidungda2", "@dung2", "@noidungda3", "@dung3", "@noidungda4", "@dung4" };
            object[] paraValue = { c.NoiDungCH, c.DA[0].NoiDungDA, c.DA[0].Dung, c.DA[1].NoiDungDA, c.DA[1].Dung, c.DA[2].NoiDungDA, c.DA[2].Dung, c.DA[3].NoiDungDA, c.DA[3].Dung };
            if(DataProvider.Instance.ExecuteNonQuery (query,paraName, paraValue) > 0) return true;
            return false;
        }
        public string DangNhap(string tenDN, string mk)
        {
            string query = "exec p_DangNhap @id, @mk";
            string[] paraNames = new string[] { "@id", "@mk" };
            object[] paraValues = new object[] { tenDN, mk };

            return (string)DataProvider.Instance.ExecuteScalar(query,paraNames,paraValues);
        }
        
    }
}
