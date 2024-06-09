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

namespace notfiy.Views.Homepage
{
    public partial class HomepageDetail : UserControl
    {
        Note Note;
        ImageController ImageController = new ImageController();

        public HomepageDetail(Note note)
        {
            Note = note;
            InitializeComponent();
        }

        private void HomepageDetail_Load(object sender, EventArgs e)
        {
            this.NotePictureBox.Visible = false;
            SetProperties();
        }

        private void SetProperties()
        {
            if (Note != null)
            {
                this.NoteName.Text = Note.NoteName;
                this.NoteContentTextBox.Text = Note.Content;
                if (Note.ImageUrl == null)
                {
                    return;
                }

                string? imageFileLocation = ImageController.GetImage(Note.IdNote, Note.ImageUrl);
                if (imageFileLocation != null)
                {
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

    }
}
