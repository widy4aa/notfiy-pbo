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
    public partial class TodoDetail : UserControl
    {
        public TodoDetail()
        {
            InitializeComponent();
        }

        private void kryptonLabel2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            TodolistControl todolist = new TodolistControl();
            NotifyViewManager.MoveView(todolist);
        }

        private void kryptonLabel1_Click(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click_1(object sender, EventArgs e)
        {
            TodolistControl todolist = new TodolistControl();
            NotifyViewManager.MoveView(todolist);
        }

        private void TodoDetail_Load(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            PopUpDelete popupdelete = new PopUpDelete();
            this.Controls.Add(popupdelete);
            popupdelete.BringToFront();
            popupdelete.BackColor = Color.Transparent;
            popupdelete.Show();

            //PopUpEdit popUpEdit = new PopUpEdit();
            //this.Controls.Add(popUpEdit);
            //popUpEdit.BringToFront();
            //popUpEdit.BackColor = Color.Transparent;
            //popUpEdit.Show();
        }

        private void kryptonCheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            EditTodolist editTodolist = new EditTodolist();
            NotifyViewManager.MoveView(editTodolist);
        }
    }
}
