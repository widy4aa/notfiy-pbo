namespace notfiy.Views.Archive
{
    partial class ArchiveItem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArchiveItem));
            flowLayoutPanel1 = new FlowLayoutPanel();
            NoteName = new Krypton.Toolkit.KryptonLabel();
            NoteTextBox = new Krypton.Toolkit.KryptonRichTextBox();
            kryptonListBox1 = new Krypton.Toolkit.KryptonListBox();
            buttonArchive = new Krypton.Toolkit.KryptonButton();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(NoteName);
            flowLayoutPanel1.Controls.Add(NoteTextBox);
            flowLayoutPanel1.Location = new Point(25, 68);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(246, 176);
            flowLayoutPanel1.TabIndex = 18;
            // 
            // NoteName
            // 
            NoteName.Location = new Point(3, 3);
            NoteName.Name = "NoteName";
            NoteName.Size = new Size(153, 26);
            NoteName.StateNormal.ShortText.Color1 = Color.Black;
            NoteName.StateNormal.ShortText.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NoteName.TabIndex = 12;
            NoteName.Values.Text = "Judul Pekerjaan";
            // 
            // NoteTextBox
            // 
            NoteTextBox.DetectUrls = false;
            NoteTextBox.ImeMode = ImeMode.Disable;
            NoteTextBox.Location = new Point(3, 35);
            NoteTextBox.Name = "NoteTextBox";
            NoteTextBox.ReadOnly = true;
            NoteTextBox.ScrollBars = RichTextBoxScrollBars.None;
            NoteTextBox.Size = new Size(243, 141);
            NoteTextBox.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            NoteTextBox.StateCommon.Border.Width = -2;
            NoteTextBox.TabIndex = 13;
            NoteTextBox.Text = resources.GetString("NoteTextBox.Text");
            NoteTextBox.TextChanged += NoteTextBox_TextChanged;
            // 
            // kryptonListBox1
            // 
            kryptonListBox1.Location = new Point(10, 54);
            kryptonListBox1.Name = "kryptonListBox1";
            kryptonListBox1.Size = new Size(272, 205);
            kryptonListBox1.StateCommon.Border.Color1 = Color.Black;
            kryptonListBox1.StateCommon.Border.Color2 = Color.Black;
            kryptonListBox1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonListBox1.StateCommon.Border.Rounding = 20F;
            kryptonListBox1.StateCommon.Border.Width = 4;
            kryptonListBox1.TabIndex = 17;
            kryptonListBox1.SelectedIndexChanged += kryptonListBox1_SelectedIndexChanged;
            // 
            // buttonArchive
            // 
            buttonArchive.Location = new Point(243, 14);
            buttonArchive.Name = "buttonArchive";
            buttonArchive.Size = new Size(28, 34);
            buttonArchive.StateCommon.Back.Color1 = Color.White;
            buttonArchive.StateCommon.Back.Color2 = Color.White;
            buttonArchive.StateCommon.Back.Image = (Image)resources.GetObject("ArchiveButton.StateCommon.Back.Image");
            buttonArchive.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            buttonArchive.StateCommon.Border.Color1 = Color.White;
            buttonArchive.StateCommon.Border.Color2 = Color.White;
            buttonArchive.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            buttonArchive.TabIndex = 19;
            buttonArchive.Values.Text = "";
            buttonArchive.Click += kryptonButton1_Click;
            // 
            // ArchiveItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(buttonArchive);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(kryptonListBox1);
            Name = "ArchiveItem";
            Size = new Size(298, 266);
            Load += ArchiveItem_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        public Krypton.Toolkit.KryptonLabel NoteName;
        private Krypton.Toolkit.KryptonRichTextBox NoteTextBox;
        private Krypton.Toolkit.KryptonListBox kryptonListBox1;
        public Krypton.Toolkit.KryptonButton buttonArchive;
    }
}
