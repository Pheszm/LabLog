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
    public partial class EditStudents : Form
    {
        public EditStudents()
        {
            InitializeComponent();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Forms.EditingStudent editingStudent = new Forms.EditingStudent();
            this.Close();
            editingStudent.ShowDialog();
        }
    }
}
