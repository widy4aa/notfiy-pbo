﻿using notfiy.Views.Other;
using notfiy.Entities;
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
using notfiy.Controllers;
using notfiy.Views.AddToDoList;
using Krypton.Toolkit;

namespace notfiy.Views.Todolist
{
    public partial class TodoItem : UserControl
    {
        public int IdTodo;
        public int IdStatus;
        //public string JudulTodolist;
        private DoItemController DoItemController;
        public KryptonCheckBox KryptonCheckBox;
        List<DoItem> doItems = new List<DoItem>();
        public TodoItem(TodoList todolist)
        {
            InitializeComponent();
            this.KryptonCheckBox = new KryptonCheckBox();
            DoItemController = new DoItemController();
            this.JudulItem.Text = todolist.TodoListName;
            this.IdTodo = todolist.IdTodoList;
            this.IdStatus = todolist.IdStatus;
            //this.KryptonCheckBox.Text =;
        }

        public void kryptonLabel1_Click(object sender, EventArgs e)
        {
            //kryptonButton2.Hide();
        }

        private void flowLayoutPanel1_Click(object sender, EventArgs e)
        {
            //TodoDetail detail = new TodoDetail(todolist);
            //NotifyViewManager.MoveView(detail);
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
            //TodoDetail detail = new TodoDetail();
            //NotifyViewManager.MoveView(detail);
        }

        private void kryptonCheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TodoItem_Load(object sender, EventArgs e)
        {
            //List<DoItem> doItems = DoItemController.GetAllDoItems(this.IdTodo);

            //foreach (DoItem doItem in doItems)
            //{
            //    //kryptonCheckBox = new KryptonCheckBox();
            //    KryptonCheckBox.Text = doItem.DoItemName;
            //    flowLayoutPanel1.Controls.Add(KryptonCheckBox);
            //    KryptonCheckBox.Text = doItem.DoItemName;
            //}
        }

        

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            PopUpShare popupshare = new PopUpShare();
            this.Controls.Add(popupshare);
            popupshare.BringToFront();
            popupshare.BackColor = Color.Transparent;
            popupshare.Location = new Point(100, 0);
        }

        
    }
}
