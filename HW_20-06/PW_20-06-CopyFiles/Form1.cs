using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace PW_20_06_CopyFiles
{
    public partial class Form1 : Form
    {
        private string path_t;
        private string path_f;
        private BackgroundWorker bgwkCopy = new BackgroundWorker();
        public Form1()
        {
            InitializeComponent();
        }

        private void open1_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            DialogResult r = open.ShowDialog();
            if(r == DialogResult.OK) path_from_tb.Text = open.FileName;
        }

        private void open2_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog open = new FolderBrowserDialog();
            DialogResult r = open.ShowDialog();
            if (r == DialogResult.OK) path_to_tb.Text = open.SelectedPath;
        }

        private void copy_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(path_from_tb.Text) || string.IsNullOrWhiteSpace(path_to_tb.Text))
                return;

            path_t = path_to_tb.Text;
            path_f = path_from_tb.Text;
        }

        private void CopyInThread()
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread p = new Thread(new ThreadStart(newThread));
            p.Start();
        }

        private void newThread()
        {

            for (int i = 0; i < 5; i++)
            {
                ThreadPriority prior = (ThreadPriority)i;
                Thread.Sleep(500);
            }
        }
    }
}
