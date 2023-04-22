namespace MedicalLab
{
    partial class AdminLogIn
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
            this.login_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancel_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.Maroon;
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Hacen Tunisia Lt", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.SystemColors.Info;
            this.login_btn.Location = new System.Drawing.Point(112, 96);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(227, 43);
            this.login_btn.TabIndex = 45;
            this.login_btn.Text = "LogIn";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 29);
            this.label2.TabIndex = 44;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // password_txt
            // 
            this.password_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_txt.Location = new System.Drawing.Point(109, 60);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(287, 30);
            this.password_txt.TabIndex = 43;
            this.password_txt.UseSystemPasswordChar = true;
            this.password_txt.TextChanged += new System.EventHandler(this.password_txt_TextChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Hacen Tunisia Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 46);
            this.label1.TabIndex = 42;
            this.label1.Text = "Medical Laboratory Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cancel_lbl
            // 
            this.cancel_lbl.AutoSize = true;
            this.cancel_lbl.BackColor = System.Drawing.Color.LavenderBlush;
            this.cancel_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_lbl.Font = new System.Drawing.Font("Hacen Tunisia Lt", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_lbl.ForeColor = System.Drawing.Color.Black;
            this.cancel_lbl.Location = new System.Drawing.Point(364, 103);
            this.cancel_lbl.Name = "cancel_lbl";
            this.cancel_lbl.Size = new System.Drawing.Size(69, 29);
            this.cancel_lbl.TabIndex = 39;
            this.cancel_lbl.Text = "Cancel";
            this.cancel_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancel_lbl.Click += new System.EventHandler(this.cancel_lbl_Click);
            // 
            // AdminLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(450, 150);
            this.Controls.Add(this.cancel_lbl);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Hacen Tunisia Lt", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cancel_lbl;
    }
}