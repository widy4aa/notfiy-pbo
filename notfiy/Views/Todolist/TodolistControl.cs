using notfiy.Views.Other;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotifyViewManager = notfiy.Core.ViewManager;


namespace notfiy.Views.Todolist
{
    public partial class TodolistControl : UserControl
    {
        public TodolistControl()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TodoItem_Click(object sender, EventArgs e)
        {
            TodoDetail detail = new TodoDetail();
            NotifyViewManager.MoveView(detail);

        }

        private void todoItem1_Load(object sender, EventArgs e)
        {

        }

        private void UsernameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void todoItem3_Load(object sender, EventArgs e)
        {

        }

        private void todoItem12_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {

        }

        private void TodolistControl_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.AutoScroll = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
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

            Navbar navbar = new Navbar();
            this.Controls.Add(navbar);
            navbar.BringToFront();
            navbar.BackColor = Color.Transparent;
            navbar.Location = new Point(990, 0);
        }

        private void todoItem12_Load_1(object sender, EventArgs e)
        {
           
        }
    }
}
