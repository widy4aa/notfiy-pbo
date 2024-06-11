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

namespace notfiy.Views.Other
{
    public partial class Navbar : UserControl
    {
        private UserController userController;
        private User currentUser;
        public Navbar()
        {
            InitializeComponent();
            kryptonPictureBox1.BackColor = Color.FromArgb(46, 26, 94);
            userController = new UserController();
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

            int IdUser = userController.GetUserLoggedIn(); //mendapatkan id dari user yang sedang login
            currentUser = userController.GetUserById(IdUser);

            if (currentUser != null)
            {
                label1.Text = $"{currentUser.Username}";
            }

        }


        private void LoadLabels()
        {
            FlowLayoutPanelLabels.Controls.Add(label1);
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

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            //string newLabelName = labelItem2.Text;
            //if (!string.IsNullOrEmpty(newLabelName))
            //{
            //    // Tambahkan logika untuk menambahkan label baru
            //    var labelController = new LabelController();
            //    int newLabelId = labelController.CreateLabel(newLabelName);

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
        }

        private void AddLabelToPanel(Entities.Label label)
        {
            var labelItem = new LabelItem();
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
