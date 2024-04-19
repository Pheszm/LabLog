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
using System.IO;

namespace LabLog.Panels
{
    public partial class DownloadReportsPanel : UserControl
    {
        string consstring = Program.MainServerDataBase;

        public DownloadReportsPanel()
        {
            InitializeComponent();
        }

        private void StudentListButton_Click(object sender, EventArgs e)
        {
            Panels.StudentListPanel EditStudentss = new Panels.StudentListPanel();
            this.Controls.Clear();
            this.Controls.Add(EditStudentss);
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










        private void DailyDownloadBtn_Click(object sender, EventArgs e)
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

            string query = "SELECT FullName, ID, Purpose, Reason, TimeIn, TimeOut, ExactDate " +
                           "FROM logbooks " +
                           "WHERE ExactDate >= @StartTime AND ExactDate <= @EndTime";

            using (MySqlConnection connection = new MySqlConnection(consstring))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StartTime", startDateTime);
                    command.Parameters.AddWithValue("@EndTime", endDateTime);

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

    }
}

