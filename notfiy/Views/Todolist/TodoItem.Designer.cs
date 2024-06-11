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
            flowLayoutPanel1 = new FlowLayoutPanel();
            JudulItem = new Krypton.Toolkit.KryptonLabel();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            kryptonButton3 = new Krypton.Toolkit.KryptonButton();
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(28, 84);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(246, 149);
            flowLayoutPanel1.TabIndex = 8;
            flowLayoutPanel1.Click += flowLayoutPanel1_Click;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint_1;
            // 
            // JudulItem
            // 
            JudulItem.Location = new Point(31, 52);
            JudulItem.Name = "JudulItem";
            JudulItem.Size = new Size(134, 26);
            JudulItem.StateNormal.ShortText.Color1 = Color.Black;
            JudulItem.StateNormal.ShortText.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            JudulItem.TabIndex = 11;
            JudulItem.Values.Text = "Judul Todolist";
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
            kryptonButton1.TabIndex = 9;
            kryptonButton1.Values.Text = "";
            kryptonButton1.Click += kryptonButton1_Click;
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
            kryptonButton2.TabIndex = 10;
            kryptonButton2.Values.Text = "";
            kryptonButton2.Click += kryptonButton2_Click;
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
            kryptonButton3.TabIndex = 11;
            kryptonButton3.Values.Text = "";
            kryptonButton3.Click += kryptonButton3_Click;
            // 
            // TodoItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(JudulItem);
            Controls.Add(kryptonButton3);
            Controls.Add(kryptonButton2);
            Controls.Add(kryptonButton1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(kryptonCheckedListBox1);
            Cursor = Cursors.Hand;
            Name = "TodoItem";
            Size = new Size(298, 266);
            Load += TodoItem_Load;
            Click += TodoItem_Click;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion
        private Krypton.Toolkit.KryptonCheckedListBox kryptonCheckedListBox1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        public Krypton.Toolkit.KryptonLabel JudulItem;
        private Krypton.Toolkit.KryptonButton kryptonButton3;
        public FlowLayoutPanel flowLayoutPanel1;
    }
}
