using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWinForms
{
    internal class UserDAO
    {
        private static UserDAO instance;
        public static UserDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserDAO();
                }
                return instance;
            }
        }
        private UserDAO() { }
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
    }
}
