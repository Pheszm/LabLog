using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABLOG.Panels
{
    public partial class Instructor_Home : UserControl
    {
        public Instructor_Home()
        {
            InitializeComponent();
            LoopFunction();
            label1.Text = $"Hello {Program.Instruc_Name}!";
        }
        private void LoopFunction()
        {
            Timer timer1 = new Timer();
            timer1.Interval = 1;
            timer1.Enabled = true;
            timer1.Tick += Timer1_Tick;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.Size = Program.Main_Form_Size;
        }
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Log-out?", "Confirming Log-out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Panels.Start_Menu intro = new Panels.Start_Menu();
                this.Controls.Clear();
                this.Controls.Add(intro);
            }
        }

        private void StudentList_btn_Click(object sender, EventArgs e)
        {
            Instructor_Panels.Student_List listup = new Instructor_Panels.Student_List();
            this.Controls.Clear();
            this.Controls.Add(listup);
        }
        private void SubjectList_btn_Click(object sender, EventArgs e)
        {
            Instructor_Panels.Subject_List listup = new Instructor_Panels.Subject_List();
            this.Controls.Clear();
            this.Controls.Add(listup);
        }
        private void DownloadReports_btn_Click(object sender, EventArgs e)
        {
            Instructor_Panels.Download_Reports listup = new Instructor_Panels.Download_Reports();
            this.Controls.Clear();
            this.Controls.Add(listup);
        }
        private void Home_btn_Click(object sender, EventArgs e)
        {
            Panels.Instructor_Home listup = new Panels.Instructor_Home();
            this.Controls.Clear();
            this.Controls.Add(listup);
        }

        private void course_list_btn_Click(object sender, EventArgs e)
        {
            Instructor_Panels.Course_List listup = new Instructor_Panels.Course_List();
            this.Controls.Clear();
            this.Controls.Add(listup);
        }
    }
}
