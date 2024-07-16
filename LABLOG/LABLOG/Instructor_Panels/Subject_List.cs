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

namespace LABLOG.Instructor_Panels
{
    public partial class Subject_List : UserControl
    {
        public Subject_List()
        {
            InitializeComponent();
            LoopFunction();
            DataGrid.CellClick += DataGrid_CellClick;
            refreshTable();
        }
        string consstring = Program.MainServerDataBase;
        string SubjectCode;
        int Identifier;

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

        private void AddButton_Click(object sender, EventArgs e)
        {
            Instructor_Forms.Add_Subject add = new Instructor_Forms.Add_Subject();
            add.ShowDialog();
            refreshTable();
        }

        void refreshTable()
        {
            DataGrid.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 255);
            label2.Visible = true;
            remove_btn.Visible = false;
            edit_btn.Visible = false;
            try
            {
                DataGrid.Rows.Clear();
                string sql = "SELECT * FROM Subjects";

                if (!string.IsNullOrEmpty(SearchBox.Text))
                {
                    sql += $" WHERE Title LIKE '%{SearchBox.Text}%' OR Course LIKE '%{SearchBox.Text}%' OR Code LIKE '%{SearchBox.Text}%' OR Status LIKE '%{SearchBox.Text}%'";
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
                            int archive_stat = reader.GetInt32(5);
                            if (archive_stat == 0)
                            {
                                // Store each row's data in rowData list
                                rowData.Add(new string[]
                            {
                        reader["Course"].ToString(),
                        reader["Code"].ToString(),
                        reader["Title"].ToString(),
                        reader["Status"].ToString(),
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
                    DataGrid.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int overallRow = DataGrid.RowCount; //Prevent Selecting the Empty at the Last
            if (e.RowIndex >= 0 && e.RowIndex <= overallRow - 2)
            {
                DataGridViewRow selectedRow = DataGrid.Rows[e.RowIndex];
                SubjectCode = selectedRow.Cells["Codeee"].Value.ToString();
            }
            DataGrid.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(47, 118, 200);
            label2.Visible = false;
            remove_btn.Visible = true;
            edit_btn.Visible = true;
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            refreshTable();
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to delete '{SubjectCode}' from the record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    //Set Archive_Status to 1
                    using (MySqlConnection con = new MySqlConnection(consstring))
                    {
                        con.Open();

                        string sql = "UPDATE Subjects SET Archive_Status = @Archive_Status, Status = @Status WHERE Code = @Code";
                        MySqlCommand cmd = new MySqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@Code", SubjectCode);
                        cmd.Parameters.AddWithValue("@Status", 0);
                        cmd.Parameters.AddWithValue("@Archive_Status", 1);
                        int rowsAffected = cmd.ExecuteNonQuery();

                    }

                    //Get Identifier
                    string sql1 = "SELECT * FROM Subjects WHERE Code = @Code";

                    using (MySqlConnection con = new MySqlConnection(consstring))
                    {
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand(sql1, con);

                        cmd.Parameters.AddWithValue("@Code", SubjectCode);

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
                        cmd.Parameters.AddWithValue("@Type", "Subject");
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
                        cmd.Parameters.AddWithValue("@Type", "Subject");
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
            Instructor_Forms.Update_Subject update = new Instructor_Forms.Update_Subject(SubjectCode);
            update.ShowDialog();
            refreshTable();
        }
    }
}
