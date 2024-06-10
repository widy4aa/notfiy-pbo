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
using System.Reflection.Metadata;
using StatusEnum = notfiy.Helpers.Status;
using notfiy.Helpers;
using notfiy.Views.Other;
using notfiy.Views.AddToDoList;

namespace notfiy.Views.NoteHomepagePartial
{
    public partial class AddNoteHomepage : UserControl
    {
        // jika melakukan mode edit
        Note? Note;
        ImageController ImageController = new ImageController();
        NoteController NoteController = new NoteController();
        int? IdLabel;
        string ImageUrl;
        HomepageAddImage HomePageAddImage;
        public AddNoteHomepage(int? idLabel = null, Note? note = null)
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

                string? imageFileLocation = ImageController.ProcessImage(Note.IdNote, Note.ImageUrl);
                if (imageFileLocation != null)
                {
                    NotePictureBox.Visible = true;
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
            this.ImageUrl = fileUrl;
            this.NotePictureBox.ImageLocation = filePath;
            this.NotePictureBox.Visible = true;
        }

        private void CloseUploadImageSubControl()
        {
            HomePageAddImage.Dispose();
        }

        private void PerformUpdate()
        {
            Note.Content = this.NoteContentTextBox.Text;
            Note.IdLabel = IdLabel;
            MessageBoxHelper.ShowInfoMessageBox(ImageUrl);
            if (ImageUrl != null)
            {
                ImageController.DeleteCache(Note.IdNote);
                Note.ImageUrl = ImageUrl;
            }

            bool hasil = NoteController.UpdateNote(Note);
            
            if (hasil)
            {
                MessageBoxHelper.ShowInfoMessageBox("Note Berhasil Di Ubah");
                Core.ViewManager.MoveView(new HomepageDetail(NoteController.GetNote(Note.IdNote)));
            }
            else
            {
                MessageBoxHelper.ShowInfoMessageBox("Note Gagal di Ubah");
            }
        }

        private void PerformCreate()
        {
            int idNewNote = NoteController.CreateNote(NoteName.Text,
                NoteContentTextBox.Text,
                this.ImageUrl,
                IdLabel,
                (int)StatusEnum.Default);
            if (idNewNote > 0)
            {
                MessageBoxHelper.ShowInfoMessageBox("Note Berhasil Dibuat");
                Core.ViewManager.MoveView(new HomepageControl());
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (Note == null)
            {
                PerformCreate();
            }
            else
            {
                PerformUpdate();
            }

        }

        private void HamburgerButton_Click(object sender, EventArgs e)
        {
            Navbar navbar = new Navbar();
            this.Controls.Add(navbar);
            navbar.BringToFront();
            navbar.BackColor = Color.Transparent;
            navbar.Location = new Point(1000, 0);
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Core.ViewManager.MoveView(new HomepageControl());
        }

        private void NotePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void AddNoteHomepage_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.AutoScroll = true;
        }

        private void kryptonLabel3_Click(object sender, EventArgs e)
        {
            Core.ViewManager.MoveView(new AddToDoListControl());
        }
    }
}
