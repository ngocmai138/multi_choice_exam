using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThiTracNghiem
{
    public class DTO_DeThi
    {
        private string maDe;
        public string MaDe { get { return maDe; } set { maDe = value; } }
        private List<DTO_CauHoi> cauHois;
        public List<DTO_CauHoi> CauHois { get { return cauHois; } set { cauHois = value; } }
    }
}
