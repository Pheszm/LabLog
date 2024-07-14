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

namespace LABLOG.Panels
{
    public partial class Start_Menu : UserControl
    {
        public Start_Menu()
        {
            InitializeComponent();
            LoopFunction();
            AlreadyLogin();
            TimerCode.timer.Start();
        }
        void AlreadyLogin()
        {
            if (Program.Bool_Time_in == true)
            {
                Logbook_btn.Text = "TIME-OUT";
            }
            else
            {
                Logbook_btn.Text = "TIME-IN";
            }
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

            if (Program.Bool_Time_in == false)
            {
                TimeShower.Text = $"Time Left to Login: {Program.Time}";
            }
            else
            {
                TimeShower.Text = $"You are already Logged In as '{Program.Who_Time_In}'";
            }
        }

        private void Manage_btn_Click(object sender, EventArgs e)
        {
            Login_Instructor select = new Login_Instructor();
            this.Controls.Clear();
            this.Controls.Add(select);
        }
        string consstring = Program.MainServerDataBase;
        private void Logbook_btn_Click(object sender, EventArgs e)
        {
            if (Program.Bool_Time_in == true)
            {
                Program.Time = 300;
                Program.Bool_Time_in = false;

                using (MySqlConnection con = new MySqlConnection(consstring))
                {
                    try
                    {
                        con.Open(); // Open the connection

                        string TimeOut = DateTime.Now.ToString("hh:mm tt");
                        string ExactDate = DateTime.Now.ToString("dd/MM/yy");

                        string query = "UPDATE logbook SET TimeOut = @TimeOut WHERE ID = @ID AND ExactDate = (SELECT MAX(ExactDate) FROM logbook WHERE ID = @ID AND ExactDate = @ExactDate) AND TimeIn = (SELECT MAX(TimeIn) FROM logbook WHERE ID = @ID AND ExactDate = @ExactDate)";

                        using (MySqlCommand cmd = new MySqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@ID", Program.Who_Id_Time_In);
                            cmd.Parameters.AddWithValue("@ExactDate", ExactDate);
                            cmd.Parameters.AddWithValue("@TimeOut", TimeOut);
                            cmd.ExecuteNonQuery(); // Execute the query
                        }

                        MessageBox.Show($"You have been logged out as '{Program.Who_Time_In}'", "Successfully Logged out");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error");
                    }
                }
            }
            else
            {
                Logbook_Panels.TimeIn_Student select = new Logbook_Panels.TimeIn_Student();
                this.Controls.Clear();
                this.Controls.Add(select);
            }
            AlreadyLogin();
        }
    }
}
