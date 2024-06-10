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

namespace notfiy.Views.Trash
{
    public partial class TrashNoteItem : UserControl
    {
        public TrashNoteItem(Note note)
        {
            InitializeComponent();
            this.Name = "NoteId" + note.IdNote;
            this.NoteName.Text = note.NoteName;
            this.NoteTextBox.Text = note.Content;
        }

        private void TrashNoteItem_Load(object sender, EventArgs e)
        {

        }
    }
}
