namespace notfiy.Views.Trash
{
    partial class TrashNoteItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrashNoteItem));
            kryptonListBox1 = new Krypton.Toolkit.KryptonListBox();
            kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            NoteName = new Krypton.Toolkit.KryptonLabel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            NoteTextBox = new Krypton.Toolkit.KryptonRichTextBox();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // kryptonListBox1
            // 
            kryptonListBox1.Location = new Point(14, 45);
            kryptonListBox1.Name = "kryptonListBox1";
            kryptonListBox1.Size = new Size(272, 205);
            kryptonListBox1.StateCommon.Back.Color1 = Color.White;
            kryptonListBox1.StateCommon.Back.Color2 = Color.White;
            kryptonListBox1.StateCommon.Border.Color1 = Color.Black;
            kryptonListBox1.StateCommon.Border.Color2 = Color.Black;
            kryptonListBox1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonListBox1.StateCommon.Border.Rounding = 20F;
            kryptonListBox1.StateCommon.Border.Width = 4;
            kryptonListBox1.TabIndex = 15;
            // 
            // kryptonPictureBox1
            // 
            kryptonPictureBox1.Location = new Point(3, 3);
            kryptonPictureBox1.Name = "kryptonPictureBox1";
            kryptonPictureBox1.Size = new Size(243, 82);
            kryptonPictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            kryptonPictureBox1.TabIndex = 14;
            kryptonPictureBox1.TabStop = false;
            kryptonPictureBox1.Visible = false;
            // 
            // NoteName
            // 
            NoteName.Location = new Point(3, 91);
            NoteName.Name = "NoteName";
            NoteName.Size = new Size(153, 26);
            NoteName.StateNormal.ShortText.Color1 = Color.Black;
            NoteName.StateNormal.ShortText.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NoteName.TabIndex = 12;
            NoteName.Values.Text = "Judul Pekerjaan";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(kryptonPictureBox1);
            flowLayoutPanel1.Controls.Add(NoteName);
            flowLayoutPanel1.Controls.Add(NoteTextBox);
            flowLayoutPanel1.Location = new Point(27, 60);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(246, 176);
            flowLayoutPanel1.TabIndex = 16;
            // 
            // NoteTextBox
            // 
            NoteTextBox.DetectUrls = false;
            NoteTextBox.ImeMode = ImeMode.Disable;
            NoteTextBox.Location = new Point(3, 123);
            NoteTextBox.Name = "NoteTextBox";
            NoteTextBox.ReadOnly = true;
            NoteTextBox.ScrollBars = RichTextBoxScrollBars.None;
            NoteTextBox.Size = new Size(243, 141);
            NoteTextBox.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            NoteTextBox.StateCommon.Border.Width = -2;
            NoteTextBox.TabIndex = 13;
            NoteTextBox.Text = resources.GetString("NoteTextBox.Text");
            // 
            // kryptonButton1
            // 
            kryptonButton1.Location = new Point(242, 13);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(31, 26);
            kryptonButton1.StateCommon.Back.Color1 = Color.White;
            kryptonButton1.StateCommon.Back.Color2 = Color.White;
            kryptonButton1.StateCommon.Back.Image = (Image)resources.GetObject("kryptonButton1.StateCommon.Back.Image");
            kryptonButton1.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton1.TabIndex = 17;
            kryptonButton1.Values.Text = "";
            // 
            // TrashNoteItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(kryptonButton1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(kryptonListBox1);
            Name = "TrashNoteItem";
            Size = new Size(298, 266);
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonListBox kryptonListBox1;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        public Krypton.Toolkit.KryptonLabel NoteName;
        private FlowLayoutPanel flowLayoutPanel1;
        private Krypton.Toolkit.KryptonRichTextBox NoteTextBox;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}
