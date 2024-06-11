using System;
using notfiy.Entities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotifyViewManager = notfiy.Core.ViewManager;
using notfiy.Controllers;
using notfiy.Helpers;
using Krypton.Toolkit;


namespace notfiy.Views.Todolist
{
    public partial class TodoDetail : UserControl
    {
        private TodoListController TodoListController;
        //private TodoItem Todoitem;
        public int IdTodo;
        public string JudulTodoList;
        private TodolistControl TodolistControl;
        private DoItemController DoItemController;

        public TodoDetail(TodoList todolist)
        {
            InitializeComponent();
            //TodoItem = new TodoItem();
            DoItemController = new DoItemController();
            TodolistControl = new TodolistControl();
            TodoListController = new TodoListController();
            this.JudulDetail.Text = todolist.TodoListName;
            this.IdTodo = todolist.IdTodoList;
            this.JudulTodoList = todolist.TodoListName;

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

        //private void TodoDetail_Load(object sender, EventArgs e)
        //{
        //    List<DoItem> doItems = DoItemController.GetAllDoItems(IdTodo);
        //    foreach (DoItem doitem in doItems)
        //    {
        //        //todoitem.kryptonCheckBox1.Text = doitem.DoItemName;
        //        KryptonCheckBox kryptonCheckBox = new KryptonCheckBox();
        //        kryptonCheckBox.Text = doitem.DoItemName;
        //        this.flowLayoutPanel1.Controls.Add(kryptonCheckBox);
        //    }
        //}

        public void BtnDelete_Click(object sender, EventArgs e)
        {
            //PopUpDelete popupdelete = new PopUpDelete();
            //this.Controls.Add(popupdelete);
            //popupdelete.BringToFront();
            //popupdelete.BackColor = Color.Transparent;
            //popupdelete.Show();
            //TodoDetail tododetail = new TodoDetail();

            if (TodoListController.UpdateTodoList(this.IdTodo, this.JudulTodoList, 2))
            {
                MessageBox.Show("Todolist disampahkan");
                NotifyViewManager.MoveView(TodolistControl);
            }
            else
            {
                MessageBoxHelper.ShowErrorMessageBox("Delete Gagal");
            }

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
            EditTodolist editTodolist = new EditTodolist(IdTodo, JudulDetail.Text);
            NotifyViewManager.MoveView(editTodolist);
        }

        private void TodoDetail_Load_1(object sender, EventArgs e)
        {
            List<DoItem> doItems = DoItemController.GetAllDoItems(IdTodo);
            foreach (DoItem doitem in doItems)
            {
                //todoitem.kryptonCheckBox1.Text = doitem.DoItemName;
                KryptonCheckBox kryptonCheckBox = new KryptonCheckBox();
                kryptonCheckBox.Text = doitem.DoItemName;
                this.flowLayoutPanel1.Controls.Add(kryptonCheckBox);
            }
        }
    }
}
