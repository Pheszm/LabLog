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
    public partial class StudentListPanel : UserControl
    {
        public StudentListPanel()
        {
            InitializeComponent();
        }

        private void YearLevelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CourseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Panels.InstructorsMenu Homeee = new Panels.InstructorsMenu();
            this.Controls.Clear();
            this.Controls.Add(Homeee);
        }

        private void SubjectListButton_Click(object sender, EventArgs e)
        {
            Panels.SubjectListPanel SubjectListt = new Panels.SubjectListPanel();
            this.Controls.Clear();
            this.Controls.Add(SubjectListt);
        }

        private void DownloadReportsButton_Click(object sender, EventArgs e)
        {
            Panels.DownloadReportsPanel DownloaddReportss = new Panels.DownloadReportsPanel();
            this.Controls.Clear();
            this.Controls.Add(DownloaddReportss);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Log-out?", "Confirming Log-out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Panels.IntroductionPanel intro = new Panels.IntroductionPanel();
                this.Controls.Clear();
                this.Controls.Add(intro);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Forms.AddStudent addStudent = new Forms.AddStudent();
            addStudent.ShowDialog();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Forms.EditStudents EdittStudent = new Forms.EditStudents();
            EdittStudent.ShowDialog();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            Forms.RemoveStudent removeStudent = new Forms.RemoveStudent();
            removeStudent.ShowDialog();
        }
    }
}
