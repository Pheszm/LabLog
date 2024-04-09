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
    public partial class SubjectListPanel : UserControl
    {
        public SubjectListPanel()
        {
            InitializeComponent();
            DataGrid.CellClick += DataGrid_CellClick; // Attach event handler
            refreshTable();
        }

        string consstring = Program.MainServerDataBase;
        string StoredSubject;


        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            refreshTable();
        }

        void refreshTable()
        {
            DataGrid.Rows.Clear();
            string sql = "SELECT * FROM subjectlist";

            if (!string.IsNullOrEmpty(SearchBox.Text))
            {
                sql += $" WHERE subjects LIKE '%{SearchBox.Text}%'";
            }

            List<string[]> rowData = new List<string[]>(); // Store rows data

            using (MySqlConnection con = new MySqlConnection(consstring))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    // Store each row's data in rowData list
                    rowData.Add(new string[]
                    {
                reader["subjects"].ToString(),
                    });
                }

                reader.Close();
            }

            // Sort the rowData list based on the first letter of the student's name
            rowData.Sort((x, y) => x[0][0].CompareTo(y[0][0]));

            // Add sorted rows to DataGrid
            foreach (string[] row in rowData)
            {
                DataGrid.Rows.Add(row);
            }
        }



        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int overallRow = DataGrid.RowCount; //Prevent Selecting the Empty at the Last
            if (e.RowIndex >= 0 && e.RowIndex <= overallRow - 2)
            {
                DataGridViewRow selectedRow = DataGrid.Rows[e.RowIndex];
                StoredSubject = selectedRow.Cells["Subjects"].Value.ToString();
            }
            RemoveButton.Visible = true;
            EditButton.Visible = true;
        }


        private void DownloadReportsButton_Click(object sender, EventArgs e)
        {
            Panels.DownloadReportsPanel DownloaddReportss = new Panels.DownloadReportsPanel();
            this.Controls.Clear();
            this.Controls.Add(DownloaddReportss);
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
            Forms.SubjectAdd add = new Forms.SubjectAdd();
            add.ShowDialog();
            refreshTable();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to delete '{StoredSubject}' from the record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (MySqlConnection con = new MySqlConnection(consstring))
                {
                    con.Open();
                    string sql = "DELETE FROM subjectlist WHERE subjects = @Subjects";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@Subjects", StoredSubject);
                    cmd.ExecuteNonQuery();
                }

            }
            refreshTable();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Forms.SubjectEditing edit = new Forms.SubjectEditing(StoredSubject);
            edit.ShowDialog();
            refreshTable();
        }

    }

}

