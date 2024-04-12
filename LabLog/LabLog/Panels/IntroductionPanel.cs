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
            StartTimer(); // Call StartTimer method when the IntroductionPanel is initialized
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

        private void StudentLogin_Click(object sender, EventArgs e)
        {
            if(Program.LoggedIn == true)
            {
                Program.Time = 300;
                Program.LoggedIn = false;
                MessageBox.Show("You have been logged out.", "Successfully Logged out");
            }
            else
            {
                Panels.StudentSignIn Login = new Panels.StudentSignIn();
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
            TimeShower.Text = $"Time Left to Login: {Program.Time}";
            Timee = new Timer();
            Timee.Interval = 1000;
            Timee.Tick += Timer_Tick;
            Timee.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
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
