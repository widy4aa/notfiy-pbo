using Krypton.Toolkit;
using notfiy.Controllers;
using notfiy.Entities;
using NotfiyViewManager = notfiy.Core.ViewManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notfiy.Views.Trash
{
    public partial class TrashToDoItem : UserControl
    {
        TodoListController todoListController = new TodoListController();
        TrashControl trashControl = new TrashControl();


        public int IdTodo;
        private DoItemController DoItemController;
        public KryptonCheckBox KryptonCheckBox;
        List<DoItem> doItems = new List<DoItem>();

        public TrashToDoItem(TodoList todolist)
        {
            InitializeComponent();
            this.KryptonCheckBox = new KryptonCheckBox();
            DoItemController = new DoItemController();
            this.kryptonLabel1.Text = todolist.TodoListName;
            this.IdTodo = todolist.IdTodoList;
        }

        private void TrashToDoItem_Load(object sender, EventArgs e)
        {

        }

        private void kryptonLabel1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonCheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            todoListController.DeleteTodoList(this.IdTodo);
            NotfiyViewManager.MoveView(trashControl);
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            todoListController.UpdateTodoListStatus(this.IdTodo,1);
            NotfiyViewManager.MoveView(trashControl);
        }

        private void TrashToDoItem_Load(object sender, EventArgs e)
        {

        }
    }
}
