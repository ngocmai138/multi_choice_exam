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
    public partial class Form_MainForm_SV : Form
    {
        private FormLogin dangNhap;
        private string maSV;
        public Form_MainForm_SV(FormLogin dangNhap, string maSV)
        {
            InitializeComponent();
            this.dangNhap = dangNhap;
            this.maSV = maSV;
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnMain.Controls.Clear();
            pnMain.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void làmBàiThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_ThiTracNghiem uc = new UC_ThiTracNghiem(maSV);
            uc.NopBai += nopBai;
            addUserControl(uc);
        }

        private void kếtQuảThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_DanhSachBaiLam uc = new UC_DanhSachBaiLam(maSV);
            addUserControl(uc );
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            dangNhap.Show();
        }
        private void nopBai(DTO_BaiThi baiThi, DTO_DeThi de)
        {
            UC_NopBai uc = new UC_NopBai(baiThi,de);
            addUserControl(uc);
        }
    }
}
