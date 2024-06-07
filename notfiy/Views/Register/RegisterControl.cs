using notfiy.Controllers;
using notfiy.Helpers;
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
        private MessageBoxHelper MessageBoxHelper;
        public RegisterControl()
        {
            InitializeComponent();
            UserController = new UserController();
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
            if (kryptonTextBox2.Text == "Password")
            {
                kryptonTextBox2.Text = "";
                kryptonTextBox2.PasswordChar = '*';
            }
        }
        private void kryptonTextBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(kryptonTextBox2.Text))
            {
                kryptonTextBox2.Text = "Password";
            }
        }

        private void kryptonLabel2_Click(object sender, EventArgs e)
        {
            LoginControl log = new LoginControl();
            NotifyViewManager.MoveView(log);
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            // Pengecekan username telah memenuhi syarat atau tidak
            // Pengecekan username apakah sudah ada pada database atau tidak
            // Pengecekan email juga sama, email yang sudah terdaftar tidak bisa digunakan mendaftar lagi
            // Pengecekan email sudah memenuhi syarat atau tidak
            // Pengecekan password apakah sudah sesuai aturan atau tidak
            // Pengecekan password apakah sudah sama dengan confirm password atau tidak

            // Mempertahankan text email dan username apabila pendaftaran akun gagal
            // Menghapus text ketika password atau confirm password tidak sesuai

            // Menampilkan messagebox ketika berhasil mendaftar atau gagal
            // Apabila sudah mendaftar langsung view berpindah ke login
        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
