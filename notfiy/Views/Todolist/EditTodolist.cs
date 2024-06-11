using Krypton.Toolkit;
using notfiy.Controllers;
using notfiy.Entities;
using notfiy.Views.AddToDoList;
using notfiy.Views.Other;
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
    public partial class EditTodolist : UserControl
    {
        int IdTodo;
        string JudulTodo;
        private TodoDetail TodoDetail;
        private DoItemController DoItemController;
        private DoItemEdit DoItemEdit;
        //private TodoListController TodoListController;
        //private DoItemController DoItemController;
        //List<TodoItem> TodolistItem = new List<TodoItem>();
        //List<DoItem> doItems = new List<DoItem>();

        public EditTodolist(int IdTodoList, string JudulTodo)
        {
            InitializeComponent();
            //DoItemEdit = new DoItemEdit();
            DoItemController = new DoItemController();
            this.IdTodo = IdTodoList;
            this.JudulTodo = JudulTodo;
            //TodoDetail = new TodoDetail();
            //SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //BackColor = Color.Transparent;
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            PopUpEdit popUpEdit = new PopUpEdit();
            //this.Controls.Add(popUpEdit);
            popUpEdit.BringToFront();
            popUpEdit.BackColor = Color.Transparent;
            this.Controls.Add(popUpEdit);
            //popUpEdit.Show();

            //tesPopUp TesPop = new tesPopUp();
            //this.Controls.Add(TesPop);
            //TesPop.BringToFront();
            //TesPop.BackColor = Color.Transparent;
            //TesPop.Show();

            //PopUpDelete popUpDelete = new PopUpDelete();
            //this.Controls.Add(popUpDelete);
            //popUpDelete.BringToFront();
            //popUpDelete.Show();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            //TodoDetail todoDetail = new TodoDetail();
            //NotifyViewManager.MoveView(todoDetail);
        }

        private void HamburgerButton_Click(object sender, EventArgs e)
        {
            //SIdeBar sideBar = new SIdeBar();
            //this.Controls.Add(sideBar);
            //sideBar.Show();
        }

        private void EditTodolist_Load(object sender, EventArgs e)
        {
            InJudulTodolist.Text = this.JudulTodo;
            List<DoItem> doItems = DoItemController.GetAllDoItems(IdTodo);
            foreach (DoItem doitem in doItems)
            {
                DoItemEdit doItemEdit = new DoItemEdit();
                doItemEdit.kryptonTextBox1.Text = doitem.DoItemName;
                this.flowLayoutPanel1.Controls.Add(doItemEdit);
                
                //DoItemEdit doitemedit = new DoItemEdit();
                //doitemedit.kryptonTextBox1.T

                //todoitem.kryptonCheckBox1.Text = doitem.DoItemName;
                //KryptonCheckBox kryptonCheckBox = new KryptonCheckBox();
                //kryptonCheckBox.Text = doitem.DoItemName;
                //this.flowLayoutPanel1.Controls.Add(kryptonCheckBox);
            }
        }
    }
}
