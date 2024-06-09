
namespace notfiy.Views.Other
{
    partial class PopUpShare
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
            SearchTextbox = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonListBox1 = new Krypton.Toolkit.KryptonListBox();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            SuspendLayout();
            // 
            // SearchTextbox
            // 
            SearchTextbox.Location = new Point(7, 33);
            SearchTextbox.Name = "SearchTextbox";
            SearchTextbox.Size = new Size(186, 36);
            SearchTextbox.StateActive.Back.Color1 = Color.White;
            SearchTextbox.StateActive.Border.Color1 = Color.FromArgb(51, 15, 126);
            SearchTextbox.StateActive.Border.Color2 = Color.FromArgb(51, 15, 126);
            SearchTextbox.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            SearchTextbox.StateActive.Border.Rounding = 20F;
            SearchTextbox.StateActive.Border.Width = 2;
            SearchTextbox.StateActive.Content.Color1 = Color.FromArgb(51, 15, 126);
            SearchTextbox.StateActive.Content.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchTextbox.StateNormal.Back.Color1 = Color.Transparent;
            SearchTextbox.TabIndex = 12;
            SearchTextbox.Text = "Search";
            SearchTextbox.TextChanged += SearchTextbox_TextChanged;
            SearchTextbox.Enter += SearchTextbox_Enter;
            SearchTextbox.KeyDown += SearchTextbox_KeyDown;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(7, 8);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(68, 19);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 13;
            kryptonLabel1.Values.Text = "Share To";
            // 
            // kryptonListBox1
            // 
            kryptonListBox1.Location = new Point(3, 0);
            kryptonListBox1.Name = "kryptonListBox1";
            kryptonListBox1.Size = new Size(194, 218);
            kryptonListBox1.StateCommon.Border.Color1 = Color.FromArgb(51, 15, 126);
            kryptonListBox1.StateCommon.Border.Color2 = Color.FromArgb(51, 15, 126);
            kryptonListBox1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonListBox1.StateCommon.Border.Rounding = 20F;
            kryptonListBox1.TabIndex = 14;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Location = new Point(164, 7);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(20, 20);
            kryptonButton1.StateCommon.Back.Color1 = Color.Red;
            kryptonButton1.StateCommon.Back.Color2 = Color.Red;
            kryptonButton1.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton1.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButton1.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton1.TabIndex = 15;
            kryptonButton1.Values.Text = "X";
            // 
            // PopUpShare
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(kryptonButton1);
            Controls.Add(kryptonLabel1);
            Controls.Add(SearchTextbox);
            Controls.Add(kryptonListBox1);
            Name = "PopUpShare";
            Size = new Size(200, 232);
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Krypton.Toolkit.KryptonTextBox SearchTextbox;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonListBox kryptonListBox1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}
