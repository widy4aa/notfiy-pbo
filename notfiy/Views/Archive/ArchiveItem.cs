using notfiy.Controllers;
using notfiy.Entities;
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

namespace notfiy.Views.Archive
{
    public partial class ArchiveItem : UserControl
    {
        public int idNote;
        public ArchiveItem(Note note)
        {
            InitializeComponent();
            this.Name = "NoteId" + note.IdNote;
            this.NoteName.Text = note.NoteName;
            this.NoteTextBox.Text = note.Content;
            this.idNote = note.IdNote;
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
    }
}
