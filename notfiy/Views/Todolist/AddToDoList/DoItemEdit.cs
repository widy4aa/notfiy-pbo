using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notfiy.Views.AddToDoList
{
    public partial class DoItemEdit : UserControl
    {

        public DoItemEdit()
        {
            InitializeComponent();
        }

        public void kryptonTextBox1_Enter(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "kryptonTextBox1")
            {
                kryptonTextBox1.Text = "";
                string value = kryptonTextBox1.Text;
                //TextBoxValue();
            }
        }

        public void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            //DoItemEdit doitem = new DoItemEdit();
            //AddToDoList addToDoList = new AddToDoList();
            //foreach (DoItemEdit item in addToDoList.flowLayoutPanel2.Controls) 
            //{
            //    addToDoList.flowLayoutPanel2.Controls.Remove(doitem);
            //}
            //addToDoList.flowLayoutPanel2.Controls.Remove(this);
        }

        //public static string TextBoxValue()
        //{
        //    return value;
        //}
        //public string TextBoxValue
        //{
        //    get { return kryptonTextBox1.Text; }
        //    set { kryptonTextBox1.Text = value; }
        //}

        public bool CheckBoxValue
        {
            get { return kryptonCheckBox1.Checked; }
            set { kryptonCheckBox1.Checked = value; }
        }
    }
}
