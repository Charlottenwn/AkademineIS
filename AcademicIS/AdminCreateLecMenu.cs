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
    public partial class CreateLF : Form
    {
       
        public class Lectures
        {
            public string Lecture { get; set; }

        }

        private MongoClient client;
        private IMongoDatabase database;

        public CreateLF()
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
            
            string lecture = textBox1.Text.Trim();

            
            if (string.IsNullOrEmpty(lecture))
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            
            var newLecture = new Lectures
            {
                Lecture = lecture
            };

            try
            {
                
                var lecturesCollection = database.GetCollection<Lectures>("Lectures");

                
                lecturesCollection.InsertOne(newLecture);

                
                MessageBox.Show("Lecture added successfully!");

                
                textBox1.Clear();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"Error adding grade: {ex.Message}");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateLF_Load(object sender, EventArgs e)
        {

        }
    }
}
