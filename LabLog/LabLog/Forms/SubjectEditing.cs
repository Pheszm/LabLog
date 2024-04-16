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

namespace LabLog.Forms
{
    public partial class SubjectEditing : Form
    {
        string consstring = Program.MainServerDataBase;
        string StoredSubject;

        public SubjectEditing(string Subject)
        {
            InitializeComponent();
            StoredSubject = Subject;
            SubjectTextBox.Text = Subject;
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (SubjectTextBox.Text == "")
            {
                MessageBox.Show("Please Fill-Up each Important Details.", "Attention");
            }
            else
            {
                UpdateSubject();
            }
        }

        void UpdateSubject()
        {
            string newSubjectName = SubjectTextBox.Text;

            try
            {
                using (MySqlConnection con = new MySqlConnection(consstring))
                {
                    con.Open();
                    string sql = "UPDATE subjectlist SET subjects = @NewName WHERE subjects = @RecentSubjectName";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@NewName", newSubjectName);
                    cmd.Parameters.AddWithValue("@RecentSubjectName", StoredSubject);
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
