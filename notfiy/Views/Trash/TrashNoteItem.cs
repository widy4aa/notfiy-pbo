using notfiy.Controllers;
using notfiy.Entities;
using NotfiyViewManager = notfiy.Core.ViewManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notfiy.Views.Trash
{


    public partial class TrashNoteItem : UserControl
    {
        NoteController NoteController = new NoteController();
        public int idNote;
        TrashControl trashControl = new TrashControl();
        public TrashNoteItem(Note note)
        {
            InitializeComponent();
            this.Name = "NoteId" + note.IdNote;
            this.NoteName.Text = note.NoteName;
            this.NoteTextBox.Text = note.Content;
            this.idNote = note.IdNote;
        }

        private void TrashNoteItem_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            NoteController.DeleteNote(idNote);
            NotfiyViewManager.MoveView(trashControl);

        }

        private void kryptonPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
