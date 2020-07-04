namespace DataBase_View.GUI
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progress_br = new System.Windows.Forms.ToolStripProgressBar();
            this.status_lbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.tables_dg = new System.Windows.Forms.DataGridView();
            this.add_table_btn = new System.Windows.Forms.ToolStripSplitButton();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tables_dg)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progress_br,
            this.status_lbl,
            this.add_table_btn});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progress_br
            // 
            this.progress_br.Name = "progress_br";
            this.progress_br.Size = new System.Drawing.Size(100, 16);
            // 
            // status_lbl
            // 
            this.status_lbl.Name = "status_lbl";
            this.status_lbl.Size = new System.Drawing.Size(36, 17);
            this.status_lbl.Text = "Nope";
            // 
            // tables_dg
            // 
            this.tables_dg.AllowUserToAddRows = false;
            this.tables_dg.AllowUserToDeleteRows = false;
            this.tables_dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tables_dg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tables_dg.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tables_dg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tables_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tables_dg.GridColor = System.Drawing.SystemColors.Control;
            this.tables_dg.Location = new System.Drawing.Point(12, 36);
            this.tables_dg.Name = "tables_dg";
            this.tables_dg.ReadOnly = true;
            this.tables_dg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tables_dg.Size = new System.Drawing.Size(776, 389);
            this.tables_dg.TabIndex = 1;
            // 
            // add_table_btn
            // 
            this.add_table_btn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.add_table_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.add_table_btn.DoubleClickEnabled = true;
            this.add_table_btn.Image = ((System.Drawing.Image)(resources.GetObject("add_table_btn.Image")));
            this.add_table_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.add_table_btn.Name = "add_table_btn";
            this.add_table_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.add_table_btn.Size = new System.Drawing.Size(86, 20);
            this.add_table_btn.Text = "Create table";
            this.add_table_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_table_btn.ButtonClick += new System.EventHandler(this.add_table_btn_ButtonClick);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tables_dg);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tables view";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainView_FormClosing);
            this.Load += new System.EventHandler(this.MainView_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tables_dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progress_br;
        private System.Windows.Forms.ToolStripStatusLabel status_lbl;
        private System.Windows.Forms.DataGridView tables_dg;
        private System.Windows.Forms.ToolStripSplitButton add_table_btn;
    }
}