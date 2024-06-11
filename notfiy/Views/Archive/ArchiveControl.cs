using notfiy.Controllers;
using notfiy.Entities;
using notfiy.Views.Other;
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
using Krypton.Toolkit;
using notfiy.Helpers;
using notfiy.Views.Homepage;
using CoreViewManager = notfiy.Core.ViewManager;

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
                archiveitem.Click += delegate
                 {
                     CoreViewManager.MoveView(new ArchiveDetail(note));
                 };


                ArchiveItem.Add(archiveitem);
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
    }
}
