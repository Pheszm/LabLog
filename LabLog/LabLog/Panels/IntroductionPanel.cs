using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace LabLog.Panels
{
    public partial class IntroductionPanel : UserControl
    {
        private Timer Timee;

        public IntroductionPanel()
        {
            InitializeComponent();
            StartTimer();
            beeep();
            AlreadyLogin();
        }
        void AlreadyLogin()
        {
            if(Program.LoggedIn == true)
            {
                StudentLogin.Text = "LOG-OUT";
            }
            else
            {
                StudentLogin.Text = "LOG-IN";
            }
        }

        string consstring = Program.MainServerDataBase;

        private void StudentLogin_Click(object sender, EventArgs e)
        {
            if (Program.LoggedIn == true)
            {
                Program.Time = 300;
                Program.LoggedIn = false;

                using (MySqlConnection con = new MySqlConnection(consstring))
                {
                    try
                    {
                        con.Open(); // Open the connection

                        string TimeOut = DateTime.Now.ToString("hh:mm tt");
                        string ExactDate = DateTime.Now.ToString("dd/MM/yy");

                        string query = "UPDATE logbooks SET TimeOut = @TimeOut WHERE FullName = @FullName AND ExactDate = @ExactDate";

                        using (MySqlCommand cmd = new MySqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@FullName", Program.NameLoggedIn);
                            cmd.Parameters.AddWithValue("@ExactDate", ExactDate);
                            cmd.Parameters.AddWithValue("@TimeOut", TimeOut);
                            cmd.ExecuteNonQuery(); // Execute the query
                        }

                        MessageBox.Show($"You have been logged out as '{Program.NameLoggedIn}'", "Successfully Logged out");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error");
                    }
                }
            }
            else
            {
                Panels.LogbookAreaForStudent Login = new Panels.LogbookAreaForStudent();
                this.Controls.Clear();
                this.Controls.Add(Login);
            }

            AlreadyLogin();
        }




        private void InstructorLogin_Click(object sender, EventArgs e)
        {
            Panels.InstructorSignIn Instructor = new Panels.InstructorSignIn();
            this.Controls.Clear();
            this.Controls.Add(Instructor);
        }

        private void StartTimer()
        {
            Timee = new Timer();
            Timee.Interval = 1000;
            Timee.Tick += Timer_Tick;
            Timee.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            beeep();
        }

        void beeep()
        {
            if (Program.LoggedIn == false)
            {
                TimeShower.Text = $"Time Left to Login: {Program.Time}";
            }
            else
            {
                TimeShower.Text = $"You are already Logged In as '{Program.NameLoggedIn}'";
            }
        }
    }
}
