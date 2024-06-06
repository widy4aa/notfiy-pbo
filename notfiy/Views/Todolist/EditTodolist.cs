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
        public EditTodolist()
        {
            InitializeComponent();
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
            TodoDetail todoDetail = new TodoDetail();
            NotifyViewManager.MoveView(todoDetail);
        }

        private void HamburgerButton_Click(object sender, EventArgs e)
        {
            //SIdeBar sideBar = new SIdeBar();
            //this.Controls.Add(sideBar);
            //sideBar.Show();
        }
    }
}
