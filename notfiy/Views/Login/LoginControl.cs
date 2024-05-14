using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notfiy.Views.Login
{
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 2000;
            timer.Tick += Timer_Tick;
            EventHandler eventHandler = ControlLoaded;
            this.Load += eventHandler;

        }

        private void LoginControl_Load(object sender, EventArgs e)
        {
            this.Width = this.ClientSize.Width;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private System.Windows.Forms.Timer timer;


        private void ControlLoaded(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            this.pictureBox1.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
