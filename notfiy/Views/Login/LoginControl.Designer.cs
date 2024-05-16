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
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
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
            // LoginButton
            // 
            LoginButton.BackColor = Color.Lime;
            LoginButton.BackgroundImageLayout = ImageLayout.None;
            LoginButton.FlatStyle = FlatStyle.Popup;
            LoginButton.Font = new Font("Segoe UI Historic", 20F);
            LoginButton.ForeColor = Color.White;
            LoginButton.Location = new Point(492, 499);
            LoginButton.Margin = new Padding(0);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(601, 51);
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
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 30F);
            textBox1.Location = new Point(492, 340);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(601, 61);
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
            label2.Size = new Size(235, 31);
            label2.TabIndex = 5;
            label2.Text = "Forgot Password?";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 30F);
            textBox2.Location = new Point(492, 173);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(601, 61);
            textBox2.TabIndex = 6;
            // 
            // LoginControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 17, 70);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
    }
}
