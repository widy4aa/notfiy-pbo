using Krypton.Toolkit;
using notfiy.Controllers;
using notfiy.Entities;
using notfiy.Helpers;
using notfiy.Models;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using LabelEntity = notfiy.Entities.Label;

namespace notfiy.Views.Other
{
    public partial class LabelItem : UserControl
    {
        LabelEntity Label;
        Note note;
        NoteController noteController;
        LabelController labelController;
        public LabelItem()
        {
            InitializeComponent();
            Label = new LabelEntity();
            noteController = new NoteController();
            labelController = new LabelController();
            LabelTextBox.Text = LabelChooseButton.Text;
            LabelTextBox.Hide();


        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            LabelChooseButton.Hide();
            ButtonLabelDelete.Hide();
            ButtonLabelEdit.Hide();

            LabelTextBox.Show();


        }
        private void kryptonButton7_Click(object sender, EventArgs e)
        {
        }

        private void ButtonLabelEdit_Click(object sender, EventArgs e)
        {
           
            List<Note> note = noteController.GetAllNoteFromLabel(Label.IdLabel);
            string LabelName = LabelChooseButton.Text;

            if (LabelController.CreateLabel(LabelName))
            {
                MessageBox.Show($"Data label {LabelName} sudah di update!");
            }
            else
            {
                MessageBoxHelper.ShowInfoMessageBox($"Gagal mengupdate data user {LabelName}!");
            }
        }

        private void ButtonLabelDelete_Click(object sender, EventArgs e)
        {
            bool keputusan = MessageBoxHelper.ShowCustomMessageBoxYesOrNo("Apakah anda yakin menghapus label?", "Hapus Label", "Ya", "Tidak", MessageBoxIcon.Warning);

        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LabelChooseButton.Text = LabelTextBox.Text;
                LabelTextBox.Hide();

                LabelChooseButton.Show();
                ButtonLabelDelete.Show();
                ButtonLabelEdit.Show();


            }
        }
    }
}
