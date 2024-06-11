using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using NotifyViewManager = notfiy.Core.ViewManager;


namespace notfiy.Views.Todolist
{
    public partial class PopUpEdit : UserControl
    {
        public PopUpEdit()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            //this.TransparencyKey = Color.White;
            kryptonCheckedListBox1.CornerRoundingRadius = 20F;
        }

        private void PopUpEdit_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            this.BackColor = Color.Transparent;

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            //TodoDetail todoDetail = new TodoDetail();
            //NotifyViewManager.MoveView(todoDetail);
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            //TodoDetail todoDetail = new TodoDetail();
            //NotifyViewManager.MoveView(todoDetail);
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            this.Visible = false ;
        }
    }
}
