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
        int IdStatus;
        private TodoDetail TodoDetail;
        private DoItemController DoItemController;
        private DoItemEdit DoItemEdit;
        private TodoListController TodoListController;
        //private TodoListController TodoListController;
        //private DoItemController DoItemController;
        //List<TodoItem> TodolistItem = new List<TodoItem>();
        //List<DoItem> doItems = new List<DoItem>();

        public EditTodolist(int IdTodoList, string JudulTodo)
        {
            InitializeComponent();
            //DoItemEdit = new DoItemEdit();
            TodoListController = new TodoListController();
            DoItemController = new DoItemController();
            this.IdTodo = IdTodoList;
            this.JudulTodo = JudulTodo;
            
            //TodoDetail = new TodoDetail();
            //SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //BackColor = Color.Transparent;
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            TodolistControl todolistControl = new TodolistControl();
            NotifyViewManager.MoveView(todolistControl);
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            //TodoDetail todoDetail = new TodoDetail();
            //NotifyViewManager.MoveView(todoDetail);

            TodoListController.UpdateTodoList(IdTodo, InJudulTodolist.Text, 1, false);
            TodolistControl todolistcontrol = new TodolistControl();
            foreach (DoItemEdit doitemedit in flowLayoutPanel1.Controls)
            {
                if (doitemedit.kryptonCheckBox1.Visible)
                {
                    //DoItemEdit itemEdit = new DoItemEdit(doitemedit.IdTodoItem);
                    if (DoItemController.UpdateDoItem(doitemedit.IdTodoItem, doitemedit.kryptonTextBox1.Text, doitemedit.kryptonCheckBox1.Checked, IdTodo))
                    {
                        MessageBox.Show("Perubahan berhasil disimpan");
                    }
                    else
                    {
                        MessageBox.Show("Perubahan gagal disimpan");
                    }
                    //MessageBox.Show("ini datanya" + doitemedit.IdTodoItem + doitemedit.kryptonTextBox1.Text + doitemedit.kryptonCheckBox1.Checked + IdTodo);
                }
                else
                {
                    DoItemController.DeleteDoItem(doitemedit.IdTodoItem);
                    //MessageBox.Show("Perubahan berhasil disimpan");
                }

            }

            NotifyViewManager.MoveView(todolistcontrol);






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
                doItemEdit.kryptonCheckBox1.Checked = doitem.Checked;
                doItemEdit.IdTodoItem = doitem.IdDoItem;
                this.flowLayoutPanel1.Controls.Add(doItemEdit);

                //DoItemEdit doitemedit = new DoItemEdit();
                ////doitemedit.kryptonTextBox1.T

                ////todoitem.kryptonCheckBox1.Text = doitem.DoItemName;
                //doitemedit.IdTodoItem = doitem.IdDoItem;
                //KryptonCheckBox kryptonCheckBox = new KryptonCheckBox();
                //kryptonCheckBox.Checked = doitem.Checked;
                //kryptonCheckBox.Text = doitem.DoItemName;
                //this.flowLayoutPanel1.Controls.Add(kryptonCheckBox);
            }
        }
    }
}
