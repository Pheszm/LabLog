using MySql.Data.MySqlClient;
using Mysqlx.Expr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABLOG.Instructor_Panels.Instructor_Forms
{
    public partial class Update_Course : Form
    {
        public Update_Course(string Course)
        {
            InitializeComponent();
            old_Course = Course;
            load_information(Course);
        }
        string old_Course;
        string consstring = Program.MainServerDataBase;

        void load_information(string Course)
        {
            string sql = "SELECT * FROM Courses WHERE Course = @Course";

            using (MySqlConnection con = new MySqlConnection(consstring))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@Course", Course);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        coursebox.Text = reader.GetString(1);
                        titlebox.Text = reader.GetString(2);
                        Statusbox.Text = reader.GetInt32(3).ToString();
                    }
                }
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (coursebox.Text == "" || titlebox.Text == "" || Statusbox.Text == "")
            {
                MessageBox.Show("Please Fill-Up each Important Details.", "Attention");
            }
            else
            {
                Updating_Course();
            }
        }

        void Updating_Course()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(consstring))
                {
                    con.Open();

                    string checkExistenceQuery = "SELECT COUNT(*) FROM Courses WHERE Course = @Course";
                    MySqlCommand checkExistenceCmd = new MySqlCommand(checkExistenceQuery, con);
                    checkExistenceCmd.Parameters.AddWithValue("@Course", coursebox.Text);
                    int existingRecordsCount = Convert.ToInt32(checkExistenceCmd.ExecuteScalar());

                    if (existingRecordsCount > 0 && coursebox.Text.ToUpper() != old_Course)
                    {
                        MessageBox.Show("Course already exists. Cannot update record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string sql = "UPDATE Courses SET Course = @Course, Title = @Title, Status = @Status WHERE Course = @OldCourse";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@Course", coursebox.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@Title", titlebox.Text);
                    cmd.Parameters.AddWithValue("@Status", Statusbox.Text);
                    cmd.Parameters.AddWithValue("@OldCourse", old_Course);
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
                cmd2.Parameters.AddWithValue("@Type", "Course");
                cmd2.Parameters.AddWithValue("@Identifier", Indentifierz);

                cmd2.ExecuteNonQuery();
            }
        }
        int Indentifierz;
        void callthedata()
        {
            string courzee = coursebox.Text;

            string sql1 = "SELECT * FROM Courses WHERE Course = @Course";

            using (MySqlConnection con1 = new MySqlConnection(consstring))
            {
                con1.Open();
                MySqlCommand cmd1 = new MySqlCommand(sql1, con1);

                cmd1.Parameters.AddWithValue("@Course", courzee);

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
