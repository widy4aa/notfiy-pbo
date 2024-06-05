using notfiy.Views.Homepage;
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
using NotifyViewManager = notfiy.Core.ViewManager;

namespace notfiy.Views.Other
{
    public partial class Sidebar : UserControl
    {
        public Sidebar()
        {
            //InitializeComponent();
        }

        private void kryptonLabel2_Click(object sender, EventArgs e)
        {
            TodolistControl todolist = new TodolistControl();
            NotifyViewManager.MoveView(todolist);
        }

        private void kryptonLabel5_Click(object sender, EventArgs e)
        {

        }

        private void kryptonLabel8_Click(object sender, EventArgs e)
        {

        }

        private void kryptonLabel3_Click(object sender, EventArgs e)
        {

        }

        private void Sidebar_Load(object sender, EventArgs e)
        {

        }

        private void kryptonLabel1_Click(object sender, EventArgs e)
        {
            HomepageControl homepage = new HomepageControl();
            NotifyViewManager.MoveView(homepage);
        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InitializeComponent()
        {

        }

        private void kryptonPictureBox9_Click(object sender, EventArgs e)
        {

        }

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
    }
}
