using Krypton.Toolkit;
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
    public partial class LabelItem : UserControl
    {
        public LabelItem()
        {
            InitializeComponent();
            kryptonTextBox1.Text = kryptonButton7.Text;
            kryptonTextBox1.Hide();


        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            kryptonButton7.Hide();
            kryptonButton2.Hide();
            kryptonButton1.Hide();

            kryptonTextBox1.Show();


        }

        private void kryptonButton7_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                kryptonButton7.Text = kryptonTextBox1.Text;
                kryptonTextBox1.Hide();

                kryptonButton7.Show();
                kryptonButton2.Show();
                kryptonButton1.Show();


            }
        }
    }
}
