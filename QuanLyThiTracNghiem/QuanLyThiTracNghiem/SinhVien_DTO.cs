using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThiTracNghiem
{
    public class SinhVien_DTO
    {
        private string maSV;
        public string MaSV { get { return maSV; } set { maSV = value; } }
        private string tenSV;
        public string TenSV { get { return tenSV; } set { tenSV = value; } }
        private string maLop;
        public string MaLop { get {  return maLop; } set {  maLop = value; } }
    }
}
