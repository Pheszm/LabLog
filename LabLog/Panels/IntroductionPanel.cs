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
    public partial class IntroductionPanel : UserControl
    {
        public IntroductionPanel()
        {
            InitializeComponent();
        }

        private void StudentLogin_Click(object sender, EventArgs e)
        {
            Panels.StudentSignIn Login = new Panels.StudentSignIn();
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
