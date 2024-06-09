using notfiy.Views.Other;
using NotifyViewManager = notfiy.Core.ViewManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using notfiy.Views.Todolist;
using Krypton.Toolkit;
using notfiy.Views.Login;
using notfiy.Views.Homepage;
using notfiy.Controllers;
using notfiy.Entities;
using notfiy.Helpers;
using notfiy.Models;

namespace notfiy.Views.Profiles
{
    public partial class ProfileControl : UserControl
    {
        private UserController userController;
        private MessageBoxHelper MessageBoxHelper;
        private string usernamePlaceholder;
        private string passwordPlaceholder;
        private string emailPlaceholder;
        private User currentUser;
        public ProfileControl()
        {
            InitializeComponent();
            userController = new UserController();
            MessageBoxHelper = new MessageBoxHelper();
        }

        private void kryptonListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonRichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonLabel3_Click(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProfileControl_Load(object sender, EventArgs e)
        {
            int IdUser = userController.GetUserLoggedIn(); //mendapatkan id dari user yang sedang login
            currentUser = userController.GetUserById(IdUser);

            if (currentUser != null)
            {
                // Ambil data yang ingin ditampilkan pada TextBox
                usernamePlaceholder = currentUser.Username;
                emailPlaceholder = currentUser.Email;
                passwordPlaceholder = currentUser.Password;

                // Menampilkan pesan selamat datang
                GreetingTextBox.Text = $"Halo {currentUser.Username}!";

                kryptonRichTextBox1.Text = usernamePlaceholder;
                kryptonRichTextBox2.Text = emailPlaceholder;
                kryptonRichTextBox3.Text = passwordPlaceholder;

                kryptonRichTextBox1.ForeColor = Color.Gray;
                kryptonRichTextBox2.ForeColor = Color.Gray;
                kryptonRichTextBox3.ForeColor = Color.Gray;
            }
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            Navbar navbar = new Navbar();
            this.Controls.Add(navbar);
            navbar.BringToFront();
            navbar.BackColor = Color.Transparent;
            navbar.Location = new Point(1000, 0);
        }

        private void kryptonPictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            HomepageControl homepage = new HomepageControl();
            NotifyViewManager.MoveView(homepage);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //int IdUser = userController.GetUserLoggedIn();
            string username = kryptonRichTextBox1.Text;
            string email = kryptonRichTextBox2.Text;
            string password = kryptonRichTextBox3.Text;

            // Cek apakah username sudah ada
            if (userController.IsUserTaken(username, email, currentUser.IdUser))
            {
                MessageBox.Show("Username atau Email sudah ada! Silakan gunakan yang lain.");
                return;
            }

            // update data user
            if (userController.UpdateUser(currentUser.IdUser, username, password, email))
            {
                MessageBoxHelper.ShowInfoMessageBox($"Data user {username} sudah di update!");
            }
            else
            {
                MessageBoxHelper.ShowInfoMessageBox($"Gagal mengupdate data user {username}!");
            }
        }

        //private void BtnDelete_TextChanged(object sender, EventArgs e)
        //{

        //}

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // Tampilkan dialog konfirmasi
            DialogResult result = MessageBox.Show("Yakin ingin menghapus akun?", "Konfirmasi Penghapusan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Jika pengguna menekan tombol "Yes"
            if (result == DialogResult.Yes)
            {
                // Hapus akun pengguna
                if (userController.DeleteUser(currentUser.IdUser))
                {
                    MessageBox.Show("Akun sudah dihapus. Kembali ke menu login");

                    // Kembali ke halaman login
                    LoginControl loginPage = new LoginControl();
                    NotifyViewManager.MoveView(loginPage);
                }
                else
                {
                    MessageBox.Show("Gagal menghapus akun!");
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            userController.Logout();
            LoginControl login = new LoginControl();
            NotifyViewManager.MoveView(login);
        }

        private void btnNote_Click(object sender, EventArgs e)
        {
            HomepageControl note = new HomepageControl();
            NotifyViewManager.MoveView(note);
        }

        private void btnTodolist_Click(object sender, EventArgs e)
        {
            TodolistControl todolist = new TodolistControl();
            NotifyViewManager.MoveView(todolist);
        }
    }
}
