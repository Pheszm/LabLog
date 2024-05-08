using LABLOG.Panels;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LABLOG.Logbook_Panels
{
    public partial class TimeIn_Student : UserControl
    {
        public TimeIn_Student()
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

        private void Return_btn_Click(object sender, EventArgs e)
        {
            Start_Menu start = new Start_Menu();
            this.Controls.Clear();
            this.Controls.Add(start);
        }

        private void Subjectbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Subjectbox.Text == "Others")
            {
                label4.Visible = true;
                reasonbox.Visible = true;
            }
            else
            {
                label4.Visible = false;
                reasonbox.Visible = false;
            }
        }

        string Coursee;
        string consstring = Program.MainServerDataBase;
        string stored_id, Stored_Name;
        private void Idbox_TextChanged(object sender, EventArgs e)
        {
            stored_id = "";
            Stored_Name = "";
            Subjectbox.Items.Clear();
            Subjectbox.Items.Add("Others");
            try
            {
                string sql = "SELECT * FROM Students WHERE StudentID = @ID";

                using (MySqlConnection con = new MySqlConnection(consstring))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@ID", Idbox.Text.ToUpper());

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (reader.GetInt32(6) == 1)
                            {
                                Coursee = reader.GetString(3);
                                LoadSubjectsss();
                                stored_id = Idbox.Text.ToUpper();
                                Stored_Name = reader.GetString(1);
                            }
                        }
                        else
                        {
                            Find_InstructorId();
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        void Find_InstructorId()
        {
            try
            {
                string sql = "SELECT * FROM instructors WHERE ID = @ID";

                using (MySqlConnection con = new MySqlConnection(consstring))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@ID", Idbox.Text.ToUpper());

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (reader.GetInt32(4) == 1)
                            {
                                Load_all_Subjectsss();
                                stored_id = Idbox.Text.ToUpper();
                                Stored_Name = reader.GetString(1);
                            }
                        }
                        else
                        {

                        }

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        void Load_all_Subjectsss()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(consstring))
                {
                    conn.Open();
                    string query = "SELECT * FROM subjects";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string courseName = reader.GetString(2);
                            Subjectbox.Items.Add(courseName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading Subjects: " + ex.Message);
            }
        }

        void LoadSubjectsss()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(consstring))
                {
                    conn.Open();
                    string query = "SELECT * FROM subjects";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader.GetInt32(4) == 1 && (reader.GetString(1) == Coursee || reader.GetString(1) == "General"))
                            {
                                string courseName = reader.GetString(2);
                                Subjectbox.Items.Add(courseName);
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading Subjects: " + ex.Message);
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (Idbox.Text != "" && Subjectbox.Text != "Others")
            {
                LogtheData();
            }
            else if (Idbox.Text != "" && Subjectbox.Text == "Others" && reasonbox.Text != "")
            {
                LogtheData();
            }
            else
            {
                MessageBox.Show("Dont leave the Text Box Empty.", "Authentication", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        string NullReason;
        void LogtheData()
        {
            if (stored_id == "" && Stored_Name == "")
            {
                MessageBox.Show("Unknown ID.", "Authentication", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            { 
                using (MySqlConnection conn = new MySqlConnection(consstring))
                {
                    conn.Open();
                    string IPaddresss = GetLocalIPAddress();
                    string TimeIn = DateTime.Now.ToString("hh:mm tt");
                    string ExactDate = DateTime.Now.ToString("dd/MM/yy");

                    if (reasonbox.Text == "") NullReason = "Class";
                    else NullReason = reasonbox.Text;
                    // Inserting data into logbooks database
                    string query = "INSERT INTO logbook (IPaddress, FullName, ID, Subject, Reason, TimeIn, ExactDate) VALUES (@IPadd, @FullName, @ID, @Purpose, @Reason, @TimeIn, @ExactDate)";
                    using (MySqlCommand insertCmd = new MySqlCommand(query, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@IPadd", IPaddresss);
                        insertCmd.Parameters.AddWithValue("@FullName", Stored_Name);
                        insertCmd.Parameters.AddWithValue("@ID", stored_id);
                        insertCmd.Parameters.AddWithValue("@Purpose", Subjectbox.Text);
                        insertCmd.Parameters.AddWithValue("@Reason", NullReason);
                        insertCmd.Parameters.AddWithValue("@TimeIn", TimeIn);
                        insertCmd.Parameters.AddWithValue("@ExactDate", ExactDate);
                        insertCmd.ExecuteNonQuery();
                    }
                    MessageBox.Show($"Successfully Time-In as '{Stored_Name}'.", "Time-in Successful");
                    Program.Bool_Time_in = true;
                    Program.Who_Time_In = Stored_Name;
                    Program.Who_Id_Time_In = stored_id;
                    Program.Time = 300;

                    Panels.Start_Menu Intro = new Panels.Start_Menu();
                    this.Controls.Clear();
                    this.Controls.Add(Intro);
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured: " + ex.Message);
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
