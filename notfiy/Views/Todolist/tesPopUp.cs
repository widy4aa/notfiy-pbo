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
    public partial class tesPopUp : UserControl
    {
        public tesPopUp()
        {
            InitializeComponent();
            this.BackColor = Color.Transparent;
        }

        private void tesPopUp_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
        }
    }
}
