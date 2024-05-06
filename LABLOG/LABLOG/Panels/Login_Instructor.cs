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
    public partial class Login_Instructor : UserControl
    {
        public Login_Instructor()
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

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (Username.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Username and Password cannot be empty");
                label1.ForeColor = string.IsNullOrEmpty(Username.Text) ? Color.FromArgb(180, 0, 0) : Color.FromArgb(28, 46, 77);
                label2.ForeColor = string.IsNullOrEmpty(Password.Text) ? Color.FromArgb(180, 0, 0) : Color.FromArgb(28, 46, 77);
            }
            else
            {
                label1.ForeColor = Color.FromArgb(28, 46, 77);
                label2.ForeColor = Color.FromArgb(28, 46, 77);
                LoginProcess();
            }
        }

        string consstring = Program.MainServerDataBase;
        void LoginProcess()
        {
            try
            {
                string sql = "SELECT * FROM instructors WHERE Username = @user AND Password = @pass";

                using (MySqlConnection con = new MySqlConnection(consstring))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@user", Username.Text);
                    cmd.Parameters.AddWithValue("@pass", Password.Text);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if(reader.GetString(4) == "1")
                            {
                                Program.Instruc_Name = reader.GetString(1);
                                MessageBox.Show($"You are logged-in as {Program.Instruc_Name}", "Login Successful");

                                Panels.Instructor_Home login = new Panels.Instructor_Home();
                                this.Controls.Clear();
                                this.Controls.Add(login);
                            }
                            else
                            {
                                MessageBox.Show("Account has been disabled.");
                            }

                        }
                        else
                        {
                            string sql1 = "SELECT * FROM System_Admin WHERE Username = @user AND Password = @pass";

                            using (MySqlConnection con1 = new MySqlConnection(consstring))
                            {
                                con1.Open();
                                MySqlCommand cmd1 = new MySqlCommand(sql1, con1);
                                cmd1.Parameters.AddWithValue("@user", Username.Text);
                                cmd1.Parameters.AddWithValue("@pass", Password.Text);

                                using (MySqlDataReader reader1 = cmd1.ExecuteReader())
                                {
                                    if (reader1.Read())
                                    {
                                        Program.Instruc_Name = reader1.GetString(1);
                                        MessageBox.Show($"You are logged-in as SYSTEM ADMIN", "Login Successful");

                                        Panels.Admin_Home login = new Panels.Admin_Home();
                                        this.Controls.Clear();
                                        this.Controls.Add(login);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Invalid Username or Password");
                                    } 
                                }
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void Return_btn_Click(object sender, EventArgs e)
        {
            Start_Menu start = new Start_Menu();
            this.Controls.Clear();
            this.Controls.Add(start);
        }

        bool PasswordView = false;
        private void ViewPassword_Click(object sender, EventArgs e)
        {
            if (PasswordView == false)
            {
                ViewPassword.Image = Properties.Resources.UnView_Password_Logo;
                PasswordView = true;
                Password.PasswordChar = '\0';
            }
            else if (PasswordView == true)
            {
                ViewPassword.Image = Properties.Resources.View_Password_Logo;
                PasswordView = false;
                Password.PasswordChar = '*';
            }
        }
    }
}
