using Krypton.Toolkit;
using notfiy.Helpers;
using notfiy.Views.Homepage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using NotifyViewManager = notfiy.Core.ViewManager;

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
            kryptonTextBox1.Text = "Password";

            // Menambahkan event handlers
            kryptonTextBox1.Enter += RemovePlaceholder;
            kryptonTextBox1.Leave += SetPlaceholder;
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            KryptonTextBox textBox = (KryptonTextBox)sender;
            if (textBox.Text == "Password")
            {
                textBox.Text = "";
                textBox.PasswordChar = '*';
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            KryptonTextBox textBox = (KryptonTextBox)sender;
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = "Password";
                textBox.PasswordChar = '\0';
            }
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
            //pictureBox1.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            HomepageControl homepage = new HomepageControl();
            NotifyViewManager.MoveView(homepage);
        }

        private void BuatAkunLabel_Click(object sender, EventArgs e)
        {

        }

        private void kryptonLabel1_Click(object sender, EventArgs e)
        {

        }

        private void UsernameTextbox_Enter(object sender, EventArgs e)
        {
            if (UsernameTextbox.Text == "Username")
            {
                UsernameTextbox.Text = "";
            }
        }

        private void UsernameTextbox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsernameTextbox.Text))
            {
                UsernameTextbox.Text = "Username";
            }
        }

        private void kryptonTextBox1_Enter(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "Password")
            {
                kryptonTextBox1.Text = "";
            }
        }
        private void kryptonTextBox1_Leave(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UsernameTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
