using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notfiy.Views.Todolist
{
    public partial class PopUpDelete : UserControl
    {
        public PopUpDelete()
        {
            InitializeComponent();
            this.BackColor = Color.Transparent;
            kryptonCheckedListBox1.CornerRoundingRadius = 20F;

        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Tidak menggambar latar belakang untuk menjaga transparansi
        }

        //public void ChangeButtonProperties(float Radius)
        //{
        //    //buttonInUserControl.Text = newText;
        //    //buttonInUserControl.BackColor = newBackColor;
        //    kryptonCheckedListBox1.CornerRoundingRadius = 20F;

        //}
    }
}
