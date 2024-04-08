using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PracticeForSQL
{
    public partial class Form1 : Form
    {
        string consstring = "server=localhost;uid=root;pwd=123456;database=sqlandcsharp";

        //Select from the Table will store in this string:
        string SelectStuID, SelectName, SelectCourse, SelectYearLevel, SelectGender;

        private void DeleteButton_Click(object sender, EventArgs e)
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

        private void EditButton_Click(object sender, EventArgs e)
        {
            UpdateForm update = new UpdateForm(SelectStuID, SelectName, SelectCourse, SelectYearLevel, SelectGender);
            update.ShowDialog();
            refreshTable();
        }

        public Form1()
        {
            InitializeComponent();
            refreshTable();
            DataGrid.CellClick += DataGrid_CellClick; // Attach event handler
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddForm add = new AddForm();
            add.ShowDialog();
            refreshTable();
        }

        void refreshTable()
        {
            using (MySqlConnection con = new MySqlConnection(consstring))
            {
                con.Open();
                string sql = "SELECT * FROM studentlist";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                DataGrid.Rows.Clear();

                while (reader.Read())
                {
                    DataGrid.Rows.Add(
                        reader["StudentName"].ToString(),
                        reader["StudentID"].ToString(),
                        reader["Course"].ToString(),
                        reader["YearLevel"].ToString(),
                        reader["Gender"].ToString()
                    ); 
                }
                reader.Close();
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
            DeleteButton.Visible = true;
            EditButton.Visible = true;
        }
    }
}
