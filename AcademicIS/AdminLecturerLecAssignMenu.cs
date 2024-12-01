using MongoDB.Driver;
using System;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AcademicIS
{
    public partial class LLAssignForm : Form
    {
        public class Assigned_Lectures
        {
            public string Name { get; set; }
            public string Lecture { get; set; }
        }
        public class Users
        {
            public string Username { get; set; }
        }
        public class Lectures
        {
            public string lectureName { get; set; }

        }


        private MongoClient client;
        private IMongoDatabase database;

        public LLAssignForm()
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string username = textBox1.Text.Trim();
            string lectureName = textBox2.Text.Trim();

            
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(lectureName))
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            try
            {
                // Get collections for Users and Groups
                var usersCollection = database.GetCollection<Users>("Users");
                var lecturesCollection = database.GetCollection<Lectures>("Lectures");

                // Check if the username exists in the Users collection
                var userFilter = Builders<Users>.Filter.Eq(a => a.Username, username); // Use 'Name' for username field
                var userExists = usersCollection.Find(userFilter).Any();

                // Check if the group exists in the Groups collection
                var lectureFilter = Builders<Lectures>.Filter.Eq(a => a.lectureName, lectureName);
                var lectureExists = lecturesCollection.Find(lectureFilter).Any();


                // Get the collection for AssignGroup where we store assignments
                var assignLectureCollection = database.GetCollection<Assigned_Lectures>("Assigned_Lectures");

                // Check if the student-group assignment already exists
                var existingAssignmentFilter = Builders<Assigned_Lectures>.Filter.And(
                    Builders<Assigned_Lectures>.Filter.Eq(a => a.Name, username),
                    Builders<Assigned_Lectures>.Filter.Eq(a => a.Lecture, lectureName)
                );

                var assignmentExists = assignLectureCollection.Find(existingAssignmentFilter).Any();

                if (assignmentExists)
                {
                    MessageBox.Show("This lecturer is already assigned to a lecture.");
                    return;
                }

                // Create and insert the new student-group assignment
                var newAssignment = new Assigned_Lectures
                {
                    Name = username,
                    Lecture = lectureName
                };

                assignLectureCollection.InsertOne(newAssignment);

                MessageBox.Show($"Lecturer {username} assigned to lecture {lectureName} successfully!");

                
                textBox1.Clear();
                textBox2.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error assigning lecturer to lecture: {ex.Message}");
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LLAssignForm_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



