using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AcademicIS
{
    public partial class CreateGroupForm : Form
    {
        
        public class Groups
        {
            public string GroupName { get; set; }

        }
        private MongoClient client;
        private IMongoDatabase database;

        public CreateGroupForm()
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

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void NewGroup_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddGroup_Click(object sender, EventArgs e)
        {
            string group = GroupNew.Text.Trim();
            if (string.IsNullOrEmpty(group))
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            
            var newGroup = new Groups
            {
                GroupName = group,
            };

            try
            {
                
                var groupsCollection = database.GetCollection<Groups>("Groups");

                
                groupsCollection.InsertOne(newGroup);

                
                MessageBox.Show("Group added successfully!");

                // Clear the textboxes after adding the grade
                GroupNew.Clear();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"Error adding grade: {ex.Message}");
            }
        }

        private void CreateGroupForm_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


