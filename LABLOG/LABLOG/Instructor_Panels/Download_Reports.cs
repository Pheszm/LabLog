using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABLOG.Instructor_Panels
{
    public partial class Download_Reports : UserControl
    {
        public Download_Reports()
        {
            InitializeComponent();
            LoopFunction();
            string StartTimee = DateTime.Now.ToString("dd/MM/yy");
            string EndTimee = DateTime.Now.ToString("dd/MM/yy");

            StartTimePicker.Text = StartTimee;
            EndTimePicker.Text = EndTimee;

            refreshTable(StartTimee, EndTimee);
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


        string consstring = Program.MainServerDataBase;
        void refreshTable(string StartTimee, string EndTimee)
        {
            try
            {
                DataGrid.Rows.Clear();

                string sql = "SELECT * FROM logbook WHERE STR_TO_DATE(ExactDate, '%d/%m/%y') >= STR_TO_DATE(@StartDate, '%d/%m/%y') AND STR_TO_DATE(ExactDate, '%d/%m/%y') <= STR_TO_DATE(@EndDate, '%d/%m/%y')";



                List<string[]> rowData = new List<string[]>(); // Store rows data

                using (MySqlConnection con = new MySqlConnection(consstring))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@StartDate", StartTimee);
                    cmd.Parameters.AddWithValue("@EndDate", EndTimee);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Store each row's data in rowData list
                            rowData.Add(new string[]
                            {
                        reader["IPaddress"].ToString(),
                        reader["FullName"].ToString(),
                        reader["ID"].ToString(),
                        reader["Subject"].ToString(),
                        reader["Reason"].ToString(),
                        reader["TimeIn"].ToString(),
                        reader["TimeOut"].ToString(),
                        reader["ExactDate"].ToString()
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

        private void export_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string startDateTime = StartTimePicker.Text;
                string endDateTime = EndTimePicker.Text;

                // Retrieve data from the database based on start and end points
                DataTable dataTable = GetDataFromDatabase(startDateTime, endDateTime);

                // Prompt user to select a folder for exporting the file
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Title = "Download Reports as CSV";
                    saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
                    saveFileDialog.FilterIndex = 1;
                    saveFileDialog.RestoreDirectory = true;
                    saveFileDialog.FileName = "DownloadReports";

                    DialogResult result = saveFileDialog.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        string fileName = saveFileDialog.FileName;

                        // Export the data to the selected file
                        ExportToCSV(dataTable, fileName);

                        MessageBox.Show("Data exported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Open the folder containing the saved file
                        string directoryPath = Path.GetDirectoryName(fileName);
                        Process.Start("explorer.exe", directoryPath); // This will open the folder in Windows Explorer

                        // Open the saved file
                        Process.Start(fileName); // This will open the file with the default application associated with its extension
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private DataTable GetDataFromDatabase(string startDateTime, string endDateTime)
        {
            DataTable dataTable = new DataTable();

            string query = "SELECT IPaddress, FullName, ID, Subject, Reason, TimeIn, TimeOut, ExactDate " +
                           "FROM logbook " +
                           "WHERE STR_TO_DATE(ExactDate, '%d/%m/%y') >= STR_TO_DATE(@StartDate, '%d/%m/%y') AND STR_TO_DATE(ExactDate, '%d/%m/%y') <= STR_TO_DATE(@EndDate, '%d/%m/%y')";

            using (MySqlConnection connection = new MySqlConnection(consstring))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StartDate", startDateTime);
                    command.Parameters.AddWithValue("@EndDate", endDateTime);

                    connection.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }


        private void ExportToCSV(DataTable dataTable, string filePath)
        {
            StringBuilder sb = new StringBuilder();

            IEnumerable<string> columnNames = dataTable.Columns.Cast<DataColumn>().Select(column => column.ColumnName);
            sb.AppendLine(string.Join(",", columnNames));

            foreach (DataRow row in dataTable.Rows)
            {
                IEnumerable<string> fields = row.ItemArray.Select(field => field.ToString());
                sb.AppendLine(string.Join(",", fields));
            }

            File.WriteAllText(filePath, sb.ToString());
        }

        private void StartTimePicker_ValueChanged(object sender, EventArgs e)
        {
            string StartTimee = StartTimePicker.Text;
            string EndTimee = EndTimePicker.Text;
            refreshTable(StartTimee, EndTimee);
        }

        private void EndTimePicker_ValueChanged(object sender, EventArgs e)
        {
            string StartTimee = StartTimePicker.Text;
            string EndTimee = EndTimePicker.Text;
            refreshTable(StartTimee, EndTimee);
        }
    }
}
