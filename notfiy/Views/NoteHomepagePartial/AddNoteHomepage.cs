using notfiy.Controllers;
using notfiy.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using notfiy.Views.Homepage;
using System.Xml.Serialization;

namespace notfiy.Views.NoteHomepagePartial
{
    public partial class AddNoteHomepage : UserControl
    {
        // jika melakukan mode edit
        Note? Note;
        ImageController ImageController = new ImageController();
        int IdLabel;
        string ImageFileUrl;
        HomepageAddImage HomePageAddImage;
        public AddNoteHomepage(int idLabel, Note? note = null)
        {
            IdLabel = idLabel;
            Note = note;
            InitializeComponent();
            this.NotePictureBox.Visible = false;
            SetProperties();
        }

        private void SetProperties()
        {
            if (Note != null)
            {
                this.NoteName.Text = Note.NoteName;
                this.NoteContentTextBox.Text = Note.Content;
                if (Note.ImageUrl == null)
                {
                    return;
                }

                string? imageFileLocation = ImageController.GetImage(Note.IdNote, Note.ImageUrl);
                if (imageFileLocation != null)
                {
                    NotePictureBox.ImageLocation = imageFileLocation;
                }
            }
        }

        private void NoteName_TextChanged(object sender, EventArgs e)
        {
            if (NoteName.Text == "Judul")
            {
                NoteName.Text = "";
            }
        }

        // button add gambar
        private void ButtonAddImage_Click(object sender, EventArgs e)
        {
            HomepageAddImage homePageAddImage = new HomepageAddImage(SetImageUrl, CloseUploadImageSubControl);
            this.Controls.Add(homePageAddImage);
            homePageAddImage.BringToFront();
            homePageAddImage.BackColor = Color.Transparent;
            homePageAddImage.Location = new Point(438, 227);
            HomePageAddImage = homePageAddImage;
        }

        private void SetImageUrl(string filePath, string fileUrl)
        {
            this.ImageFileUrl = fileUrl;
            this.NotePictureBox.ImageLocation = filePath;
            this.NotePictureBox.Visible = true;
        }

        private void CloseUploadImageSubControl()
        {
            HomePageAddImage.Dispose();
        }

        private void PerformUpdate()
        {

        }

        private void PerformCreate()
        {

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (Note != null)
            {
                PerformCreate();
            } 
            else
            {
                PerformUpdate();
            }
                    
        }
    }
}
