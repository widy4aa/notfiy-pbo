using notfiy.Views.Other;
using notfiy.Entities;
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
    public partial class HomepageDetail : UserControl
    {
        public HomepageDetail(int? idNote = null)
        {
            InitializeComponent();
        }

        private void HomepageDetail_Load(object sender, EventArgs e)
        {

        }

        private void kryptonRichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonLabel2_Click(object sender, EventArgs e)
        {

        }

        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kryptonTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonBorderEdge1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            HomepageAddImage homepageaddimage = new HomepageAddImage();
            this.Controls.Add(homepageaddimage);
            homepageaddimage.BringToFront();
            homepageaddimage.BackColor = Color.Transparent;
            homepageaddimage.Location = new Point(438, 227);
        }
    }
}
