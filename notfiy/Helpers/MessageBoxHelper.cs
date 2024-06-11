using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace notfiy.Helpers
{
    class MessageBoxHelper
    {
        public static void ShowWarningMessageBox(string message, string title = "Warning")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowErrorMessageBox(string message, string title = "Error")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowInfoMessageBox(string message, string title = "Information")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowCustomMessageBox(string message, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            MessageBox.Show(message, title, buttons, icon);
        }

        // Method untuk menampilkan MessageBox dengan dua button dan custom icon
        public static bool ShowCustomMessageBoxYesOrNo(string message, string caption, string buttonAcceptText, string buttonDeniedText, MessageBoxIcon icon)
        {
            // Membuat instance dari Form untuk MessageBox custom
            Form form = new Form();
            Label label = new Label();
            Button button1 = new Button();
            Button button2 = new Button();

            // Mengatur teks dan posisi dari label
            label.Text = message;
            label.AutoSize = true;
            label.Location = new System.Drawing.Point(10, 20);

            // Mengatur teks dan posisi dari button1
            button1.Text = buttonAcceptText;
            button1.AutoSize = true;
            button1.Location = new System.Drawing.Point(10, label.Bottom + 20);
            button1.DialogResult = DialogResult.OK;

            // Mengatur teks dan posisi dari button2
            button2.Text = buttonDeniedText;
            button2.AutoSize = true;
            button2.Location = new System.Drawing.Point(button1.Right + 10, label.Bottom + 20);
            button2.DialogResult = DialogResult.Cancel;

            // Menambahkan kontrol ke form
            form.Text = caption;
            form.Controls.AddRange(new Control[] { label, button1, button2 });
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = button1;
            form.CancelButton = button2;

            // Mengatur ukuran form berdasarkan ukuran kontrol yang ada
            form.ClientSize = new System.Drawing.Size(
                Math.Max(300, label.Width + 20),
                label.Height + button1.Height + 60 + 20
            );

            // Menentukan icon dari MessageBox
            switch (icon)
            {
                case MessageBoxIcon.Information:
                    form.Icon = SystemIcons.Information;
                    break;
                case MessageBoxIcon.Warning:
                    form.Icon = SystemIcons.Warning;
                    break;
                case MessageBoxIcon.Error:
                    form.Icon = SystemIcons.Error;
                    break;
                case MessageBoxIcon.Question:
                    form.Icon = SystemIcons.Question;
                    break;
            }

            // Menampilkan form sebagai dialog dan mengembalikan hasilnya
            DialogResult dialogResult = form.ShowDialog();
            return dialogResult == DialogResult.OK;
        }


    }
}
