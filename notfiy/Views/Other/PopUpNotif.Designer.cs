namespace notfiy.Views.Other
{
    partial class PopUpNotif
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopUpNotif));
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            kryptonPictureBox2 = new Krypton.Toolkit.KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox2).BeginInit();
            SuspendLayout();
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(0, 14);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(284, 48);
            kryptonLabel1.StateNormal.ShortText.Color1 = Color.Black;
            kryptonLabel1.StateNormal.ShortText.Color2 = Color.Black;
            kryptonLabel1.StateNormal.ShortText.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 0;
            kryptonLabel1.Values.Text = "User Rafky telah membagikan\r\nvitamin buat ibu hamil";
            // 
            // kryptonPictureBox1
            // 
            kryptonPictureBox1.Image = (Image)resources.GetObject("kryptonPictureBox1.Image");
            kryptonPictureBox1.Location = new Point(306, 15);
            kryptonPictureBox1.Name = "kryptonPictureBox1";
            kryptonPictureBox1.Size = new Size(48, 48);
            kryptonPictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            kryptonPictureBox1.TabIndex = 1;
            kryptonPictureBox1.TabStop = false;
            // 
            // kryptonPictureBox2
            // 
            kryptonPictureBox2.Image = (Image)resources.GetObject("kryptonPictureBox2.Image");
            kryptonPictureBox2.Location = new Point(360, 15);
            kryptonPictureBox2.Name = "kryptonPictureBox2";
            kryptonPictureBox2.Size = new Size(57, 47);
            kryptonPictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            kryptonPictureBox2.TabIndex = 2;
            kryptonPictureBox2.TabStop = false;
            // 
            // PopUpNotif
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(kryptonPictureBox2);
            Controls.Add(kryptonPictureBox1);
            Controls.Add(kryptonLabel1);
            Name = "PopUpNotif";
            Size = new Size(431, 89);
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox2;
    }
}
