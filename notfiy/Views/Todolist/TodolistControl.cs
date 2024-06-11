using notfiy.Views.Other;
using notfiy.Controllers;
using notfiy.Entities;
using notfiy.Views.AddToDoList;
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
using notfiy.Views.Homepage;
using Microsoft.VisualBasic.ApplicationServices;
using notfiy.Core;
using Krypton.Toolkit;


namespace notfiy.Views.Todolist
{

    public partial class TodolistControl : UserControl
    {
        private TodoListController TodoListController;
        private DoItemController DoItemController;
        List<TodoItem> TodolistItem = new List<TodoItem>();
        List<DoItem> doItems = new List<DoItem>();
        FlowLayoutPanel FlowLayoutPanel;

        public TodolistControl()
        {
            InitializeComponent();
            TodoListController = new TodoListController();
            DoItemController = new DoItemController();
        }
        private void TodoItem_Click(object sender, EventArgs e)
        {
            //TodoDetail detail = new TodoDetail();
            //NotifyViewManager.MoveView(detail);
        }
        private void TodolistControl_Load(object sender, EventArgs e)
        {
            List<TodoList> todoList = TodoListController.GetAllTodoList();
            //List<DoItem> doItems = DoItemController.GetAllDoItems(idTodolist);
            //todoList = TodoListController.GetAllTodoList();
            //TodoItem todoitem = new TodoItem(todoList);
            flowLayoutPanel1.AutoScroll = true;
            foreach (TodoList todolist in todoList)
            {
                TodoItem todoitem = new TodoItem(todolist);
                todoitem.Margin = new Padding(3);
                todoitem.Click += delegate
                {
                    NotifyViewManager.MoveView(new TodoDetail(todolist));
                };

                flowLayoutPanel1.Controls.Add(todoitem);
                if (DoItemController.GetAllDoItems(todolist.IdTodoList).Count > 0)
                {
                    List<DoItem> doItems = DoItemController.GetAllDoItems(todolist.IdTodoList);
                    foreach (DoItem doitem in doItems)
                    {
                        //todoitem.kryptonCheckBox1.Text = doitem.DoItemName;
                        KryptonCheckBox kryptonCheckBox= new KryptonCheckBox();
                        kryptonCheckBox.Text = doitem.DoItemName;
                        todoitem.flowLayoutPanel1.Controls.Add(kryptonCheckBox);
                    }
                }
                else
                {
                    MessageBox.Show("gagal");
                }
               
            }
            //MessageBox.Show(todoList.Count.ToString());
            //flowLayoutPanel1.AutoScroll = true;
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
            navbar.Location = new Point(1000, 0);
        }
        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            AddToDoList.AddToDoListControl addtodolist = new AddToDoList.AddToDoListControl();
            NotifyViewManager.MoveView(addtodolist);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        //private void setTodolistItem()
        //{
        //    List<TodoList> todoList = TodoListController.GetAllTodoList();
        //    //todoList = TodoListController.GetAllTodoList();
        //    TodoItem todoitem = new TodoItem();

        //    foreach (TodoList todolist in todoList)
        //    {
        //        flowLayoutPanel1.Controls.Add(todoitem);
        //    }
        //}
    }
}
