namespace notfiy.Views
{
    partial class LoginUnitTesterForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TextBoxPasswordLogin = new Krypton.Toolkit.KryptonTextBox();
            TextBoxUsernameLogin = new Krypton.Toolkit.KryptonTextBox();
            Username = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            ButtonLoginOrRegister = new Krypton.Toolkit.KryptonButton();
            RadioButtonRegister = new Krypton.Toolkit.KryptonRadioButton();
            RadioButtonLogin = new Krypton.Toolkit.KryptonRadioButton();
            ProcessResultLogin = new Krypton.Toolkit.KryptonLabel();
            TextBoxEmail = new Krypton.Toolkit.KryptonTextBox();
            LabelEmail = new Krypton.Toolkit.KryptonLabel();
            LabelUpdateEmail = new Krypton.Toolkit.KryptonLabel();
            TextBoxEmailUpdate = new Krypton.Toolkit.KryptonTextBox();
            LabelUpdatePassword = new Krypton.Toolkit.KryptonLabel();
            LabelUpdateUsername = new Krypton.Toolkit.KryptonLabel();
            TextBoxUsernameUpdate = new Krypton.Toolkit.KryptonTextBox();
            TextBoxPasswordUpdate = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            LabelUpdate = new Krypton.Toolkit.KryptonLabel();
            ButtonUpdate = new Button();
            ProcessResultUpdate = new Krypton.Toolkit.KryptonLabel();
            SuspendLayout();
            // 
            // TextBoxPasswordLogin
            // 
            TextBoxPasswordLogin.Location = new Point(225, 57);
            TextBoxPasswordLogin.Name = "TextBoxPasswordLogin";
            TextBoxPasswordLogin.Size = new Size(197, 23);
            TextBoxPasswordLogin.TabIndex = 0;
            // 
            // TextBoxUsernameLogin
            // 
            TextBoxUsernameLogin.Location = new Point(12, 57);
            TextBoxUsernameLogin.Name = "TextBoxUsernameLogin";
            TextBoxUsernameLogin.Size = new Size(166, 23);
            TextBoxUsernameLogin.TabIndex = 1;
            // 
            // Username
            // 
            Username.Location = new Point(12, 31);
            Username.Name = "Username";
            Username.Size = new Size(65, 20);
            Username.TabIndex = 2;
            Username.Values.Text = "Username";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(225, 31);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(62, 20);
            kryptonLabel2.TabIndex = 3;
            kryptonLabel2.Values.Text = "Password";
            // 
            // ButtonLoginOrRegister
            // 
            ButtonLoginOrRegister.Location = new Point(12, 99);
            ButtonLoginOrRegister.Name = "ButtonLoginOrRegister";
            ButtonLoginOrRegister.Size = new Size(138, 25);
            ButtonLoginOrRegister.TabIndex = 4;
            ButtonLoginOrRegister.Values.Text = "ButtonLogin/Register";
            ButtonLoginOrRegister.Click += ButtonLoginOrRegister_Click;
            // 
            // RadioButtonRegister
            // 
            RadioButtonRegister.Location = new Point(286, 99);
            RadioButtonRegister.Name = "RadioButtonRegister";
            RadioButtonRegister.Size = new Size(102, 20);
            RadioButtonRegister.TabIndex = 5;
            RadioButtonRegister.Values.Text = "Register Mode";
            RadioButtonRegister.CheckedChanged += RadioButtonRegister_CheckedChanged;
            // 
            // RadioButtonLogin
            // 
            RadioButtonLogin.Location = new Point(177, 99);
            RadioButtonLogin.Name = "RadioButtonLogin";
            RadioButtonLogin.Size = new Size(88, 20);
            RadioButtonLogin.TabIndex = 6;
            RadioButtonLogin.Values.Text = "Login Mode";
            RadioButtonLogin.CheckedChanged += RadioButtonLogin_CheckedChanged;
            // 
            // ProcessResultLogin
            // 
            ProcessResultLogin.Location = new Point(12, 141);
            ProcessResultLogin.Name = "ProcessResultLogin";
            ProcessResultLogin.Size = new Size(6, 2);
            ProcessResultLogin.TabIndex = 7;
            ProcessResultLogin.Values.Text = "";
            ProcessResultLogin.Click += StatusProcess_Click;
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.Location = new Point(468, 57);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Size = new Size(248, 23);
            TextBoxEmail.TabIndex = 8;
            // 
            // LabelEmail
            // 
            LabelEmail.Location = new Point(468, 31);
            LabelEmail.Name = "LabelEmail";
            LabelEmail.Size = new Size(40, 20);
            LabelEmail.TabIndex = 9;
            LabelEmail.Values.Text = "Email";
            // 
            // LabelUpdateEmail
            // 
            LabelUpdateEmail.Location = new Point(468, 187);
            LabelUpdateEmail.Name = "LabelUpdateEmail";
            LabelUpdateEmail.Size = new Size(40, 20);
            LabelUpdateEmail.TabIndex = 15;
            LabelUpdateEmail.Values.Text = "Email";
            // 
            // TextBoxEmailUpdate
            // 
            TextBoxEmailUpdate.Location = new Point(468, 213);
            TextBoxEmailUpdate.Name = "TextBoxEmailUpdate";
            TextBoxEmailUpdate.Size = new Size(248, 23);
            TextBoxEmailUpdate.TabIndex = 14;
            // 
            // LabelUpdatePassword
            // 
            LabelUpdatePassword.Location = new Point(225, 187);
            LabelUpdatePassword.Name = "LabelUpdatePassword";
            LabelUpdatePassword.Size = new Size(62, 20);
            LabelUpdatePassword.TabIndex = 13;
            LabelUpdatePassword.Values.Text = "Password";
            // 
            // LabelUpdateUsername
            // 
            LabelUpdateUsername.Location = new Point(12, 187);
            LabelUpdateUsername.Name = "LabelUpdateUsername";
            LabelUpdateUsername.Size = new Size(65, 20);
            LabelUpdateUsername.TabIndex = 12;
            LabelUpdateUsername.Values.Text = "Username";
            // 
            // TextBoxUsernameUpdate
            // 
            TextBoxUsernameUpdate.Location = new Point(12, 213);
            TextBoxUsernameUpdate.Name = "TextBoxUsernameUpdate";
            TextBoxUsernameUpdate.Size = new Size(166, 23);
            TextBoxUsernameUpdate.TabIndex = 11;
            // 
            // TextBoxPasswordUpdate
            // 
            TextBoxPasswordUpdate.Location = new Point(225, 213);
            TextBoxPasswordUpdate.Name = "TextBoxPasswordUpdate";
            TextBoxPasswordUpdate.Size = new Size(197, 23);
            TextBoxPasswordUpdate.TabIndex = 10;
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(12, 5);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(41, 20);
            kryptonLabel5.TabIndex = 16;
            kryptonLabel5.Values.Text = "Login";
            // 
            // LabelUpdate
            // 
            LabelUpdate.Location = new Point(12, 161);
            LabelUpdate.Name = "LabelUpdate";
            LabelUpdate.Size = new Size(136, 20);
            LabelUpdate.TabIndex = 17;
            LabelUpdate.Values.Text = "Update Logged in User";
            // 
            // ButtonUpdate
            // 
            ButtonUpdate.Location = new Point(12, 254);
            ButtonUpdate.Name = "ButtonUpdate";
            ButtonUpdate.Size = new Size(75, 23);
            ButtonUpdate.TabIndex = 18;
            ButtonUpdate.Text = "Save";
            ButtonUpdate.UseVisualStyleBackColor = true;
            ButtonUpdate.Click += LabelUpdate_Click;
            // 
            // ProcessResultUpdate
            // 
            ProcessResultUpdate.Location = new Point(12, 296);
            ProcessResultUpdate.Name = "ProcessResultUpdate";
            ProcessResultUpdate.Size = new Size(6, 2);
            ProcessResultUpdate.TabIndex = 19;
            ProcessResultUpdate.Values.Text = "";
            // 
            // UnitTesterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 559);
            Controls.Add(ProcessResultUpdate);
            Controls.Add(ButtonUpdate);
            Controls.Add(LabelUpdate);
            Controls.Add(kryptonLabel5);
            Controls.Add(LabelUpdateEmail);
            Controls.Add(TextBoxEmailUpdate);
            Controls.Add(LabelUpdatePassword);
            Controls.Add(LabelUpdateUsername);
            Controls.Add(TextBoxUsernameUpdate);
            Controls.Add(TextBoxPasswordUpdate);
            Controls.Add(LabelEmail);
            Controls.Add(TextBoxEmail);
            Controls.Add(ProcessResultLogin);
            Controls.Add(RadioButtonLogin);
            Controls.Add(RadioButtonRegister);
            Controls.Add(ButtonLoginOrRegister);
            Controls.Add(kryptonLabel2);
            Controls.Add(Username);
            Controls.Add(TextBoxUsernameLogin);
            Controls.Add(TextBoxPasswordLogin);
            Name = "UnitTesterForm";
            Text = "User Unit Tester";
            Load += UnitTesterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox TextBoxPasswordLogin;
        private Krypton.Toolkit.KryptonTextBox TextBoxUsernameLogin;
        private Krypton.Toolkit.KryptonLabel Username;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonButton ButtonLoginOrRegister;
        private Krypton.Toolkit.KryptonRadioButton RadioButtonRegister;
        private Krypton.Toolkit.KryptonRadioButton RadioButtonLogin;
        private Krypton.Toolkit.KryptonLabel ProcessResultLogin;
        private Krypton.Toolkit.KryptonTextBox TextBoxEmail;
        private Krypton.Toolkit.KryptonLabel LabelEmail;
        private Krypton.Toolkit.KryptonLabel LabelUpdateEmail;
        private Krypton.Toolkit.KryptonTextBox TextBoxEmailUpdate;
        private Krypton.Toolkit.KryptonLabel LabelUpdatePassword;
        private Krypton.Toolkit.KryptonLabel LabelUpdateUsername;
        private Krypton.Toolkit.KryptonTextBox TextBoxUsernameUpdate;
        private Krypton.Toolkit.KryptonTextBox TextBoxPasswordUpdate;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel LabelUpdate;
        private Button ButtonUpdate;
        private Krypton.Toolkit.KryptonLabel ProcessResultUpdate;
    }
}