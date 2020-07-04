using DataBase_View.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_View.GUI
{
    public partial class Auth : Form
    {
        public static Auth hndlr;

        private IniFile ini = new IniFile("settings.ini");
        public Auth()
        {
            hndlr = this;
            InitializeComponent();
        }

        private void Auth_Load(object sender, EventArgs e)
        {
           
        }

        private async Task<bool> auth()
        {
            string login = login_tb.Text;
            string pass = password_tb.Text;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = $"SELECT * FROM accounts WHERE username = '{login}' AND pass = '{pass}'";
            cmd.Connection = Program.db.cnn;

            using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
            {
                if (reader.HasRows) return true;
                else return false;
            }
        }

        public static async Task<bool> auth(string l, string p)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = $"SELECT * FROM accounts WHERE username = '{l}' AND pass = '{p}'";
            cmd.Connection = Program.db.cnn;

            using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
            {
                if (reader.HasRows) return true;
                else return false;
            }
        }

        private void auth_btn_Click(object sender, EventArgs e)
        {
            Task<bool> r = Task.Run(() => auth());
            if (r.Result)
            {
                if(savepass_cb.Checked)
                {
                    ini.Write("login", login_tb.Text, "Auth");
                    ini.Write("Password", password_tb.Text, "Auth");
                    ini.Write("save_password", savepass_cb.Checked.ToString(), "Config");
                    if (quickauth_cb.Checked) ini.Write("quick_auth", quickauth_cb.Checked.ToString(), "Config");
                }

                Hide();
                if (MainView.hndlr == null)
                {
                    MainView hndlr = new MainView();
                    hndlr.Show();
                }
                else MainView.hndlr.Show();
            }
        }
    }
}
