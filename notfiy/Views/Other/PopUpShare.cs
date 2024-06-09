using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notfiy.Views.Other
{
    public partial class PopUpShare : UserControl
    {
        public PopUpShare()
        {
            InitializeComponent();
        }

        private void SearchTextbox_TextChanged(object sender, EventArgs e)
        {

        }
        private void SearchTextbox_Enter(object sender, EventArgs e)
        {
            if (SearchTextbox.Text == "Search")
            {
                SearchTextbox.Text = string.Empty;
            }
        }
        private void SearchTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchTextbox.Text = "berhasil diinputkan";
            }
        }
    }
}
