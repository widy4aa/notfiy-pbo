namespace notfiy.Views.Homepage
{
    partial class HomepageAddImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomepageAddImage));
            kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            ButtonChooseFile = new Krypton.Toolkit.KryptonButton();
            ButtonUpload = new Krypton.Toolkit.KryptonButton();
            kryptonButton3 = new Krypton.Toolkit.KryptonButton();
            NotePictureBox = new Krypton.Toolkit.KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NotePictureBox).BeginInit();
            SuspendLayout();
            // 
            // kryptonPictureBox1
            // 
            kryptonPictureBox1.Image = (Image)resources.GetObject("kryptonPictureBox1.Image");
            kryptonPictureBox1.Location = new Point(3, 3);
            kryptonPictureBox1.Name = "kryptonPictureBox1";
            kryptonPictureBox1.Size = new Size(583, 464);
            kryptonPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            kryptonPictureBox1.TabIndex = 0;
            kryptonPictureBox1.TabStop = false;
            // 
            // ButtonChooseFile
            // 
            ButtonChooseFile.Location = new Point(42, 351);
            ButtonChooseFile.Name = "ButtonChooseFile";
            ButtonChooseFile.Size = new Size(223, 69);
            ButtonChooseFile.StateCommon.Back.Color1 = Color.White;
            ButtonChooseFile.StateCommon.Back.Color2 = Color.White;
            ButtonChooseFile.StateCommon.Back.Image = (Image)resources.GetObject("ButtonChooseFile.StateCommon.Back.Image");
            ButtonChooseFile.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            ButtonChooseFile.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ButtonChooseFile.StateCommon.Border.Width = -2;
            ButtonChooseFile.TabIndex = 1;
            ButtonChooseFile.Values.Text = "";
            ButtonChooseFile.Click += ButtonChooseFile_Click;
            // 
            // ButtonUpload
            // 
            ButtonUpload.Location = new Point(324, 351);
            ButtonUpload.Name = "ButtonUpload";
            ButtonUpload.Size = new Size(223, 69);
            ButtonUpload.StateCommon.Back.Color1 = Color.White;
            ButtonUpload.StateCommon.Back.Color2 = Color.White;
            ButtonUpload.StateCommon.Back.Image = (Image)resources.GetObject("ButtonUpload.StateCommon.Back.Image");
            ButtonUpload.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            ButtonUpload.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ButtonUpload.StateCommon.Border.Width = -2;
            ButtonUpload.TabIndex = 2;
            ButtonUpload.Values.Text = "";
            ButtonUpload.Click += ButtonUpload_Click;
            // 
            // kryptonButton3
            // 
            kryptonButton3.Location = new Point(431, 8);
            kryptonButton3.Name = "kryptonButton3";
            kryptonButton3.Size = new Size(97, 44);
            kryptonButton3.StateCommon.Back.Color1 = Color.Red;
            kryptonButton3.StateCommon.Back.Color2 = Color.Red;
            kryptonButton3.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton3.StateCommon.Border.Width = -2;
            kryptonButton3.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton3.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButton3.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton3.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.AntiAlias;
            kryptonButton3.TabIndex = 3;
            kryptonButton3.Values.Text = "X";
            kryptonButton3.Click += kryptonButton3_Click;
            // 
            // NotePictureBox
            // 
            NotePictureBox.Location = new Point(89, 71);
            NotePictureBox.MaximumSize = new Size(417, 243);
            NotePictureBox.Name = "NotePictureBox";
            NotePictureBox.Size = new Size(417, 243);
            NotePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            NotePictureBox.TabIndex = 4;
            NotePictureBox.TabStop = false;
            NotePictureBox.Visible = false;
            // 
            // HomepageAddImage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(NotePictureBox);
            Controls.Add(kryptonButton3);
            Controls.Add(ButtonUpload);
            Controls.Add(ButtonChooseFile);
            Controls.Add(kryptonPictureBox1);
            Name = "HomepageAddImage";
            Size = new Size(600, 500);
            Load += HomepageAddImage_Load;
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)NotePictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private Krypton.Toolkit.KryptonButton ButtonChooseFile;
        private Krypton.Toolkit.KryptonButton ButtonUpload;
        private Krypton.Toolkit.KryptonButton kryptonButton3;
        private Krypton.Toolkit.KryptonPictureBox NotePictureBox;
    }
}
