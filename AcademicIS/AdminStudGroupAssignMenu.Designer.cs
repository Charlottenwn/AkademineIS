namespace AcademicIS
{
    partial class StudentGroupAssignForm
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
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label3 = new Label();
            button1 = new Button();
            BackButton = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(78, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(289, 31);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(76, 49);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(289, 31);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 15);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 3;
            label1.Text = "Name:";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 49);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 5;
            label3.Text = "Group:";
            // 
            // button1
            // 
            button1.Location = new Point(156, 86);
            button1.Name = "button1";
            button1.Size = new Size(159, 34);
            button1.TabIndex = 6;
            button1.Text = "Assign to group";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(11, 86);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(66, 34);
            BackButton.TabIndex = 7;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // StudentGroupAssignForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 130);
            Controls.Add(BackButton);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Name = "StudentGroupAssignForm";
            Text = "Student Group assign";
            Load += StudentGroupAssignForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox3;
        private Label label1;
        private Label label3;
        private Button button1;
        private Button BackButton;
    }
}