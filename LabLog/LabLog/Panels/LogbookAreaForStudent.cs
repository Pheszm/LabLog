using Google.Protobuf.Reflection;
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
    public partial class LogbookAreaForStudent : UserControl
    {
        public LogbookAreaForStudent()
        {
            InitializeComponent();
            WhosLogin.Text = "Student";
            Loadsubjects();
        }

        string consstring = Program.MainServerDataBase;

        void Loadsubjects()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(consstring))
                {
                    conn.Open();
                    string query = "SELECT Subjects FROM subjectlist";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string courseName = reader.GetString(0);
                            Purpose.Items.Add(courseName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading courses: " + ex.Message);
            }
        }

        private void Purpose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Purpose.Text == "Others")
            {
                OthersPanel.Visible = true;
            }
            else
            {
                OthersPanel.Visible = false;
            }
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {


            Panels.IntroductionPanel Intro = new Panels.IntroductionPanel();
            this.Controls.Clear();
            this.Controls.Add(Intro);

        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            Panels.IntroductionPanel Intro = new Panels.IntroductionPanel();
            this.Controls.Clear();
            this.Controls.Add(Intro);
        }

        private void WhosLogin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WhosLogin.Text == "Staff")
            {
                Panels.LogbookAreaForStaff staff = new Panels.LogbookAreaForStaff();
                this.Controls.Clear();
                this.Controls.Add(staff);
            }
        }
    }
}
