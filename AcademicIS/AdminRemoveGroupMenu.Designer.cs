namespace AcademicIS
{
    partial class RemoveGroupForm
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
            button2 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            BackButton = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 31);
            textBox1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(246, 49);
            button2.Name = "button2";
            button2.Size = new Size(145, 34);
            button2.TabIndex = 11;
            button2.Text = "Remove group";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(169, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(310, 31);
            textBox2.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 15);
            label2.Name = "label2";
            label2.Size = new Size(115, 25);
            label2.TabIndex = 14;
            label2.Text = "Group name:";
            // 
            // BackButton
            // 
            BackButton.Location = new Point(42, 49);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(94, 34);
            BackButton.TabIndex = 15;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // RemoveGroupForm
            // 
            ClientSize = new Size(563, 102);
            Controls.Add(BackButton);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Name = "RemoveGroupForm";
            Text = "Remove group";
            Load += RemoveGroupForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Button button2;
        private TextBox textBox2;
        private Label label2;
        private Button BackButton;
    }
}