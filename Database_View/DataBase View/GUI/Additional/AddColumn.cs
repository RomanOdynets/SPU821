using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_View.GUI.Additional
{
    public partial class AddColumn : Form
    {
        private CreateTable hndlr;

        public AddColumn(CreateTable hndlr)
        {
            InitializeComponent();
            this.hndlr = hndlr;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            bool notCh = false;
            if (column_name_tb.Text == null || column_type_cb.SelectedIndex == -1 || column_length_tb.Text == null) return;
            Dictionary<string, int> cell = new Dictionary<string, int>();
            if (column_type_cb.SelectedItem.ToString() == "INT") notCh = true;
            cell.Add(column_type_cb.SelectedItem.ToString(), !notCh ? Convert.ToInt32(column_length_tb.Text) : 0);
            hndlr.columns.Add(column_name_tb.Text, cell);
            hndlr.refreshList();
            Close();
        }
    }
}
