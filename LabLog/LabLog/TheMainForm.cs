using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabLog
{
    public partial class TheMainForm : Form
    {
        public TheMainForm()
        {
            InitializeComponent();
        }

        private void TheMainForm_Load(object sender, EventArgs e)
        {
            Panels.IntroductionPanel intro = new Panels.IntroductionPanel();
            panel1.Controls.Add(intro);

        }

        private void TheMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Exiting the App might turn of the pc, are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
