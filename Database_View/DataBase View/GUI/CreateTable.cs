using DataBase_View.GUI.Additional;
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
    public partial class CreateTable : Form
    {
        public static CreateTable hndlr;
        public Dictionary<string, Dictionary<string, int>> columns = new Dictionary<string, Dictionary<string, int>>();
        private List<string> status = new List<string>();
        private StringBuilder query = new StringBuilder();
        private string PK_column = null;
        private string AI_column = null;

        public CreateTable()
        {
            hndlr = this;
            InitializeComponent();
            checkStatus();
        }

        public void refreshList()
        {
            columns_list.Items.Clear();
            pk_columns_cb.Items.Clear();
            select_ai_cb.Items.Clear();

            foreach (string cname in columns.Keys)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(cname + " ");
                foreach(var item in columns[cname].Keys) sb.Append(item + "(" + columns[cname][item].ToString() + ")");
                columns_list.Items.Add(sb.ToString());
                pk_columns_cb.Items.Add(cname);
                select_ai_cb.Items.Add(cname);
            }

            changeColumnsCount();
            checkStatus();
        }

        private void tableName_tb_TextChanged(object sender, EventArgs e)
        {
            setTableName(tableName_tb.Text);
            checkStatus();
        }

        private void setTableName(string tbn) => table_name_lbl.Text = $"Table Name: {tbn}";

        private void changeColumnsCount() => table_columns_lbl.Text = "Columns Count: " + columns_list.Items.Count.ToString();

        private void add_btn_Click(object sender, EventArgs e)
        {
            AddColumn add = new AddColumn(hndlr);
            add.ShowDialog();
            checkStatus();
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            if (columns_list.SelectedItems[0].Index == -1) return;

            string v = columns_list.SelectedItems[0].Text;

            string[] r = v.Split(' ');
            columns.Remove(r[0]);

            refreshList();
            checkStatus();
        }

        private void checkStatus(object sender = null, EventArgs e = null)
        {
            status_lbl.Text = null;
            status.Clear();

            bool selAI = (select_ai_cb.SelectedIndex == -1) ? true : false;
            bool selPK = (pk_columns_cb.SelectedIndex == -1) ? true : false;
            bool colVL = (columns_list.Items.Count == 0) ? true : false;
            bool tblNM = (string.IsNullOrWhiteSpace(tableName_tb.Text)) ? true : false;

            if (selAI) status.Add("Doesn't selected autoincrement column.");
            if (selPK) status.Add("Doesn't selected primary key column.");
            if (colVL) status.Add("Doesn't created any columns.");
            if (tblNM) status.Add("Doesn't enter table name.");

            PK_column = pk_columns_cb.SelectedIndex != -1 ? pk_columns_cb.SelectedItem.ToString() : "";
            AI_column = select_ai_cb.SelectedIndex != -1 ? select_ai_cb.SelectedItem.ToString() : "";

            foreach (var item in status)
            {
                status_lbl.Text += item + "\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (status.Count > 0)
            {
                MessageBox.Show("Read status message!", "You have an error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach(DataRow item in MainView.hndlr.ds.Tables[0].Rows)
            {
                if(item.ItemArray[0].ToString() == tableName_tb.Text)
                {
                    MessageBox.Show("Table is already exists!", "You have an error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            query.Append($"CREATE TABLE {tableName_tb.Text} (");

            int count = 0;

            foreach(var key in columns.Keys)
            {
                count++;
                query.Append($"{key} ");
                foreach (var item in columns[key].Keys)
                {
                    string lngh = columns[key][item] == 0 ? "" : "(" + columns[key][item] + ")";
                    query.Append($"{item} {lngh}");
                }
                if (key == PK_column) query.Append("PRIMARY KEY ");
                if (key == AI_column) query.Append("IDENTITY ");
                if (count != columns.Count) query.Append(",");
            }
            query.Append(")");

            Task<int> res = Task.Run(() => createTable());
            if(res.Result == -1)
            {
                DialogResult r = MessageBox.Show($"Table {tableName_tb.Text} was successful created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainView.hndlr.refreshTables();
                if (r == DialogResult.OK) Close();
            }
        }

        private async Task<int> createTable()
        {
            SqlCommand cmd = new SqlCommand(query.ToString(), Program.db.cnn);
            return await cmd.ExecuteNonQueryAsync();
        }
    }
}
