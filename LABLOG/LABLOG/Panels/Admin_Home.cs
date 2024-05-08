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
    public partial class Admin_Home : UserControl
    {
        public Admin_Home()
        {
            InitializeComponent();
            LoopFunction();
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

        private void Home_btn_Click(object sender, EventArgs e)
        {
            Panels.Admin_Home nextpage = new Panels.Admin_Home();
            this.Controls.Clear();
            this.Controls.Add(nextpage);
        }
        private void Instructors_accounts_btn_Click(object sender, EventArgs e)
        {
            Admin_Panels.Instructors_Accounts nextpage = new Admin_Panels.Instructors_Accounts();
            this.Controls.Clear();
            this.Controls.Add(nextpage);
        }
        private void Archive_btn_Click(object sender, EventArgs e)
        {
            Admin_Panels.Archives nextpage = new Admin_Panels.Archives();
            this.Controls.Clear();
            this.Controls.Add(nextpage);
        }
        private void History_btn_Click(object sender, EventArgs e)
        {
            Admin_Panels.History nextpage = new Admin_Panels.History();
            this.Controls.Clear();
            this.Controls.Add(nextpage);
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
    }
}
