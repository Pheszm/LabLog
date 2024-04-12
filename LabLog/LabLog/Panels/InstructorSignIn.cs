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

namespace LabLog.Panels
{
    public partial class InstructorSignIn : UserControl
    {
        string consstring = Program.MainServerDataBase;

        public InstructorSignIn()
        {
            InitializeComponent();
        }

        bool PasswordView = false;

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            Panels.IntroductionPanel Intro = new Panels.IntroductionPanel();
            this.Controls.Clear();
            this.Controls.Add(Intro);
        }

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

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = Username.Text.Trim();
            string password = Password.Text.Trim();

            try
            {
                // Check if username and password are not empty
                if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
                {
                    string sql = "SELECT * FROM instructors_account WHERE username = @username AND pass = @password";

                    using (MySqlConnection con = new MySqlConnection(consstring))
                    {
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Successful login
                                Panels.InstructorsMenu Menu = new Panels.InstructorsMenu();
                                this.Controls.Clear();
                                this.Controls.Add(Menu);
                            }
                            else
                            {
                                // Failed login
                                MessageBox.Show("Wrong Username or Password");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Username and Password cannot be empty");
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during lo+gin
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


    }
}
