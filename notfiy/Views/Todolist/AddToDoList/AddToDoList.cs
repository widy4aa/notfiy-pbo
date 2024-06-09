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

namespace notfiy.Views.AddToDoList
{
    public partial class AddToDoList : UserControl
    {
        public AddToDoList()
        {
            InitializeComponent();
        }
        private void AddToDoList_Load(object sender, EventArgs e)
        {

        }
        private void kryptonTextBox1_Enter(object sender, EventArgs e)
        {
            kryptonTextBox1.Text = "";
        }
        private void kryptonTextBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(kryptonTextBox1.Text))
            {
                kryptonTextBox1.Text = "Judul";
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            //DoItemEdit doitem = new DoItemEdit();
            flowLayoutPanel2.Controls.Add(new DoItemEdit());

            //kryptonTextBox1.Controls.Add(doitem);

            //KryptonTextBox textbox = doitem.GetKrypto

            //flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            //flowLayoutPanel2.AutoScroll = true;
        }
    }
}
