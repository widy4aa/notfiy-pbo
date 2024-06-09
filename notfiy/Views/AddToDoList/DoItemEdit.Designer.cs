namespace notfiy.Views.AddToDoList
{
    partial class DoItemEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoItemEdit));
            kryptonCheckBox1 = new Krypton.Toolkit.KryptonCheckBox();
            kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            SuspendLayout();
            // 
            // kryptonCheckBox1
            // 
            kryptonCheckBox1.AutoSize = false;
            kryptonCheckBox1.Images.CheckedDisabled = (Image)resources.GetObject("kryptonCheckBox1.Images.CheckedDisabled");
            kryptonCheckBox1.Images.CheckedNormal = (Image)resources.GetObject("kryptonCheckBox1.Images.CheckedNormal");
            kryptonCheckBox1.Images.CheckedPressed = (Image)resources.GetObject("kryptonCheckBox1.Images.CheckedPressed");
            kryptonCheckBox1.Images.CheckedTracking = (Image)resources.GetObject("kryptonCheckBox1.Images.CheckedTracking");
            kryptonCheckBox1.Images.UncheckedDisabled = (Image)resources.GetObject("kryptonCheckBox1.Images.UncheckedDisabled");
            kryptonCheckBox1.Images.UncheckedNormal = (Image)resources.GetObject("kryptonCheckBox1.Images.UncheckedNormal");
            kryptonCheckBox1.Images.UncheckedPressed = (Image)resources.GetObject("kryptonCheckBox1.Images.UncheckedPressed");
            kryptonCheckBox1.Images.UncheckedTracking = (Image)resources.GetObject("kryptonCheckBox1.Images.UncheckedTracking");
            kryptonCheckBox1.Location = new Point(3, 4);
            kryptonCheckBox1.Name = "kryptonCheckBox1";
            kryptonCheckBox1.Size = new Size(23, 30);
            kryptonCheckBox1.StateNormal.ShortText.Color1 = Color.Black;
            kryptonCheckBox1.TabIndex = 8;
            kryptonCheckBox1.Values.Text = "";
            kryptonCheckBox1.CheckedChanged += kryptonCheckBox1_CheckedChanged;
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.Location = new Point(23, 3);
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.Size = new Size(150, 31);
            kryptonTextBox1.StateActive.Back.Color1 = Color.White;
            kryptonTextBox1.StateActive.Border.Color1 = Color.White;
            kryptonTextBox1.StateActive.Border.Color2 = Color.White;
            kryptonTextBox1.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonTextBox1.StateActive.Content.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBox1.StateNormal.Back.Color1 = Color.White;
            kryptonTextBox1.StateNormal.Border.Color1 = Color.White;
            kryptonTextBox1.StateNormal.Border.Color2 = Color.White;
            kryptonTextBox1.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonTextBox1.TabIndex = 9;
            kryptonTextBox1.Text = "kryptonTextBox1";
            // 
            // kryptonButton1
            // 
            kryptonButton1.Location = new Point(489, 2);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(56, 33);
            kryptonButton1.StateCommon.Back.Color1 = Color.White;
            kryptonButton1.StateCommon.Back.Color2 = Color.White;
            kryptonButton1.StateCommon.Back.Image = (Image)resources.GetObject("kryptonButton1.StateCommon.Back.Image");
            kryptonButton1.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            kryptonButton1.StateCommon.Border.Color1 = Color.White;
            kryptonButton1.StateCommon.Border.Color2 = Color.White;
            kryptonButton1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.TabIndex = 10;
            kryptonButton1.Values.Text = "";
            // 
            // DoItemEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(kryptonButton1);
            Controls.Add(kryptonTextBox1);
            Controls.Add(kryptonCheckBox1);
            Name = "DoItemEdit";
            Size = new Size(548, 38);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonCheckBox kryptonCheckBox1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}
