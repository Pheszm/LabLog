using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LABLOG.Admin_Panels.Admin_Forms
{
    public partial class Add_Instructor : Form
    {
        public Add_Instructor()
        {
            InitializeComponent();
        }
        string consstring = Program.MainServerDataBase;

        private void Create_btn_Click(object sender, EventArgs e)
        {
            if (Fullnamebox.Text == "" || Idbox.Text == "" || usernamebox.Text == "" || passwordbox.Text == "")
            {
                MessageBox.Show("Please Fill-Up each Important Details.", "Attention");
            }
            else
            {
                Creating_Instructor();
            }
        }
        void Creating_Instructor()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(consstring))
                {
                    con.Open();

                    string checkIDQuery = "SELECT COUNT(*) FROM instructors WHERE ID = @ID";
                    MySqlCommand checkIDCmd = new MySqlCommand(checkIDQuery, con);
                    checkIDCmd.Parameters.AddWithValue("@ID", Idbox.Text.ToUpper());
                    int count = Convert.ToInt32(checkIDCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("ID already exists. Please use a different ID.");
                        return; 
                    }

                    string sql = "INSERT INTO instructors (ID, Fullname, Username, Password, Status) VALUES (@ID, @Fullname, @Username, @Password, @Status)";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@ID", Idbox.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@Fullname", Fullnamebox.Text);
                    cmd.Parameters.AddWithValue("@Username", usernamebox.Text);
                    cmd.Parameters.AddWithValue("@Password", passwordbox.Text);
                    cmd.Parameters.AddWithValue("@Status", Statusbox.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Instructor Account Successfully Created.", "Successful");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
