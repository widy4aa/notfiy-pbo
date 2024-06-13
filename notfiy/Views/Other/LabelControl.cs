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

namespace notfiy.Views.Other
{
    public partial class LabelControl : UserControl
    {
        private Entities.Label label;
        NoteController NoteController;
        LabelController LabelController;
        UserController userController;
        private User currentUser;
        List<HomepageItem> HomepageItems;
 
        public LabelControl()
        {
            InitializeComponent();
            NoteController = new NoteController();
            LabelController = new LabelController();
            userController = new UserController();
            HomepageItems = new List<HomepageItem>();
        }

        private void LabelControl_Load(object sender, EventArgs e)
        {
            int IdUser = userController.GetUserLoggedIn(); //mendapatkan id dari user yang sedang login
            currentUser = userController.GetUserById(IdUser);
            List<Note> notes = NoteController.GetAllNoteFromLabel(label.IdLabel);

            foreach (Note note in notes)
            {
                HomepageItem homepageItem = new HomepageItem(note, UpdateNoteArrangement);
                homepageItem.Margin = new Padding(3);
                flowLayoutPanel1.Controls.Add(homepageItem);
                homepageItem.Click += delegate
                {
                    Core.ViewManager.MoveView(new HomepageDetail(note));
                };

                HomepageItems.Add(homepageItem);
            }
        }

        public void UpdateNoteArrangement()
        {
            // Menyaring item yang di-pin dari HomepageItems dan menyimpannya ke dalam daftar pinnedItems
            List<HomepageItem> pinnedItems = HomepageItems
                .Where(item => item.IsPinned) // Memeriksa apakah item di-pin
                .ToList(); // Mengubah hasil penyaringan menjadi daftar (list)

            List<HomepageItem> unpinnedItems = HomepageItems
                .Where(item => !item.IsPinned)
                .ToList();

            HomepageItems.Clear();

            // Menambahkan semua item yang di-pin ke HomepageItems sehingga mereka berada di bagian atas
            HomepageItems.AddRange(pinnedItems);

            // Menambahkan semua item yang tidak di-pin ke HomepageItems sehingga mereka berada di bagian bawah
            HomepageItems.AddRange(unpinnedItems);

            flowLayoutPanel1.Controls.Clear();

            // Menambahkan kembali semua HomepageItems ke FlowLayoutPanel dalam urutan baru
            foreach (var item in HomepageItems)
            {
                flowLayoutPanel1.Controls.Add(item);
            }
        }

        private void HamburgerButton_Click(object sender, EventArgs e)
        {
            Navbar navbar = new Navbar();
            this.Controls.Add(navbar);
            navbar.BringToFront();
            navbar.BackColor = Color.Transparent;
            navbar.Location = new Point(1000, 0);
        }
    }
}
