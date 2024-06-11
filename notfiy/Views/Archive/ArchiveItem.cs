using notfiy.Controllers;
using notfiy.Entities;
using notfiy.Helpers;
using notfiy.Views.Homepage;
using notfiy.Views.Trash;
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
using notfiy.Helpers;
using Krypton.Toolkit;

namespace notfiy.Views.Archive
{
    public partial class ArchiveItem : UserControl
    {
        public int idNote;
        Note Note;
        NoteController NoteController = new NoteController();
        public KryptonButton ArchiveButton
        {
            get { return buttonArchive; } // buttonArchive adalah tombol di dalam ArchiveItem
        }

        public ArchiveItem(Note note)
        {
            InitializeComponent();
            this.Name = "NoteId" + note.IdNote;
            this.NoteName.Text = note.NoteName;
            this.NoteTextBox.Text = note.Content;
            this.idNote = note.IdNote;
            Note = note;
        }

        private void ArchiveItem_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {

        }

        private void kryptonListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NoteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (NoteController.UpdateNoteStatus(Note.IdNote, (int)StatusHelper.Default))
            {
                MessageBoxHelper.ShowInfoMessageBox("Note Telah di Pindahkan ke homepage");
                Core.ViewManager.MoveView(new HomepageControl(Note.IdLabel));

            }
            else
            {
                MessageBoxHelper.ShowErrorMessageBox("Note gagal di pindahkan ke homepage");
            }
        }
    }
}
