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
        }

        string consstring = Program.MainServerDataBase;

        private void StudentLogin_Click(object sender, EventArgs e)
        {

            Panels.LogbookAreaForStudent Login = new Panels.LogbookAreaForStudent();
            this.Controls.Clear();
            this.Controls.Add(Login);
        }


        private void InstructorLogin_Click(object sender, EventArgs e)
        {
            Panels.InstructorSignIn Instructor = new Panels.InstructorSignIn();
            this.Controls.Clear();
            this.Controls.Add(Instructor);
        }
    }
}
