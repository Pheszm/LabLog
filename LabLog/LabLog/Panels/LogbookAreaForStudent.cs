using Google.Protobuf.Reflection;
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

namespace LabLog.Panels
{
    public partial class LogbookAreaForStudent : UserControl
    {
        public LogbookAreaForStudent()
        {
            InitializeComponent();
            WhosLogin.Text = "Student";
            Loadsubjects();
        }

        void Loadsubjects()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(consstring))
                {
                    conn.Open();
                    string query = "SELECT Subjects FROM subjectlist";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string courseName = reader.GetString(0);
                            Purpose.Items.Add(courseName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading courses: " + ex.Message);
            }
        }

        private void Purpose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Purpose.Text == "Others")
            {
                OthersPanel.Visible = true;
            }
            else
            {
                OthersPanel.Visible = false;
            }
        }

        string consstring = Program.MainServerDataBase;

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (StudentID.Text != "" && Purpose.Text != "Others" && Purpose.Text != "")
            {
                LogtheData();
            }
            else if (StudentID.Text != "" && Purpose.Text == "Others" && Reasonn.Text != "")
            {
                LogtheData();            }
            else
            {
                MessageBox.Show("Dont leave the Text Box Empty.", "Authentication", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            void LogtheData()
            {
                try
                {
                    string ID = StudentID.Text;
                    string Purposee = Purpose.Text;
                    string Reason = Reasonn.Text;
                    string TimeIn = DateTime.Now.ToString("hh:mm tt");
                    string ExactDate = DateTime.Now.ToString("dd/MM/yy");

                    string fullName = "Unknown";

                    using (MySqlConnection con = new MySqlConnection(consstring))
                    {
                        con.Open();

                        // Retrieve student name from studentlist database
                        string query = "SELECT StudentName FROM studentlist WHERE StudentID = @ID";

                        using (MySqlCommand cmd = new MySqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@ID", ID);
                            object result = cmd.ExecuteScalar();
                            if (result != null)
                            {
                                fullName = result.ToString();

                                // Inserting data into logbooks database
                                query = "INSERT INTO logbooks (FullName, ID, Purpose, Reason, TimeIn, ExactDate) VALUES (@FullName, @ID, @Purpose, @Reason, @TimeIn, @ExactDate)";
                                using (MySqlCommand insertCmd = new MySqlCommand(query, con))
                                {
                                    insertCmd.Parameters.AddWithValue("@FullName", fullName);
                                    insertCmd.Parameters.AddWithValue("@ID", ID);
                                    insertCmd.Parameters.AddWithValue("@Purpose", Purposee);
                                    insertCmd.Parameters.AddWithValue("@Reason", Reason);
                                    insertCmd.Parameters.AddWithValue("@TimeIn", TimeIn);
                                    insertCmd.Parameters.AddWithValue("@ExactDate", ExactDate);
                                    insertCmd.ExecuteNonQuery();
                                }
                                MessageBox.Show($"Successfully Login as '{fullName}'.", "Login Successful");
                                Program.LoggedIn = true;
                                Program.NameLoggedIn = fullName;
                                Program.Time = 300;

                                Panels.IntroductionPanel Intro = new Panels.IntroductionPanel();
                                this.Controls.Clear();
                                this.Controls.Add(Intro);
                            }
                            else
                            {
                                // Handle the case where ID is not found
                                MessageBox.Show("Student ID not found. Logbook entry not created.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle the error, you can log it or show a message to the user
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            Panels.IntroductionPanel Intro = new Panels.IntroductionPanel();
            this.Controls.Clear();
            this.Controls.Add(Intro);
        }

        private void WhosLogin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(WhosLogin.Text == "Staff")
            {
                Panels.LogbookAreaForStaff staff = new Panels.LogbookAreaForStaff();
                this.Controls.Clear();
                this.Controls.Add(staff);
            }
        }
    }
}
