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
    public partial class StudentSignIn : UserControl
    {
        public StudentSignIn()
        {
            InitializeComponent();
            starter();
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
                panel2.Controls.Clear();
                panel2.Controls.Add(staff);
            }

            if (WhosLogin.Text == "Student")
            {
                Panels.LogbookAreaForStudent student = new Panels.LogbookAreaForStudent();
                panel2.Controls.Clear();
                panel2.Controls.Add(student);
            }
        }

        void starter()
        {
            WhosLogin.Text = "Student";
            Panels.LogbookAreaForStudent student = new Panels.LogbookAreaForStudent();
            panel2.Controls.Clear();
            panel2.Controls.Add(student);
        }
    }
}
