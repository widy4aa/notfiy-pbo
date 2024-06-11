namespace notfiy.Views.Trash
{
    partial class TrashControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrashControl));
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            HamburgerButton = new Krypton.Toolkit.KryptonButton();
            kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            FlowLayoutNote = new FlowLayoutPanel();
            FlowLayoutTodo = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            SuspendLayout();
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(HamburgerButton);
            kryptonPanel1.Controls.Add(kryptonPictureBox1);
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(1440, 120);
            kryptonPanel1.StateCommon.Color1 = Color.FromArgb(31, 12, 70);
            kryptonPanel1.StateCommon.Color2 = Color.FromArgb(31, 12, 70);
            kryptonPanel1.TabIndex = 1;
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
            // kryptonTextBox1
            // 
            kryptonTextBox1.AlwaysActive = false;
            kryptonTextBox1.Cursor = Cursors.IBeam;
            kryptonTextBox1.Location = new Point(93, 156);
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
            kryptonTextBox1.TabIndex = 18;
            kryptonTextBox1.Text = "Trash";
            kryptonTextBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Location = new Point(0, 860);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(1440, 164);
            kryptonPanel2.StateNormal.Color1 = Color.Black;
            kryptonPanel2.StateNormal.Color2 = Color.Black;
            kryptonPanel2.TabIndex = 20;
            // 
            // FlowLayoutNote
            // 
            FlowLayoutNote.AutoScroll = true;
            FlowLayoutNote.Location = new Point(74, 232);
            FlowLayoutNote.Name = "FlowLayoutNote";
            FlowLayoutNote.Size = new Size(624, 581);
            FlowLayoutNote.TabIndex = 21;
            FlowLayoutNote.Paint += FlowLayoutNote_Paint;
            // 
            // FlowLayoutTodo
            // 
            FlowLayoutTodo.Location = new Point(718, 232);
            FlowLayoutTodo.Name = "FlowLayoutTodo";
            FlowLayoutTodo.Size = new Size(607, 581);
            FlowLayoutTodo.TabIndex = 22;
            FlowLayoutTodo.Paint += flowLayoutPanel1_Paint_1;
            // 
            // TrashControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(FlowLayoutTodo);
            Controls.Add(FlowLayoutNote);
            Controls.Add(kryptonPanel2);
            Controls.Add(kryptonTextBox1);
            Controls.Add(kryptonPanel1);
            Name = "TrashControl";
            Size = new Size(1440, 1024);
            Load += TrashControl_Load;
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton HamburgerButton;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        public FlowLayoutPanel FlowLayoutNote;
        public FlowLayoutPanel FlowLayoutTodo;
    }
}
