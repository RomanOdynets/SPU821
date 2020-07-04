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
    public partial class MainView : Form
    {
        public static MainView hndlr;

        public DataSet ds = new DataSet();
        private SqlDataAdapter adapter;

        public MainView()
        {
            hndlr = this;
            InitializeComponent();
        }

        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Auth.hndlr == null)
            {
                Auth main = new Auth();
                main.ShowDialog();
            }
            else Auth.hndlr.ShowDialog();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            status_lbl.Text = "Current user: " + Program.ini.Read("Login", "Auth");

            adapter = new SqlDataAdapter("SELECT name, type_desc, create_date, modify_date FROM sys.objects WHERE type IN (N'U')", Program.db.cnn);
            adapter.Fill(ds);


            tables_dg.DataSource = ds.Tables[0];
        }

        private void add_table_btn_ButtonClick(object sender, EventArgs e)
        {
            if (CreateTable.hndlr == null)
            {
                CreateTable ct = new CreateTable();
                ct.ShowDialog();
            }
            else CreateTable.hndlr.ShowDialog();
        }

        public void refreshTables()
        {
            ds.Clear();
            adapter.Fill(ds);
        }
    }
}
