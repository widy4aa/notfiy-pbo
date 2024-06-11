using notfiy.Controllers;
using notfiy.Entities;
using notfiy.Views.Homepage;
using notfiy.Views.Profiles;
using notfiy.Views.Todolist;
using notfiy.Views.Other;
using notfiy.Views.Trash;
using notfiy.Views.Archive;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotifyViewManager = notfiy.Core.ViewManager;
using LabelEntity = notfiy.Entities.Label;
using System.Reflection.Emit;

namespace notfiy.Views.Other
{
    public partial class Navbar : UserControl
    {
        private UserController UserController;
        private User CurrentUser;
        private LabelController LabelController;
        public Navbar()
        {
            InitializeComponent();
            kryptonPictureBox1.BackColor = Color.FromArgb(46, 26, 94);
            UserController = new UserController();
            LabelController = new LabelController();
        }

        private void kryptonPictureBox1_Click(object sender, EventArgs e)
        {
            ProfileControl profil = new ProfileControl();
            NotifyViewManager.MoveView(profil);
        }

        private void Navbar_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
            FlowLayoutPanelLabels.AutoScroll = true;

            int IdUser = UserController.GetUserLoggedIn(); //mendapatkan id dari user yang sedang login
            CurrentUser = UserController.GetUserById(IdUser);

            if (CurrentUser != null)
            {
                label1.Text = $"{CurrentUser.Username}";
            }
            SetLabelItems();
        }

        private void ResetFlowLayoutPanelLabels()
        {
            FlowLayoutPanelLabels.Controls.Clear();
            //FlowLayoutPanelLabels = new FlowLayoutPanel();
            FlowLayoutPanelLabels.AutoScroll = true;
            FlowLayoutPanelLabels.BackColor = Color.FromArgb(46, 26, 96);
            FlowLayoutPanelLabels.Location = new Point(84, 373);
            FlowLayoutPanelLabels.Name = "FlowLayoutPanelLabels";
            FlowLayoutPanelLabels.Size = new Size(374, 138);
            FlowLayoutPanelLabels.TabIndex = 2;
            FlowLayoutPanelLabels.Paint += flowLayoutPanel1_Paint;
            this.Controls.Add(FlowLayoutPanelLabels);
            FlowLayoutPanelLabels.BringToFront();
        }

        private void SetLabelItems()
        {
            ResetFlowLayoutPanelLabels();
            List<LabelEntity> labels = LabelController.GetAllLabel();
            foreach (var label in labels)
            {
                LabelItem labelControl = new LabelItem(label, SetLabelItems);
                labelControl.Text = label.LabelName;
                labelControl.Location = new Point(3, 3);
                labelControl.Size = new Size(321, 58);
                labelControl.TabIndex = 0;                
                labelControl.BackColor = Color.FromArgb(61, 44, 94);
                labelControl.ForeColor = Color.White;
                labelControl.Margin = new Padding(5);
                labelControl.BorderStyle = BorderStyle.FixedSingle;
                labelControl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);

                FlowLayoutPanelLabels.Controls.Add(labelControl);


            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            //kryptonButton7.StateCommon.Back.Image;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelItem2_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            HomepageControl homepage = new HomepageControl();
            NotifyViewManager.MoveView(homepage);
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            TodolistControl todolist = new TodolistControl();
            NotifyViewManager.MoveView(todolist);
        }

        //nambah label 1 baris
        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            //string newLabelName = labelItem2.Text;
            //if (!string.IsNullOrEmpty(newLabelName))
            //{
            //    // Tambahkan logika untuk menambahkan label baru
            //    var labelController = new LabelController();
            //    int newLabelId = labelController.CreateLabel(newLabelName);
            LabelEntity labelEntity = new LabelEntity
            {
                LabelName = "Label Baru",
            };
            int idNewLabel = LabelController.CreateLabel(labelEntity.LabelName);
            labelEntity.IdLabel = idNewLabel;
            LabelItem labelControl = new LabelItem(labelEntity, SetLabelItems);
            labelControl.Text = "Label Baru";
            labelControl.Location = new Point(3, 3);
            labelControl.Size = new Size(321, 58);
            labelControl.TabIndex = 0;            
            labelControl.BackColor = Color.FromArgb(61, 44, 94);
            labelControl.ForeColor = Color.White;
            labelControl.Margin = new Padding(5);
            labelControl.BorderStyle = BorderStyle.FixedSingle;
            labelControl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);

            //    if (newLabelId > 0)
            //    {
            //        Entities.Label newLabel = new Entities.Label { IdLabel = newLabelId, LabelName = newLabelName };
            //        AddLabelToPanel(newLabel);
            //        //labelItem2.Clear();
            //        labelItem2.Visible = false;
            //        labelItem2.Visible = false;
            //        kryptonButton5.Location = new Point(kryptonButton5.Location.X, kryptonButton5.Location.Y - 30); // Kembalikan tombol ke posisi semula
            //    }
            //    else
            //    {
            //        MessageBox.Show("Failed to add label.");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Label name cannot be empty.");
            //}
            FlowLayoutPanelLabels.Controls.Add(labelControl);
            if (idNewLabel > 0)
            {
                Helpers.MessageBoxHelper.ShowInfoMessageBox("Label Kosongan telah telah dibuat jangan lupa untuk mengganti namanya");
                SetLabelItems();
            } else
            {
                Helpers.MessageBoxHelper.ShowErrorMessageBox("Tidak Dapat membuat label baru!");
            }
        }

        private void AddLabelToPanel(Entities.Label label)
        {
            var labelItem = new LabelItem(label, ResetFlowLayoutPanelLabels);
            FlowLayoutPanelLabels.Controls.Add(labelItem);
        }

        private void kryptonCheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            ArchiveControl archiveControl = new ArchiveControl();
            NotifyViewManager.MoveView(archiveControl);
        }

        private void labelItem1_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton6_Click(object sender, EventArgs e)
        {
            TrashControl trashcontrol = new TrashControl();
            NotifyViewManager.MoveView(trashcontrol);
        }
    }
}
