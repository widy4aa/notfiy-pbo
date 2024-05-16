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
            LoginButton = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Chivo", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(707, 341);
            label1.Name = "label1";
            label1.Size = new Size(254, 42);
            label1.TabIndex = 0;
            label1.Text = "Forgot Password?";
            label1.Click += label1_Click;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.Lime;
            LoginButton.BackgroundImageLayout = ImageLayout.None;
            LoginButton.FlatStyle = FlatStyle.Popup;
            LoginButton.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginButton.ForeColor = Color.White;
            LoginButton.Location = new Point(452, 419);
            LoginButton.Margin = new Padding(0);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(536, 33);
            LoginButton.TabIndex = 1;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += button1_Click;
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
            // LoginControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 17, 70);
            Controls.Add(panel1);
            Controls.Add(LoginButton);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginControl";
            Size = new Size(1600, 800);
            Load += LoginControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button LoginButton;
        private Panel panel1;
    }
}
