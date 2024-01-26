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
    public partial class QLSinhVien : Form
    {
        private MainForm_GV mainForm_GV;
        public QLSinhVien(MainForm_GV mainForm_GV)
        {
            InitializeComponent();
            this.mainForm_GV = mainForm_GV;
            btnXem_Click(this, new EventArgs());
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text == "Sửa")
            {
            txtTenSV.Text = lbTenSV.Text;
            lbTenSV.Visible = false;
            txtTenSV.Visible = true;
            txtMaLop.Text = lbMaLop.Text;
            lbMaLop.Visible = false;
            txtMaLop.Visible = true;
                btnSua.Text = "Hoàn thành";
            }else if(btnSua.Text == "Hoàn thành")
            {
                btnSua.Text = "Sửa";
                if (BUS_SinhVien.Instance.Sua(lbMaSV.Text, txtTenSV.Text, txtMaLop.Text)){
                    lbTenSV.Text = txtTenSV.Text;
                    lbTenSV.Visible = true;
                    txtTenSV.Visible = false;
                    lbMaLop.Text = txtMaLop.Text;
                    lbMaLop.Visible = true;
                    txtMaLop.Visible = false;
                    btnXem_Click(sender, new EventArgs());
                } else
                    MessageBox.Show("Lỗi");
            }
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            BUS_SinhVien.Instance.HienThiThongTinSV(dtgDSSV, dtgChiTiet,lbMaSV, lbTenSV, lbMaLop);
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            mainForm_GV.Show();
            this.Hide();
        }

        private void dtgDSSV_SelectionChanged(object sender, EventArgs e)
        {
            BUS_SinhVien.Instance.HienThiThongTinSV(dtgDSSV, dtgChiTiet, lbMaSV, lbTenSV, lbMaLop);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            BUS_SinhVien.Instance.XemDSSV(dtgDSSV);
        }
    }
}
