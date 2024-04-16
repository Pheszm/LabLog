using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mysqlx.Notice.Warning.Types;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace LabLog.Forms
{
    public partial class EditingStudent : Form
    {
        string consstring = Program.MainServerDataBase;
        string StudentID;

        public EditingStudent(string id, string name, string course, string level, string gender)
        {
            InitializeComponent();
            LoadCourses();
            StudentID = id;
            FullNamee.Text = name;
            CourseComboBox.Text = course;
            YearLevel.Text = level;
            GenderComboBox.Text = gender;
        }

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
                MessageBox.Show("An error occurred while loading courses: " + ex.Message);
            }
        }


        private void Save_Click(object sender, EventArgs e)
        {
            if (FullNamee.Text == "" || CourseComboBox.Text == "" || YearLevel.Text == "" || GenderComboBox.Text == "")
            {
                MessageBox.Show("Please Fill-Up each Important Details.", "Attention");
            }
            else
            {
                UpdatingStudent();
            }
        }


        void UpdatingStudent()
        {
            string studentID = StudentID;
            string name = FullNamee.Text;
            string course = CourseComboBox.Text;
            string yearLevel = YearLevel.Text;
            string gender = GenderComboBox.Text;

            try
            {
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
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
