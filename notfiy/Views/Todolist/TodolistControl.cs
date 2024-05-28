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
    }
}
