using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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
            if (PersonName.Text != "" && Reasonn.Text != "")
            {
                LogtheData();
            }
            else
            {
                MessageBox.Show("Dont leave the Text Box Empty.", "Authentication", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void LogtheData()
        {
            try
            {
                string IPaddresss = GetLocalIPAddress();
                string Reasonnn = Reasonn.Text;
                string FullName = PersonName.Text;
                string TimeIn = DateTime.Now.ToString("hh:mm tt");
                string ExactDate = DateTime.Now.ToString("dd/MM/yy"); 

                using (MySqlConnection con = new MySqlConnection(consstring))
                {
                    con.Open();
                    string query = "INSERT INTO logbooks (IPaddress, FullName, Reason, TimeIn, ExactDate) VALUES (@IPadd, @FullName, @Reason, @TimeIn, @ExactDate)"; // Fixed parameter name in query
                    using (MySqlCommand insertCmd = new MySqlCommand(query, con))
                    {
                        insertCmd.Parameters.AddWithValue("@IPadd", IPaddresss);
                        insertCmd.Parameters.AddWithValue("@FullName", FullName);
                        insertCmd.Parameters.AddWithValue("@Reason", Reasonnn); 
                        insertCmd.Parameters.AddWithValue("@TimeIn", TimeIn);
                        insertCmd.Parameters.AddWithValue("@ExactDate", ExactDate);
                        insertCmd.ExecuteNonQuery();
                    }
                    MessageBox.Show($"Successfully logged in as '{FullName}'.", "Login Successful"); 
                    Program.LoggedIn = true;
                    Program.NameLoggedIn = FullName;
                    Program.Time = 300;

                    Panels.IntroductionPanel Intro = new Panels.IntroductionPanel();
                    this.Controls.Clear();
                    this.Controls.Add(Intro);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string GetLocalIPAddress()
        {
            string localIP = "";
            try
            {
                // Get the host name of the local machine
                string hostName = Dns.GetHostName();

                // Get the IP addresses associated with the host
                IPAddress[] addresses = Dns.GetHostAddresses(hostName);

                // Find the first IPv4 address
                foreach (IPAddress address in addresses)
                {
                    if (address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        localIP = address.ToString();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception, if any
                MessageBox.Show("Error getting IP address: " + ex.Message);
            }
            return localIP;
        }

    }
}
