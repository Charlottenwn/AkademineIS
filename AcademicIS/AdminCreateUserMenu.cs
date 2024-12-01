using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AcademicIS
{
    public partial class CreateUserForm : Form
    {
        
        public class Users
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public string Role { get; set; }
        }

        private MongoClient client;
        private IMongoDatabase database;

        public CreateUserForm()
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

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();
            string role = textBox3.Text.Trim();

            // Validate that all fields are filled out
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            
            var newUser = new Users
            {
                Username = username,
                Password = password,
                Role = role
            };

            try
            {
                // Get the database and the User collection
                var nameCollection = database.GetCollection<Users>("Users");

                // Insert the new user into the database
                nameCollection.InsertOne(newUser);

                
                MessageBox.Show("User added successfully!");

                
                textBox1.Clear();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"Error adding grade: {ex.Message}");
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
