using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotifyViewManager = notfiy.Core.ViewManager;


namespace notfiy.Views.Todolist
{
    public partial class TodoDetail : UserControl
    {
        public TodoDetail()
        {
            InitializeComponent();
        }

        private void kryptonLabel2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            TodolistControl todolist = new TodolistControl();
            NotifyViewManager.MoveView(todolist);
        }

        private void kryptonLabel1_Click(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click_1(object sender, EventArgs e)
        {
            TodolistControl todolist = new TodolistControl();
            NotifyViewManager.MoveView(todolist);
        }

        private void TodoDetail_Load(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            PopUpDelete popupdelete = new PopUpDelete();
            this.Controls.Add(popupdelete);
            popupdelete.BringToFront();
            popupdelete.BackColor = Color.Transparent;

            //popupdelete.CornerRoundingRadius = 20F;
            //popupdelete.kryptonCheckedListBox1.CornerRoundingRadius = 20F;
            //popupdelete.kryptonCheckedListBox1.StateCommon.Border.Rounding = 20F;
            //kryptonCheckedListBox1.StateCommon.Item.Border.Rounding = 20F;
            //popupdelete.kryptonCheckedListBox1.CornerRoundingRadius = 20F;
            //popupdelete.kryptonCheckedListBox1.ItemCornerRoundingRadius = 20F;
            //popupdelete.kryptonCheckedListBox1.Location = new Point(500, 450);
            //popupdelete.kryptonCheckedListBox1.Name = "kryptonCheckedListBox1";
            //popupdelete.kryptonCheckedListBox1.Size = new Size(328, 175);
            //popupdelete.kryptonCheckedListBox1.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            //popupdelete.kryptonCheckedListBox1.StateActive.Border.Rounding = 20F;
            //popupdelete.kryptonCheckedListBox1.StateCheckedNormal.Item.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            //popupdelete.kryptonCheckedListBox1.StateCheckedNormal.Item.Border.Rounding = 20F;
            //popupdelete.kryptonCheckedListBox1.StateCommon.Back.Color1 = Color.Yellow;
            //popupdelete.kryptonCheckedListBox1.StateCommon.Border.Color1 = Color.Black;
            //popupdelete.kryptonCheckedListBox1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            //popupdelete.kryptonCheckedListBox1.StateCommon.Border.Rounding = 20F;
            //popupdelete.kryptonCheckedListBox1.StateCommon.Border.Width = 4;
            //popupdelete.kryptonCheckedListBox1.StateCommon.Item.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            //popupdelete.kryptonCheckedListBox1.StateCommon.Item.Border.Rounding = 20F;
            //popupdelete.kryptonCheckedListBox1.StateNormal.Border.Color1 = Color.Black;
            //popupdelete.kryptonCheckedListBox1.StateNormal.Border.Color2 = Color.Black;
            //popupdelete.kryptonCheckedListBox1.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            //popupdelete.kryptonCheckedListBox1.StateNormal.Border.Rounding = 20F;
            //popupdelete.kryptonCheckedListBox1.StateNormal.Border.Width = 3;
            //popupdelete.kryptonCheckedListBox1.TabIndex = 3;
            //popupdelete.kryptonCheckedListBox1.ToolTipValues.ImageTransparentColor = Color.Transparent;


            popupdelete.Show();
        }
    }
}
