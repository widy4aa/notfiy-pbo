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
    public partial class TodoItem : UserControl
    {
        public TodoItem()
        {
            InitializeComponent();
        }

        public void kryptonLabel1_Click(object sender, EventArgs e)
        {
            kryptonButton2.Hide();
        }

        private void flowLayoutPanel1_Click(object sender, EventArgs e)
        {
            TodoDetail detail = new TodoDetail();
            NotifyViewManager.MoveView(detail);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void TodoItem_Click(object sender, EventArgs e)
        {
            TodoDetail detail = new TodoDetail();
            NotifyViewManager.MoveView(detail);
        }

        private void kryptonCheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TodoItem_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            kryptonButton2.Hide();
            kryptonButton3.Show();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            kryptonButton3.Hide();
            kryptonButton2.Show();
        }
    }
}
