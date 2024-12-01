namespace AcademicIS
{
    partial class LecturerMainMenuForm
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
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            EditGradeButton = new Button();
            AddGradeButton = new Button();
            BackButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-1, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(379, 45);
            label1.TabIndex = 1;
            label1.Text = "Welcome back, Lecturer!";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 8F);
            button1.Location = new Point(68, 68);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "Add grade";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 8F);
            button2.Location = new Point(220, 68);
            button2.Name = "button2";
            button2.Size = new Size(131, 34);
            button2.TabIndex = 3;
            button2.Text = "Edit grade";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 9);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(379, 45);
            label2.TabIndex = 3;
            label2.Text = "Welcome back, Lecturer!";
            label2.Click += label2_Click;
            // 
            // EditGradeButton
            // 
            EditGradeButton.Location = new Point(219, 57);
            EditGradeButton.Name = "EditGradeButton";
            EditGradeButton.Size = new Size(112, 34);
            EditGradeButton.TabIndex = 4;
            EditGradeButton.Text = "Edit grade";
            EditGradeButton.UseVisualStyleBackColor = true;
            EditGradeButton.Click += EditGradeButton_Click;
            // 
            // AddGradeButton
            // 
            AddGradeButton.Location = new Point(44, 57);
            AddGradeButton.Name = "AddGradeButton";
            AddGradeButton.Size = new Size(112, 34);
            AddGradeButton.TabIndex = 5;
            AddGradeButton.Text = "Add grade";
            AddGradeButton.UseVisualStyleBackColor = true;
            AddGradeButton.Click += AddGradeButton_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(314, 102);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(112, 34);
            BackButton.TabIndex = 6;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // LecturerMainMenuForm
            // 
            ClientSize = new Size(438, 148);
            Controls.Add(BackButton);
            Controls.Add(AddGradeButton);
            Controls.Add(EditGradeButton);
            Controls.Add(label2);
            Name = "LecturerMainMenuForm";
            Text = "Lecturer main menu";
            Load += LecturerMainMenuForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private Button EditGradeButton;
        private Button AddGradeButton;
        private Button BackButton;
    }
}