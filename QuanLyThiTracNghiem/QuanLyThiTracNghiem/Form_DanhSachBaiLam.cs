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
    public partial class Form_DanhSachBaiLam : Form
    {
        Form_MainForm_SV formSV;
        String maSV;
        public Form_DanhSachBaiLam(Form_MainForm_SV formSV, String maSV)
        {
            InitializeComponent();
            this.formSV = formSV;
            this.maSV = maSV;
        }


        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            formSV.Show();
            this.Hide();
        }

        private void Form_DanhSachBaiLam_Load(object sender, EventArgs e)
        {
            BUS_ThiTN.Instance.DanhSachBaiLam(dtgvDSBL, maSV);
        }
    }
}
