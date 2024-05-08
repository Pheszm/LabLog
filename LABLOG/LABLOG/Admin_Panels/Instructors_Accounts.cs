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

namespace LABLOG.Admin_Panels
{
    public partial class Instructors_Accounts : UserControl
    {
        public Instructors_Accounts()
        {
            InitializeComponent();
            LoopFunction();
            refreshTable();
            DataGridView1.CellClick += DataGrid_CellClick; // Attach event handler
            DataGridView1.ClearSelection();
        }
        string Stored_ID;
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

        private void Home_btn_Click(object sender, EventArgs e)
        {
            Panels.Admin_Home nextpage = new Panels.Admin_Home();
            this.Controls.Clear();
            this.Controls.Add(nextpage);
        }
        private void Instructors_accounts_btn_Click(object sender, EventArgs e)
        {
            Admin_Panels.Instructors_Accounts nextpage = new Admin_Panels.Instructors_Accounts();
            this.Controls.Clear();
            this.Controls.Add(nextpage);
        }
        private void Archive_btn_Click(object sender, EventArgs e)
        {
            Admin_Panels.Archives nextpage = new Admin_Panels.Archives();
            this.Controls.Clear();
            this.Controls.Add(nextpage);
        }
        private void History_btn_Click(object sender, EventArgs e)
        {
            Admin_Panels.History nextpage = new Admin_Panels.History();
            this.Controls.Clear();
            this.Controls.Add(nextpage);
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            Admin_Panels.Admin_Forms.Add_Instructor add = new Admin_Panels.Admin_Forms.Add_Instructor();
            add.ShowDialog();
            refreshTable();
        }

        string consstring = Program.MainServerDataBase;
        void refreshTable()
        {
            DataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 255);

            label4.Visible = true;
            View_passw_btn.Visible = false;
            remove_btn.Visible = false;
            edit_btn.Visible = false;
            try
            {
                DataGridView1.Rows.Clear();


                string sql = "SELECT * FROM instructors";

                if (!string.IsNullOrEmpty(statusbox.Text))
                {
                    sql += " WHERE 1=1";

                    if (!string.IsNullOrEmpty(statusbox.Text) && statusbox.Text != "none")
                        sql += $" AND Status = '{statusbox.Text}'";
                }

                List<string[]> rowData = new List<string[]>();

                using (MySqlConnection con = new MySqlConnection(consstring))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            rowData.Add(new string[]
                            {
                        reader["ID"].ToString(),
                        reader["Fullname"].ToString(),
                        reader["Username"].ToString(),
                        "* * * * * * * *".ToString(),
                        reader["Status"].ToString()
                            });
                        }
                    }
                }

                rowData.Sort((x, y) => x[0][0].CompareTo(y[0][0]));

                // Add sorted rows to DataGrid
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

        private void reset_filter_btn_Click(object sender, EventArgs e)
        {
            statusbox.Text = "none";
            FilterButtonCheck();
        }
        void FilterButtonCheck()
        {
            if (statusbox.Text != "none")
            {
                reset_filter_btn.Visible = true;
            }
            else
            {
                reset_filter_btn.Visible = false;
            }
        }

        private void statusbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterButtonCheck();
            refreshTable();
        }

        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int overallRow = DataGridView1.RowCount;
            if (e.RowIndex >= 0 && e.RowIndex <= overallRow - 2)
            {
                DataGridViewRow selectedRow = DataGridView1.Rows[e.RowIndex];
                Stored_ID = selectedRow.Cells["ID"].Value.ToString();
            }
            DataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(47, 118, 200);

            label4.Visible = false;
            remove_btn.Visible = true;
            edit_btn.Visible = true;
            View_passw_btn.Visible = true;
        }

        private void View_passw_btn_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Password FROM instructors WHERE ID = @ID";

            using (MySqlConnection con = new MySqlConnection(consstring))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@ID", Stored_ID);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string passw = reader.GetString(0);
                        MessageBox.Show(passw, "Showing Password", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            Admin_Panels.Admin_Forms.Update_Instructor update = new Admin_Panels.Admin_Forms.Update_Instructor(Stored_ID);
            update.ShowDialog();
            refreshTable();
        }


        string name;
        private void remove_btn_Click(object sender, EventArgs e)
        {
            try
            { 
                string sql1 = "SELECT Fullname FROM instructors WHERE ID = @ID";

                using (MySqlConnection con = new MySqlConnection(consstring))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(sql1, con);

                    cmd.Parameters.AddWithValue("@ID", Stored_ID);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            name = reader.GetString(0);
                        }
                    }
                }

                DialogResult result = MessageBox.Show($"Are you sure you want to delete '{name}' from the record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (MySqlConnection con = new MySqlConnection(consstring))
                    {
                        con.Open();
                        string sql = "DELETE FROM instructors WHERE ID = @ID";
                        MySqlCommand cmd = new MySqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@ID", Stored_ID);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Instructor Successfully Removed.", "Removed Successful");
                    }

                }
                refreshTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
