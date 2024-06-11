using Krypton.Toolkit;
using notfiy.Controllers;
using notfiy.Entities;
using notfiy.Helpers;
using notfiy.Views.Homepage;
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
        LabelController LabelController = new LabelController();
        Action RefreshFlowLayoutPanelLabels;
        public LabelItem(LabelEntity label, Action refreshFlowLayoutPanelLabels)
        {
            InitializeComponent();
            LabelChooseButton.Text = label.LabelName;
            LabelTextBox.Text = LabelChooseButton.Text;
            LabelTextBox.Hide();
            Label = label;
            RefreshFlowLayoutPanelLabels = refreshFlowLayoutPanelLabels;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }


        private void kryptonButton7_Click(object sender, EventArgs e)
        {
            Core.ViewManager.MoveView(new HomepageControl(Label.IdLabel));

        }

        private void ButtonLabelEdit_Click(object sender, EventArgs e)
        {
            LabelChooseButton.Hide();
            ButtonLabelDelete.Hide();
            ButtonLabelEdit.Hide();

            LabelTextBox.Show();

        }

        private void KeyDownPressEnterEdit_Click(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                bool keputusan = MessageBoxHelper.ShowCustomMessageBoxYesOrNo("Apakah anda yakin mengedit label?", "Edit Label", "Ya", "Tidak", MessageBoxIcon.Warning);
                if (keputusan)
                {
                    Label.LabelName = LabelTextBox.Text;
                    if (LabelController.UpdateLabel(Label))
                    {
                        MessageBoxHelper.ShowInfoMessageBox("Label berhasil diubah!");
                        LabelChooseButton.Show();
                        ButtonLabelDelete.Show();
                        ButtonLabelEdit.Show();

                        LabelTextBox.Hide();
                        RefreshFlowLayoutPanelLabels.Invoke();
                    } else
                    {
                        MessageBoxHelper.ShowErrorMessageBox("Label gagal diubah!");
                    }
                }
            }
        }
 
        private void ButtonLabelDelete_Click(object sender, EventArgs e)
        {
            bool keputusan = MessageBoxHelper.ShowCustomMessageBoxYesOrNo("Apakah anda yakin menghapus label?", "Hapus Label", "Ya", "Tidak", MessageBoxIcon.Warning);
            if (keputusan)
            {
                if (LabelController.DeleteLabel(Label.IdLabel))
                {
                    MessageBoxHelper.ShowInfoMessageBox("Label berhasil Di hapus!");
                    RefreshFlowLayoutPanelLabels.Invoke();

                }
                else
                {
                    MessageBoxHelper.ShowErrorMessageBox("Label gagal Di hapus!");

                }
            }
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
