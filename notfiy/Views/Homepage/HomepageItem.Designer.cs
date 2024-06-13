﻿namespace notfiy.Views.Homepage
{
    partial class HomepageItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomepageItem));
            kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            kryptonListBox1 = new Krypton.Toolkit.KryptonListBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            NoteTextBox = new Krypton.Toolkit.KryptonWrapLabel();
            NoteName = new Krypton.Toolkit.KryptonLabel();
            kryptonButton3 = new Krypton.Toolkit.KryptonButton();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // kryptonButton2
            // 
            kryptonButton2.Location = new Point(242, 4);
            kryptonButton2.Name = "kryptonButton2";
            kryptonButton2.Size = new Size(32, 33);
            kryptonButton2.StateCommon.Back.Color1 = Color.White;
            kryptonButton2.StateCommon.Back.Color2 = Color.White;
            kryptonButton2.StateCommon.Back.Image = (Image)resources.GetObject("kryptonButton2.StateCommon.Back.Image");
            kryptonButton2.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            kryptonButton2.StateCommon.Border.Color1 = Color.White;
            kryptonButton2.StateCommon.Border.Color2 = Color.White;
            kryptonButton2.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton2.TabIndex = 11;
            kryptonButton2.Values.Text = "";
            kryptonButton2.Click += kryptonButton2_Click;
            // 
            // kryptonListBox1
            // 
            kryptonListBox1.Location = new Point(13, 43);
            kryptonListBox1.Name = "kryptonListBox1";
            kryptonListBox1.Size = new Size(272, 205);
            kryptonListBox1.StateCommon.Border.Color1 = Color.Black;
            kryptonListBox1.StateCommon.Border.Color2 = Color.Black;
            kryptonListBox1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonListBox1.StateCommon.Border.Rounding = 20F;
            kryptonListBox1.StateCommon.Border.Width = 4;
            kryptonListBox1.TabIndex = 13;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(NoteTextBox);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(28, 86);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(246, 147);
            flowLayoutPanel1.TabIndex = 14;
            flowLayoutPanel1.Click += ClickItem;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // NoteTextBox
            // 
            NoteTextBox.Font = new Font("Segoe UI", 9F);
            NoteTextBox.ForeColor = Color.FromArgb(30, 57, 91);
            NoteTextBox.LabelStyle = Krypton.Toolkit.LabelStyle.AlternateControl;
            NoteTextBox.Location = new Point(3, 0);
            NoteTextBox.MaximumSize = new Size(210, 0);
            NoteTextBox.Name = "NoteTextBox";
            NoteTextBox.Size = new Size(110, 15);
            NoteTextBox.Text = "kryptonWrapLabel1";
            NoteTextBox.Click += NoteTextBox_Click;
            // 
            // NoteName
            // 
            NoteName.Location = new Point(28, 54);
            NoteName.Name = "NoteName";
            NoteName.Size = new Size(153, 26);
            NoteName.StateNormal.ShortText.Color1 = Color.Black;
            NoteName.StateNormal.ShortText.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NoteName.TabIndex = 12;
            NoteName.Values.Text = "Judul Pekerjaan";
            NoteName.Click += ClickItem;
            // 
            // kryptonButton3
            // 
            kryptonButton3.Location = new Point(242, 4);
            kryptonButton3.Name = "kryptonButton3";
            kryptonButton3.Size = new Size(32, 33);
            kryptonButton3.StateCommon.Back.Color1 = Color.White;
            kryptonButton3.StateCommon.Back.Color2 = Color.White;
            kryptonButton3.StateCommon.Back.Image = (Image)resources.GetObject("kryptonButton3.StateCommon.Back.Image");
            kryptonButton3.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            kryptonButton3.StateCommon.Border.Color1 = Color.White;
            kryptonButton3.StateCommon.Border.Color2 = Color.White;
            kryptonButton3.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton3.TabIndex = 15;
            kryptonButton3.Values.Text = "";
            kryptonButton3.Click += kryptonButton3_Click;
            // 
            // HomepageItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(NoteName);
            Controls.Add(kryptonButton3);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(kryptonListBox1);
            Controls.Add(kryptonButton2);
            Name = "HomepageItem";
            Size = new Size(298, 266);
            Load += HomepageItem_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonListBox kryptonListBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        public Krypton.Toolkit.KryptonLabel NoteName;
        private Krypton.Toolkit.KryptonButton kryptonButton3;
        private Krypton.Toolkit.KryptonWrapLabel NoteTextBox;
    }
}
