using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWinForms
{
     class HangBUS
    {
        private static HangBUS instance;
        public static HangBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HangBUS();
                }
                return instance;
            }
        }
        private HangBUS() { }
        public void Xem(DataGridView data)
        {
            data.DataSource = HangDAO.Instance.Xem();
        }
        public void Tim_ID(DataGridView data, String txtTim) 
        {
            data.DataSource = HangDAO.Instance.Tim_ID(txtTim);
        }
        public bool Xoa_ID(DataGridView data)
        {
            string id = data.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString();
            return HangDAO.Instance.XoatheoID(id);
        }

        public bool Sua_ID(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            string hangID= row.Cells["ID"].Value.ToString();
            string tenHang = row.Cells["Tên hàng hóa"].Value.ToString();
            string NCCid = row.Cells["Nhà cung cấp"].Value.ToString();
            string donViTinh = row.Cells["Đơn vị tính"].Value.ToString();
            string quyCach = row.Cells["Quy cách"].Value.ToString();
            HangDTO hang = new HangDTO() { IdHang = hangID, TenHang = tenHang, IdNCC = NCCid, DonViTinh = donViTinh, QuyCach = quyCach};
            return HangDAO.Instance.SuatheoID(hangID, hang);
        }

        public bool Them(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            string id = row.Cells["ID"].Value.ToString();
            string ten = row.Cells["Tên hàng hóa"].Value.ToString() ;
            string ncc = row.Cells["Nhà cung cấp"].Value.ToString();
            string donvitinh = row.Cells["Đơn vị tính"].Value.ToString();
            string quycach = row.Cells["Quy cách"].Value.ToString();
            HangDTO hang = new HangDTO() { IdHang = id, TenHang = ten, IdNCC = ncc, DonViTinh = donvitinh, QuyCach = quycach};
            return HangDAO.Instance.Them(hang);
        }

        
    }
}
