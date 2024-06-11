using notfiy.Controllers;
using notfiy.Entities;
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
using StatusHelper = notfiy.Helpers.Status;

namespace notfiy.Views.Archive
{
    public partial class ArchiveDetail : UserControl
    {
        Note Note;
        ImageController ImageController = new ImageController();
        NoteController NoteController = new NoteController();

        public ArchiveDetail(Note note)
        {
            Note = note;
            InitializeComponent();
        }

        private void ArchiveDetail_Load(object sender, EventArgs e)
        {
            NotePictureBox2.Visible = false;
            NoteContentTextBox2.Location = new Point(3, 3);

            SetProperties();
        }

        private void SetProperties()
        {
            if (Note != null)
            {
                this.NoteName.Text = Note.NoteName;
                this.NoteContentTextBox2.Text = Note.Content;
                if (Note.ImageUrl == null || Note.ImageUrl.Length < 1)
                {

                    return;
                }

                string? imageFileLocation = ImageController.ProcessImage(Note.IdNote, Note.ImageUrl);
                if (imageFileLocation != null)
                {
                    NotePictureBox2.Visible = true;
                    NotePictureBox2.ImageLocation = imageFileLocation;
                }
            }
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            Core.ViewManager.MoveView(new ArchiveControl());

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (NoteController.UpdateNoteStatus(Note.IdNote, (int)StatusHelper.Trashed))
            {
                MessageBoxHelper.ShowInfoMessageBox("Note Telah di Trashed");
                Core.ViewManager.MoveView(new HomepageControl(Note.IdLabel));

            }
            else
            {
                MessageBoxHelper.ShowErrorMessageBox("Note gagal di Trashed");
            }
        }
    }
}
