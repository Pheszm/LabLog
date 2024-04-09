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
            string NewSubjectName = SubjectTextBox.Text;

            using (MySqlConnection con = new MySqlConnection(consstring))
            {
                con.Open();
                string sql = "UPDATE subjectlist SET subjects = @NewName WHERE subjects = @RecentSubjectName";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@NewName", NewSubjectName);
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
    }
}
