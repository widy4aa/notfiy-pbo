using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using notfiy.Controllers;
using notfiy.Core;
using notfiy.Entities;

namespace notfiy.Views
{
    public partial class LoginUnitTesterForm : Form
    {
        private bool RegisterMode;
        private UserController UserController;
        public LoginUnitTesterForm()
        {
            InitializeComponent();
            UserController = new UserController();
        }

        private void RadioButtonRegister_CheckedChanged(object sender, EventArgs e)
        {
            RegisterMode = RadioButtonRegister.Checked;
            UpdateState();
        }

        private void RadioButtonLogin_CheckedChanged(object sender, EventArgs e)
        {
            RegisterMode = !RadioButtonLogin.Checked;
            UpdateState();
        }

        private void StatusProcess_Click(object sender, EventArgs e)
        {

        }

        private void UpdateState()
        {
            if (RegisterMode)
            {
                ButtonLoginOrRegister.Text = "Register";
                LabelEmail.Visible = true;
                TextBoxEmail.Visible = true;
            }
            else
            {
                ButtonLoginOrRegister.Text = "Login";
                LabelEmail.Visible = false;
                TextBoxEmail.Visible = false;
            }
        }

        private void UpdateLogggedInState()
        {
            if (SystemSingleton.Instance.UserLoggedIn == null)
            {
                LabelUpdateUsername.Visible = false;
                LabelUpdatePassword.Visible = false;
                LabelUpdateEmail.Visible = false;
                TextBoxUsernameUpdate.Visible = false;
                TextBoxPasswordUpdate.Visible = false;
                TextBoxEmailUpdate.Visible = false;
                ButtonUpdate.Visible = false;
                LabelUpdate.Visible = false;
            } else 
            {
                LabelUpdateUsername.Visible = true;
                LabelUpdatePassword.Visible = true;
                LabelUpdateEmail.Visible = true;
                TextBoxUsernameUpdate.Visible = true;
                TextBoxPasswordUpdate.Visible = true;
                TextBoxEmailUpdate.Visible = true;
                ButtonUpdate.Visible = true;
                LabelUpdate.Visible = true;

                TextBoxUsernameUpdate.Text = SystemSingleton.Instance.UserLoggedIn.Username;
                TextBoxPasswordUpdate.Text = SystemSingleton.Instance.UserLoggedIn.Password;
                TextBoxEmailUpdate.Text = SystemSingleton.Instance.UserLoggedIn.Email;
            }
        }

        private void UnitTesterForm_Load(object sender, EventArgs e)
        {
            RadioButtonLogin.Checked = true;
            RegisterMode = false;
            UpdateState();
            UpdateLogggedInState();
        }



        private void ButtonLoginOrRegister_Click(object sender, EventArgs e)
        {


            if (RegisterMode)
            {
                // Registration Mode
                if (UserController.CreateUser(TextBoxUsernameLogin.Text, TextBoxPasswordLogin.Text, TextBoxEmail.Text))
                {
                    ProcessResultLogin.Text = "Register Berhasil!";
                    return;
                }


                ProcessResultLogin.Text = "Register Gagal. Coba lagi.";
                return;
            }

            // Login Mode
            if (UserController.AuthAttempt(TextBoxUsernameLogin.Text, TextBoxPasswordLogin.Text))
            {
                ProcessResultLogin.Text = "Login Berhasil, User Session : " + JsonConvert.SerializeObject(SystemSingleton.Instance.UserLoggedIn);
                UpdateLogggedInState();
                return;
            }
            ProcessResultLogin.Text = "Login Gagal. Username atau password salah.";
        }

        private void LabelUpdate_Click(object sender, EventArgs e)
        {
            User user = SystemSingleton.Instance.UserLoggedIn;
            user.Username = TextBoxUsernameUpdate.Text;
            user.Password = TextBoxPasswordUpdate.Text;
            user.Email = TextBoxEmailUpdate.Text;
            if(UserController.UpdateUser(user.IdUser, user.Username, user.Password, user.Email))
            {

                ProcessResultLogin.Text = "Login Berhasil, User Session : " + JsonConvert.SerializeObject(SystemSingleton.Instance.UserLoggedIn);
                ProcessResultUpdate.Text = "Update Berhasil!.";
                return;
            }
            ProcessResultUpdate.Text = "Update Gagal!.";
        }
    }
}
