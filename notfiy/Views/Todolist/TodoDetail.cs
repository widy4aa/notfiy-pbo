﻿using System;
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
using notfiy.Views.AddToDoList;
using System.Security.Cryptography.X509Certificates;


namespace notfiy.Views.Todolist
{
    public partial class TodoDetail : UserControl
    {
        private TodoListController TodoListController;
        //private TodoItem Todoitem;
        public int IdTodo;
        public int IdItem;
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
            //this.IdItem = todolist.

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
            //TodoListController.UpdateTodoList(IdTodo, JudulTodoList.Text, 1);
            TodolistControl todolistcontrol = new TodolistControl();
            foreach (KryptonCheckBox kryptonCheckBox in flowLayoutPanel1.Controls)
            {
                if (DoItemController.UpdateDoItem(IdTodo, kryptonCheckBox.Text, kryptonCheckBox.Checked, IdItem))
                {
                    MessageBox.Show("Perubahan berhasil disimpan");
                }



                //if (doitemedit.kryptonCheckBox1.Visible)
                //{
                //    //DoItemEdit itemEdit = new DoItemEdit(doitemedit.IdTodoItem);
                //    if (DoItemController.UpdateDoItem(doitemedit.IdTodoItem, doitemedit.kryptonTextBox1.Text, doitemedit.kryptonCheckBox1.Checked, IdTodo))
                //    {
                //        MessageBox.Show("Perubahan berhasil disimpan");
                //    }
                //    else
                //    {
                //        MessageBox.Show("Perubahan gagal disimpan");
                //    }
                //    //MessageBox.Show("ini datanya" + doitemedit.IdTodoItem + doitemedit.kryptonTextBox1.Text + doitemedit.kryptonCheckBox1.Checked + IdTodo);
                //}
                //else
                //{
                //    DoItemController.DeleteDoItem(doitemedit.IdTodoItem);
                //    //MessageBox.Show("Perubahan berhasil disimpan");
                //}

            }
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

            if (TodoListController.UpdateTodoList(this.IdTodo, this.JudulTodoList, 2, false))
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

        //public void IdTodoItem(int IdItem)
        //{
        //    this.IdItem = IdItem;

            
        //}

        private void TodoDetail_Load_1(object sender, EventArgs e)
        {
            List<DoItem> doItems = DoItemController.GetAllDoItems(IdTodo);
            foreach (DoItem doitem in doItems)
            {
                //todoitem.kryptonCheckBox1.Text = doitem.DoItemName;
                KryptonCheckBox kryptonCheckBox = new KryptonCheckBox();
                //this.IdTodoItem item = new IdTodoItem(doitem.IdDoItem);
                kryptonCheckBox.Text = doitem.DoItemName;
                kryptonCheckBox.Checked = doitem.Checked;
                //if (doitem.Checked)
                //{
                //    kryptonCheckBox.Checked = true;
                //}
                this.flowLayoutPanel1.Controls.Add(kryptonCheckBox);
            }
        }
    }
}
