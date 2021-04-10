using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace todo_list
{
    static class Program
    {
        public static string userID = "";
        public static string serverEndPoin = "http://192.168.1.45:8081";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SignIn(serverEndPoin,userID));
        }
    }
}
