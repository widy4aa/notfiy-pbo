namespace notfiy.Views.Homepage
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
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            kryptonListBox1 = new Krypton.Toolkit.KryptonListBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonRichTextBox1 = new Krypton.Toolkit.KryptonRichTextBox();
            kryptonButton3 = new Krypton.Toolkit.KryptonButton();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // kryptonButton2
            // 
            kryptonButton2.Location = new Point(208, 3);
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
            // kryptonButton1
            // 
            kryptonButton1.Location = new Point(246, 3);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(28, 34);
            kryptonButton1.StateCommon.Back.Color1 = Color.White;
            kryptonButton1.StateCommon.Back.Color2 = Color.White;
            kryptonButton1.StateCommon.Back.Image = (Image)resources.GetObject("kryptonButton1.StateCommon.Back.Image");
            kryptonButton1.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            kryptonButton1.StateCommon.Border.Color1 = Color.White;
            kryptonButton1.StateCommon.Border.Color2 = Color.White;
            kryptonButton1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.TabIndex = 12;
            kryptonButton1.Values.Text = "";
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
            flowLayoutPanel1.Controls.Add(kryptonLabel1);
            flowLayoutPanel1.Controls.Add(kryptonRichTextBox1);
            flowLayoutPanel1.Location = new Point(28, 57);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(246, 176);
            flowLayoutPanel1.TabIndex = 14;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(3, 3);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(153, 26);
            kryptonLabel1.StateNormal.ShortText.Color1 = Color.Black;
            kryptonLabel1.StateNormal.ShortText.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 12;
            kryptonLabel1.Values.Text = "Judul Pekerjaan";
            // 
            // kryptonRichTextBox1
            // 
            kryptonRichTextBox1.DetectUrls = false;
            kryptonRichTextBox1.ImeMode = ImeMode.Disable;
            kryptonRichTextBox1.Location = new Point(3, 35);
            kryptonRichTextBox1.Name = "kryptonRichTextBox1";
            kryptonRichTextBox1.ReadOnly = true;
            kryptonRichTextBox1.ScrollBars = RichTextBoxScrollBars.None;
            kryptonRichTextBox1.Size = new Size(243, 141);
            kryptonRichTextBox1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonRichTextBox1.StateCommon.Border.Width = -2;
            kryptonRichTextBox1.TabIndex = 13;
            kryptonRichTextBox1.Text = resources.GetString("kryptonRichTextBox1.Text");
            kryptonRichTextBox1.TextChanged += kryptonRichTextBox1_TextChanged_1;
            // 
            // kryptonButton3
            // 
            kryptonButton3.Location = new Point(208, 4);
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
            Controls.Add(kryptonButton3);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(kryptonListBox1);
            Controls.Add(kryptonButton1);
            Controls.Add(kryptonButton2);
            Name = "HomepageItem";
            Size = new Size(298, 266);
            Load += HomepageItem_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonListBox kryptonListBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        public Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonRichTextBox kryptonRichTextBox1;
        private Krypton.Toolkit.KryptonButton kryptonButton3;
    }
}
