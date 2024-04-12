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
    public partial class InstructorSignIn : UserControl
    {
        string consstring = Program.MainServerDataBase;

        public InstructorSignIn()
        {
            InitializeComponent();
        }

        bool PasswordView = false;

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            Panels.IntroductionPanel Intro = new Panels.IntroductionPanel();
            this.Controls.Clear();
            this.Controls.Add(Intro);
        }

        private void ViewPassword_Click(object sender, EventArgs e)
        {
            if (PasswordView == false)
            {
                ViewPassword.Image = Properties.Resources.UnView_Password_Logo;
                PasswordView = true;
                Password.PasswordChar = '\0';
            }
            else if (PasswordView == true)
            {
                ViewPassword.Image = Properties.Resources.View_Password_Logo;
                PasswordView = false;
                Password.PasswordChar = '*';
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

            Panels.InstructorsMenu Menu = new Panels.InstructorsMenu();
            this.Controls.Clear();
            this.Controls.Add(Menu);
        }


    }
}
