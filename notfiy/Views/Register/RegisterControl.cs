using notfiy.Controllers;
using notfiy.Helpers;
using notfiy.Models;
using notfiy.Views.Login;
using Npgsql;
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

namespace notfiy.Views.Register
{
    public partial class RegisterControl : UserControl
    {
        private UserController UserController;
        private UserModel UserModel;
        private MessageBoxHelper MessageBoxHelper;
        public RegisterControl()
        {
            InitializeComponent();
            UserController = new UserController();
            UserModel = new UserModel();
            MessageBoxHelper = new MessageBoxHelper();
        }

        private void RegisterControl_Load(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox3_Enter(object sender, EventArgs e)
        {
            if (kryptonTextBox3.Text == "Username")
            {
                kryptonTextBox3.Text = "";
            }
        }
        private void kryptonTextBox3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(kryptonTextBox3.Text))
            {
                kryptonTextBox3.Text = "Username";
            }
        }

        private void kryptonTextBox4_Enter(object sender, EventArgs e)
        {
            if (kryptonTextBox4.Text == "Email")
            {
                kryptonTextBox4.Text = "";
            }
        }
        private void kryptonTextBox4_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(kryptonTextBox4.Text))
            {
                kryptonTextBox4.Text = "Email";
            }
        }

        private void kryptonTextBox2_Enter(object sender, EventArgs e)
        {
            if (kryptonTextBox2.Text == "Confirm Password")
            {
                kryptonTextBox2.Text = "";
                kryptonTextBox2.PasswordChar = '●';
            }
        }
        private void kryptonTextBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(kryptonTextBox2.Text))
            {
                kryptonTextBox2.Text = "Confirm Password";
                kryptonTextBox2.PasswordChar = '\0';
            }
        }

        private void kryptonLabel2_Click(object sender, EventArgs e)
        {
            LoginControl log = new LoginControl();
            NotifyViewManager.MoveView(log);
        }

        private void kryptonTextBox5_Enter(object sender, EventArgs e)
        {
            if (kryptonTextBox5.Text == "Password")
            {
                kryptonTextBox5.Text = "";
                kryptonTextBox5.PasswordChar = '●';
            }
        }
        private void kryptonTextBox5_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(kryptonTextBox5.Text))
            {
                kryptonTextBox5.Text = "Password";
                kryptonTextBox5.PasswordChar = '\0';
            }
        }
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (kryptonTextBox2.Text == "Confirm Password" || kryptonTextBox3.Text == "Username" || kryptonTextBox4.Text == "Email" || kryptonTextBox5.Text == "Password"
                || string.IsNullOrWhiteSpace(kryptonTextBox2.Text) || string.IsNullOrWhiteSpace(kryptonTextBox3.Text) || string.IsNullOrWhiteSpace(kryptonTextBox4.Text) || string.IsNullOrWhiteSpace(kryptonTextBox5.Text))
            {
                MessageBoxHelper.ShowInfoMessageBox("Mohon lengkapi data terlebih dahulu!");
                kryptonTextBox2.Text = "Confirm Password";
                kryptonTextBox3.Text = "Username";
                kryptonTextBox4.Text = "Email";
                kryptonTextBox5.Text = "Password";
                return;
            }

            if (!kryptonTextBox3.Text.Any(char.IsDigit))
            {
                MessageBoxHelper.ShowWarningMessageBox("Username harus mengandung angka!");
                return;
            }

            if (UserModel.IsUsernameTaken(kryptonTextBox3.Text))
            {
                MessageBoxHelper.ShowWarningMessageBox("Username telah digunakan! Mohon gunakan username lain");
                kryptonTextBox3.Text = "";
                return;
            }

            if (!(kryptonTextBox4.Text.Contains("@mail") || kryptonTextBox4.Text.Contains("@gmail")))
            {
                MessageBoxHelper.ShowWarningMessageBox("Format Email yang anda masukkan salah!");
                return;
            }

            if (UserModel.IsEmailTaken(kryptonTextBox4.Text))
            {
                MessageBoxHelper.ShowWarningMessageBox("Email telah digunakan! Mohon gunakan email lain");
                kryptonTextBox4.Text = "";
                return;
            }

            if (kryptonTextBox2.Text.Length < 8)
            {
                MessageBoxHelper.ShowWarningMessageBox("Password harus memiliki minimal panjang 8 karakter");
                kryptonTextBox5.Text = "";
                kryptonTextBox2.Text = "";
                return;
            }

            if (kryptonTextBox5.Text != kryptonTextBox2.Text)
            {
                MessageBoxHelper.ShowWarningMessageBox("Password dengan Confirm Password tidak sama!");
                kryptonTextBox5.Text = "";
                kryptonTextBox2.Text = "";
                return;
            }

            if (UserController.CreateUser(kryptonTextBox3.Text, kryptonTextBox5.Text, kryptonTextBox4.Text))
            {
                MessageBoxHelper.ShowInfoMessageBox("Registrasi Berhasil! Silahkan login terlebih dahulu!");
                LoginControl log = new LoginControl();
                NotifyViewManager.MoveView(log);
            }
            else
            {
                MessageBoxHelper.ShowErrorMessageBox("Registrasi Gagal! Silahkan mencoba lagi");
                kryptonTextBox3.Text = "Username";
                kryptonTextBox4.Text = "Email";
                kryptonTextBox5.Text = "Password";
                kryptonTextBox2.Text = "Confirm Password";
            }
        }

        private void kryptonTextBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
