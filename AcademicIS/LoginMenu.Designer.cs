namespace AcademicIS
{
    partial class LoginMenu
    {

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoginButton = new Button();
            Username = new TextBox();
            Password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(0, 0);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(75, 23);
            LoginButton.TabIndex = 0;
            // 
            // Username
            // 
            Username.Location = new Point(0, 0);
            Username.Name = "Username";
            Username.Size = new Size(100, 31);
            Username.TabIndex = 0;
            // 
            // Password
            // 
            Password.Location = new Point(0, 0);
            Password.Name = "Password";
            Password.Size = new Size(100, 31);
            Password.TabIndex = 0;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 339);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(274, 145);
            button1.Name = "button1";
            button1.Size = new Size(123, 46);
            button1.TabIndex = 14;
            button1.Text = "login";
            button1.Click += button1_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(108, 108);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 11;
            label5.Text = "Password:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(108, 71);
            label6.Name = "label6";
            label6.Size = new Size(95, 25);
            label6.TabIndex = 10;
            label6.Text = "Username:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(209, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(282, 31);
            textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(209, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(282, 31);
            textBox1.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(200, 9);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(218, 45);
            label4.TabIndex = 13;
            label4.Text = "Akademinė IS";
            // 
            // LoginMenu
            // 
            ClientSize = new Size(584, 203);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "LoginMenu";
            Text = "Academic IS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginButton;
        private TextBox Username;
        private TextBox Password;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
    }
}