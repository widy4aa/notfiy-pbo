using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;
using notfiy.Controllers;
using notfiy.Entities;
using notfiy.Views.Homepage;
using notfiy.Views.Other;
using notfiy.Views.Todolist;

namespace notfiy.Views.Trash
{
    public partial class TrashControl : UserControl
    {
        NoteController NoteController = new NoteController();
        DoItemController DoItemController = new DoItemController(); 
        List<TrashNoteItem> TrashItems = new List<TrashNoteItem>();
        TodoListController todoListController = new TodoListController();
        List<TodoItem> TodolistItem = new List<TodoItem>();
        List<DoItem> doItems = new List<DoItem>();


        public TrashControl()
        {
            InitializeComponent();
        }

        private void TrashControl_Load(object sender, EventArgs e)
        {
            SetNoteItems();
            SetTodolistItems();
        }

        private void SetNoteItems()
        {
            List<Note> notes = NoteController.GetAllNote(2);

            foreach (Note note in notes)
            {
                TrashNoteItem trashNoteItem = new TrashNoteItem(note);
                trashNoteItem.Margin = new Padding(2);
                FlowLayoutNote.Controls.Add(trashNoteItem);
                TrashItems.Add(trashNoteItem);


            }
        }

        private void SetTodolistItems()
        {
            List<TodoList> todoLists = todoListController.GetAllTodoList(2);

            foreach (TodoList todoList in todoLists)
            {
                TrashToDoItem todoitem = new TrashToDoItem(todoList);
                todoitem.Margin = new Padding(2);
                FlowLayoutTodo.Controls.Add(todoitem);

                if (DoItemController.GetAllDoItems(todoList.IdTodoList).Count > 0)
                {
                    List<DoItem> doItems = DoItemController.GetAllDoItems(todoList.IdTodoList);
                    foreach (DoItem doitem in doItems)
                    {
                        //todoitem.kryptonCheckBox1.Text = doitem.DoItemName;
                        KryptonCheckBox kryptonCheckBox = new KryptonCheckBox();
                        kryptonCheckBox.Text = doitem.DoItemName;
                        kryptonCheckBox.Enabled = false;
                        if (doitem.Checked)
                        {
                            kryptonCheckBox.Checked = true;
                        }
                        todoitem.flowLayoutPanel1.Controls.Add(kryptonCheckBox);
                    }
                }
                else
                {
                    MessageBox.Show("gagal");
                }

            }



        }



        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
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

        private void FlowLayoutNote_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
