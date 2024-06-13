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
            LabelChooseButton = new Krypton.Toolkit.KryptonButton();
            ButtonLabelEdit = new Krypton.Toolkit.KryptonButton();
            ButtonLabelDelete = new Krypton.Toolkit.KryptonButton();
            LabelTextBox = new Krypton.Toolkit.KryptonTextBox();
            SuspendLayout();
            // 
            // LabelChooseButton
            // 
            LabelChooseButton.Location = new Point(-2, -1);
            LabelChooseButton.Name = "LabelChooseButton";
            LabelChooseButton.Size = new Size(197, 54);
            LabelChooseButton.StateCommon.Back.Color1 = Color.FromArgb(46, 26, 96);
            LabelChooseButton.StateCommon.Back.Color2 = Color.FromArgb(46, 26, 96);
            LabelChooseButton.StateCommon.Back.Image = (Image)resources.GetObject("LabelChooseButton.StateCommon.Back.Image");
            LabelChooseButton.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            LabelChooseButton.StateCommon.Border.Color1 = Color.FromArgb(46, 26, 96);
            LabelChooseButton.StateCommon.Border.Color2 = Color.FromArgb(46, 26, 96);
            LabelChooseButton.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            LabelChooseButton.StateCommon.Border.Width = 2;
            LabelChooseButton.StateCommon.Content.ShortText.Color1 = Color.White;
            LabelChooseButton.StateCommon.Content.ShortText.Color2 = Color.White;
            LabelChooseButton.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelChooseButton.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far;
            LabelChooseButton.TabIndex = 1;
            LabelChooseButton.Values.Text = "Label";
            LabelChooseButton.Click += kryptonButton7_Click;
            // 
            // ButtonLabelEdit
            // 
            ButtonLabelEdit.Location = new Point(201, -14);
            ButtonLabelEdit.Name = "ButtonLabelEdit";
            ButtonLabelEdit.Size = new Size(48, 80);
            ButtonLabelEdit.StateCommon.Back.Color1 = Color.FromArgb(46, 26, 96);
            ButtonLabelEdit.StateCommon.Back.Color2 = Color.FromArgb(46, 26, 96);
            ButtonLabelEdit.StateCommon.Back.Image = (Image)resources.GetObject("ButtonLabelEdit.StateCommon.Back.Image");
            ButtonLabelEdit.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            ButtonLabelEdit.StateCommon.Border.Color1 = Color.FromArgb(46, 26, 96);
            ButtonLabelEdit.StateCommon.Border.Color2 = Color.FromArgb(46, 26, 96);
            ButtonLabelEdit.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ButtonLabelEdit.StateCommon.Border.Width = 2;
            ButtonLabelEdit.StateCommon.Content.ShortText.Color1 = Color.White;
            ButtonLabelEdit.StateCommon.Content.ShortText.Color2 = Color.White;
            ButtonLabelEdit.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonLabelEdit.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far;
            ButtonLabelEdit.TabIndex = 2;
            ButtonLabelEdit.Values.Text = " ";
            ButtonLabelEdit.Click += ButtonLabelEdit_Click;
            // 
            // ButtonLabelDelete
            // 
            ButtonLabelDelete.Location = new Point(258, -9);
            ButtonLabelDelete.Name = "ButtonLabelDelete";
            ButtonLabelDelete.Size = new Size(38, 67);
            ButtonLabelDelete.StateCommon.Back.Color1 = Color.FromArgb(46, 26, 96);
            ButtonLabelDelete.StateCommon.Back.Color2 = Color.FromArgb(46, 26, 96);
            ButtonLabelDelete.StateCommon.Back.Image = (Image)resources.GetObject("ButtonLabelDelete.StateCommon.Back.Image");
            ButtonLabelDelete.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            ButtonLabelDelete.StateCommon.Border.Color1 = Color.FromArgb(46, 26, 96);
            ButtonLabelDelete.StateCommon.Border.Color2 = Color.FromArgb(46, 26, 96);
            ButtonLabelDelete.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ButtonLabelDelete.StateCommon.Border.Width = 2;
            ButtonLabelDelete.StateCommon.Content.ShortText.Color1 = Color.White;
            ButtonLabelDelete.StateCommon.Content.ShortText.Color2 = Color.White;
            ButtonLabelDelete.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonLabelDelete.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far;
            ButtonLabelDelete.TabIndex = 3;
            ButtonLabelDelete.Values.Text = "";
            ButtonLabelDelete.Click += ButtonLabelDelete_Click;
            // 
            // LabelTextBox
            // 
            LabelTextBox.AlwaysActive = false;
            LabelTextBox.Cursor = Cursors.IBeam;
            LabelTextBox.Location = new Point(-13, -1);
            LabelTextBox.Name = "LabelTextBox";
            LabelTextBox.Size = new Size(375, 48);
            LabelTextBox.StateActive.Back.Color1 = Color.FromArgb(46, 26, 96);
            LabelTextBox.StateActive.Border.Color1 = Color.Transparent;
            LabelTextBox.StateActive.Border.Color2 = Color.Transparent;
            LabelTextBox.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            LabelTextBox.StateActive.Border.Rounding = 20F;
            LabelTextBox.StateActive.Border.Width = 1;
            LabelTextBox.StateActive.Content.Color1 = Color.White;
            LabelTextBox.StateActive.Content.Font = new Font("Microsoft Sans Serif", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelTextBox.StateCommon.Back.Color1 = Color.FromArgb(46, 26, 96);
            LabelTextBox.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            LabelTextBox.StateCommon.Border.Width = 1;
            LabelTextBox.StateCommon.Content.Color1 = Color.White;
            LabelTextBox.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelTextBox.StateNormal.Back.Color1 = Color.FromArgb(61, 44, 94);
            LabelTextBox.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            LabelTextBox.StateNormal.Border.Rounding = 20F;
            LabelTextBox.StateNormal.Border.Width = 1;
            LabelTextBox.TabIndex = 18;
            LabelTextBox.Text = "Note";
            LabelTextBox.TextAlign = HorizontalAlignment.Center;
            LabelTextBox.TextChanged += kryptonTextBox1_TextChanged;
            LabelTextBox.KeyDown += KeyDownPressEnterEdit_Click;
            // 
            // LabelItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 26, 96);
            Controls.Add(ButtonLabelDelete);
            Controls.Add(ButtonLabelEdit);
            Controls.Add(LabelChooseButton);
            Controls.Add(LabelTextBox);
            Name = "LabelItem";
            Size = new Size(325, 49);
            ResumeLayout(false);
            PerformLayout();
        }

        private void KryptonTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Krypton.Toolkit.KryptonButton LabelChooseButton;
        private Krypton.Toolkit.KryptonButton ButtonLabelEdit;
        private Krypton.Toolkit.KryptonButton ButtonLabelDelete;
        private Krypton.Toolkit.KryptonTextBox LabelTextBox;
    }
}
