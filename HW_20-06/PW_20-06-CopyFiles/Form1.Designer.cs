namespace PW_20_06_CopyFiles
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.path_from_tb = new System.Windows.Forms.TextBox();
            this.path_to_tb = new System.Windows.Forms.TextBox();
            this.open1_btn = new System.Windows.Forms.Button();
            this.open2_btn = new System.Windows.Forms.Button();
            this.copy_btn = new System.Windows.Forms.Button();
            this.status_pb = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // path_from_tb
            // 
            this.path_from_tb.Enabled = false;
            this.path_from_tb.Location = new System.Drawing.Point(25, 12);
            this.path_from_tb.Name = "path_from_tb";
            this.path_from_tb.Size = new System.Drawing.Size(565, 20);
            this.path_from_tb.TabIndex = 0;
            // 
            // path_to_tb
            // 
            this.path_to_tb.Enabled = false;
            this.path_to_tb.Location = new System.Drawing.Point(25, 38);
            this.path_to_tb.Name = "path_to_tb";
            this.path_to_tb.Size = new System.Drawing.Size(565, 20);
            this.path_to_tb.TabIndex = 1;
            // 
            // open1_btn
            // 
            this.open1_btn.Location = new System.Drawing.Point(596, 9);
            this.open1_btn.Name = "open1_btn";
            this.open1_btn.Size = new System.Drawing.Size(181, 23);
            this.open1_btn.TabIndex = 2;
            this.open1_btn.Text = "Open";
            this.open1_btn.UseVisualStyleBackColor = true;
            this.open1_btn.Click += new System.EventHandler(this.open1_btn_Click);
            // 
            // open2_btn
            // 
            this.open2_btn.Location = new System.Drawing.Point(596, 35);
            this.open2_btn.Name = "open2_btn";
            this.open2_btn.Size = new System.Drawing.Size(181, 23);
            this.open2_btn.TabIndex = 3;
            this.open2_btn.Text = "Open";
            this.open2_btn.UseVisualStyleBackColor = true;
            this.open2_btn.Click += new System.EventHandler(this.open2_btn_Click);
            // 
            // copy_btn
            // 
            this.copy_btn.Location = new System.Drawing.Point(25, 103);
            this.copy_btn.Name = "copy_btn";
            this.copy_btn.Size = new System.Drawing.Size(752, 23);
            this.copy_btn.TabIndex = 4;
            this.copy_btn.Text = "Copy";
            this.copy_btn.UseVisualStyleBackColor = true;
            this.copy_btn.Click += new System.EventHandler(this.copy_btn_Click);
            // 
            // status_pb
            // 
            this.status_pb.Location = new System.Drawing.Point(25, 64);
            this.status_pb.Name = "status_pb";
            this.status_pb.Size = new System.Drawing.Size(752, 23);
            this.status_pb.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 321);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.status_pb);
            this.Controls.Add(this.copy_btn);
            this.Controls.Add(this.open2_btn);
            this.Controls.Add(this.open1_btn);
            this.Controls.Add(this.path_to_tb);
            this.Controls.Add(this.path_from_tb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox path_from_tb;
        private System.Windows.Forms.TextBox path_to_tb;
        private System.Windows.Forms.Button open1_btn;
        private System.Windows.Forms.Button open2_btn;
        private System.Windows.Forms.Button copy_btn;
        private System.Windows.Forms.ProgressBar status_pb;
        private System.Windows.Forms.Label label1;
    }
}

