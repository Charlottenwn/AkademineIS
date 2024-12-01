using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicIS
{
    public partial class StudentMainMenu : Form
    {
        public StudentMainMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentGradesScreen viewGrades = new StudentGradesScreen();
            viewGrades.ShowDialog();
        }

        private void StudentMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginMenu loginMenu = new LoginMenu();
            loginMenu.Show();
        }
    }
}
