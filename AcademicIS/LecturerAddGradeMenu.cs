using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;

namespace AcademicIS
{
    public partial class LecturerAddGradeMenu : Form
    {
        
        public class Grades
        {
            public string Name { get; set; }
            public string Subject { get; set; }
            public string Grade { get; set; }
        }

        private MongoClient client;
        private IMongoDatabase database;

        public LecturerAddGradeMenu()
        {
            
            InitializeComponent();
            const string connectionUri = "mongodb+srv://charlotteesto:RJ7FO7nNNx3arwbV@akademineis.mwlnb.mongodb.net/";
            client = new MongoClient(connectionUri);
            database = GetDatabase();
        }

        
        public IMongoDatabase GetDatabase()
        {
            return client.GetDatabase("AkademineIS"); // Fetch database
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Subject_Click(object sender, EventArgs e)
        {

        }

        private void Grade_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            
            string name = textBox1.Text.Trim();
            string subject = textBox2.Text.Trim();
            string grade = textBox3.Text.Trim();

            
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(subject) || string.IsNullOrEmpty(grade))
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            
            var newGrade = new Grades
            {
                Name = name,
                Subject = subject,
                Grade = grade
            };

            try
            {
                
                var gradesCollection = database.GetCollection<Grades>("Grades");

               
                gradesCollection.InsertOne(newGrade);

                
                MessageBox.Show("Grade added successfully!");

                
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"Error adding grade: {ex.Message}");
            }
        }

        private void LecturerAddGradeMenu_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
