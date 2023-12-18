using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWinForms
{
     class UserBUS
    {
        private static UserBUS instance;
        public static UserBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserBUS();
                }
                return instance;
            }
        }
        private UserBUS() { }
        public void Xem(DataGridView data)
        {
            data.DataSource = UserDAO.Instance.Xem();
        }
        public void Tim_ID(DataGridView data, String txtTim) 
        {
            data.DataSource = UserDAO.Instance.Tim_ID(txtTim);
        }
        public bool Xoa_ID(DataGridView data)
        {
            string id = data.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString();
            return UserDAO.Instance.XoatheoID(id);
        }
    }
}
