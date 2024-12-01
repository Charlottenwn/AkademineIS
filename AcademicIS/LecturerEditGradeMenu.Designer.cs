namespace AcademicIS
{
    partial class LecturerEditGradeMenu
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
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            NameSurname1 = new Label();
            Subject = new Label();
            textBox1 = new TextBox();
            Grade = new Label();
            BackButton = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(336, 125);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "Edit grade";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(127, 88);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(321, 31);
            textBox3.TabIndex = 23;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(127, 9);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(321, 31);
            textBox2.TabIndex = 22;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // NameSurname1
            // 
            NameSurname1.AutoSize = true;
            NameSurname1.Location = new Point(12, 49);
            NameSurname1.Name = "NameSurname1";
            NameSurname1.Size = new Size(74, 25);
            NameSurname1.TabIndex = 21;
            NameSurname1.Text = "Subject:";
            // 
            // Subject
            // 
            Subject.AutoSize = true;
            Subject.Location = new Point(12, 12);
            Subject.Name = "Subject";
            Subject.Size = new Size(63, 25);
            Subject.TabIndex = 20;
            Subject.Text = "Name:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(127, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(321, 31);
            textBox1.TabIndex = 19;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Grade
            // 
            Grade.AutoSize = true;
            Grade.Location = new Point(12, 88);
            Grade.Name = "Grade";
            Grade.Size = new Size(63, 25);
            Grade.TabIndex = 18;
            Grade.Text = "Grade:";
            // 
            // BackButton
            // 
            BackButton.Location = new Point(12, 125);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(112, 34);
            BackButton.TabIndex = 24;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // LecturerEditGradeMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 168);
            Controls.Add(BackButton);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(NameSurname1);
            Controls.Add(Subject);
            Controls.Add(textBox1);
            Controls.Add(Grade);
            Controls.Add(button1);
            Name = "LecturerEditGradeMenu";
            Text = "Edit grade";
            Load += LecturerEditGradeMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label NameSurname1;
        private Label Subject;
        private TextBox textBox1;
        private Label Grade;
        private Button BackButton;
    }
}