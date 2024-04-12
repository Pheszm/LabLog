using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabLog.Forms
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
            LoadCourses();
        }

        string consstring = Program.MainServerDataBase;


        private void LoadCourses()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(consstring))
                {
                    conn.Open();
                    string query = "SELECT course FROM courselist";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string courseName = reader.GetString(0);
                            CourseComboBox.Items.Add(courseName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during loading courses
                MessageBox.Show("An error occurred while loading courses: " + ex.Message);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(consstring))
                {
                    con.Open();
                    string sql = "INSERT INTO studentlist (StudentID, StudentName, Course, YearLevel, Gender) VALUES (@StudentID, @StudentName, @Course, @YearLevel, @Gender)";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@StudentID", StudentID.Text);
                    cmd.Parameters.AddWithValue("@StudentName", $"{FirstName.Text} {MiddleInitialComboBox.Text}. {LastName.Text}");
                    cmd.Parameters.AddWithValue("@Course", CourseComboBox.Text);
                    cmd.Parameters.AddWithValue("@YearLevel", YearLevel.Text);
                    cmd.Parameters.AddWithValue("@Gender", GenderComboBox.Text);
                    cmd.ExecuteNonQuery();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during adding a student
                MessageBox.Show("An error occurred while adding a student: " + ex.Message);
            }
        }

    }
}

