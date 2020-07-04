using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
