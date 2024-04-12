using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class LogbookAreaForStaff : UserControl
    {

        string consstring = Program.MainServerDataBase;

        public LogbookAreaForStaff()
        {
            InitializeComponent();
            WhosLogin.Text = "Staff";
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            Panels.IntroductionPanel Intro = new Panels.IntroductionPanel();
            this.Controls.Clear();
            this.Controls.Add(Intro);
        }

        private void WhosLogin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WhosLogin.Text == "Student")
            {
                Panels.LogbookAreaForStudent student = new Panels.LogbookAreaForStudent();
                this.Controls.Clear();
                this.Controls.Add(student);
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (PersonName.Text != "" && Reasonn.Text != "")
            {
                LogtheData();
            }
            else
            {
                MessageBox.Show("Dont leave the Text Box Empty.", "Authentication", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void LogtheData()
        {
            try
            {
                string Purposee = Reasonn.Text;
                string FullName = PersonName.Text;
                string TimeIn = DateTime.Now.ToString("hh:mm tt");
                string ExactDate = DateTime.Now.ToString("dd/MM/yy"); 

                using (MySqlConnection con = new MySqlConnection(consstring))
                {
                    con.Open();
                    string query = "INSERT INTO logbooks (FullName, Purpose, TimeIn, ExactDate) VALUES (@FullName, @Purpose, @TimeIn, @ExactDate)"; // Fixed parameter name in query
                    using (MySqlCommand insertCmd = new MySqlCommand(query, con))
                    {
                        insertCmd.Parameters.AddWithValue("@FullName", FullName);
                        insertCmd.Parameters.AddWithValue("@Purpose", Purposee); 
                        insertCmd.Parameters.AddWithValue("@TimeIn", TimeIn);
                        insertCmd.Parameters.AddWithValue("@ExactDate", ExactDate);
                        insertCmd.ExecuteNonQuery();
                    }
                    MessageBox.Show($"Successfully logged in as '{FullName}'.", "Login Successful"); 
                    Program.LoggedIn = true;
                    Program.NameLoggedIn = FullName;
                    Program.Time = 300;

                    Panels.IntroductionPanel Intro = new Panels.IntroductionPanel();
                    this.Controls.Clear();
                    this.Controls.Add(Intro);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
