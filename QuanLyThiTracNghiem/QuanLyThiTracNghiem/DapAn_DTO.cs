using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThiTracNghiem
{
    public class DapAn_DTO
    {
        private string maDA;
        public string MaDA { get { return maDA; } set { maDA = value; } }
        private string maCH;
        public string MaCH { get {  return maCH; } set { maCH = value; } }
        private string noiDungDA;
        public string NoiDungDA { get { return noiDungDA; } set {  noiDungDA = value; } }
        private bool dung ;
        public bool Dung { get { return dung; } set { dung = value; } }
        private bool sVChon;
        public bool SVChon { get {  return sVChon; } set {  sVChon = value; } }
    }
}
