using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabLog.Panels
{
    public partial class LogbookAreaForStaff : UserControl
    {
        public LogbookAreaForStaff()
        {
            InitializeComponent();
        }

        private void Purpose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Purpose.Text == "Others")
            {
                OthersPanel.Visible = true;
            }
            else
            {
                OthersPanel.Visible = false;
            }
        }
    }
}
