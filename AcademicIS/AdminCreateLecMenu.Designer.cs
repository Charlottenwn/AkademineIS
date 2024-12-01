namespace AcademicIS
{
    partial class CreateLF
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
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            BackButton = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(183, 49);
            button1.Name = "button1";
            button1.Size = new Size(159, 34);
            button1.TabIndex = 13;
            button1.Text = "Create lecture";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 52);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 15);
            label1.Name = "label1";
            label1.Size = new Size(121, 25);
            label1.TabIndex = 10;
            label1.Text = "Lecture name:";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(128, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(289, 31);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(11, 49);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(101, 34);
            BackButton.TabIndex = 14;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // CreateLF
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 99);
            Controls.Add(BackButton);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "CreateLF";
            Text = "Create Lecture";
            Load += CreateLF_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Button BackButton;
    }
}