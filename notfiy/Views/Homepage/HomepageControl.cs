using Krypton.Toolkit;
using notfiy.Views.Other;
using notfiy.Views.Todolist;
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
using StatusHelper = notfiy.Helpers.Status;
using CoreViewManager = notfiy.Core.ViewManager;
using notfiy.Views.NoteHomepagePartial;


namespace notfiy.Views.Homepage
{
    public partial class HomepageControl : UserControl
    {
        NoteController NoteController = new NoteController();
        List<HomepageItem> HomepageItems = new List<HomepageItem>();
        int IdLabel;
        FlowLayoutPanel FlowLayoutPanel;

        public HomepageControl(int? idLabel = null)
        {
            if (idLabel == null)
            {
                IdLabel = (int)StatusHelper.Default;
            }
            else
            {
                IdLabel = idLabel.Value;
            }
            InitializeComponent();

        }

        private void HomepageControl_Load(object sender, EventArgs e)
        {
            FlowLayoutPanel = new FlowLayoutPanel
            {
                Size = new Size(1288, 584),
                Location = new Point(93, 254),
                BackColor = Color.White,
                AutoScroll = true
            };

            this.Controls.Add(FlowLayoutPanel);
            SetNoteItems();

        }

        private void SetNoteItems()
        {
            List<Note> notes = NoteController.GetAllNote();

            foreach (Note note in notes)
            {
                HomepageItem homepageItem = new HomepageItem(note, UpdateNoteArrangement);
                homepageItem.Margin = new Padding(3);
                FlowLayoutPanel.Controls.Add(homepageItem);
                homepageItem.Click += delegate
                {
                    CoreViewManager.MoveView(new HomepageDetail(note));
                };

                HomepageItems.Add(homepageItem);
            }
        }

        private void SearchTextbox_Enter(object sender, EventArgs e)
        {
            if (SearchTextbox.Text == "Search")
            {
                SearchTextbox.Text = string.Empty;
            }
        }

        public void TogglePinAndMoveToTop(int id)
        {
            // cari item berdasarkan ID-nya
            var itemToToggle = HomepageItems.FirstOrDefault(item => item.IdNote == id);

            if (itemToToggle != null)
            {
                // Menukar properti IsPinned
                itemToToggle.IsPinned = !itemToToggle.IsPinned;

                // Jika item sekarang di-pin, pindahkan ke atas
                if (itemToToggle.IsPinned)
                {
                    // Menghapus item dari daftar
                    HomepageItems.Remove(itemToToggle);

                    // Memasukkan item ke posisi paling atas dari daftar
                    HomepageItems.Insert(0, itemToToggle);
                }

                // Memperbarui pengaturan catatan untuk mencerminkan perubahan
                UpdateNoteArrangement();
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

            FlowLayoutPanel.Controls.Clear();

            // Menambahkan kembali semua HomepageItems ke FlowLayoutPanel dalam urutan baru
            foreach (var item in HomepageItems)
            {
                FlowLayoutPanel.Controls.Add(item);
            }
        }


        private void SearchTextbox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchTextbox.Text))
            {
                SearchTextbox.Text = "Search";
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homepageItem1_Load(object sender, EventArgs e)
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

        private void homepageItem7_Load(object sender, EventArgs e)
        {
        }

        private void kryptonPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homepageItem10_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void homepageItem8_Load(object sender, EventArgs e)
        {

        }

        private void homepageItem2_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void SearchTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        // button create

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            CoreViewManager.MoveView(new AddNoteHomepage(IdLabel));
        }
    }
}
