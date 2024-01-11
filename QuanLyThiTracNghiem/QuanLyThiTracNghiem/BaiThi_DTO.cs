using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThiTracNghiem
{
    public class BaiThi_DTO
    {
        private string maKQ;
        public string MaKQ { get { return maKQ; } set { maKQ = value; } }
        private string maSV;
        public string MaSV { get { return maSV; } set { maSV = value; } }
        private string maDe;
        public string MaDe { get { return maDe; } set { maDe = value; } }
        private DateTime ngayThi;
        public DateTime NgayThi { get { return ngayThi; } set { ngayThi = value; } }
        private float diem;
        public float Diem { get {  return diem; } set {  diem = value; } }
    }
}
