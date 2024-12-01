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
    public partial class RLectureForm : Form
    {
        public class Lecture
        {
            public string LectureName { get; set; }
        }

        private MongoClient client;
        private IMongoDatabase database;

        public RLectureForm()
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            string lecture = textBox1.Text.Trim();

          
            if (string.IsNullOrEmpty(lecture))
            {
                MessageBox.Show("Please enter a lecture name.");
                return;
            }

            try
            {
                // Get the Groups collection from the database
                var LecturesCollection = database.GetCollection<Lecture>("Lectures");

                // Construct a filter to find the group by its name
                var lectureFilter = Builders<Lecture>.Filter.Eq(u => u.LectureName, lecture);

                // Check if the group exists first before attempting to delete
                var lectureExists = LecturesCollection.Find(lectureFilter).Any();

                if (!lectureExists)
                {
                    MessageBox.Show("No lecture found with the specified details.");
                    return;
                }

                // Proceed to delete the group
                var deleteResult = LecturesCollection.DeleteOne(lectureFilter);

                // Check if a document was deleted
                if (deleteResult.DeletedCount > 0)
                {
                    MessageBox.Show("Lecture removed successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to remove the lecture. Please try again.");
                }

                
                textBox1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error removing lecture: {ex.Message}");
            }

        }

        private void RLectureForm_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
