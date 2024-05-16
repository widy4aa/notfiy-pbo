namespace notfiy.Views.Login
{
    partial class LoginControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginControl));
            label1 = new Label();
            panel1 = new Panel();
            textBox1 = new TextBox();
            label2 = new Label();
            kryptonMaskedTextBox1 = new Krypton.Toolkit.KryptonMaskedTextBox();
            LoginButton = new Krypton.Toolkit.KryptonButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(847, 419);
            label1.Name = "label1";
            label1.Size = new Size(235, 31);
            label1.TabIndex = 0;
            label1.Text = "Forgot Password?";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1, 276);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Minecraft", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(492, 340);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(601, 51);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(492, 284);
            label2.Name = "label2";
            label2.Size = new Size(134, 31);
            label2.TabIndex = 5;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // kryptonMaskedTextBox1
            // 
            kryptonMaskedTextBox1.Location = new Point(344, 104);
            kryptonMaskedTextBox1.Name = "kryptonMaskedTextBox1";
            kryptonMaskedTextBox1.PasswordChar = 'K';
            kryptonMaskedTextBox1.Size = new Size(556, 23);
            kryptonMaskedTextBox1.TabIndex = 8;
            kryptonMaskedTextBox1.Text = "kryptonMaskedTextBox1";
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(492, 470);
            LoginButton.Margin = new Padding(0);
            LoginButton.Name = "LoginButton";
            LoginButton.OverrideDefault.Back.Color1 = Color.Lime;
            LoginButton.OverrideDefault.Back.Color2 = Color.Lime;
            LoginButton.OverrideDefault.Border.Color1 = Color.Lime;
            LoginButton.OverrideDefault.Border.Color2 = Color.Lime;
            LoginButton.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            LoginButton.OverrideDefault.Content.ShortText.Color1 = Color.White;
            LoginButton.OverrideDefault.Content.ShortText.Color2 = Color.White;
            LoginButton.OverrideDefault.Content.ShortText.Font = new Font("Inria Sans", 20.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginButton.Size = new Size(601, 46);
            LoginButton.StateCommon.Back.Color1 = Color.Lime;
            LoginButton.StateCommon.Back.Color2 = Color.Lime;
            LoginButton.StateCommon.Border.Color1 = Color.Lime;
            LoginButton.StateCommon.Border.Color2 = Color.Lime;
            LoginButton.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            LoginButton.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            LoginButton.StateCommon.Border.Rounding = 20F;
            LoginButton.StateCommon.Border.Width = 2;
            LoginButton.StateDisabled.Back.Color1 = Color.Lime;
            LoginButton.StateDisabled.Back.Color2 = Color.Lime;
            LoginButton.StateNormal.Back.Color1 = Color.Lime;
            LoginButton.StateNormal.Back.Color2 = Color.Lime;
            LoginButton.StateNormal.Border.Color1 = Color.Lime;
            LoginButton.StateNormal.Border.Color2 = Color.Lime;
            LoginButton.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            LoginButton.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            LoginButton.StateNormal.Border.Rounding = 20F;
            LoginButton.StateNormal.Border.Width = 2;
            LoginButton.StatePressed.Back.Color1 = Color.White;
            LoginButton.StatePressed.Back.Color2 = Color.White;
            LoginButton.StatePressed.Border.Color1 = Color.White;
            LoginButton.StatePressed.Border.Color2 = Color.White;
            LoginButton.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            LoginButton.StateTracking.Back.Color1 = Color.Lime;
            LoginButton.StateTracking.Back.Color2 = Color.Lime;
            LoginButton.StateTracking.Border.Color1 = Color.Lime;
            LoginButton.StateTracking.Border.Color2 = Color.Lime;
            LoginButton.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            LoginButton.StateTracking.Content.LongText.Color1 = Color.Transparent;
            LoginButton.StateTracking.Content.LongText.Color2 = Color.Transparent;
            LoginButton.StateTracking.Content.LongText.Font = new Font("Sans Serif Collection", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginButton.TabIndex = 9;
            LoginButton.Values.Text = "Login";
            // 
            // LoginControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 17, 70);
            Controls.Add(LoginButton);
            Controls.Add(kryptonMaskedTextBox1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginControl";
            Size = new Size(1440, 1024);
            Load += LoginControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox textBox1;
        private Label label2;
        private Krypton.Toolkit.KryptonMaskedTextBox kryptonMaskedTextBox1;
        private Krypton.Toolkit.KryptonButton LoginButton;
    }
}
