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
    public partial class BaoCaoThongKe : Form
    {
        private MainForm_GV mainForm_GV;
        public BaoCaoThongKe(MainForm_GV mainForm_GV)
        {
            InitializeComponent();
            this.mainForm_GV = mainForm_GV;
            Button btn = new Button();
            btn.Name = "btnKQTheoLop";
            Btn_Click(btn,null);
        }
        private void Them_UserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnMain.Controls.Clear();
            pnMain.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            foreach(var pn in tableLayoutPanel1.Controls.OfType<Panel>())
            {
                pn.BackColor = Color.Silver;
            }
            Button btn = (Button)sender;
            switch(btn.Name)
            {
                case "btnKQTheoLop":
                    Them_UserControl(new UKQThiTheoLop());
                    pnKQTheoLop.BackColor = Color.WhiteSmoke;
                    break;
                case "btnKQTheoSV":
                    Them_UserControl(new UKQThiTheoSV());
                    pnKQTheoSV.BackColor = Color.WhiteSmoke;
                    break;
                case "btnTK_NHCH":
                    Them_UserControl(new UThongKe_NHCH());
                    pnTK_NHCH.BackColor = Color.WhiteSmoke;
                    break;
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            mainForm_GV.Show();
            this.Hide();
        }
    }
}
