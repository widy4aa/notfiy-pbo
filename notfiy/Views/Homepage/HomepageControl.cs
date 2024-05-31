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
    }
}
