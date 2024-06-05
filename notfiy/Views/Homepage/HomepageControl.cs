using Krypton.Toolkit;
using notfiy.Views.Other;
using notfiy.Views.Todolist;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notfiy.Views.Homepage
{
    public partial class HomepageControl : UserControl
    {
        public HomepageControl()
        {
            InitializeComponent();
        }
        private void HomepageControl_Load(object sender, EventArgs e)
        {
            HomepagePanel1.AutoScroll = true;
        }

        private void UsernameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homepageItem1_Load(object sender, EventArgs e)
        {

        }

        private void HamburgerButton_Click(object sender, EventArgs e)
        {
            //Sidebar sidebar = new Sidebar();
            //this.Controls.Add(sidebar);
            //sidebar.BringToFront();
            //sidebar.BackColor = Color.Transparent;
            //sidebar.Location = new Point(950, 0);
            //sidebar.Show();
        }

        private void homepageItem7_Load(object sender, EventArgs e)
        {

        }

        private void kryptonPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homepageItem10_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
