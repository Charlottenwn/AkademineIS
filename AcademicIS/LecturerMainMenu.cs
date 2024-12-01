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
    public partial class LecturerMainMenuForm : Form
    {
        public LecturerMainMenuForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LecturerMainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void AddGradeButton_Click(object sender, EventArgs e)
        {
            LecturerAddGradeMenu addGradeForm = new LecturerAddGradeMenu();
            addGradeForm.Show();
        }

        private void EditGradeButton_Click(object sender, EventArgs e)
        {
            LecturerEditGradeMenu editGradeForm = new LecturerEditGradeMenu();
            editGradeForm.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginMenu loginMenu = new LoginMenu();
            loginMenu.Show();
        }
    }
}
