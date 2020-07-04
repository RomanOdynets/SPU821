namespace DataBase_View.GUI
{
    partial class CreateTable
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
            this.tableName_tb = new System.Windows.Forms.TextBox();
            this.table_info_gb = new System.Windows.Forms.GroupBox();
            this.del_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.columns_list = new System.Windows.Forms.ListView();
            this.columns_lbl = new System.Windows.Forms.Label();
            this.table_columns_lbl = new System.Windows.Forms.Label();
            this.table_name_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pk_lbl = new System.Windows.Forms.Label();
            this.pk_columns_cb = new System.Windows.Forms.ComboBox();
            this.ai_select_lbl = new System.Windows.Forms.Label();
            this.select_ai_cb = new System.Windows.Forms.ComboBox();
            this.createTable_btn = new System.Windows.Forms.Button();
            this.status_lbl = new System.Windows.Forms.Label();
            this.table_info_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableName_tb
            // 
            this.tableName_tb.Location = new System.Drawing.Point(12, 36);
            this.tableName_tb.Name = "tableName_tb";
            this.tableName_tb.Size = new System.Drawing.Size(260, 20);
            this.tableName_tb.TabIndex = 0;
            this.tableName_tb.TextChanged += new System.EventHandler(this.tableName_tb_TextChanged);
            // 
            // table_info_gb
            // 
            this.table_info_gb.Controls.Add(this.del_btn);
            this.table_info_gb.Controls.Add(this.add_btn);
            this.table_info_gb.Controls.Add(this.columns_list);
            this.table_info_gb.Controls.Add(this.columns_lbl);
            this.table_info_gb.Controls.Add(this.table_columns_lbl);
            this.table_info_gb.Controls.Add(this.table_name_lbl);
            this.table_info_gb.Location = new System.Drawing.Point(324, 12);
            this.table_info_gb.Name = "table_info_gb";
            this.table_info_gb.Size = new System.Drawing.Size(250, 300);
            this.table_info_gb.TabIndex = 1;
            this.table_info_gb.TabStop = false;
            this.table_info_gb.Text = "Table Info";
            // 
            // del_btn
            // 
            this.del_btn.Location = new System.Drawing.Point(201, 181);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(43, 113);
            this.del_btn.TabIndex = 5;
            this.del_btn.Text = "-";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(201, 62);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(43, 113);
            this.add_btn.TabIndex = 4;
            this.add_btn.Text = "+";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // columns_list
            // 
            this.columns_list.GridLines = true;
            this.columns_list.HideSelection = false;
            this.columns_list.Location = new System.Drawing.Point(10, 62);
            this.columns_list.MultiSelect = false;
            this.columns_list.Name = "columns_list";
            this.columns_list.Size = new System.Drawing.Size(184, 232);
            this.columns_list.TabIndex = 3;
            this.columns_list.UseCompatibleStateImageBehavior = false;
            // 
            // columns_lbl
            // 
            this.columns_lbl.AutoSize = true;
            this.columns_lbl.Location = new System.Drawing.Point(7, 46);
            this.columns_lbl.Name = "columns_lbl";
            this.columns_lbl.Size = new System.Drawing.Size(50, 13);
            this.columns_lbl.TabIndex = 2;
            this.columns_lbl.Text = "Columns:";
            // 
            // table_columns_lbl
            // 
            this.table_columns_lbl.AutoSize = true;
            this.table_columns_lbl.Location = new System.Drawing.Point(7, 33);
            this.table_columns_lbl.Name = "table_columns_lbl";
            this.table_columns_lbl.Size = new System.Drawing.Size(81, 13);
            this.table_columns_lbl.TabIndex = 1;
            this.table_columns_lbl.Text = "Columns Count:";
            // 
            // table_name_lbl
            // 
            this.table_name_lbl.AutoSize = true;
            this.table_name_lbl.Location = new System.Drawing.Point(7, 20);
            this.table_name_lbl.Name = "table_name_lbl";
            this.table_name_lbl.Size = new System.Drawing.Size(71, 13);
            this.table_name_lbl.TabIndex = 0;
            this.table_name_lbl.Text = "Table Name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter table name:";
            // 
            // pk_lbl
            // 
            this.pk_lbl.AutoSize = true;
            this.pk_lbl.Location = new System.Drawing.Point(16, 74);
            this.pk_lbl.Name = "pk_lbl";
            this.pk_lbl.Size = new System.Drawing.Size(96, 13);
            this.pk_lbl.TabIndex = 3;
            this.pk_lbl.Text = "Select primary key:";
            // 
            // pk_columns_cb
            // 
            this.pk_columns_cb.FormattingEnabled = true;
            this.pk_columns_cb.Location = new System.Drawing.Point(12, 90);
            this.pk_columns_cb.Name = "pk_columns_cb";
            this.pk_columns_cb.Size = new System.Drawing.Size(260, 21);
            this.pk_columns_cb.TabIndex = 4;
            this.pk_columns_cb.SelectedIndexChanged += new System.EventHandler(this.checkStatus);
            // 
            // ai_select_lbl
            // 
            this.ai_select_lbl.AutoSize = true;
            this.ai_select_lbl.Location = new System.Drawing.Point(19, 130);
            this.ai_select_lbl.Name = "ai_select_lbl";
            this.ai_select_lbl.Size = new System.Drawing.Size(113, 13);
            this.ai_select_lbl.TabIndex = 5;
            this.ai_select_lbl.Text = "Select auto increment:";
            // 
            // select_ai_cb
            // 
            this.select_ai_cb.FormattingEnabled = true;
            this.select_ai_cb.Location = new System.Drawing.Point(12, 146);
            this.select_ai_cb.Name = "select_ai_cb";
            this.select_ai_cb.Size = new System.Drawing.Size(260, 21);
            this.select_ai_cb.TabIndex = 6;
            this.select_ai_cb.SelectedIndexChanged += new System.EventHandler(this.checkStatus);
            // 
            // createTable_btn
            // 
            this.createTable_btn.Location = new System.Drawing.Point(12, 282);
            this.createTable_btn.Name = "createTable_btn";
            this.createTable_btn.Size = new System.Drawing.Size(260, 23);
            this.createTable_btn.TabIndex = 7;
            this.createTable_btn.Text = "Create table";
            this.createTable_btn.UseVisualStyleBackColor = true;
            this.createTable_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // status_lbl
            // 
            this.status_lbl.AutoSize = true;
            this.status_lbl.Location = new System.Drawing.Point(13, 210);
            this.status_lbl.Name = "status_lbl";
            this.status_lbl.Size = new System.Drawing.Size(0, 13);
            this.status_lbl.TabIndex = 8;
            // 
            // CreateTable
            // 
            this.AcceptButton = this.createTable_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 324);
            this.Controls.Add(this.status_lbl);
            this.Controls.Add(this.createTable_btn);
            this.Controls.Add(this.select_ai_cb);
            this.Controls.Add(this.ai_select_lbl);
            this.Controls.Add(this.pk_columns_cb);
            this.Controls.Add(this.pk_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.table_info_gb);
            this.Controls.Add(this.tableName_tb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreateTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CreateTable";
            this.table_info_gb.ResumeLayout(false);
            this.table_info_gb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tableName_tb;
        private System.Windows.Forms.GroupBox table_info_gb;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.ListView columns_list;
        private System.Windows.Forms.Label columns_lbl;
        private System.Windows.Forms.Label table_columns_lbl;
        private System.Windows.Forms.Label table_name_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pk_lbl;
        private System.Windows.Forms.ComboBox pk_columns_cb;
        private System.Windows.Forms.Label ai_select_lbl;
        private System.Windows.Forms.ComboBox select_ai_cb;
        private System.Windows.Forms.Button createTable_btn;
        private System.Windows.Forms.Label status_lbl;
    }
}