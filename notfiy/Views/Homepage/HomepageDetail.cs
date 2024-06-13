using notfiy.Views.Other;
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
using notfiy.Controllers;
using Krypton.Toolkit;
using notfiy.Views.NoteHomepagePartial;
using StatusHelper = notfiy.Helpers.Status;
using notfiy.Helpers;

namespace notfiy.Views.Homepage
{
    public partial class HomepageDetail : UserControl
    {
        Note Note;
        ImageController ImageController = new ImageController();
        NoteController NoteController = new NoteController();

        public HomepageDetail(Note note)
        {
            Note = note;
            InitializeComponent();
        }

        private void HomepageDetail_Load(object sender, EventArgs e)
        {
            NotePictureBox.Visible = false;
            NoteContentTextBox.Location = new Point(3, 3);

            SetProperties();
        }

        private void SetProperties()
        {
            if (Note != null)
            {
                this.NoteName.Text = Note.NoteName;
                this.NoteContentTextBox.Text = Note.Content;

                if (Note.ImageUrl == null || Note.ImageUrl.Length < 3)
                {

                    return;
                }

                string? imageFileLocation = ImageController.ProcessImage(Note.IdNote, Note.ImageUrl);
                if (imageFileLocation != null)
                {
                    NotePictureBox.Visible = true;
                    NotePictureBox.ImageLocation = imageFileLocation;
                }
            }
        }
        private void kryptonRichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonLabel2_Click(object sender, EventArgs e)
        {

        }

        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kryptonTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonBorderEdge1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Core.ViewManager.MoveView(new HomepageControl(Note.IdLabel));
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            Core.ViewManager.MoveView(new AddNoteHomepageControl(Note.IdLabel, Note));
        }

        private void ButtonTrash_Click(object sender, EventArgs e)
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

        private void BtnEdit_Click(object sender, EventArgs e)
        {

        }

        private void NotePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void NoteContentTextBox_TextChanged(object sender, EventArgs e)
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

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (NoteController.UpdateNoteStatus(Note.IdNote, (int)StatusHelper.Archived))
            {
                MessageBoxHelper.ShowInfoMessageBox("Note Telah di Archive");
                Core.ViewManager.MoveView(new HomepageControl(Note.IdLabel));

            }
            else
            {
                MessageBoxHelper.ShowErrorMessageBox("Note gagal di Archive");
            }
        }

        private void NoteName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
