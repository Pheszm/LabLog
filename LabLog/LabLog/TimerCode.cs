using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABLOG
{
    internal class TimerCode
    {
        private Timer timer;

        public void StartTimer()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!Program.Bool_Time_in)
            {
                Program.Time -= 1;
            }

            if (Program.Time <= 0)
            {
                timer.Stop();
                Shutdown();
            }
        }

        public static void Shutdown()
        {
            bool testing = true;
            if (!testing)
            {
                ManagementBaseObject mboShutdown = null;
                ManagementClass mcWin32 = new ManagementClass("Win32_OperatingSystem");
                mcWin32.Get();

                mcWin32.Scope.Options.EnablePrivileges = true;
                ManagementBaseObject mboShutdownParams = mcWin32.GetMethodParameters("Win32Shutdown");

                mboShutdownParams["Flags"] = "1";
                mboShutdownParams["Reserved"] = "0";
                foreach (ManagementObject manObj in mcWin32.GetInstances())
                {
                    mboShutdown = manObj.InvokeMethod("Win32Shutdown", mboShutdownParams, null);
                }
            }
            else
            {
                MessageBox.Show("WILL NOT SHUTDOWN BECAUSE IT'S TESTING.", "SHUTTING DOWN");
            }
        }
    }
}
