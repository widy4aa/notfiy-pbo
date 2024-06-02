namespace notfiy.Views.UnitTester
{
    partial class NoteUnitTestForm
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
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            Name = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 95);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(305, 125);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(305, 23);
            textBox1.TabIndex = 1;
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Location = new Point(12, 27);
            Name.Name = "Name";
            Name.Size = new Size(38, 15);
            Name.TabIndex = 2;
            Name.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 77);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 3;
            label2.Text = "Content";
            // 
            // button1
            // 
            button1.Location = new Point(388, 69);
            button1.Name = "button1";
            button1.Size = new Size(96, 23);
            button1.TabIndex = 4;
            button1.Text = "Create Mode";
            button1.UseVisualStyleBackColor = true;
            // 
            // NoteUnitTestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(Name);
            Controls.Add(textBox1);
            Controls.Add(richTextBox1);
            Text = "Note Unit Test Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private Label Name;
        private Label label2;
        private Button button1;
    }
}