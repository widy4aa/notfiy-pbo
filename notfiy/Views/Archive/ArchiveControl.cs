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
    public partial class ArchiveControl : UserControl
    {
        NoteController NoteController = new NoteController();
        List<ArchiveItem> ArchiveItem = new List<ArchiveItem>();
        public ArchiveControl()
        {
            InitializeComponent();
        }

        private void ArchiveControl_Load(object sender, EventArgs e)
        {
            SetNoteItems();
        }

        private void ArchivePanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void SetNoteItems()
        {
            List<Note> notes = NoteController.GetAllNote(3);

            foreach (Note note in notes)
            {
                ArchiveItem archiveitem = new ArchiveItem(note);
                archiveitem.Margin = new Padding(2);
                ArchivePanel.Controls.Add(archiveitem);
                ArchiveItem.Add(archiveitem);

            }
        }
    }
}
