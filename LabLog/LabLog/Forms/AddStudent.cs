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


        private void AddButton_Click(object sender, EventArgs e)
        {
            if(StudentID.Text == "" || FirstName.Text == "" || LastName.Text == "" || CourseComboBox.Text == "" ||
                YearLevel.Text == "" || GenderComboBox.Text == "")
            {
                MessageBox.Show("Please Fill-Up each Important Details.", "Attention");
            }
            else
            {
                addingStudent();
            }
        }

        void LoadCourses()
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
                MessageBox.Show("An error occurred while loading courses: " + ex.Message);
            }
        }

        void addingStudent()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(consstring))
                {
                    con.Open();

                    // Check if the student ID already exists
                    string checkIDQuery = "SELECT COUNT(*) FROM studentlist WHERE StudentID = @StudentID";
                    MySqlCommand checkIDCmd = new MySqlCommand(checkIDQuery, con);
                    checkIDCmd.Parameters.AddWithValue("@StudentID", StudentID.Text);
                    int count = Convert.ToInt32(checkIDCmd.ExecuteScalar());

                    // If the count is greater than 0, it means the ID already exists
                    if (count > 0)
                    {
                        MessageBox.Show("Student ID already exists. Please use a different ID.");
                        return; // Exit the method without adding the student
                    }

                    // If the ID doesn't exist, proceed to insert the new student
                    string sql = "INSERT INTO studentlist (StudentID, StudentName, Course, YearLevel, Gender) VALUES (@StudentID, @StudentName, @Course, @YearLevel, @Gender)";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@StudentID", StudentID.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@StudentName", $"{FirstName.Text} {MiddleInitialComboBox.Text}. {LastName.Text}");
                    cmd.Parameters.AddWithValue("@Course", CourseComboBox.Text);
                    cmd.Parameters.AddWithValue("@YearLevel", YearLevel.Text);
                    cmd.Parameters.AddWithValue("@Gender", GenderComboBox.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Successfully added.", "Successful");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding a student: " + ex.Message);
            }
        }


    }
}

