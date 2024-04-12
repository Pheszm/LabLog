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
        //public static string MainServerDataBase = "server=192.168.1.16;port=3306;uid=root;pwd=123456;database=sqlandcsharp";
        public static int Time = 10;
        public static string NameLoggedIn = "Carl Wyne S. Gallardo";
        public static bool LoggedIn = true;

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
