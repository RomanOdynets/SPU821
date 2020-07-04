using MSSQL_Lib;
using System;
using DataBase_View.GUI;
using System.Windows.Forms;
using DataBase_View.Engine;
using System.Threading.Tasks;

namespace DataBase_View
{
    static class Program
    {
        public static Connection db;
        public static IniFile ini = new IniFile("settings.ini");
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            db = new Connection("localhost", "student", "Itstep123", "itstep");
            db.MakeConnection();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (ini.KeyExists("save_password", "Config") && ini.Read("save_password", "Config") == "True")
            {
                string l = null;
                string p = null;

                if (ini.KeyExists("login", "Auth") && ini.KeyExists("Password", "Auth"))
                {
                    l = ini.Read("login", "Auth");
                    p = ini.Read("Password", "Auth");
                }

                if (ini.KeyExists("quick_auth", "Config") && ini.Read("quick_auth", "Config") == "True")
                {
                    
                    Task<bool> r = Task.Run(() => Auth.auth(l, p));
                    if(r.Result) Application.Run(new MainView());
                }
            }
            else Application.Run(new Auth());
        }
    }
}
