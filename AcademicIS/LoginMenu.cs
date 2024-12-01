using System;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;

namespace AcademicIS
{
    public partial class LoginMenu : Form //inheritance
    {

        [BsonIgnoreExtraElements] // ingores "_id:", so the username and password can get checked afterwards
        public class User
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public string Role { get; set; }
        }

        private MongoClient client;
        private IMongoDatabase database;

        public LoginMenu()
        {
            // Initialize and connect to MongoDB
            InitializeComponent();
            const string connectionUri = "mongodb+srv://charlotteesto:RJ7FO7nNNx3arwbV@akademineis.mwlnb.mongodb.net/";
            client = new MongoClient(connectionUri);
            database = GetDatabase();
        }

        // Method to fetch the database instance
        public IMongoDatabase GetDatabase()
        {
            return client.GetDatabase("AkademineIS"); // Fetch database
        }

        private string AuthenticateUser(string username, string password)
        {
            try
            {
                var usersCollection = database.GetCollection<User>("Users");

                // Find a user document that matches the username and password
                var filter = Builders<User>.Filter.And(
                    Builders<User>.Filter.Eq(u => u.Username, username),
                    Builders<User>.Filter.Eq(u => u.Password, password)
                );

                var user = usersCollection.Find(filter).FirstOrDefault();

                if (user != null)
                {
                    return user.Role; // Return the role if the user is found
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error accessing the database: {ex.Message}");
            }

            return null; // Return null if authentication fails
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            // Authenticate the user by checking against the database
            string role = AuthenticateUser(username, password);

            if (!string.IsNullOrEmpty(role))
            {
                // Navigate to the corresponding page based on the role
                LoadRoleBasedView(role);
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        // Method to authenticate the user


        // Load a specific view based on the user's role
        private void LoadRoleBasedView(string role)
        {
            this.Hide(); // Hide the login menu

            if (role == "Admin")
            {
                AdminMainMenuForm1 adminForm1 = new AdminMainMenuForm1();
                adminForm1.Show();
            }
            else if (role == "Lecturer")
            {
                LecturerMainMenuForm lecturerForm1 = new LecturerMainMenuForm();
                lecturerForm1.Show();
            }
            else if (role == "Student")
            {
                StudentMainMenu studentForm = new StudentMainMenu();
                studentForm.Show();
            }
            else
            {
                MessageBox.Show("Unknown role. Please contact the administrator.");
                this.Show(); // Show the login form again if the role is unknown
            }
        }
    }
}
