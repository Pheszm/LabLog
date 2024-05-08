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

namespace LABLOG.Instructor_Panels
{
    public partial class Student_List : UserControl
    {
        public Student_List()
        {
            InitializeComponent();
            LoopFunction();
            DataGridView1.CellClick += DataGrid_CellClick; // Attach event handler
            DataGridView1.ClearSelection();
            LoadCourses();
            refreshTable();
        }

        private void LoadCourses()
        {
            try
            {
                Yearcbox.Text = "none";
                Coursecbx.Text = "none";
                Gendercbox.Text = "none";

                using (MySqlConnection conn = new MySqlConnection(consstring))
                {
                    conn.Open();
                    string query = "SELECT * FROM Courses";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader.GetInt32(3) == 1)
                            {
                                string courseName = reader.GetString(1);
                                Coursecbx.Items.Add(courseName);
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


        private void LoopFunction()
        {
            Timer timer1 = new Timer();
            timer1.Interval = 1;
            timer1.Enabled = true;
            timer1.Tick += Timer1_Tick;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.Size = Program.Main_Form_Size;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Log-out?", "Confirming Log-out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Panels.Start_Menu intro = new Panels.Start_Menu();
                this.Controls.Clear();
                this.Controls.Add(intro);
            }
        }


        private void StudentList_btn_Click(object sender, EventArgs e)
        {
            Instructor_Panels.Student_List listup = new Instructor_Panels.Student_List();
            this.Controls.Clear();
            this.Controls.Add(listup);
        }
        private void SubjectList_btn_Click(object sender, EventArgs e)
        {
            Instructor_Panels.Subject_List listup = new Instructor_Panels.Subject_List();
            this.Controls.Clear();
            this.Controls.Add(listup);
        }
        private void DownloadReports_btn_Click(object sender, EventArgs e)
        {
            Instructor_Panels.Download_Reports listup = new Instructor_Panels.Download_Reports();
            this.Controls.Clear();
            this.Controls.Add(listup);
        }
        private void Home_btn_Click(object sender, EventArgs e)
        {
            Panels.Instructor_Home listup = new Panels.Instructor_Home();
            this.Controls.Clear();
            this.Controls.Add(listup);
        }

        private void course_list_btn_Click(object sender, EventArgs e)
        {
            Instructor_Panels.Course_List listup = new Instructor_Panels.Course_List();
            this.Controls.Clear();
            this.Controls.Add(listup);
        }

        void FilterButtonCheck()
        {
            if (Yearcbox.Text != "none" || Coursecbx.Text != "none" || Gendercbox.Text != "none")
            {
                reset_btn.Visible = true;
            }
            else
            {
                reset_btn.Visible = false;
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            Instructor_Forms.Add_Student add = new Instructor_Forms.Add_Student();
            add.ShowDialog();
            refreshTable();
        }

        string consstring = Program.MainServerDataBase;


        void refreshTable()
        {
            DataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 255);

            label1.Visible = true;

            RemoveButton.Visible = false;
            EditButton.Visible = false;
            try
            {
                DataGridView1.Rows.Clear();

                string yearLevel = Yearcbox.Text;
                string course = Coursecbx.Text;
                string gender = Gendercbox.Text;

                string sql = "SELECT * FROM Students";

                if (!string.IsNullOrEmpty(yearLevel) || !string.IsNullOrEmpty(course) || !string.IsNullOrEmpty(gender))
                {
                    sql += " WHERE 1=1";

                    if (!string.IsNullOrEmpty(yearLevel) && yearLevel != "none")
                        sql += $" AND YearLevel = '{yearLevel}'";

                    if (!string.IsNullOrEmpty(course) && course != "none")
                        sql += $" AND Course = '{course}'";

                    if (!string.IsNullOrEmpty(gender) && gender != "none")
                        sql += $" AND Sex = '{gender}'";
                }

                List<string[]> rowData = new List<string[]>(); // Store rows data

                using (MySqlConnection con = new MySqlConnection(consstring))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int archive_stat = reader.GetInt32(7);
                            if (archive_stat == 0)
                            {
                                    // Store each row's data in rowData list
                                    rowData.Add(new string[]
                                {
                            reader["Fullname"].ToString(),
                            reader["StudentID"].ToString(),
                            reader["Course"].ToString(),
                            reader["YearLevel"].ToString(),
                            reader["Sex"].ToString(),
                            reader["Status"].ToString()
                                });
                            }
                        }
                    }
                }

                // Sort the rowData list based on the first letter of the student's name
                rowData.Sort((x, y) => x[0][0].CompareTo(y[0][0]));

                // Add sorted rows to DataGrid
                foreach (string[] row in rowData)
                {
                    DataGridView1.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during refreshing the table
                MessageBox.Show("An error occurred while refreshing the table: " + ex.Message);
            }
        }
        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int overallRow = DataGridView1.RowCount;
            if (e.RowIndex >= 0 && e.RowIndex <= overallRow - 2)
            {
                DataGridViewRow selectedRow = DataGridView1.Rows[e.RowIndex];
                Stored_ID = selectedRow.Cells["StuIDTable"].Value.ToString();
            }
            DataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(47, 118, 200);
            label1.Visible = false;
            RemoveButton.Visible = true;
            EditButton.Visible = true;
        }

        string Stored_ID;
        int Identifier;

        private void Coursecbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterButtonCheck();
            refreshTable();
        }

        private void Gendercbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterButtonCheck();
            refreshTable();
        }

        private void Yearcbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterButtonCheck();
            refreshTable();
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            Yearcbox.Text = "none";
            Coursecbx.Text = "none";
            Gendercbox.Text = "none";
            FilterButtonCheck();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to delete '{Stored_ID}' from the record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    //Set Archive_Status to 1
                    using (MySqlConnection con = new MySqlConnection(consstring))
                    {
                        con.Open();

                        string sql = "UPDATE Students SET Archive_Status = @Archive_Status, Status = @Status WHERE StudentID = @Stored_ID";
                        MySqlCommand cmd = new MySqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@Stored_ID", Stored_ID);
                        cmd.Parameters.AddWithValue("@Status", 0);
                        cmd.Parameters.AddWithValue("@Archive_Status", 1);
                        int rowsAffected = cmd.ExecuteNonQuery();

                    }

                    //Get Identifier
                    string sql1 = "SELECT * FROM Students WHERE StudentID = @StudentID";

                    using (MySqlConnection con = new MySqlConnection(consstring))
                    {
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand(sql1, con);

                        cmd.Parameters.AddWithValue("@StudentID", Stored_ID);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Identifier = reader.GetInt32(0);
                            }
                        }
                    }

                    //Add The Manipulation to the History
                    using (MySqlConnection con = new MySqlConnection(consstring))
                    {
                        con.Open();
                        DateTime now = DateTime.Now;
                        string formattedDateTime = now.ToString("h:mm tt dd-MM-yy");

                        string sql = "INSERT INTO History (Datetime, Manage_By, Manage, Type, Identifier) VALUES (@Datetime, @Manage_By, @Manage, @Type, @Identifier)";
                        MySqlCommand cmd = new MySqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@Datetime", formattedDateTime);
                        cmd.Parameters.AddWithValue("@Manage", "REMOVE");
                        cmd.Parameters.AddWithValue("@Manage_By", Program.Instruc_Name);
                        cmd.Parameters.AddWithValue("@Type", "Student");
                        cmd.Parameters.AddWithValue("@Identifier", Identifier);

                        cmd.ExecuteNonQuery();
                    }

                    //Add The Remove to Archive
                    using (MySqlConnection con = new MySqlConnection(consstring))
                    {
                        con.Open();
                        DateTime now = DateTime.Now;
                        string formattedDateTime = now.ToString("h:mm tt dd-MM-yy");

                        string sql = "INSERT INTO Archives (Date_Removed, Removed_By, Type, Identifier) VALUES (@Date_Removed, @Removed_By, @Type, @Identifier)";
                        MySqlCommand cmd = new MySqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@Date_Removed", formattedDateTime);
                        cmd.Parameters.AddWithValue("@Removed_By", Program.Instruc_Name);
                        cmd.Parameters.AddWithValue("@Type", "Student");
                        cmd.Parameters.AddWithValue("@Identifier", Identifier);

                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Successfully Removed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            refreshTable();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Instructor_Forms.Update_Student update = new Instructor_Forms.Update_Student(Stored_ID);
            update.ShowDialog();
            refreshTable();
        }
    }
}
