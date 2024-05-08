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

namespace LABLOG.Admin_Panels
{
    public partial class History : UserControl
    {
        public History()
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

        string consstring = Program.MainServerDataBase;
        void refreshTable()
        {
            DataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 255);
            try
            {
                DataGridView1.Rows.Clear();

                string sql = "SELECT * FROM history";

                using (MySqlConnection con = new MySqlConnection(consstring))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            object[] rowData = new object[reader.FieldCount];
                            reader.GetValues(rowData);
                            DataGridView1.Rows.Insert(0, rowData);
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while refreshing the table: " + ex.Message);
            }
        }

        string Type_File, Indentifierz;


        string Name_Course;
        private void View_btn_Click(object sender, EventArgs e)
        {
            if (Type_File == "Course")
            {
                //Get Identifier
                string sql1 = "SELECT * FROM Courses WHERE Identifier = @Identifier";

                using (MySqlConnection con = new MySqlConnection(consstring))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(sql1, con);

                    cmd.Parameters.AddWithValue("@Identifier", Indentifierz);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Name_Course = reader.GetString(1);
                        }
                    }
                }
                MessageBox.Show($"{Name_Course}");
            }

            if (Type_File == "Student")
            {
                //Get Identifier
                string sql1 = "SELECT * FROM Students WHERE Identifier = @Identifier";

                using (MySqlConnection con = new MySqlConnection(consstring))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(sql1, con);

                    cmd.Parameters.AddWithValue("@Identifier", Indentifierz);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Name_Course = reader.GetString(1);
                        }
                    }
                }
                MessageBox.Show($"{Name_Course}");
            }

            if (Type_File == "Subject")
            {
                //Get Identifier
                string sql1 = "SELECT * FROM Subjects WHERE Identifier = @Identifier";

                using (MySqlConnection con = new MySqlConnection(consstring))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(sql1, con);

                    cmd.Parameters.AddWithValue("@Identifier", Indentifierz);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Name_Course = reader.GetString(2);
                        }
                    }
                }
                MessageBox.Show($"{Name_Course}");
            }
        }

        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int overallRow = DataGridView1.RowCount;
            if (e.RowIndex >= 0 && e.RowIndex <= overallRow - 2)
            {
                DataGridViewRow selectedRow = DataGridView1.Rows[e.RowIndex];
                Type_File = selectedRow.Cells["Type"].Value.ToString();
                Indentifierz = selectedRow.Cells["IdentifierTable"].Value.ToString();
            }
            DataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(47, 118, 200);

            label4.Visible = false;
            View_btn.Visible = true;
        }
    }
}
