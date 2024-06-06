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
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();

            // Mengatur ukuran FlowLayoutPanel
            flowLayoutPanel.Size = new Size(1288, 584); // Contoh ukuran 500x300 piksel
            flowLayoutPanel.Location = new Point(93, 254); // Mengatur lokasi di dalam form

            // Mengatur properti lain jika diperlukan
            flowLayoutPanel.BackColor = Color.White; // Untuk memastikan terlihat
            flowLayoutPanel.AutoScroll = true;

            // Menambahkan FlowLayoutPanel ke Form
            this.Controls.Add(flowLayoutPanel);

            // Menambahkan beberapa tombol ke dalam FlowLayoutPanel
            for (int i = 0; i < 10; i++)
            {
                HomepageItem homepageItem = new HomepageItem();
                homepageItem.Name = $"Note {i + 1}";

                // Mengatur margin
                homepageItem.Margin = new Padding(3); // Margin kiri, atas, kanan, bawah sama 10 piksel

                // Menambahkan kontrol ke FlowLayoutPanel
                flowLayoutPanel.Controls.Add(homepageItem);
            }
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
            Navbar navbar = new Navbar();
            this.Controls.Add(navbar);
            navbar.BringToFront();
            navbar.BackColor = Color.Transparent;
            navbar.Location = new Point(1000, 0);
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

        private void homepageItem8_Load(object sender, EventArgs e)
        {

        }

        private void homepageItem2_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
