using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using notfiy.Controllers;
using notfiy.Entities;
using notfiy.Views.Homepage;
using notfiy.Views.Other;

namespace notfiy.Views.Trash
{
    public partial class TrashControl : UserControl
    {
        NoteController NoteController = new NoteController();
        List<TrashNoteItem> TrashItems = new List<TrashNoteItem>();


        public TrashControl()
        {
            InitializeComponent();
        }

        private void TrashControl_Load(object sender, EventArgs e)
        {
            SetNoteItems();
        }

        private void SetNoteItems()
        {
            List<Note> notes = NoteController.GetAllNote();

            foreach (Note note in notes)
            {
                TrashNoteItem trashNoteItem = new TrashNoteItem(note);
                trashNoteItem.Margin = new Padding(2);
                FlowLayoutNote.Controls.Add(trashNoteItem);
                TrashItems.Add(trashNoteItem);

            }
        }
        
        

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HamburgerButton_Click(object sender, EventArgs e)
        {
            Navbar navbar = new Navbar();
            this.Controls.Add(navbar);
            navbar.BringToFront();
            navbar.BackColor = Color.Transparent;
            navbar.Location = new Point(1000, 0);
        }

        private void FlowLayoutNote_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
