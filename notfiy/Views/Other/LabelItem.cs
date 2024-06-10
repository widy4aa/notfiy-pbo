using Krypton.Toolkit;
using notfiy.Entities;
using notfiy.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabelEntity = notfiy.Entities.Label;

namespace notfiy.Views.Other
{
    public partial class LabelItem : UserControl
    {
        LabelEntity Label;
        public LabelItem()
        {
            InitializeComponent();
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
