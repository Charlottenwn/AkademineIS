namespace AcademicIS
{
    partial class CreateGroupForm
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
            NewGroupName = new TextBox();
            label1 = new Label();
            button1 = new Button();
            GroupNew = new TextBox();
            NewGroup = new Label();
            AddGroup = new Button();
            BackButton = new Button();
            SuspendLayout();
            // 
            // NewGroupName
            // 
            NewGroupName.Location = new Point(171, 30);
            NewGroupName.Name = "NewGroupName";
            NewGroupName.Size = new Size(424, 31);
            NewGroupName.TabIndex = 0;
            NewGroupName.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 30);
            label1.Name = "label1";
            label1.Size = new Size(154, 25);
            label1.TabIndex = 1;
            label1.Text = "New group name:";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(303, 67);
            button1.Name = "button1";
            button1.Size = new Size(145, 34);
            button1.TabIndex = 2;
            button1.Text = "create group";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // GroupNew
            // 
            GroupNew.Location = new Point(172, 15);
            GroupNew.Name = "GroupNew";
            GroupNew.Size = new Size(321, 31);
            GroupNew.TabIndex = 22;
            GroupNew.TextChanged += textBox2_TextChanged;
            // 
            // NewGroup
            // 
            NewGroup.AutoSize = true;
            NewGroup.Location = new Point(12, 15);
            NewGroup.Name = "NewGroup";
            NewGroup.Size = new Size(154, 25);
            NewGroup.TabIndex = 21;
            NewGroup.Text = "New group name:";
            NewGroup.Click += NewGroup_Click;
            // 
            // AddGroup
            // 
            AddGroup.Location = new Point(257, 52);
            AddGroup.Name = "AddGroup";
            AddGroup.Size = new Size(112, 34);
            AddGroup.TabIndex = 17;
            AddGroup.Text = "Add group";
            AddGroup.UseVisualStyleBackColor = true;
            AddGroup.Click += AddGroup_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(12, 54);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(112, 34);
            BackButton.TabIndex = 23;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // CreateGroupForm
            // 
            ClientSize = new Size(530, 100);
            Controls.Add(BackButton);
            Controls.Add(GroupNew);
            Controls.Add(NewGroup);
            Controls.Add(AddGroup);
            Name = "CreateGroupForm";
            Text = "Create Group";
            Load += CreateGroupForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NewGroupName;
        private Label label1;
        private Button button1;
        private TextBox GroupNew;
        private Label NewGroup;
        private Button AddGroup;
        private Button BackButton;
    }
}