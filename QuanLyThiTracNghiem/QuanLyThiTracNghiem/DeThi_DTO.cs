using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThiTracNghiem
{
    public class DeThi_DTO
    {
        private string maDe;
        public string MaDe { get { return maDe; } set { maDe = value; } }
        private List<CauHoi_DTO> cauHois;
        public List<CauHoi_DTO> CauHois { get { return cauHois; } set { cauHois = value; } }
    }
}
