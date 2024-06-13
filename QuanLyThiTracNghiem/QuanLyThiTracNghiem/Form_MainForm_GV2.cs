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
            ResetMenuItemColor();
            ngânHàngCâuHỏiToolStripMenuItem.BackColor = Color.LightBlue;
            UC_NganHangCauHoi ucNHCH = new UC_NganHangCauHoi(); ;
            addUserControl(ucNHCH);
        }

        private void quảnLýBàiThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetMenuItemColor();
            quảnLýBàiThiToolStripMenuItem.BackColor = Color.LightBlue;
            UC_QuanLyBaiThi uc = new UC_QuanLyBaiThi(tenDN);
            addUserControl(uc);
        }

        private void quảnLýĐềThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetMenuItemColor();
            quảnLýĐềThiToolStripMenuItem.BackColor = Color.LightBlue;
            UC_QuanLyDeThi uc = new UC_QuanLyDeThi();
            addUserControl(uc);
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetMenuItemColor();
            quảnLýSinhViênToolStripMenuItem.BackColor = Color.LightBlue;
            UC_QLSinhVien uc = new UC_QLSinhVien();
            addUserControl(uc);
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetMenuItemColor();
            sinhViênToolStripMenuItem.BackColor = Color.LightBlue;
            báoCáoThốngKêToolStripMenuItem.BackColor = Color.LightBlue;
            UC_BaoCaoThongKe uc = new UC_BaoCaoThongKe("SV");
            addUserControl(uc);
        }

        private void ngânHàngCâuHỏiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ResetMenuItemColor() ;
            ngânHàngCâuHỏiToolStripMenuItem1 .BackColor = Color.LightBlue;
            báoCáoThốngKêToolStripMenuItem.BackColor = Color.LightBlue;
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
            ResetMenuItemColor();
            theoLớpToolStripMenuItem.BackColor = Color.LightBlue;
            báoCáoThốngKêToolStripMenuItem.BackColor = Color.LightBlue;
            UC_BaoCaoThongKe uc = new UC_BaoCaoThongKe("Lop");
            addUserControl(uc);
        }

        private void ResetMenuItemColor()
        {
            foreach(ToolStripMenuItem menuItem in menuStrip1.Items)
            {
                if (menuItem.HasDropDownItems)
                {
                    foreach(ToolStripMenuItem subItem in menuItem.DropDownItems)
                    {
                        subItem.BackColor = SystemColors.Control;
                    }
                }
                menuItem.BackColor = SystemColors.Control;
            }
        }
    }
}
