namespace AcademicIS
{
    partial class LLAssignForm
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
            label3 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Back = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(155, 86);
            button1.Name = "button1";
            button1.Size = new Size(159, 34);
            button1.TabIndex = 13;
            button1.Text = "Assign to lecture";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 49);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 12;
            label3.Text = "Lecture:";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 15);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 10;
            label1.Text = "Name:";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(88, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(276, 31);
            textBox1.TabIndex = 14;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(87, 49);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(276, 31);
            textBox2.TabIndex = 15;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Back
            // 
            Back.Location = new Point(10, 86);
            Back.Name = "Back";
            Back.Size = new Size(83, 34);
            Back.TabIndex = 16;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // LLAssignForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 130);
            Controls.Add(Back);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "LLAssignForm";
            Text = "Lecturer Lecture Assign";
            Load += LLAssignForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label3;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button Back;
    }
}