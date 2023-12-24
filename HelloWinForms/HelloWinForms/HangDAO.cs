using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWinForms
{
    internal class HangDAO
    {
        private static HangDAO instance;
        public static HangDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HangDAO();
                }
                return instance;
            }
        }
        private HangDAO() { }
        public DataTable Xem()
        {
            string query = "select PK_sHangID as ID, sTenHang as N'Tên hàng hóa', FK_sNhacungcapID as N'Nhà cung cấp', sDonvitinh as N'Đơn vị tính', sQuycach as N'Quy cách' from tblHang";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable Tim_ID(string txtTim) 
        {
            string query = "select PK_sHangID as ID, sTenHang as N'Tên hàng hóa', FK_sNhacungcapID as N'Nhà cung cấp', sDonvitinh as N'Đơn vị tính', sQuycach as N'Quy cách' from tblHang where PK_sHangID like @ID";
            string[] paramNames = new string[] { "@ID" };
            object[] paramValues = new object[] { txtTim };
            return DataProvider.Instance.ExecuteQuery(query, paramNames, paramValues);
        }
        public string TimMaxID()
        {
            string query = "select max(PK_sHangID) from tblHang";
            object result = DataProvider.Instance.ExecuteScalar(query);
            if(result!=null & result!= DBNull.Value) {
                string currentMaxID = result.ToString();
                int numberPart = 0;
                if(int.TryParse(currentMaxID.Substring(1),out numberPart)){
                    return "H"+(numberPart+1).ToString("D2");
                }else
                return "H01";
            }
            else { 
                return "H01"; 
            }
        }
        public bool XoatheoID(string txtID)
        {
            string query = "delete from tblHang where PK_sHangID = @id";
            string[] paraNames = new string[] { "@ID" };
            object[] paraValues = new object[] { txtID };
            if(DataProvider.Instance.ExecuteNonQuery(query, paraNames, paraValues) > 0) {
            return true;
            }
            return false;
        }
        public bool SuatheoID(string txtID, HangDTO hang)
        {
            string query = "update tblHang set PK_sHangID = @id, sTenHang = @tenHang, FK_sNhacungcapID = @NCCID, sDonvitinh = @donViTinh, sQuycach = @quyCach where PK_sHangID = @id";
            string[] paraNames = new string[] { "@id","@tenHang", "@NCCID", "@donViTinh", "@quyCach"};
            object[] paraValues = new object[] { hang.IdHang, hang.TenHang, hang.IdNCC, hang.DonViTinh, hang.QuyCach };
            if(DataProvider.Instance.ExecuteNonQuery(query,paraNames,paraValues) > 0) { return true; }
            return false;
        }

        public bool Them(HangDTO hang)
        {
            string query = "insert into tblHang values (@id, @tenHang, @NCCID, @donViTinh, @quyCach)";
            if (checkIDTonTai(hang.IdHang))
            {
                hang.IdHang = TimMaxID();
            }
            string[] paraNames = new string[] { "@id", "@tenHang","@NCCID", "@donViTinh", "@quyCach"};
            object[] paraValues = new object[] { hang.IdHang, hang.TenHang, hang.IdNCC, hang.DonViTinh, hang.QuyCach};
            if(DataProvider.Instance.ExecuteNonQuery(query, paraNames,paraValues) > 0) return true;
            return false;
        }
        bool checkIDTonTai(string id)
        {
            string query = "select count(*) from tblHang where PK_sHangID = @ID";
            string[] paraNames = new string[] { "@ID" };
            object[] paraValues = new object[] { id };
            object result = DataProvider.Instance.ExecuteScalar(query, paraNames, paraValues);
            if(result!=null && result != DBNull.Value)
            {
                if(int.TryParse(result.ToString(),out int count))
                {
                    return count > 0;
                }
            }
            return false;
        }
    }
}
