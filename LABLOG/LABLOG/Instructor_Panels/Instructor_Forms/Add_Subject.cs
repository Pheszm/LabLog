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
    public partial class Add_Subject : Form
    {
        public Add_Subject()
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


        private void Create_btn_Click(object sender, EventArgs e)
        {
            if (CourseComboBox.Text == "" || codebox.Text == "" || titlebox.Text == "" || Statusbox.Text == "")
            {
                MessageBox.Show("Please Fill-Up each Important Details.", "Attention");
            }
            else
            {
                Creating_Subject();
            }
        }

        string consstring = Program.MainServerDataBase;

        int Identifier;
        void Creating_Subject()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(consstring))
                {
                    con.Open();

                    string checkIDQuery = "SELECT COUNT(*) FROM Subjects WHERE Code = @Code";
                    MySqlCommand checkIDCmd = new MySqlCommand(checkIDQuery, con);
                    checkIDCmd.Parameters.AddWithValue("@Code", codebox.Text.ToUpper());
                    int count = Convert.ToInt32(checkIDCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Code already exists. Please use a different Code.");
                        return;
                    }

                    string sql = "INSERT INTO Subjects (Course, Code, Title, Status) VALUES (@Course, @Code, @Title, @Status)";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@Course", CourseComboBox.Text);
                    cmd.Parameters.AddWithValue("@Code", codebox.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@Title", titlebox.Text);
                    cmd.Parameters.AddWithValue("@Status", Statusbox.Text);
                    cmd.ExecuteNonQuery();
                }
                string Coourse = codebox.Text.ToUpper();

                string sql1 = "SELECT * FROM Subjects WHERE Code = @Code";

                using (MySqlConnection con = new MySqlConnection(consstring))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(sql1, con);

                    cmd.Parameters.AddWithValue("@Code", Coourse);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Identifier = reader.GetInt32(0);
                        }
                    }
                }

                using (MySqlConnection con = new MySqlConnection(consstring))
                {
                    con.Open();
                    DateTime now = DateTime.Now;
                    string formattedDateTime = now.ToString("h:mm tt dd-MM-yy");

                    string sql = "INSERT INTO History (Datetime, Manage_By, Manage, Type, Identifier) VALUES (@Datetime, @Manage_By, @Manage, @Type, @Identifier)";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@Datetime", formattedDateTime);
                    cmd.Parameters.AddWithValue("@Manage", "ADD");
                    cmd.Parameters.AddWithValue("@Manage_By", Program.Instruc_Name);
                    cmd.Parameters.AddWithValue("@Type", "Subject");
                    cmd.Parameters.AddWithValue("@Identifier", Identifier);

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Subject Successfully Added.", "Successful");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
