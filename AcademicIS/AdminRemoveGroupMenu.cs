using MongoDB.Driver;
using System;
using System.Windows.Forms;

namespace AcademicIS
{
    public partial class RemoveGroupForm : Form
    {
        public class Group
        {
            public string GroupName { get; set; }
        }

        private MongoClient client;
        private IMongoDatabase database;

        public RemoveGroupForm()
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

        private void button2_Click(object sender, EventArgs e)
        {
            
            string group = textBox2.Text.Trim();

            
            if (string.IsNullOrEmpty(group))
            {
                MessageBox.Show("Please enter a group name.");
                return;
            }

            try
            {
                // Get the Groups collection from the database
                var groupsCollection = database.GetCollection<Group>("Groups");

                // Construct a filter to find the group by its name
                var groupFilter = Builders<Group>.Filter.Eq(u => u.GroupName, group);

                // Check if the group exists first before attempting to delete
                var groupExists = groupsCollection.Find(groupFilter).Any();

                if (!groupExists)
                {
                    MessageBox.Show("No group found with the specified details.");
                    return;
                }

                
                var deleteResult = groupsCollection.DeleteOne(groupFilter);

                // Check if a document was deleted
                if (deleteResult.DeletedCount > 0)
                {
                    MessageBox.Show("Group removed successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to remove the group. Please try again.");
                }

                
                textBox1.Clear();
            }
            catch (Exception ex)
            {
               
                MessageBox.Show($"Error removing group: {ex.Message}");
            }
        }

        private void RemoveGroupForm_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

