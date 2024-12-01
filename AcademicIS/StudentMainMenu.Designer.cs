namespace AcademicIS
{
    partial class StudentMainMenu
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
            BackButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(373, 45);
            label1.TabIndex = 1;
            label1.Text = "Welcome back, Student!";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 71);
            button1.Name = "button1";
            button1.Size = new Size(143, 34);
            button1.TabIndex = 2;
            button1.Text = "View grades";
            button1.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(270, 152);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(143, 34);
            BackButton.TabIndex = 3;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // StudentMainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 198);
            Controls.Add(BackButton);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "StudentMainMenu";
            Text = "Student Main Menu";
            Load += StudentMainMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button BackButton;
    }
}