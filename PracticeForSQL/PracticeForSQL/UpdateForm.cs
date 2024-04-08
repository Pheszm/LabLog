using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PracticeForSQL
{
    public partial class UpdateForm : Form
    {
        string consstring = "server=localhost;uid=root;pwd=123456;database=sqlandcsharp";
        string StudentID;
        public UpdateForm(string id, string name, string course, string level, string gender)
        {
            InitializeComponent();
            StudentID = id;
            StuName.Text = name;
            StuCourse.Text = course;
            StuYearLevel.Text = level;
            StuGender.Text = gender;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string studentID = StudentID;
            string name = StuName.Text;
            string course = StuCourse.Text;
            string yearLevel = StuYearLevel.Text;
            string gender = StuGender.Text;

            using (MySqlConnection con = new MySqlConnection(consstring))
            {
                con.Open();
                string sql = "UPDATE studentlist SET StudentName = @name, Course = @course, YearLevel = @yearLevel, Gender = @gender WHERE StudentID = @studentID";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@course", course);
                cmd.Parameters.AddWithValue("@yearLevel", yearLevel);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@studentID", studentID);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No records were updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            this.Close(); // Close the form after updating the record
        }
    }

}

