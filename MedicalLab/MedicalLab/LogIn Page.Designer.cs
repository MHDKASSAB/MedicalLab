namespace MedicalLab
{
    partial class LogIn_Page
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
            this.conasadmin_lbl = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.close_btn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // conasadmin_lbl
            // 
            this.conasadmin_lbl.AutoSize = true;
            this.conasadmin_lbl.BackColor = System.Drawing.Color.LavenderBlush;
            this.conasadmin_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.conasadmin_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.conasadmin_lbl.Font = new System.Drawing.Font("Hacen Tunisia Lt", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conasadmin_lbl.ForeColor = System.Drawing.Color.Black;
            this.conasadmin_lbl.Location = new System.Drawing.Point(285, 150);
            this.conasadmin_lbl.Name = "conasadmin_lbl";
            this.conasadmin_lbl.Size = new System.Drawing.Size(140, 29);
            this.conasadmin_lbl.TabIndex = 46;
            this.conasadmin_lbl.Text = "LogIn As Admin";
            this.conasadmin_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.conasadmin_lbl.Click += new System.EventHandler(this.conasadmin_lbl_Click);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.Maroon;
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Hacen Tunisia Lt", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(166, 143);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(113, 43);
            this.login_btn.TabIndex = 50;
            this.login_btn.Text = "LogIn";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Hacen Tunisia Lt", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 29);
            this.label2.TabIndex = 49;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // password_txt
            // 
            this.password_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_txt.Location = new System.Drawing.Point(164, 101);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(201, 36);
            this.password_txt.TabIndex = 48;
            this.password_txt.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Hacen Tunisia Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 46);
            this.label1.TabIndex = 47;
            this.label1.Text = "Medical Laboratory Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // username_txt
            // 
            this.username_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username_txt.Location = new System.Drawing.Point(164, 59);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(201, 36);
            this.username_txt.TabIndex = 48;
            this.username_txt.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Hacen Tunisia Lt", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 29);
            this.label3.TabIndex = 49;
            this.label3.Text = "UserName";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // close_btn
            // 
            this.close_btn.AutoSize = true;
            this.close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Hacen Tunisia Lt", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.Location = new System.Drawing.Point(420, 0);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(24, 29);
            this.close_btn.TabIndex = 51;
            this.close_btn.Text = "X";
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // LogIn_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(450, 200);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.conasadmin_lbl);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.username_txt);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Hacen Tunisia Lt", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LogIn_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn_Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label conasadmin_lbl;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label close_btn;
    }
}