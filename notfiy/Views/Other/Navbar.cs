using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notfiy.Views.Other
{
    public partial class Navbar : UserControl
    {
        public Navbar()
        {
            InitializeComponent();
            kryptonPictureBox1.BackColor = Color.FromArgb(46, 26, 94);
        }

        private void kryptonPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Navbar_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
            flowLayoutPanel1.AutoScroll = true;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            //kryptonButton7.StateCommon.Back.Image;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
