using LABLOG.Instructor_Panels.Instructor_Forms;
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
using System.Xml.Linq;

namespace LABLOG.Instructor_Panels
{
    public partial class Course_List : UserControl
    {
        public Course_List()
        {
            InitializeComponent();
            LoopFunction();
            refreshTable();
            DataGridView1.CellClick += DataGrid_CellClick; // Attach event handler
            DataGridView1.ClearSelection();
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

        private void add_btn_Click(object sender, EventArgs e)
        {
            Instructor_Forms.Add_Course add = new Instructor_Forms.Add_Course();
            add.ShowDialog();
            refreshTable();
        }


        string Stored_Course;
        string consstring = Program.MainServerDataBase;


        void refreshTable()
        {
            label1.Visible = true;
            remove_btn.Visible = false;
            edit_btn.Visible = false;
            DataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 255);
            try
            {
                DataGridView1.Rows.Clear();

                string sql = "SELECT * FROM Courses";

                List<string[]> rowData = new List<string[]>();

                using (MySqlConnection con = new MySqlConnection(consstring))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int archive_stat = reader.GetInt32(4);
                            if (archive_stat == 0)
                            {
                                rowData.Add(new string[]
                                {
                        reader["Course"].ToString(),
                        reader["Title"].ToString(),
                        reader["Status"].ToString(),
                                });
                            }

                        }
                    }
                }

                rowData.Sort((x, y) => x[0][0].CompareTo(y[0][0]));

                foreach (string[] row in rowData)
                {
                    DataGridView1.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while refreshing the table: " + ex.Message);
            }
        }
        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int overallRow = DataGridView1.RowCount;
            if (e.RowIndex >= 0 && e.RowIndex <= overallRow - 2)
            {
                DataGridViewRow selectedRow = DataGridView1.Rows[e.RowIndex];
                Stored_Course = selectedRow.Cells["Course"].Value.ToString();
            }
            DataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(47, 118, 200);
            label1.Visible = false;
            remove_btn.Visible = true;
            edit_btn.Visible = true;
        }


        int Identifier;
        private void remove_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to delete '{Stored_Course}' from the record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    //Set Archive_Status to 1
                    using (MySqlConnection con = new MySqlConnection(consstring))
                    {
                        con.Open();

                        string sql = "UPDATE Courses SET Archive_Status = @Archive_Status, Status = @Status WHERE Course = @Stored_Course";
                        MySqlCommand cmd = new MySqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@Stored_Course", Stored_Course);
                        cmd.Parameters.AddWithValue("@Status", 0);
                        cmd.Parameters.AddWithValue("@Archive_Status", 1);
                        int rowsAffected = cmd.ExecuteNonQuery();

                    }

                    //Get Identifier
                    string sql1 = "SELECT * FROM Courses WHERE Course = @Course";

                    using (MySqlConnection con = new MySqlConnection(consstring))
                    {
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand(sql1, con);

                        cmd.Parameters.AddWithValue("@Course", Stored_Course);

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
                        cmd.Parameters.AddWithValue("@Type", "Course");
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
                        cmd.Parameters.AddWithValue("@Type", "Course");
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

        private void edit_btn_Click(object sender, EventArgs e)
        {
            Update_Course add = new Update_Course(Stored_Course);
            add.ShowDialog();
            refreshTable();
        }
    }
}
