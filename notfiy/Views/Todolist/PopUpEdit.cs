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
    public partial class PopUpEdit : UserControl
    {
        public PopUpEdit()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
        }

        private void PopUpEdit_Load(object sender, EventArgs e)
        {
            //this.BackColor = Color.Transparent;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
            this.BackColor = Color.Transparent;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            TodoDetail todoDetail = new TodoDetail();
            NotifyViewManager.MoveView(todoDetail);
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            this.Visible = false ;
        }
    }
}
