namespace notfiy.Views.Todolist
{
    partial class tesPopUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tesPopUp));
            kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            label1 = new Label();
            kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            kryptonCheckedListBox1 = new Krypton.Toolkit.KryptonCheckedListBox();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // kryptonButton2
            // 
            kryptonButton2.Location = new Point(557, 208);
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
            kryptonButton2.TabIndex = 10;
            kryptonButton2.Values.Text = "";
            // 
            // kryptonButton1
            // 
            kryptonButton1.Location = new Point(379, 208);
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
            kryptonButton1.TabIndex = 9;
            kryptonButton1.Values.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(366, 137);
            label1.Name = "label1";
            label1.Size = new Size(385, 32);
            label1.TabIndex = 8;
            label1.Text = "Yakin Ingin Menghapus Todolist ? ";
            // 
            // kryptonPictureBox1
            // 
            kryptonPictureBox1.BackgroundImageLayout = ImageLayout.Center;
            kryptonPictureBox1.Image = (Image)resources.GetObject("kryptonPictureBox1.Image");
            kryptonPictureBox1.Location = new Point(217, 125);
            kryptonPictureBox1.Name = "kryptonPictureBox1";
            kryptonPictureBox1.Size = new Size(132, 139);
            kryptonPictureBox1.TabIndex = 7;
            kryptonPictureBox1.TabStop = false;
            // 
            // kryptonCheckedListBox1
            // 
            kryptonCheckedListBox1.Location = new Point(206, 94);
            kryptonCheckedListBox1.Name = "kryptonCheckedListBox1";
            kryptonCheckedListBox1.Size = new Size(559, 203);
            kryptonCheckedListBox1.StateCommon.Border.Color1 = Color.FromArgb(46, 26, 94);
            kryptonCheckedListBox1.StateCommon.Border.Color2 = Color.FromArgb(46, 26, 94);
            kryptonCheckedListBox1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCheckedListBox1.StateCommon.Border.Rounding = 20F;
            kryptonCheckedListBox1.StateCommon.Border.Width = 5;
            kryptonCheckedListBox1.TabIndex = 6;
            // 
            // tesPopUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(kryptonButton2);
            Controls.Add(kryptonButton1);
            Controls.Add(label1);
            Controls.Add(kryptonPictureBox1);
            Controls.Add(kryptonCheckedListBox1);
            Name = "tesPopUp";
            Size = new Size(970, 390);
            Load += tesPopUp_Load;
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Label label1;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private Krypton.Toolkit.KryptonCheckedListBox kryptonCheckedListBox1;
    }
}
