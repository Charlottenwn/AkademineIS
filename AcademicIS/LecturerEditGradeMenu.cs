using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AcademicIS
{
    public partial class LecturerEditGradeMenu : Form
    {
        [BsonIgnoreExtraElements] // Ignores "id:", espcially with elements already in the database
        public class Grades
        {
            public string Name { get; set; }
            public string Subject { get; set; }
            public string Grade { get; set; }
        }

        private MongoClient client;
        private IMongoDatabase database;

        public LecturerEditGradeMenu()
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

       
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text.Trim();
            string subject = textBox1.Text.Trim();
            string newGrade = textBox3.Text.Trim();

            
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(subject) || string.IsNullOrEmpty(newGrade))
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            // Create a filter to find the grade by Name and Subject
            var filter = Builders<Grades>.Filter.And(
                Builders<Grades>.Filter.Eq(g => g.Name, name),
                Builders<Grades>.Filter.Eq(g => g.Subject, subject)
            );

            try
            {
                
                var gradesCollection = database.GetCollection<Grades>("Grades");

                // Check if the grade exists
                var existingGrade = gradesCollection.Find(filter).FirstOrDefault();

                if (existingGrade != null)
                {
                    // If record exists, update the grade
                    var update = Builders<Grades>.Update.Set(g => g.Grade, newGrade);

                    // Update the grade in the database
                    var result = gradesCollection.UpdateOne(filter, update);

                   
                    if (result.ModifiedCount > 0)
                    {
                        MessageBox.Show("Grade updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No changes were made.");
                    }
                }
                else
                {
                    
                    MessageBox.Show("Grade not found for the given Name and Subject.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating grade: {ex.Message}");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void LecturerEditGradeMenu_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
