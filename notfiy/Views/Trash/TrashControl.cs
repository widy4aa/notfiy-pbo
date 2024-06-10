using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using notfiy.Views.Other;

namespace notfiy.Views.Trash
{
    public partial class TrashControl : UserControl
    {
        public TrashControl()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HamburgerButton_Click(object sender, EventArgs e)
        {
            Navbar navbar = new Navbar();
            this.Controls.Add(navbar);
            navbar.BringToFront();
            navbar.BackColor = Color.Transparent;
            navbar.Location = new Point(1000, 0);
        }
    }
}
