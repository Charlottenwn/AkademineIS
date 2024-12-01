using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Windows.Forms;

namespace AcademicIS
{
    public partial class AdminRemoveUserMenu : Form
    {
        
        public class User
        {
            public string Username { get; set; }
        }

        private MongoClient client;
        private IMongoDatabase database;

        public AdminRemoveUserMenu()
        {
            InitializeComponent();
            const string connectionUri = "mongodb+srv://charlotteesto:RJ7FO7nNNx3arwbV@akademineis.mwlnb.mongodb.net/";
            client = new MongoClient(connectionUri);
            database = GetDatabase();
        }

        public IMongoDatabase GetDatabase()
        {
            return client.GetDatabase("AkademineIS"); // Fetch the database
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
            // Retrieve the entered values from the textboxes
            string user = textBox1.Text.Trim();

            // Validate that all fields are filled out
            if (string.IsNullOrEmpty(user))
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            try
            {
                // Get the Users collection from the database
                var userCollection = database.GetCollection<User>("Users");

                // Construct a filter to find the user based on name, surname, and role
                var userFilter = Builders<User>.Filter.And(
                    Builders<User>.Filter.Eq(u => u.Username, user)
                );

                // Delete the user matching the filter
                var deleteResult = userCollection.DeleteOne(userFilter);

                // Check if a document was deleted
                if (deleteResult.DeletedCount > 0)
                {
                    MessageBox.Show("User removed successfully!");
                }
                else
                {
                    MessageBox.Show("No user found with the specified details.");
                }

                
                textBox1.Clear();
            }
            catch (Exception ex)
            {
              
                MessageBox.Show($"Error removing user: {ex.Message}");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminRemoveUserMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
