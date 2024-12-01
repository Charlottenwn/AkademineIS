namespace AcademicIS
{
    partial class AdminRemoveUserMenu
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
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            BackButton = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(122, 52);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 10;
            button1.Text = "Remove user";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 15);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 8;
            label1.Text = "Name:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(100, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(12, 52);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(74, 34);
            BackButton.TabIndex = 13;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // AdminRemoveUserMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 97);
            Controls.Add(BackButton);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "AdminRemoveUserMenu";
            Text = "Remove User";
            Load += AdminRemoveUserMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Button BackButton;
    }
}