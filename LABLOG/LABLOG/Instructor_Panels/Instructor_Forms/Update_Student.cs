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

namespace LABLOG.Instructor_Panels.Instructor_Forms
{
    public partial class Update_Student : Form
    {
        public Update_Student(string Stu_ID)
        {
            InitializeComponent();
            oldID = Stu_ID;
            loadCourses();
            load_information(Stu_ID);
        }
        string oldID;

        string consstring = Program.MainServerDataBase;


        void loadCourses()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(consstring))
                {
                    conn.Open();
                    string query = "SELECT * FROM courses";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader.GetInt32(3) == 1)
                            {
                                string courseName = reader.GetString(1);
                                CourseComboBox.Items.Add(courseName);
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading courses: " + ex.Message);
            }
        }


        void load_information(string StuID)
        {
            string sql = "SELECT * FROM Students WHERE StudentID = @StudentID";

            using (MySqlConnection con = new MySqlConnection(consstring))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@StudentID", StuID);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Fullnamebox.Text = reader.GetString(1);
                        Idbox.Text = reader.GetString(2);
                        CourseComboBox.Text = reader.GetString(3);
                        yearlevelbox.Text = reader.GetString(4);
                        sexbox.Text = reader.GetString(5);
                        Statusbox.Text = reader.GetInt32(6).ToString();
                    }
                }
            }
        }

        private void Create_btn_Click(object sender, EventArgs e)
        {
            if (Fullnamebox.Text == "" || Idbox.Text == "" || CourseComboBox.Text == "" || yearlevelbox.Text == "" || sexbox.Text == "" || Statusbox.Text == "")
            {
                MessageBox.Show("Please Fill-Up each Important Details.", "Attention");
            }
            else
            {
                Updating_Student();
            }
        }

        void Updating_Student()
        {
          try
            {
                using (MySqlConnection con = new MySqlConnection(consstring))
                {
                    con.Open();

                    string checkExistenceQuery = "SELECT COUNT(*) FROM Students WHERE StudentID = @StudentID";
                    MySqlCommand checkExistenceCmd = new MySqlCommand(checkExistenceQuery, con);
                    checkExistenceCmd.Parameters.AddWithValue("@StudentID", Idbox.Text);
                    int existingRecordsCount = Convert.ToInt32(checkExistenceCmd.ExecuteScalar());

                    if (existingRecordsCount > 0 && Idbox.Text.ToUpper() != oldID)
                    {
                        MessageBox.Show("Student already exists. Cannot update record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string sql = "UPDATE Students SET StudentID = @StudentID, Fullname = @Fullname, Course = @Course, YearLevel = @YearLevel, Sex = @Sex, Status = @Status WHERE StudentID = @oldID";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@StudentID", Idbox.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@Fullname", Fullnamebox.Text);
                    cmd.Parameters.AddWithValue("@Course", CourseComboBox.Text);
                    cmd.Parameters.AddWithValue("@YearLevel", yearlevelbox.Text);
                    cmd.Parameters.AddWithValue("@Sex", sexbox.Text);
                    cmd.Parameters.AddWithValue("@Status", Statusbox.Text);
                    cmd.Parameters.AddWithValue("@oldID", oldID);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    callthedata();

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

        void addToHistory()
        {
            using (MySqlConnection con2 = new MySqlConnection(consstring))
            {
                con2.Open();
                DateTime now = DateTime.Now;
                string formattedDateTime = now.ToString("h:mm tt dd-MM-yy");

                string sql2 = "INSERT INTO History (Datetime, Manage, Manage_By, Type, Identifier) VALUES (@Datetime, @Manage, @Manage_By, @Type, @Identifier)";
                MySqlCommand cmd2 = new MySqlCommand(sql2, con2);
                cmd2.Parameters.AddWithValue("@Datetime", formattedDateTime);
                cmd2.Parameters.AddWithValue("@Manage", "UPDATE");
                cmd2.Parameters.AddWithValue("@Manage_By", Program.Instruc_Name);
                cmd2.Parameters.AddWithValue("@Type", "Student");
                cmd2.Parameters.AddWithValue("@Identifier", Indentifierz);

                cmd2.ExecuteNonQuery();
            }
        }
        int Indentifierz;
        void callthedata()
        {
            string old_ID = oldID;

            string sql1 = "SELECT * FROM Students WHERE StudentID = @StudentID";

            using (MySqlConnection con1 = new MySqlConnection(consstring))
            {
                con1.Open();
                MySqlCommand cmd1 = new MySqlCommand(sql1, con1);

                cmd1.Parameters.AddWithValue("@StudentID", old_ID);

                using (MySqlDataReader reader = cmd1.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Indentifierz = reader.GetInt32(0);
                    }
                }
                addToHistory();
            }
        }
    }
}
