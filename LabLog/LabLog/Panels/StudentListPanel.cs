using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LabLog.Panels
{
    public partial class StudentListPanel : UserControl
    {
        public StudentListPanel()
        {
            InitializeComponent();
            refreshTable();
            DataGrid.CellClick += DataGrid_CellClick; // Attach event handler
            LoadCourses();
        }

        string consstring = Program.MainServerDataBase;

        //Select from the Table will store in this string:
        string SelectStuID, SelectName, SelectCourse, SelectYearLevel, SelectGender;


        private void YearLevelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshTable();
        }

        private void LoadCourses()
        {
            try
            {
                YearLevelComboBox.Text = "none";
                CourseComboBox.Text = "none";
                GenderComboBox.Text = "none";

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
                // Handle any exceptions that occur during loading courses
                MessageBox.Show("An error occurred while loading courses: " + ex.Message);
            }
        }

        private void CourseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshTable();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Panels.InstructorsMenu Homeee = new Panels.InstructorsMenu();
            this.Controls.Clear();
            this.Controls.Add(Homeee);
        }

        private void SubjectListButton_Click(object sender, EventArgs e)
        {
            Panels.SubjectListPanel SubjectListt = new Panels.SubjectListPanel();
            this.Controls.Clear();
            this.Controls.Add(SubjectListt);
        }

        private void DownloadReportsButton_Click(object sender, EventArgs e)
        {
            Panels.DownloadReportsPanel DownloaddReportss = new Panels.DownloadReportsPanel();
            this.Controls.Clear();
            this.Controls.Add(DownloaddReportss);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Log-out?", "Confirming Log-out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Panels.IntroductionPanel intro = new Panels.IntroductionPanel();
                this.Controls.Clear();
                this.Controls.Add(intro);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Forms.AddStudent addStudent = new Forms.AddStudent();
            addStudent.ShowDialog();
            refreshTable();
        }

        private void GenderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshTable();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Forms.EditingStudent EdittStudent = new Forms.EditingStudent(SelectStuID, SelectName, SelectCourse, SelectYearLevel, SelectGender);
            EdittStudent.ShowDialog();
            refreshTable();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to delete '{SelectName}' from the record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (MySqlConnection con = new MySqlConnection(consstring))
                    {
                        con.Open();
                        string sql = "DELETE FROM studentlist WHERE StudentID = @studentID";
                        MySqlCommand cmd = new MySqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@studentID", SelectStuID);
                        cmd.ExecuteNonQuery();
                    }

                }
                refreshTable();
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during removing a student
                MessageBox.Show("An error occurred while removing a student: " + ex.Message);
            }
        }


        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int overallRow = DataGrid.RowCount; //Prevent Selecting the Empty at the Last
            if (e.RowIndex >= 0 && e.RowIndex <= overallRow - 2)
            {
                DataGridViewRow selectedRow = DataGrid.Rows[e.RowIndex];
                SelectStuID = selectedRow.Cells["StuIDTable"].Value.ToString();
                SelectName = selectedRow.Cells["StuNameTable"].Value.ToString();
                SelectCourse = selectedRow.Cells["StuCourseTable"].Value.ToString();
                SelectYearLevel = selectedRow.Cells["StuYearLevelTable"].Value.ToString();
                SelectGender = selectedRow.Cells["StuGenderTable"].Value.ToString();
            }
            RemoveButton.Visible = true;
            EditButton.Visible = true;
        }

        void refreshTable()
        {
            try
            {
                DataGrid.Rows.Clear();

                string yearLevel = YearLevelComboBox.Text;
                string course = CourseComboBox.Text;
                string gender = GenderComboBox.Text;

                string sql = "SELECT * FROM studentlist";

                if (!string.IsNullOrEmpty(yearLevel) || !string.IsNullOrEmpty(course) || !string.IsNullOrEmpty(gender))
                {
                    sql += " WHERE 1=1";

                    if (!string.IsNullOrEmpty(yearLevel) && yearLevel != "none")
                        sql += $" AND YearLevel = '{yearLevel}'";

                    if (!string.IsNullOrEmpty(course) && course != "none")
                        sql += $" AND Course = '{course}'";

                    if (!string.IsNullOrEmpty(gender) && gender != "none")
                        sql += $" AND Gender = '{gender}'";
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
                            // Store each row's data in rowData list
                            rowData.Add(new string[]
                            {
                        reader["StudentName"].ToString(),
                        reader["StudentID"].ToString(),
                        reader["Course"].ToString(),
                        reader["YearLevel"].ToString(),
                        reader["Gender"].ToString()
                            });
                        }
                    }
                }

                // Sort the rowData list based on the first letter of the student's name
                rowData.Sort((x, y) => x[0][0].CompareTo(y[0][0]));

                // Add sorted rows to DataGrid
                foreach (string[] row in rowData)
                {
                    DataGrid.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during refreshing the table
                MessageBox.Show("An error occurred while refreshing the table: " + ex.Message);
            }
        }
    }
}

