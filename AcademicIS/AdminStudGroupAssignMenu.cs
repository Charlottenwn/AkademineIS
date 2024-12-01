using MongoDB.Driver;
using System;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AcademicIS
{
    public partial class StudentGroupAssignForm : Form
    {
        public class Assigned_Groups
        {
            public string Name { get; set; }
            public string Group { get; set; }
        }
        public class Users
        {
            public string Username { get; set; }
        }
        public class Groups
        {
            public string GroupName { get; set; }

        }


        private MongoClient client;
        private IMongoDatabase database;

        public StudentGroupAssignForm()
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            string username = textBox1.Text.Trim();
            string groupName = textBox3.Text.Trim();

            
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(groupName))
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            try
            {
                // Get collections for Users and Groups
                var usersCollection = database.GetCollection<Users>("Users");
                var groupsCollection = database.GetCollection<Groups>("Groups");

                // Check if the username exists in the Users collection
                var userFilter = Builders<Users>.Filter.Eq(a => a.Username, username);
                var userExists = usersCollection.Find(userFilter).Any();

                // Check if the group exists in the Groups collection
                var groupFilter = Builders<Groups>.Filter.Eq(a => a.GroupName, groupName);
                var groupExists = groupsCollection.Find(groupFilter).Any();

                if (!userExists || !groupExists)
                {
                    MessageBox.Show("Add user or group.");
                    return;
                }

                // Get the collection for AssignGroup where we store assignments
                var assignGroupCollection = database.GetCollection<Assigned_Groups>("Assigned_Groups");

                // Check if the student-group assignment already exists
                var existingAssignmentFilter = Builders<Assigned_Groups>.Filter.And(
                    Builders<Assigned_Groups>.Filter.Eq(a => a.Name, username),
                    Builders<Assigned_Groups>.Filter.Eq(a => a.Group, groupName)
                );

                var assignmentExists = assignGroupCollection.Find(existingAssignmentFilter).Any();

                if (assignmentExists)
                {
                    MessageBox.Show("This student is already assigned to the group.");
                    return;
                }

                
                var newAssignment = new Assigned_Groups
                {
                    Name = username,
                    Group = groupName
                };

                assignGroupCollection.InsertOne(newAssignment);

                MessageBox.Show($"Student {username} assigned to group {groupName} successfully!");

                
                textBox1.Clear();
                textBox3.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error assigning student to group: {ex.Message}");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentGroupAssignForm_Load(object sender, EventArgs e)
        {

        }
    }
}
    


