using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThiTracNghiem
{
    internal class BUS_ThongKe
    {
        private static BUS_ThongKe instance;
        public static BUS_ThongKe Instance { get { 
                if(instance == null) { instance = new BUS_ThongKe();}
                return instance; } }

        public void ThongKeDTBTheoLop(DataGridView dtg, string maLop)
        {
            dtg.DataSource = DAO_ThongKe.Instance.ThongKeDTBTheoLop(maLop);
        }
        public void TyLeDatTruotTheoLop(DataGridView dtg, string maLop, int diemTruot)
        {
            dtg.DataSource = DAO_ThongKe.Instance.TyLeDatTruotTheoLop(maLop, diemTruot); 
        }
        public void ThongKeTheoMaSV(DataGridView dtg, string maSV)
        {
            dtg.DataSource = DAO_ThongKe.Instance.ThongKeTheoMaSV(maSV);
        }
    }
}
