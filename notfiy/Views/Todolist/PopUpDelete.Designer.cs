namespace notfiy.Views.Todolist
{
    partial class PopUpDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopUpDelete));
            kryptonCheckedListBox1 = new Krypton.Toolkit.KryptonCheckedListBox();
            kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            label1 = new Label();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // kryptonCheckedListBox1
            // 
            kryptonCheckedListBox1.Location = new Point(519, 347);
            kryptonCheckedListBox1.Name = "kryptonCheckedListBox1";
            kryptonCheckedListBox1.Size = new Size(559, 203);
            kryptonCheckedListBox1.StateCommon.Border.Color1 = Color.FromArgb(46, 26, 94);
            kryptonCheckedListBox1.StateCommon.Border.Color2 = Color.FromArgb(46, 26, 94);
            kryptonCheckedListBox1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCheckedListBox1.StateCommon.Border.Rounding = 20F;
            kryptonCheckedListBox1.StateCommon.Border.Width = 5;
            kryptonCheckedListBox1.TabIndex = 0;
            // 
            // kryptonPictureBox1
            // 
            kryptonPictureBox1.BackgroundImageLayout = ImageLayout.Center;
            kryptonPictureBox1.Image = (Image)resources.GetObject("kryptonPictureBox1.Image");
            kryptonPictureBox1.Location = new Point(530, 378);
            kryptonPictureBox1.Name = "kryptonPictureBox1";
            kryptonPictureBox1.Size = new Size(132, 139);
            kryptonPictureBox1.TabIndex = 1;
            kryptonPictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(679, 390);
            label1.Name = "label1";
            label1.Size = new Size(385, 32);
            label1.TabIndex = 3;
            label1.Text = "Yakin Ingin Menghapus Todolist ? ";
            // 
            // kryptonButton1
            // 
            kryptonButton1.Location = new Point(692, 461);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(149, 47);
            kryptonButton1.StateCommon.Back.Color1 = Color.White;
            kryptonButton1.StateCommon.Back.Color2 = Color.White;
            kryptonButton1.StateCommon.Back.Image = (Image)resources.GetObject("kryptonButton1.StateCommon.Back.Image");
            kryptonButton1.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            kryptonButton1.StateCommon.Border.Color1 = Color.White;
            kryptonButton1.StateCommon.Border.Color2 = Color.White;
            kryptonButton1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.StateCommon.Border.Rounding = 0F;
            kryptonButton1.TabIndex = 4;
            kryptonButton1.Values.Text = "";
            kryptonButton1.Click += this.kryptonButton1_Click;
            // 
            // kryptonButton2
            // 
            kryptonButton2.Location = new Point(870, 461);
            kryptonButton2.Name = "kryptonButton2";
            kryptonButton2.Size = new Size(149, 47);
            kryptonButton2.StateCommon.Back.Color1 = Color.White;
            kryptonButton2.StateCommon.Back.Color2 = Color.White;
            kryptonButton2.StateCommon.Back.Image = (Image)resources.GetObject("kryptonButton2.StateCommon.Back.Image");
            kryptonButton2.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            kryptonButton2.StateCommon.Border.Color1 = Color.White;
            kryptonButton2.StateCommon.Border.Color2 = Color.White;
            kryptonButton2.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton2.StateCommon.Border.Rounding = 0F;
            kryptonButton2.TabIndex = 5;
            kryptonButton2.Values.Text = "";
            // 
            // PopUpDelete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(kryptonButton2);
            Controls.Add(kryptonButton1);
            Controls.Add(label1);
            Controls.Add(kryptonPictureBox1);
            Controls.Add(kryptonCheckedListBox1);
            Name = "PopUpDelete";
            Size = new Size(1440, 1024);
            Load += this.PopUpDelete_Load;
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Krypton.Toolkit.KryptonCheckedListBox kryptonCheckedListBox1;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private Label label1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
    }
}
