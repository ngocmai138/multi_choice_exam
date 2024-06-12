using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThiTracNghiem
{
    public partial class Form_MainForm_GV2 : Form
    {
        private FormLogin dangNhap;
        private string tenDN;
        public Form_MainForm_GV2(FormLogin dangNhap, string tenDN)
        {
            InitializeComponent();
            this.dangNhap = dangNhap;
            this.tenDN = tenDN;
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnMain.Controls.Clear();
            pnMain.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void ngânHàngCâuHỏiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_NganHangCauHoi ucNHCH = new UC_NganHangCauHoi(); ;
            addUserControl(ucNHCH);
        }

        private void quảnLýBàiThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_QuanLyBaiThi uc = new UC_QuanLyBaiThi(tenDN);
            addUserControl(uc);
        }

        private void quảnLýĐềThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_QuanLyDeThi uc = new UC_QuanLyDeThi();
            addUserControl(uc);
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_QLSinhVien uc = new UC_QLSinhVien();
            addUserControl(uc);
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_BaoCaoThongKe uc = new UC_BaoCaoThongKe("SV");
            addUserControl(uc);
        }

        private void ngânHàngCâuHỏiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UC_BaoCaoThongKe uc = new UC_BaoCaoThongKe("NHCH");
            addUserControl(uc);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            dangNhap.Show();
        }

        private void theoLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_BaoCaoThongKe uc = new UC_BaoCaoThongKe("Lop");
            addUserControl(uc);
        }
    }
}
