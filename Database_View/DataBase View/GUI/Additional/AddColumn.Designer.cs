namespace DataBase_View.GUI.Additional
{
    partial class AddColumn
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
            this.column_name_tb = new System.Windows.Forms.TextBox();
            this.column_type_cb = new System.Windows.Forms.ComboBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.column_length_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // column_name_tb
            // 
            this.column_name_tb.Location = new System.Drawing.Point(12, 23);
            this.column_name_tb.Name = "column_name_tb";
            this.column_name_tb.Size = new System.Drawing.Size(136, 20);
            this.column_name_tb.TabIndex = 0;
            // 
            // column_type_cb
            // 
            this.column_type_cb.FormattingEnabled = true;
            this.column_type_cb.Items.AddRange(new object[] {
            "INT",
            "VARCHAR",
            "DATE",
            "DATETIME",
            "TEXT",
            "REAL",
            "TIME",
            "TIMESTAMP",
            "TINYINT",
            "VARBINARY"});
            this.column_type_cb.Location = new System.Drawing.Point(154, 22);
            this.column_type_cb.Name = "column_type_cb";
            this.column_type_cb.Size = new System.Drawing.Size(124, 21);
            this.column_type_cb.TabIndex = 1;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(12, 49);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(353, 23);
            this.add_btn.TabIndex = 3;
            this.add_btn.Text = "Add column";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Column Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Column Type:";
            // 
            // column_length_tb
            // 
            this.column_length_tb.Location = new System.Drawing.Point(285, 22);
            this.column_length_tb.Name = "column_length_tb";
            this.column_length_tb.Size = new System.Drawing.Size(80, 20);
            this.column_length_tb.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Length:";
            // 
            // AddColumn
            // 
            this.AcceptButton = this.add_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 78);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.column_length_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.column_type_cb);
            this.Controls.Add(this.column_name_tb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddColumn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Column";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox column_name_tb;
        private System.Windows.Forms.ComboBox column_type_cb;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox column_length_tb;
        private System.Windows.Forms.Label label3;
    }
}