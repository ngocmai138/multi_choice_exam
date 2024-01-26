using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThiTracNghiem
{
    public class DTO_NHCH
    {
        private string maCH;
        public string MaCH
        {
            get { return maCH; }
            set { maCH = value; }
        }
        private string noiDungCH;
        public string NoiDungCH { get { return noiDungCH; } set { noiDungCH = value; } }
        private List<DTO_DapAn> dA;
        public List<DTO_DapAn> DA
        {
            get { return dA; }
            set { dA = value; }

        }
    }
}
