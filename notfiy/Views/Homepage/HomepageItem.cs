using notfiy.Controllers;
using notfiy.Entities;
using notfiy.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreViewManager = notfiy.Core.ViewManager;

namespace notfiy.Views.Homepage
{
    public partial class HomepageItem : UserControl
    {
        private Note Note;
        private NoteController NoteController = new NoteController();
        public int IdNote
        {
            get
            {
                return Note.IdNote;
            }
        }
        public bool IsPinned;
        private Action RearangeNoteItemsAction;


        public HomepageItem(Note note, Action rearangeNoteItemsAction)
        {
            InitializeComponent();

            this.Name = "NoteId" + note.IdNote;
            this.Note = note;
            this.NoteName.Text = note.NoteName;
            this.NoteTextBox.Text = note.Content;
            IsPinned = note.Pinned;
            RearangeNoteItemsAction = rearangeNoteItemsAction;
          

        }

        private void ChangeButtonState()
        {
            if (IsPinned)
            {
                kryptonButton2.Show();
                kryptonButton3.Hide();
            }
            else
            {
                kryptonButton3.Show();
                kryptonButton2.Hide();
            }
            NoteController.UpdateNotePin(IdNote, IsPinned);
        }

        private void ClickItem(object sender, EventArgs e)
        {
            CoreViewManager.MoveView(new HomepageDetail(Note));
        }

        private void HomepageItem_Load(object sender, EventArgs e)
        {
            ChangeButtonState();
        }

        private void kryptonLabel2_Click(object sender, EventArgs e)
        {

        }

        private void kryptonRichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonMaskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void kryptonLabel2_Click_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Click(object sender, PaintEventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            IsPinned = false;
            ChangeButtonState();
            RearangeNoteItemsAction.Invoke();
        }



        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            IsPinned = true;
            ChangeButtonState();
            RearangeNoteItemsAction.Invoke();
        }

        private void kryptonLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
