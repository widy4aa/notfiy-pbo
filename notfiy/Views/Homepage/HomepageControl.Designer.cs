namespace notfiy.Views.Homepage
{
    partial class HomepageControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomepageControl));
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            ButtonSearch = new Krypton.Toolkit.KryptonButton();
            HamburgerButton = new Krypton.Toolkit.KryptonButton();
            kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            SearchTextbox = new Krypton.Toolkit.KryptonTextBox();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            kryptonButton4 = new Krypton.Toolkit.KryptonButton();
            NoteNotFoundResultStatus = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(ButtonSearch);
            kryptonPanel1.Controls.Add(HamburgerButton);
            kryptonPanel1.Controls.Add(kryptonPictureBox1);
            kryptonPanel1.Controls.Add(SearchTextbox);
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(1440, 120);
            kryptonPanel1.StateCommon.Color1 = Color.FromArgb(31, 12, 70);
            kryptonPanel1.StateCommon.Color2 = Color.FromArgb(31, 12, 70);
            kryptonPanel1.TabIndex = 0;
            // 
            // ButtonSearch
            // 
            ButtonSearch.Location = new Point(1062, 37);
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(40, 40);
            ButtonSearch.StateCommon.Back.Color1 = Color.White;
            ButtonSearch.StateCommon.Back.Color2 = Color.White;
            ButtonSearch.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            ButtonSearch.StateCommon.Back.Image = (Image)resources.GetObject("ButtonSearch.StateCommon.Back.Image");
            ButtonSearch.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            ButtonSearch.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ButtonSearch.StateCommon.Border.Width = -3;
            ButtonSearch.TabIndex = 18;
            ButtonSearch.Values.Text = "";
            ButtonSearch.Click += ButtonSearch_Click;
            // 
            // HamburgerButton
            // 
            HamburgerButton.Location = new Point(1299, 31);
            HamburgerButton.Name = "HamburgerButton";
            HamburgerButton.Size = new Size(60, 55);
            HamburgerButton.StateCommon.Back.Color1 = Color.FromArgb(51, 15, 126);
            HamburgerButton.StateCommon.Back.Color2 = Color.FromArgb(51, 15, 126);
            HamburgerButton.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            HamburgerButton.StateCommon.Back.Image = (Image)resources.GetObject("HamburgerButton.StateCommon.Back.Image");
            HamburgerButton.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            HamburgerButton.StateCommon.Border.Color1 = Color.FromArgb(51, 15, 126);
            HamburgerButton.StateCommon.Border.Color2 = Color.FromArgb(51, 15, 126);
            HamburgerButton.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            HamburgerButton.StateCommon.Border.Width = -2;
            HamburgerButton.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            HamburgerButton.StateTracking.Back.Image = (Image)resources.GetObject("HamburgerButton.StateTracking.Back.Image");
            HamburgerButton.StateTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            HamburgerButton.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            HamburgerButton.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            HamburgerButton.StateTracking.Border.Width = -5;
            HamburgerButton.TabIndex = 14;
            HamburgerButton.Values.Text = "";
            HamburgerButton.Click += HamburgerButton_Click;
            // 
            // kryptonPictureBox1
            // 
            kryptonPictureBox1.Image = (Image)resources.GetObject("kryptonPictureBox1.Image");
            kryptonPictureBox1.Location = new Point(63, 30);
            kryptonPictureBox1.Name = "kryptonPictureBox1";
            kryptonPictureBox1.Size = new Size(267, 63);
            kryptonPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            kryptonPictureBox1.TabIndex = 13;
            kryptonPictureBox1.TabStop = false;
            // 
            // SearchTextbox
            // 
            SearchTextbox.Location = new Point(380, 32);
            SearchTextbox.Name = "SearchTextbox";
            SearchTextbox.Size = new Size(745, 54);
            SearchTextbox.StateActive.Back.Color1 = Color.White;
            SearchTextbox.StateActive.Border.Color1 = Color.White;
            SearchTextbox.StateActive.Border.Color2 = Color.White;
            SearchTextbox.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            SearchTextbox.StateActive.Border.Rounding = 20F;
            SearchTextbox.StateActive.Border.Width = 4;
            SearchTextbox.StateActive.Content.Color1 = Color.FromArgb(51, 15, 126);
            SearchTextbox.StateActive.Content.Font = new Font("Microsoft Sans Serif", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchTextbox.StateNormal.Back.Color1 = Color.Transparent;
            SearchTextbox.TabIndex = 11;
            SearchTextbox.Text = "Search";
            SearchTextbox.TextChanged += SearchTextbox_TextChanged;
            SearchTextbox.Enter += SearchTextbox_Enter;
            SearchTextbox.KeyDown += KeyDownSearch;
            SearchTextbox.Leave += SearchTextbox_Leave;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(kryptonLabel1);
            kryptonPanel2.Location = new Point(0, 860);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(1440, 164);
            kryptonPanel2.StateNormal.Color1 = Color.Black;
            kryptonPanel2.StateNormal.Color2 = Color.Black;
            kryptonPanel2.TabIndex = 1;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(541, 71);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(314, 26);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel1.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel1.StateCommon.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.AntiAlias;
            kryptonLabel1.TabIndex = 0;
            kryptonLabel1.Values.Text = "2024 * Notify - Copyright Reserved";
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.AlwaysActive = false;
            kryptonTextBox1.Cursor = Cursors.IBeam;
            kryptonTextBox1.Location = new Point(93, 169);
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.ReadOnly = true;
            kryptonTextBox1.Size = new Size(218, 48);
            kryptonTextBox1.StateActive.Back.Color1 = Color.FromArgb(61, 44, 94);
            kryptonTextBox1.StateActive.Border.Color1 = Color.Black;
            kryptonTextBox1.StateActive.Border.Color2 = Color.Black;
            kryptonTextBox1.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonTextBox1.StateActive.Border.Rounding = 20F;
            kryptonTextBox1.StateActive.Border.Width = 1;
            kryptonTextBox1.StateActive.Content.Color1 = Color.White;
            kryptonTextBox1.StateActive.Content.Font = new Font("Microsoft Sans Serif", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBox1.StateCommon.Back.Color1 = Color.FromArgb(128, 128, 255);
            kryptonTextBox1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonTextBox1.StateCommon.Border.Width = 1;
            kryptonTextBox1.StateCommon.Content.Color1 = Color.White;
            kryptonTextBox1.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBox1.StateNormal.Back.Color1 = Color.FromArgb(61, 44, 94);
            kryptonTextBox1.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonTextBox1.StateNormal.Border.Rounding = 20F;
            kryptonTextBox1.StateNormal.Border.Width = 1;
            kryptonTextBox1.TabIndex = 17;
            kryptonTextBox1.Text = "Note";
            kryptonTextBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // kryptonButton4
            // 
            kryptonButton4.Location = new Point(1258, 731);
            kryptonButton4.Name = "kryptonButton4";
            kryptonButton4.Size = new Size(136, 100);
            kryptonButton4.StateCommon.Back.Color1 = Color.FromArgb(51, 15, 126);
            kryptonButton4.StateCommon.Back.Color2 = Color.FromArgb(51, 15, 126);
            kryptonButton4.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounding4;
            kryptonButton4.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonButton4.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton4.StateCommon.Border.Rounding = 20F;
            kryptonButton4.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton4.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButton4.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonButton4.TabIndex = 20;
            kryptonButton4.Values.Text = "+";
            kryptonButton4.Click += kryptonButton4_Click;
            // 
            // NoteNotFoundResultStatus
            // 
            NoteNotFoundResultStatus.Location = new Point(625, 414);
            NoteNotFoundResultStatus.Name = "NoteNotFoundResultStatus";
            NoteNotFoundResultStatus.Size = new Size(240, 43);
            NoteNotFoundResultStatus.StateNormal.ShortText.Color1 = Color.Black;
            NoteNotFoundResultStatus.StateNormal.ShortText.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NoteNotFoundResultStatus.TabIndex = 37;
            NoteNotFoundResultStatus.Values.Text = "Tidak ada Note";
            NoteNotFoundResultStatus.Visible = false;
            NoteNotFoundResultStatus.Click += NoteNotFoundResultStatus_Click;
            // 
            // HomepageControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(NoteNotFoundResultStatus);
            Controls.Add(kryptonButton4);
            Controls.Add(kryptonTextBox1);
            Controls.Add(kryptonPanel2);
            Controls.Add(kryptonPanel1);
            Name = "HomepageControl";
            Size = new Size(1440, 1024);
            Load += HomepageControl_Load;
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            kryptonPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonTextBox SearchTextbox;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private Krypton.Toolkit.KryptonButton HamburgerButton;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonButton ButtonSearch;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton kryptonButton4;
        private Krypton.Toolkit.KryptonLabel NoteNotFoundResultStatus;
    }
}
