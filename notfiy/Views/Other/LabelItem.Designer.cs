namespace notfiy.Views.Other
{
    partial class LabelItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LabelItem));
            kryptonButton7 = new Krypton.Toolkit.KryptonButton();
            SuspendLayout();
            // 
            // kryptonButton7
            // 
            kryptonButton7.Location = new Point(-1, -1);
            kryptonButton7.Name = "kryptonButton7";
            kryptonButton7.Size = new Size(228, 58);
            kryptonButton7.StateCommon.Back.Color1 = Color.FromArgb(46, 26, 96);
            kryptonButton7.StateCommon.Back.Color2 = Color.FromArgb(46, 26, 96);
            kryptonButton7.StateCommon.Back.Image = (Image)resources.GetObject("kryptonButton7.StateCommon.Back.Image");
            kryptonButton7.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            kryptonButton7.StateCommon.Border.Color1 = Color.FromArgb(46, 26, 96);
            kryptonButton7.StateCommon.Border.Color2 = Color.FromArgb(46, 26, 96);
            kryptonButton7.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton7.StateCommon.Border.Width = 2;
            kryptonButton7.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton7.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButton7.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonButton7.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far;
            kryptonButton7.TabIndex = 1;
            kryptonButton7.Values.Text = "kryptonButton7";
            // 
            // LabelItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 26, 96);
            Controls.Add(kryptonButton7);
            Name = "LabelItem";
            Size = new Size(227, 58);
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonButton kryptonButton7;
    }
}
