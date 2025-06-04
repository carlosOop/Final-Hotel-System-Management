using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DASHBOARD : Form
    {
        public DASHBOARD()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            movingpanel.Left = BtnTItle.Left + 150;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            movingpanel.Left = BtnHome.Left+10;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            movingpanel.Left = BtnHistory.Left + 10;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            movingpanel.Left = BtnCheckout.Left + 23;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            movingpanel.Left = BtnRegistration.Left+68;


        }

        private void DASHBOARD_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            movingpanel.Left = BtnManage.Left + 25;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void movingpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
