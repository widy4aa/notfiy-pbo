namespace notfiy.Views.Todolist
{
    partial class TodoItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TodoItem));
            kryptonCheckedListBox1 = new Krypton.Toolkit.KryptonCheckedListBox();
            kryptonCheckBox1 = new Krypton.Toolkit.KryptonCheckBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonCheckBox2 = new Krypton.Toolkit.KryptonCheckBox();
            kryptonCheckBox3 = new Krypton.Toolkit.KryptonCheckBox();
            kryptonCheckBox4 = new Krypton.Toolkit.KryptonCheckBox();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // kryptonCheckedListBox1
            // 
            kryptonCheckedListBox1.Location = new Point(13, 43);
            kryptonCheckedListBox1.Name = "kryptonCheckedListBox1";
            kryptonCheckedListBox1.Size = new Size(272, 205);
            kryptonCheckedListBox1.StateCommon.Border.Color1 = Color.Black;
            kryptonCheckedListBox1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCheckedListBox1.StateCommon.Border.Rounding = 20F;
            kryptonCheckedListBox1.StateCommon.Border.Width = 4;
            kryptonCheckedListBox1.StateNormal.Border.Color1 = Color.Black;
            kryptonCheckedListBox1.StateNormal.Border.Color2 = Color.Black;
            kryptonCheckedListBox1.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCheckedListBox1.StateNormal.Border.Width = 3;
            kryptonCheckedListBox1.TabIndex = 2;
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
            kryptonCheckBox1.Location = new Point(3, 29);
            kryptonCheckBox1.Name = "kryptonCheckBox1";
            kryptonCheckBox1.Size = new Size(163, 30);
            kryptonCheckBox1.TabIndex = 7;
            kryptonCheckBox1.Values.Text = "kryptonCheckBox1";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(kryptonLabel1);
            flowLayoutPanel1.Controls.Add(kryptonCheckBox1);
            flowLayoutPanel1.Controls.Add(kryptonCheckBox2);
            flowLayoutPanel1.Controls.Add(kryptonCheckBox3);
            flowLayoutPanel1.Controls.Add(kryptonCheckBox4);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(28, 57);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(246, 176);
            flowLayoutPanel1.TabIndex = 8;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint_1;
            flowLayoutPanel1.Click += flowLayoutPanel1_Click;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(3, 3);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(95, 20);
            kryptonLabel1.TabIndex = 11;
            kryptonLabel1.Values.Text = "Judul Pekerjaan";
            // 
            // kryptonCheckBox2
            // 
            kryptonCheckBox2.AutoSize = false;
            kryptonCheckBox2.Images.CheckedDisabled = (Image)resources.GetObject("kryptonCheckBox2.Images.CheckedDisabled");
            kryptonCheckBox2.Images.CheckedNormal = (Image)resources.GetObject("kryptonCheckBox2.Images.CheckedNormal");
            kryptonCheckBox2.Images.CheckedPressed = (Image)resources.GetObject("kryptonCheckBox2.Images.CheckedPressed");
            kryptonCheckBox2.Images.CheckedTracking = (Image)resources.GetObject("kryptonCheckBox2.Images.CheckedTracking");
            kryptonCheckBox2.Images.UncheckedDisabled = (Image)resources.GetObject("kryptonCheckBox2.Images.UncheckedDisabled");
            kryptonCheckBox2.Images.UncheckedNormal = (Image)resources.GetObject("kryptonCheckBox2.Images.UncheckedNormal");
            kryptonCheckBox2.Images.UncheckedPressed = (Image)resources.GetObject("kryptonCheckBox2.Images.UncheckedPressed");
            kryptonCheckBox2.Images.UncheckedTracking = (Image)resources.GetObject("kryptonCheckBox2.Images.UncheckedTracking");
            kryptonCheckBox2.Location = new Point(3, 65);
            kryptonCheckBox2.Name = "kryptonCheckBox2";
            kryptonCheckBox2.Size = new Size(163, 30);
            kryptonCheckBox2.TabIndex = 8;
            kryptonCheckBox2.Values.Text = "kryptonCheckBox2";
            // 
            // kryptonCheckBox3
            // 
            kryptonCheckBox3.AutoSize = false;
            kryptonCheckBox3.Images.CheckedDisabled = (Image)resources.GetObject("kryptonCheckBox3.Images.CheckedDisabled");
            kryptonCheckBox3.Images.CheckedNormal = (Image)resources.GetObject("kryptonCheckBox3.Images.CheckedNormal");
            kryptonCheckBox3.Images.CheckedPressed = (Image)resources.GetObject("kryptonCheckBox3.Images.CheckedPressed");
            kryptonCheckBox3.Images.CheckedTracking = (Image)resources.GetObject("kryptonCheckBox3.Images.CheckedTracking");
            kryptonCheckBox3.Images.UncheckedDisabled = (Image)resources.GetObject("kryptonCheckBox3.Images.UncheckedDisabled");
            kryptonCheckBox3.Images.UncheckedNormal = (Image)resources.GetObject("kryptonCheckBox3.Images.UncheckedNormal");
            kryptonCheckBox3.Images.UncheckedPressed = (Image)resources.GetObject("kryptonCheckBox3.Images.UncheckedPressed");
            kryptonCheckBox3.Images.UncheckedTracking = (Image)resources.GetObject("kryptonCheckBox3.Images.UncheckedTracking");
            kryptonCheckBox3.Location = new Point(3, 101);
            kryptonCheckBox3.Name = "kryptonCheckBox3";
            kryptonCheckBox3.Size = new Size(163, 30);
            kryptonCheckBox3.TabIndex = 9;
            kryptonCheckBox3.Values.Text = "kryptonCheckBox3";
            // 
            // kryptonCheckBox4
            // 
            kryptonCheckBox4.AutoSize = false;
            kryptonCheckBox4.Images.CheckedDisabled = (Image)resources.GetObject("kryptonCheckBox4.Images.CheckedDisabled");
            kryptonCheckBox4.Images.CheckedNormal = (Image)resources.GetObject("kryptonCheckBox4.Images.CheckedNormal");
            kryptonCheckBox4.Images.CheckedPressed = (Image)resources.GetObject("kryptonCheckBox4.Images.CheckedPressed");
            kryptonCheckBox4.Images.CheckedTracking = (Image)resources.GetObject("kryptonCheckBox4.Images.CheckedTracking");
            kryptonCheckBox4.Images.UncheckedDisabled = (Image)resources.GetObject("kryptonCheckBox4.Images.UncheckedDisabled");
            kryptonCheckBox4.Images.UncheckedNormal = (Image)resources.GetObject("kryptonCheckBox4.Images.UncheckedNormal");
            kryptonCheckBox4.Images.UncheckedPressed = (Image)resources.GetObject("kryptonCheckBox4.Images.UncheckedPressed");
            kryptonCheckBox4.Images.UncheckedTracking = (Image)resources.GetObject("kryptonCheckBox4.Images.UncheckedTracking");
            kryptonCheckBox4.Location = new Point(3, 137);
            kryptonCheckBox4.Name = "kryptonCheckBox4";
            kryptonCheckBox4.Size = new Size(163, 30);
            kryptonCheckBox4.TabIndex = 10;
            kryptonCheckBox4.Values.Text = "kryptonCheckBox4";
            // 
            // kryptonButton1
            // 
            kryptonButton1.Location = new Point(246, 12);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(22, 25);
            kryptonButton1.StateCommon.Back.Color1 = Color.White;
            kryptonButton1.StateCommon.Back.Color2 = Color.White;
            kryptonButton1.StateCommon.Back.Image = (Image)resources.GetObject("kryptonButton1.StateCommon.Back.Image");
            kryptonButton1.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            kryptonButton1.StateCommon.Border.Color1 = Color.White;
            kryptonButton1.StateCommon.Border.Color2 = Color.White;
            kryptonButton1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.TabIndex = 9;
            kryptonButton1.Values.Text = "";
            // 
            // kryptonButton2
            // 
            kryptonButton2.Location = new Point(212, 12);
            kryptonButton2.Name = "kryptonButton2";
            kryptonButton2.Size = new Size(23, 24);
            kryptonButton2.StateCommon.Back.Color1 = Color.White;
            kryptonButton2.StateCommon.Back.Color2 = Color.White;
            kryptonButton2.StateCommon.Back.Image = (Image)resources.GetObject("kryptonButton2.StateCommon.Back.Image");
            kryptonButton2.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            kryptonButton2.StateCommon.Border.Color1 = Color.White;
            kryptonButton2.StateCommon.Border.Color2 = Color.White;
            kryptonButton2.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton2.TabIndex = 10;
            kryptonButton2.Values.Text = "";
            // 
            // TodoItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(kryptonButton2);
            Controls.Add(kryptonButton1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(kryptonCheckedListBox1);
            Cursor = Cursors.Hand;
            Name = "TodoItem";
            Size = new Size(300, 264);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

       

        #endregion
        private Krypton.Toolkit.KryptonCheckedListBox kryptonCheckedListBox1;
        private Krypton.Toolkit.KryptonCheckBox kryptonCheckBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Krypton.Toolkit.KryptonCheckBox kryptonCheckBox2;
        private Krypton.Toolkit.KryptonCheckBox kryptonCheckBox3;
        private Krypton.Toolkit.KryptonCheckBox kryptonCheckBox4;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        public Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}
