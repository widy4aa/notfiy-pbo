using notfiy.Controllers;
using notfiy.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notfiy.Views.Homepage
{
    public partial class HomepageAddImage : UserControl
    {
        private Action<string, string> SetImageUrl;
        private Action CloseUploadImageSubControl;
        private ImageController ImageController;
        private string ImageFilePath;
        public HomepageAddImage(Action<string, string> setImageUrl, Action closeUploadImageSubControl)
        {
            InitializeComponent();
            this.ButtonUpload.Visible = false;
            this.NotePictureBox.Visible = false;
            SetImageUrl = setImageUrl;
            CloseUploadImageSubControl = closeUploadImageSubControl;
        }


        private string? OpenExplorerGetImage()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of specified file
                    string filePath = openFileDialog.FileName;

                    // Display the file path in the text box
                    return filePath;
                }
            }

            return null;
        }

        private void HomepageAddImage_Load(object sender, EventArgs e)
        {

        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonChooseFile_Click(object sender, EventArgs e)
        {
            string? imageFilePath = OpenExplorerGetImage();
            if (imageFilePath == null)
            {
                MessageBoxHelper.ShowErrorMessageBox("FIle yang dipilih harus ada!");
                return;
            }

            this.NotePictureBox.Visible = true;
            this.ButtonUpload.Visible = true;
            this.NotePictureBox.ImageLocation = imageFilePath;
            this.ImageFilePath = imageFilePath;
        }

        private void ButtonUpload_Click(object sender, EventArgs e)
        {

            string? imageUrl = ImageController.ProcessImage(ImageFilePath);
            if (imageUrl == null)
            {
                MessageBoxHelper.ShowErrorMessageBox("Gagal Mengupload Gambar!, Ada bisa coba sekali lagi!");
                return;
            }

            SetImageUrl.Invoke(imageUrl, ImageFilePath);
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            CloseUploadImageSubControl.Invoke();
        }
    }
}
