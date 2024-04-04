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
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            Panels.IntroductionPanel Intro = new Panels.IntroductionPanel();
            this.Controls.Clear();
            this.Controls.Add(Intro);
        }


        private void WhosLogin_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("HEHEHE");
            if (WhosLogin.Text == "Student")
            {
                Panels.LogbookAreaForStaff staff = new Panels.LogbookAreaForStaff();
                panel2.Controls.Clear();
                panel2.Controls.Add(staff);
            }
        }
    }
}
