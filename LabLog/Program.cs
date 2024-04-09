using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabLog
{
    internal static class Program
    {
        public static string MainServerDataBase = "server=localhost;uid=root;pwd=123456;database=sqlandcsharp";
        //public static string MainServerDataBase = "server=192.168.73.210;port=3306;uid=root;pwd=123456;database=sqlandcsharp";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>  
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TheMainForm());
        }
    }
}
