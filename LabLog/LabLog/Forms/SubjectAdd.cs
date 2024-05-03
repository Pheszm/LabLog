﻿using MySql.Data.MySqlClient;
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
            if (AddSubjectBox.Text == "" || Titleee.Text == "")
            {
                MessageBox.Show("Please Fill-Up the Box.", "Attention");
            }
            else
            {
                addSubject();
                MessageBox.Show("Subject Successfully added.", "Successful");
            }
        }

        void addSubject()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(consstring))
                {
                    con.Open();
                    string sql = "INSERT INTO subjectlist (Subject_Code, Subject_Title) VALUES (@Code, @Title)";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@Code", AddSubjectBox.Text);
                    cmd.Parameters.AddWithValue("@Title", Titleee.Text);
                    cmd.ExecuteNonQuery();
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
