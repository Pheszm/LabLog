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
            Panels.IntroductionPanel Intro = new Panels.IntroductionPanel();
            this.Controls.Clear();
            this.Controls.Add(Intro);
        }
    }
}
