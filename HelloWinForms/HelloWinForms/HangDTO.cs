using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWinForms
{
    class HangDTO
    {
        private string idHang;
        public string IdHang { get { return idHang; } set { idHang = value; } }
        private string tenHang;
        public string TenHang { get { return tenHang; } set { tenHang = value; } }
        private string idNCC;
        public string IdNCC { get { return idNCC; } set { idNCC = value; }}
        private string donViTinh;
        public string DonViTinh { get { return donViTinh; } set { donViTinh = value; } }
        private string quyCach;
        public string QuyCach { get { return quyCach; } set { quyCach = value; } }

    }
}
