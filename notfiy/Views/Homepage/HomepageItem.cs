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
    public partial class HomepageItem : UserControl
    {
        public HomepageItem()
        {
            InitializeComponent();
        }

        private void HomepageItem_Load(object sender, EventArgs e)
        {
            kryptonButton2.Hide();
        }

        private void kryptonLabel2_Click(object sender, EventArgs e)
        {

        }

        private void kryptonRichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonMaskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void kryptonLabel2_Click_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            kryptonButton3.Show();
            kryptonButton2.Hide();
        }

        private void kryptonRichTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            kryptonButton3.Hide();
            kryptonButton2.Show();
        }
    }
}
