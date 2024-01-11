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
    public partial class MainForm_SV : Form
    {
        private string maSV;
        public MainForm_SV(FormLogin formLogin, string maSV)
        {
            InitializeComponent();
            this.maSV = maSV;
        }

        private void btnLamBaiThi_Click(object sender, EventArgs e)
        {
            ThiTracNghiem thiTracNghiem = new ThiTracNghiem(this, maSV);
            thiTracNghiem.Show();
            this.Hide();
        }
    }
}
