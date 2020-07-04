namespace DataBase_View.GUI
{
    partial class Auth
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
            this.login_tb = new System.Windows.Forms.TextBox();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.login_lbl = new System.Windows.Forms.Label();
            this.password_lbl = new System.Windows.Forms.Label();
            this.auth_btn = new System.Windows.Forms.Button();
            this.savepass_cb = new System.Windows.Forms.CheckBox();
            this.quickauth_cb = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // login_tb
            // 
            this.login_tb.Location = new System.Drawing.Point(12, 28);
            this.login_tb.Name = "login_tb";
            this.login_tb.Size = new System.Drawing.Size(240, 20);
            this.login_tb.TabIndex = 0;
            // 
            // password_tb
            // 
            this.password_tb.Location = new System.Drawing.Point(275, 28);
            this.password_tb.Name = "password_tb";
            this.password_tb.PasswordChar = '*';
            this.password_tb.Size = new System.Drawing.Size(240, 20);
            this.password_tb.TabIndex = 1;
            // 
            // login_lbl
            // 
            this.login_lbl.AutoSize = true;
            this.login_lbl.Location = new System.Drawing.Point(12, 9);
            this.login_lbl.Name = "login_lbl";
            this.login_lbl.Size = new System.Drawing.Size(83, 13);
            this.login_lbl.TabIndex = 2;
            this.login_lbl.Text = "Enter your login:";
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Location = new System.Drawing.Point(272, 9);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(106, 13);
            this.password_lbl.TabIndex = 3;
            this.password_lbl.Text = "Enter your password:";
            // 
            // auth_btn
            // 
            this.auth_btn.Location = new System.Drawing.Point(12, 95);
            this.auth_btn.Name = "auth_btn";
            this.auth_btn.Size = new System.Drawing.Size(503, 23);
            this.auth_btn.TabIndex = 4;
            this.auth_btn.Text = "Go auth";
            this.auth_btn.UseVisualStyleBackColor = true;
            this.auth_btn.Click += new System.EventHandler(this.auth_btn_Click);
            // 
            // savepass_cb
            // 
            this.savepass_cb.AutoSize = true;
            this.savepass_cb.Location = new System.Drawing.Point(12, 72);
            this.savepass_cb.Name = "savepass_cb";
            this.savepass_cb.Size = new System.Drawing.Size(99, 17);
            this.savepass_cb.TabIndex = 5;
            this.savepass_cb.Text = "Save password";
            this.savepass_cb.UseVisualStyleBackColor = true;
            // 
            // quickauth_cb
            // 
            this.quickauth_cb.AutoSize = true;
            this.quickauth_cb.Location = new System.Drawing.Point(275, 72);
            this.quickauth_cb.Name = "quickauth_cb";
            this.quickauth_cb.Size = new System.Drawing.Size(78, 17);
            this.quickauth_cb.TabIndex = 6;
            this.quickauth_cb.Text = "Quick auth";
            this.quickauth_cb.UseVisualStyleBackColor = true;
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 130);
            this.Controls.Add(this.quickauth_cb);
            this.Controls.Add(this.savepass_cb);
            this.Controls.Add(this.auth_btn);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.login_lbl);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.login_tb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auth";
            this.Load += new System.EventHandler(this.Auth_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login_tb;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.Label login_lbl;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.Button auth_btn;
        private System.Windows.Forms.CheckBox savepass_cb;
        private System.Windows.Forms.CheckBox quickauth_cb;
    }
}