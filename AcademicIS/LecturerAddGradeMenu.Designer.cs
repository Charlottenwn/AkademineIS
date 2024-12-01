namespace AcademicIS
{
    partial class LecturerAddGradeMenu
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            gradesBindingSource = new BindingSource(components);
            Grade = new Label();
            Subject = new Label();
            textBox1 = new TextBox();
            NameSurname1 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            BackButton = new Button();
            ((System.ComponentModel.ISupportInitialize)gradesBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(379, 151);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "Add grade";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Grade
            // 
            Grade.AutoSize = true;
            Grade.Location = new Point(55, 104);
            Grade.Name = "Grade";
            Grade.Size = new Size(63, 25);
            Grade.TabIndex = 8;
            Grade.Text = "Grade:";
            Grade.Click += Grade_Click;
            // 
            // Subject
            // 
            Subject.AutoSize = true;
            Subject.Location = new Point(55, 25);
            Subject.Name = "Subject";
            Subject.Size = new Size(63, 25);
            Subject.TabIndex = 10;
            Subject.Text = "Name:";
            Subject.Click += Subject_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(170, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(321, 31);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // NameSurname1
            // 
            NameSurname1.AutoSize = true;
            NameSurname1.Location = new Point(55, 62);
            NameSurname1.Name = "NameSurname1";
            NameSurname1.Size = new Size(74, 25);
            NameSurname1.TabIndex = 12;
            NameSurname1.Text = "Subject:";
            NameSurname1.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(170, 62);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(321, 31);
            textBox2.TabIndex = 15;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(170, 104);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(321, 31);
            textBox3.TabIndex = 16;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(6, 151);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(112, 34);
            BackButton.TabIndex = 17;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // LecturerAddGradeMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 202);
            Controls.Add(BackButton);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(NameSurname1);
            Controls.Add(Subject);
            Controls.Add(textBox1);
            Controls.Add(Grade);
            Controls.Add(button1);
            Name = "LecturerAddGradeMenu";
            Text = "Add Grade";
            Load += LecturerAddGradeMenu_Load;
            ((System.ComponentModel.ISupportInitialize)gradesBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private BindingSource gradesBindingSource;
        private Label Grade;
        private Label Subject;
        private TextBox textBox1;
        private Label NameSurname1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button BackButton;
    }
}