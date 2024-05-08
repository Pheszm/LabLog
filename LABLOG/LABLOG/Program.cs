using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABLOG
{
    internal static class Program
    {
        public static Size Main_Form_Size;
        public static string MainServerDataBase = "server=localhost;uid=root;pwd=123456;database=lablog_database";
        //public static string MainServerDataBase = "server=192.168.1.16;port=3306;uid=root;pwd=123456;database=sqlandcsharp";
        public static int Time = 300;
        public static string Who_Time_In = "";
        public static bool Bool_Time_in = false;
        public static string Who_Id_Time_In = "";
        public static string Instruc_Name = "";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_Form());
        }
    }
}
