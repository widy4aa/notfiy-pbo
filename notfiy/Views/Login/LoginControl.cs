using Krypton.Toolkit;
using Newtonsoft.Json;
using notfiy.Controllers;
using notfiy.Core;
using notfiy.Helpers;
using notfiy.Views.Homepage;
using notfiy.Views.Register;
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
        private UserController UserController;
        private MessageBoxHelper MessageBoxHelper;
        public LoginControl()
        {
            InitializeComponent();
            UserController = new UserController();
            MessageBoxHelper = new MessageBoxHelper();
        }

        private void LoginControl_Load(object sender, EventArgs e)
        {
            this.Width = this.ClientSize.Width;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UserController.AuthAttempt(UsernameTextbox.Text, kryptonTextBox1.Text))
            {
                HomepageControl homepage = new HomepageControl();
                NotifyViewManager.MoveView(homepage);
            }
            else
            {
                if (UsernameTextbox.Text == "Username" || kryptonTextBox1.Text == "Password" || string.IsNullOrWhiteSpace(kryptonTextBox1.Text) || string.IsNullOrWhiteSpace(UsernameTextbox.Text))
                {
                    MessageBoxHelper.ShowInfoMessageBox("Mohon lengkapi data terlebih dahulu!");
                }
                else
                {
                    MessageBoxHelper.ShowCustomMessageBox("Username atau Password Salah", "Login Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    kryptonTextBox1.Text = "";
                }
            }
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
                kryptonTextBox1.PasswordChar = '*';
            }
        }
        private void kryptonTextBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(kryptonTextBox1.Text))
            {
                kryptonTextBox1.Text = "Password";
                kryptonTextBox1.PasswordChar = '\0';
            }
        }

        private void BuatAkunLabel_Click(object sender, EventArgs e)
        {
            RegisterControl reg = new RegisterControl();
            NotifyViewManager.MoveView(reg);
        }
    }
}
