using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicIS
{
    public partial class AdminMainMenuForm1 : Form
    {
        public AdminMainMenuForm1()
        {
            InitializeComponent();
        }

        private void AdminMainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void CreateUser_Click(object sender, EventArgs e)
        {
            CreateUserForm userForm = new CreateUserForm();
            userForm.Show();
        }

        private void CreateLectureButton_Click(object sender, EventArgs e)
        {
            CreateLF createLF = new CreateLF();
            createLF.Show();
        }

        private void StudentAssignButton_Click(object sender, EventArgs e)
        {
            StudentGroupAssignForm studentGroup = new StudentGroupAssignForm();
            studentGroup.Show();
        }

        private void LectureAssignButton_Click(object sender, EventArgs e)
        {
            LLAssignForm AdminLLForm = new LLAssignForm();
            AdminLLForm.Show();
        }

        private void AddGroupButton_Click(object sender, EventArgs e)
        {
            CreateGroupForm studentGroup = new CreateGroupForm();
            studentGroup.Show();
        }

        private void RemvoeUserButton_Click(object sender, EventArgs e)
        {
            AdminRemoveUserMenu adminRemoveUserMenu = new AdminRemoveUserMenu();
            adminRemoveUserMenu.Show();
        }

        private void RemoveLectureButton_Click(object sender, EventArgs e)
        {
            RLectureForm rLectureForm = new RLectureForm();
            rLectureForm.Show();
        }

        private void RemoveGroupButton_Click(object sender, EventArgs e)
        {
            RemoveGroupForm studentGroup = new RemoveGroupForm();
            studentGroup.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this .Close();
            LoginMenu loginMenu = new LoginMenu();
            loginMenu.Show();
        }
    }
}
