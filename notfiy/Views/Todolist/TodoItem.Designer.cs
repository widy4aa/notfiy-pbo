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
            kryptonCheckedListBox1 = new Krypton.Toolkit.KryptonCheckedListBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            JudulItem = new Krypton.Toolkit.KryptonLabel();
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
            // TodoItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(JudulItem);
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
        public Krypton.Toolkit.KryptonLabel JudulItem;
        public FlowLayoutPanel flowLayoutPanel1;
    }
}
