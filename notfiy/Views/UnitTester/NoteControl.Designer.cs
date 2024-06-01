namespace notfiy.Views.UnitTester
{
    partial class NoteControl
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
            PinButton = new Krypton.Toolkit.KryptonRadioButton();
            ShareButton = new Krypton.Toolkit.KryptonButton();
            NoteText = new Krypton.Toolkit.KryptonRichTextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // PinButton
            // 
            PinButton.Location = new Point(336, 35);
            PinButton.Name = "PinButton";
            PinButton.Size = new Size(39, 20);
            PinButton.TabIndex = 0;
            PinButton.Values.Text = "Pin";
            // 
            // ShareButton
            // 
            ShareButton.Location = new Point(393, 30);
            ShareButton.Name = "ShareButton";
            ShareButton.Size = new Size(58, 36);
            ShareButton.TabIndex = 1;
            ShareButton.Values.Text = "Share";
            // 
            // NoteText
            // 
            NoteText.Location = new Point(3, 72);
            NoteText.Name = "NoteText";
            NoteText.Size = new Size(467, 208);
            NoteText.TabIndex = 2;
            NoteText.Text = "kryptonRichTextBox1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 18);
            label1.Name = "label1";
            label1.Size = new Size(49, 21);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // NoteControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(NoteText);
            Controls.Add(ShareButton);
            Controls.Add(PinButton);
            Name = "NoteControl";
            Size = new Size(473, 283);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonRadioButton PinButton;
        private Krypton.Toolkit.KryptonButton ShareButton;
        private Krypton.Toolkit.KryptonRichTextBox NoteText;
        private Label label1;
    }
}
