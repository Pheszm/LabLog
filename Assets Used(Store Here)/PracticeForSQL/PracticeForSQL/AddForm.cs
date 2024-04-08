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

namespace PracticeForSQL
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        string consstring = "server=localhost;uid=root;pwd=123456;database=sqlandcsharp";


        private void AddButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(consstring))
            {
                con.Open();
                string sql = "INSERT INTO studentlist (StudentID, StudentName, Course, YearLevel, Gender) VALUES (@StudentID, @StudentName, @Course, @YearLevel, @Gender)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@StudentID", StuID.Text);
                cmd.Parameters.AddWithValue("@StudentName", StuName.Text);
                cmd.Parameters.AddWithValue("@Course", StuCourse.Text);
                cmd.Parameters.AddWithValue("@YearLevel", StuYearLevel.Text);
                cmd.Parameters.AddWithValue("@Gender", StuGender.Text);
                cmd.ExecuteNonQuery();
            }
            this.Close();
        }
    }
}
