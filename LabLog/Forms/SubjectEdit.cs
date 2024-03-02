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
    public partial class SubjectEdit : Form
    {
        public SubjectEdit()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SubjectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Forms.SubjectEditing edit = new Forms.SubjectEditing();
            this.Close();
            edit.ShowDialog();
        }

        private void SubjectEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
