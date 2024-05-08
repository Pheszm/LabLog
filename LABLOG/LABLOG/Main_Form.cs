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

namespace LABLOG
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            Panels.Start_Menu stater = new Panels.Start_Menu();
            MainPanel.Controls.Add(stater);

            TimerCode timerCode = new TimerCode();
            timerCode.StartTimer();
        }

        private void Main_Form_Resize(object sender, EventArgs e)
        {
            Program.Main_Form_Size = MainPanel.Size; 
        }

        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Exiting the App might turn of the pc, are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Logoff();
                    TimerCode.Shutdown();
                }
            }
        }

        string consstring = Program.MainServerDataBase;
        private void Main_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Logoff();
        }


        void Logoff()
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
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error");
                    }
                }
            }
        }
    }
}
