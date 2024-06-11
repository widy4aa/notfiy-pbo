using notfiy.Controllers;
using notfiy.Helpers;
using notfiy.Models;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using notfiy.Views.Todolist;
using notfiy.Views.NoteHomepagePartial;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using NotifyViewManager = notfiy.Core.ViewManager;

namespace notfiy.Views.AddToDoList
{
    public partial class AddToDoListControl : UserControl
    {
        private TodoListController TodoListController;
        private TodoListModel TodoListModel;
        private DoItemController DoItemController;
        private MessageBoxHelper MessageBoxHelper;
        private DoItemEdit DoItemEdit;

        public AddToDoListControl()
        {
            InitializeComponent();
            TodoListController = new TodoListController();
            TodoListModel = new TodoListModel();
            DoItemController = new DoItemController();
            MessageBoxHelper = new MessageBoxHelper();
            DoItemEdit = new DoItemEdit();
        }
        private void AddToDoList_Load(object sender, EventArgs e)
        {

        }
        private void kryptonTextBox1_Enter(object sender, EventArgs e)
        {
            InJudulTodolist.Text = "";
        }
        private void kryptonTextBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(InJudulTodolist.Text))
            {
                InJudulTodolist.Text = "Judul";
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Add(new DoItemEdit());
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //TodoListController todoListController = new TodoListController();
            //DoItemEdit doitemedit = new DoItemEdit();

            int IdStatus = 1;
            bool IsPinned = true;
            string Judul = InJudulTodolist.Text;

            //foreach (DoItemEdit doitem in flowLayoutPanel2.Controls)
            //{

            //}

            if (TodoListController.CreateTodoList(Judul, IdStatus, IsPinned) > 0)
            {
                int idtodolist = TodoListController.GetIdNewTodoList();
                //string text = DoItemController.TextBoxvalue();
                //bool checkbox = DoItemController.CheckBoxvalue();

                foreach (DoItemEdit doitem in flowLayoutPanel2.Controls)
                {
                    if (doitem.kryptonTextBox1.Visible)
                    {
                        if (doitem.kryptonCheckBox1.Checked)
                        {
                            bool checkbox = true; 
                            DoItemController.CreateDoItem(doitem.kryptonTextBox1.Text, checkbox, idtodolist);
                        }
                        else
                        {
                            bool checkbox = false;
                            DoItemController.CreateDoItem(doitem.kryptonTextBox1.Text, checkbox, idtodolist);
                        }
                    
                    }
                }
                MessageBoxHelper.ShowInfoMessageBox("Todolist berhasil ditambahkan");
                TodolistControl todolistControl = new TodolistControl();

                NotifyViewManager.MoveView(todolistControl);




                //if (DoItemController.CreateDoItem(text, checkbox, idtodolist) > 0)
                //{
                //    MessageBoxHelper.ShowInfoMessageBox("Todolist berhasil ditambahkan");
                //    TodolistControl todolistControl = new TodolistControl();
                //}


            }
        }

        //private void doItemEdit1_Load(object sender, EventArgs e)
        //{
        //    //foreach (DoItemEdit doItem in flowLayoutPanel2.Controls)
        //    //{
        //    //    doItem.kryptonButton1_Click(this, e);
        //    //}


        //    //private void kryptonButton1_Click(object sender, EventArgs e)
        //    //{
        //    //    //this.Visible = false;
        //    //    DoItemEdit doitem = new DoItemEdit();
        //    //    AddToDoList addToDoList = new AddToDoList();
        //    //    foreach (DoItemEdit item in addToDoList.flowLayoutPanel2.Controls)
        //    //    {
        //    //        addToDoList.flowLayoutPanel2.Controls.Remove(doitem);
        //    //    }
        //    //    //addToDoList.flowLayoutPanel2.Controls.Remove(this);
        //    //}
        //}

            //private void kryptonButton1_Click(object sender, EventArgs e)
            //{
            //    //this.Visible = false;
            //    DoItemEdit doitem = new DoItemEdit();
            //    AddToDoList addToDoList = new AddToDoList();
            //    foreach (DoItemEdit item in addToDoList.flowLayoutPanel2.Controls)
            //    {
            //        addToDoList.flowLayoutPanel2.Controls.Remove(doitem);
            //    }
            //    //addToDoList.flowLayoutPanel2.Controls.Remove(this);
            //}
        }

        //private void kryptonLabel2_Click(object sender, EventArgs e)
        //{
        //    Core.ViewManager.MoveView(new AddNoteHomepageControl());

        //}

    }
