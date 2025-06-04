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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ✅ Create and show your UserControl on the form
            var customerControl = new User_Control.UserControl1(); // Use correct namespace
            customerControl.Dock = DockStyle.Fill; // Fill the whole form

            this.Controls.Add(customerControl); // Add control to form
        }
    }
}

