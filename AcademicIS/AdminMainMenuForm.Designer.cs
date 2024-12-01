namespace AcademicIS
{
    partial class AdminMainMenuForm1
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
            label1 = new Label();
            RemvoeUserButton = new Button();
            RemoveLectureButton = new Button();
            RemoveGroupButton = new Button();
            LectureAssignButton = new Button();
            CreateLectureButton = new Button();
            AddGroupButton = new Button();
            StudentAssignButton = new Button();
            CreateUserButton = new Button();
            BackButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(354, 45);
            label1.TabIndex = 2;
            label1.Text = "Welcome back, Admin!";
            // 
            // RemvoeUserButton
            // 
            RemvoeUserButton.BackgroundImageLayout = ImageLayout.Stretch;
            RemvoeUserButton.Location = new Point(189, 170);
            RemvoeUserButton.Name = "RemvoeUserButton";
            RemvoeUserButton.Size = new Size(143, 34);
            RemvoeUserButton.TabIndex = 3;
            RemvoeUserButton.Text = "Remove user";
            RemvoeUserButton.UseVisualStyleBackColor = true;
            RemvoeUserButton.Click += RemvoeUserButton_Click;
            // 
            // RemoveLectureButton
            // 
            RemoveLectureButton.Location = new Point(338, 170);
            RemoveLectureButton.Name = "RemoveLectureButton";
            RemoveLectureButton.Size = new Size(143, 34);
            RemoveLectureButton.TabIndex = 4;
            RemoveLectureButton.Text = "Remove lecture";
            RemoveLectureButton.UseVisualStyleBackColor = true;
            RemoveLectureButton.Click += RemoveLectureButton_Click;
            // 
            // RemoveGroupButton
            // 
            RemoveGroupButton.Location = new Point(487, 170);
            RemoveGroupButton.Name = "RemoveGroupButton";
            RemoveGroupButton.Size = new Size(143, 34);
            RemoveGroupButton.TabIndex = 5;
            RemoveGroupButton.Text = "Remove group";
            RemoveGroupButton.UseVisualStyleBackColor = true;
            RemoveGroupButton.Click += RemoveGroupButton_Click;
            // 
            // LectureAssignButton
            // 
            LectureAssignButton.Location = new Point(163, 109);
            LectureAssignButton.Name = "LectureAssignButton";
            LectureAssignButton.Size = new Size(143, 34);
            LectureAssignButton.TabIndex = 7;
            LectureAssignButton.Text = "Lecturer assign";
            LectureAssignButton.UseVisualStyleBackColor = true;
            LectureAssignButton.Click += LectureAssignButton_Click;
            // 
            // CreateLectureButton
            // 
            CreateLectureButton.Location = new Point(14, 109);
            CreateLectureButton.Name = "CreateLectureButton";
            CreateLectureButton.Size = new Size(143, 34);
            CreateLectureButton.TabIndex = 8;
            CreateLectureButton.Text = "Create lecture";
            CreateLectureButton.UseVisualStyleBackColor = true;
            CreateLectureButton.Click += CreateLectureButton_Click;
            // 
            // AddGroupButton
            // 
            AddGroupButton.Location = new Point(312, 69);
            AddGroupButton.Name = "AddGroupButton";
            AddGroupButton.Size = new Size(143, 34);
            AddGroupButton.TabIndex = 9;
            AddGroupButton.Text = "Add group";
            AddGroupButton.UseVisualStyleBackColor = true;
            AddGroupButton.Click += AddGroupButton_Click;
            // 
            // StudentAssignButton
            // 
            StudentAssignButton.Location = new Point(163, 69);
            StudentAssignButton.Name = "StudentAssignButton";
            StudentAssignButton.Size = new Size(143, 34);
            StudentAssignButton.TabIndex = 10;
            StudentAssignButton.Text = "Student assign";
            StudentAssignButton.UseVisualStyleBackColor = true;
            StudentAssignButton.Click += StudentAssignButton_Click;
            // 
            // CreateUserButton
            // 
            CreateUserButton.Location = new Point(14, 69);
            CreateUserButton.Name = "CreateUserButton";
            CreateUserButton.Size = new Size(143, 34);
            CreateUserButton.TabIndex = 11;
            CreateUserButton.Text = "Create user";
            CreateUserButton.UseVisualStyleBackColor = true;
            CreateUserButton.Click += CreateUser_Click;
            // 
            // BackButton
            // 
            BackButton.BackgroundImageLayout = ImageLayout.Stretch;
            BackButton.Location = new Point(14, 170);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(143, 34);
            BackButton.TabIndex = 12;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // AdminMainMenuForm1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 220);
            Controls.Add(BackButton);
            Controls.Add(CreateUserButton);
            Controls.Add(StudentAssignButton);
            Controls.Add(AddGroupButton);
            Controls.Add(CreateLectureButton);
            Controls.Add(LectureAssignButton);
            Controls.Add(RemoveGroupButton);
            Controls.Add(RemoveLectureButton);
            Controls.Add(RemvoeUserButton);
            Controls.Add(label1);
            Name = "AdminMainMenuForm1";
            Text = "Admin Main Menu";
            Load += AdminMainMenuForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button RemvoeUserButton;
        private Button RemoveLectureButton;
        private Button RemoveGroupButton;
        private Button LectureAssignButton;
        private Button CreateLectureButton;
        private Button AddGroupButton;
        private Button StudentAssignButton;
        private Button CreateUserButton;
        private Button BackButton;
    }
}