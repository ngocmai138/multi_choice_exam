using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThiTracNghiem
{
    public class DTO_CauHoi
    {
        private string maCH;
        public string MaCH { get { return maCH; } set { maCH = value; } }
        private string noiDungCH;
        public string NoiDungCH { get { return noiDungCH; } set { noiDungCH = value; } }
        private List<DTO_DapAn> dapAns;
        public List<DTO_DapAn> DapAns {  get { return dapAns; } set { dapAns = value; } }
    }
}
