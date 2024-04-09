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
    public partial class SubjectAdd : Form
    {
        public SubjectAdd()
        {
            InitializeComponent();
        }

        string consstring = Program.MainServerDataBase;

        private void AddButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(consstring))
            {
                con.Open();
                string sql = "INSERT INTO subjectlist (subjects) VALUES (@Subjects)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Subjects", AddSubjectBox.Text);
                cmd.ExecuteNonQuery();
            }
            this.Close();
        }
    }
}
