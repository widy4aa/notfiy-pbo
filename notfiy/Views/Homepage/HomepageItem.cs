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

namespace notfiy.Views.Homepage
{
    public partial class HomepageItem : UserControl
    {
        public int IdNote { get; set; }
        public bool IsPinned;
        private Action RearangeNoteItemsAction;


        public HomepageItem(Note note, Action rearangeNoteItemsAction)
        {
            InitializeComponent();
       
            this.Name = "NoteId" + note.IdNote;
            this.NoteName.Text = note.NoteName;
            this.NoteTextBox.Text = note.Content;
            IsPinned = note.Pinned;
            RearangeNoteItemsAction = rearangeNoteItemsAction;
        }

        private void ChangeButtonState()
        {
            if (IsPinned)
            {
                kryptonButton2.Hide();
                kryptonButton3.Show();
            } else
            {
                kryptonButton3.Show();
                kryptonButton2.Hide();
            }
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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            IsPinned = true;
            RearangeNoteItemsAction.Invoke();
        }

        private void kryptonRichTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            IsPinned = true;
            RearangeNoteItemsAction.Invoke();
        }
    }
}
