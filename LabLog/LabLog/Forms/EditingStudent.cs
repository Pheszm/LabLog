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
            StuIDtxt.Text = id;
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
            try
            {
                using (MySqlConnection con = new MySqlConnection(consstring))
                {
                    con.Open();

                    // Check if the new StudentID already exists
                    string checkExistenceQuery = "SELECT COUNT(*) FROM studentlist WHERE StudentID = @newId";
                    MySqlCommand checkExistenceCmd = new MySqlCommand(checkExistenceQuery, con);
                    checkExistenceCmd.Parameters.AddWithValue("@newId", StuIDtxt.Text);
                    int existingRecordsCount = Convert.ToInt32(checkExistenceCmd.ExecuteScalar());

                    if (existingRecordsCount > 0 && StuIDtxt.Text.ToUpper() != StudentID)
                    {
                        MessageBox.Show("StudentID already exists. Cannot update record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method without proceeding further
                    }

                    // If StudentID doesn't exist, proceed with update
                    string sql = "UPDATE studentlist SET StudentID = @newId, StudentName = @name, Course = @course, YearLevel = @yearLevel, Gender = @gender WHERE StudentID = @studentID";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@newId", StuIDtxt.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@name", FullNamee.Text);
                    cmd.Parameters.AddWithValue("@course", CourseComboBox.Text);
                    cmd.Parameters.AddWithValue("@yearLevel", YearLevel.Text);
                    cmd.Parameters.AddWithValue("@gender", GenderComboBox.Text);
                    cmd.Parameters.AddWithValue("@studentID", StudentID);
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
