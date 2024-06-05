using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notfiy.Views.Other
{
    public partial class SIdeBar : UserControl
    {
        public SIdeBar()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(SIdeBar));
            kryptonCheckedListBox1 = new Krypton.Toolkit.KryptonCheckedListBox();
            kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            label1 = new Label();
            ((ISupportInitialize)kryptonPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // kryptonCheckedListBox1
            // 
            kryptonCheckedListBox1.Location = new Point(1015, 0);
            kryptonCheckedListBox1.Name = "kryptonCheckedListBox1";
            kryptonCheckedListBox1.Size = new Size(483, 1024);
            kryptonCheckedListBox1.StateCommon.Back.Color1 = Color.FromArgb(46, 26, 94);
            kryptonCheckedListBox1.StateCommon.Back.Color2 = Color.FromArgb(46, 26, 94);
            kryptonCheckedListBox1.StateCommon.Border.Color1 = Color.FromArgb(37, 21, 76);
            kryptonCheckedListBox1.StateCommon.Border.Color2 = Color.FromArgb(37, 21, 76);
            kryptonCheckedListBox1.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            kryptonCheckedListBox1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCheckedListBox1.StateCommon.Border.Rounding = 20F;
            kryptonCheckedListBox1.StateCommon.Border.Width = 10;
            kryptonCheckedListBox1.TabIndex = 0;
            // 
            // kryptonPictureBox1
            // 
            kryptonPictureBox1.BackgroundImage = (Image)resources.GetObject("kryptonPictureBox1.BackgroundImage");
            kryptonPictureBox1.BackgroundImageLayout = ImageLayout.Center;
            kryptonPictureBox1.Location = new Point(1052, 43);
            kryptonPictureBox1.Name = "kryptonPictureBox1";
            kryptonPictureBox1.Size = new Size(118, 113);
            kryptonPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            kryptonPictureBox1.TabIndex = 1;
            kryptonPictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(46, 26, 94);
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1218, 82);
            label1.Name = "label1";
            label1.Size = new Size(86, 40);
            label1.TabIndex = 2;
            label1.Text = "Rafky";
            // 
            // SIdeBar
            // 
            Controls.Add(label1);
            Controls.Add(kryptonPictureBox1);
            Controls.Add(kryptonCheckedListBox1);
            Name = "SIdeBar";
            Size = new Size(1440, 1024);
            ((ISupportInitialize)kryptonPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Krypton.Toolkit.KryptonCheckedListBox kryptonCheckedListBox1;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private Label label1;
    }
}
