using MySql.Data.MySqlClient;
using Mysqlx.Expr;
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
    public partial class Add_Student : Form
    {
        public Add_Student()
        {
            InitializeComponent();
            loadCourses();
        }

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
                            if(reader.GetInt32(3) == 1)
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

        private void Create_btn_Click(object sender, EventArgs e)
        {
            if (Fullnamebox.Text == "" || Idbox.Text == "" || CourseComboBox.Text == "" || yearlevelbox.Text == "" || sexbox.Text == "" || Statusbox.Text == "")
            {
                MessageBox.Show("Please Fill-Up each Important Details.", "Attention");
            }
            else
            {
                Creating_Instructor();
            }
        }
        string consstring = Program.MainServerDataBase;
        int Indentifierz;

        void Creating_Instructor()
        {
            //try
            //{
                using (MySqlConnection con = new MySqlConnection(consstring))
                {
                    con.Open();

                    string checkIDQuery = "SELECT COUNT(*) FROM students WHERE StudentID = @StudentID";
                    MySqlCommand checkIDCmd = new MySqlCommand(checkIDQuery, con);
                    checkIDCmd.Parameters.AddWithValue("@StudentID", Idbox.Text.ToUpper());
                    int count = Convert.ToInt32(checkIDCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("ID already exists. Please use a different ID.");
                        return;
                    }

                    string sql = "INSERT INTO students (Fullname, StudentID, Course, YearLevel, Sex, Status, Archive_Status) VALUES (@Fullname, @StudentID, @Course, @YearLevel, @Sex, @Status, @Archive_Status)";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@Fullname", Fullnamebox.Text);
                    cmd.Parameters.AddWithValue("@StudentID", Idbox.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@Course", CourseComboBox.Text);
                    cmd.Parameters.AddWithValue("@YearLevel", yearlevelbox.Text);
                    cmd.Parameters.AddWithValue("@Sex", sexbox.Text);
                    cmd.Parameters.AddWithValue("@Status", Statusbox.Text);
                    cmd.Parameters.AddWithValue("@Archive_Status", 0);
                    cmd.ExecuteNonQuery();

                    callthedata();
                }
                this.Close();
            }
            //catch (Exception ex)
            //{
              //  MessageBox.Show("An error occurred: " + ex.Message);
            //}
        //}

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
                cmd2.Parameters.AddWithValue("@Manage", "ADD");
                cmd2.Parameters.AddWithValue("@Manage_By", Program.Instruc_Name);
                cmd2.Parameters.AddWithValue("@Type", "Student");
                cmd2.Parameters.AddWithValue("@Identifier", Indentifierz);

                cmd2.ExecuteNonQuery();
                MessageBox.Show("Student Successfully Created.", "Successful");
            }
        }
        void callthedata()
        {
            string idddd = Idbox.Text;

            string sql1 = "SELECT * FROM students WHERE StudentID = @StudentID";

            using (MySqlConnection con1 = new MySqlConnection(consstring))
            {
                con1.Open();
                MySqlCommand cmd1 = new MySqlCommand(sql1, con1);

                cmd1.Parameters.AddWithValue("@StudentID", idddd);

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

        private void CourseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
