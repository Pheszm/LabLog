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
    public partial class Add_Course : Form
    {
        public Add_Course()
        {
            InitializeComponent();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (coursebox.Text == "" || titlebox.Text == "" || Statusbox.Text == "")
            {
                MessageBox.Show("Please Fill-Up each Important Details.", "Attention");
            }
            else
            {
                Creating_Course();
            }
        }
        string consstring = Program.MainServerDataBase;

        int Identifier;
        void Creating_Course()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(consstring))
                {
                    con.Open();

                    string checkIDQuery = "SELECT COUNT(*) FROM Courses WHERE Course = @Course";
                    MySqlCommand checkIDCmd = new MySqlCommand(checkIDQuery, con);
                    checkIDCmd.Parameters.AddWithValue("@Course", coursebox.Text.ToUpper());
                    int count = Convert.ToInt32(checkIDCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Course already exists. Please use a different Course.");
                        return;
                    }

                    string sql = "INSERT INTO Courses (Course, Title, Status) VALUES (@Course, @Title, @Status)";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@Course", coursebox.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@Title", titlebox.Text);
                    cmd.Parameters.AddWithValue("@Status", Statusbox.Text);

                    cmd.ExecuteNonQuery();
                }
                string Coourse = coursebox.Text.ToUpper();

                string sql1 = "SELECT * FROM Courses WHERE Course = @Course";

                using (MySqlConnection con = new MySqlConnection(consstring))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(sql1, con);

                    cmd.Parameters.AddWithValue("@Course", Coourse);

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
                    cmd.Parameters.AddWithValue("@Type", "Course");
                    cmd.Parameters.AddWithValue("@Identifier", Identifier);

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Course Successfully Added.", "Successful");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
