namespace notfiy.Views.Archive
{
    partial class ArchiveItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArchiveItem));
            flowLayoutPanel1 = new FlowLayoutPanel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonRichTextBox1 = new Krypton.Toolkit.KryptonRichTextBox();
            kryptonListBox1 = new Krypton.Toolkit.KryptonListBox();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(kryptonLabel1);
            flowLayoutPanel1.Controls.Add(kryptonRichTextBox1);
            flowLayoutPanel1.Location = new Point(25, 68);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(246, 176);
            flowLayoutPanel1.TabIndex = 18;
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
            // 
            // kryptonListBox1
            // 
            kryptonListBox1.Location = new Point(10, 54);
            kryptonListBox1.Name = "kryptonListBox1";
            kryptonListBox1.Size = new Size(272, 205);
            kryptonListBox1.StateCommon.Border.Color1 = Color.Black;
            kryptonListBox1.StateCommon.Border.Color2 = Color.Black;
            kryptonListBox1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonListBox1.StateCommon.Border.Rounding = 20F;
            kryptonListBox1.StateCommon.Border.Width = 4;
            kryptonListBox1.TabIndex = 17;
            kryptonListBox1.SelectedIndexChanged += kryptonListBox1_SelectedIndexChanged;
            // 
            // ArchiveItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(kryptonListBox1);
            Name = "ArchiveItem";
            Size = new Size(298, 266);
            Load += ArchiveItem_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        public Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonRichTextBox kryptonRichTextBox1;
        private Krypton.Toolkit.KryptonListBox kryptonListBox1;
    }
}
