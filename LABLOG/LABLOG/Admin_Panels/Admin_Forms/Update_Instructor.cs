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

namespace LABLOG.Admin_Panels.Admin_Forms
{
    public partial class Update_Instructor : Form
    {
        public Update_Instructor(string ID)
        {
            InitializeComponent();
            load_information(ID);
            oldID = ID;
        }
        string oldID;
        string consstring = Program.MainServerDataBase;
        void load_information(string ID)
        {
            string sql = "SELECT * FROM instructors WHERE ID = @ID";

            using (MySqlConnection con = new MySqlConnection(consstring))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@ID", ID);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Fullnamebox.Text = reader.GetString(1);
                        Idbox.Text = reader.GetString(0);
                        usernamebox.Text = reader.GetString(2);
                        passwordbox.Text = reader.GetString(3);
                        Statusbox.Text = reader.GetString(4);
                    }
                }
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (Fullnamebox.Text == "" || Idbox.Text == "" || usernamebox.Text == "" || passwordbox.Text == "")
            {
                MessageBox.Show("Please Fill-Up each Important Details.", "Attention");
            }
            else
            {
                Updating_Instructor();
            }
        }
        void Updating_Instructor()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(consstring))
                {
                    con.Open();

                    string checkExistenceQuery = "SELECT COUNT(*) FROM instructors WHERE ID = @newId";
                    MySqlCommand checkExistenceCmd = new MySqlCommand(checkExistenceQuery, con);
                    checkExistenceCmd.Parameters.AddWithValue("@newId", Idbox.Text);
                    int existingRecordsCount = Convert.ToInt32(checkExistenceCmd.ExecuteScalar());

                    if (existingRecordsCount > 0 && Idbox.Text.ToUpper() != oldID)
                    {
                        MessageBox.Show("ID already exists. Cannot update record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; 
                    }

                    string sql = "UPDATE instructors SET ID = @newId, Fullname = @Fullname, Username = @Username, Password = @Password, Status = @Status WHERE ID = @Old_ID";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@newId", Idbox.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@Fullname", Fullnamebox.Text);
                    cmd.Parameters.AddWithValue("@Username", usernamebox.Text);
                    cmd.Parameters.AddWithValue("@Password", passwordbox.Text);
                    cmd.Parameters.AddWithValue("@Status", Statusbox.Text);
                    cmd.Parameters.AddWithValue("@Old_ID", oldID);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No records were updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
