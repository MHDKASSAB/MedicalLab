namespace MedicalLab
{
    partial class Patients_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patients_Page));
            this.patname_txt = new System.Windows.Forms.TextBox();
            this.pataddress_txt = new System.Windows.Forms.TextBox();
            this.patphone_txt = new System.Windows.Forms.TextBox();
            this.patientgen_combobox = new System.Windows.Forms.ComboBox();
            this.patdob_date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.pat_dvg = new System.Windows.Forms.DataGridView();
            this.close_btn = new System.Windows.Forms.Label();
            this.panelbuttons = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.PictureBox();
            this.result_btn = new System.Windows.Forms.PictureBox();
            this.test_btn = new System.Windows.Forms.PictureBox();
            this.agent_btn = new System.Windows.Forms.PictureBox();
            this.patient_btn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pat_dvg)).BeginInit();
            this.panelbuttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logout_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.result_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agent_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patient_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // patname_txt
            // 
            this.patname_txt.Location = new System.Drawing.Point(146, 112);
            this.patname_txt.Name = "patname_txt";
            this.patname_txt.Size = new System.Drawing.Size(208, 37);
            this.patname_txt.TabIndex = 0;
            // 
            // pataddress_txt
            // 
            this.pataddress_txt.Location = new System.Drawing.Point(146, 293);
            this.pataddress_txt.Name = "pataddress_txt";
            this.pataddress_txt.Size = new System.Drawing.Size(208, 37);
            this.pataddress_txt.TabIndex = 4;
            // 
            // patphone_txt
            // 
            this.patphone_txt.Location = new System.Drawing.Point(146, 160);
            this.patphone_txt.Name = "patphone_txt";
            this.patphone_txt.Size = new System.Drawing.Size(208, 37);
            this.patphone_txt.TabIndex = 1;
            // 
            // patientgen_combobox
            // 
            this.patientgen_combobox.FormattingEnabled = true;
            this.patientgen_combobox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.patientgen_combobox.Location = new System.Drawing.Point(146, 203);
            this.patientgen_combobox.Name = "patientgen_combobox";
            this.patientgen_combobox.Size = new System.Drawing.Size(208, 37);
            this.patientgen_combobox.TabIndex = 2;
            // 
            // patdob_date
            // 
            this.patdob_date.Location = new System.Drawing.Point(146, 243);
            this.patdob_date.Name = "patdob_date";
            this.patdob_date.Size = new System.Drawing.Size(208, 37);
            this.patdob_date.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Hacen Tunisia Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(990, 56);
            this.label1.TabIndex = 48;
            this.label1.Text = "Medical Laboratory Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 29);
            this.label2.TabIndex = 49;
            this.label2.Text = "Patients Page";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 29);
            this.label3.TabIndex = 49;
            this.label3.Text = "Patient Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 29);
            this.label4.TabIndex = 49;
            this.label4.Text = "Patient Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 29);
            this.label5.TabIndex = 49;
            this.label5.Text = "Patient Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 29);
            this.label6.TabIndex = 49;
            this.label6.Text = "Patient Address";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(1851, -20);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(297, 37);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 29);
            this.label7.TabIndex = 49;
            this.label7.Text = "BOD";
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.Maroon;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.Location = new System.Drawing.Point(25, 353);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(91, 37);
            this.add_btn.TabIndex = 5;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.Maroon;
            this.edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_btn.ForeColor = System.Drawing.Color.White;
            this.edit_btn.Location = new System.Drawing.Point(122, 353);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(91, 37);
            this.edit_btn.TabIndex = 6;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.BackColor = System.Drawing.Color.Maroon;
            this.del_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_btn.ForeColor = System.Drawing.Color.White;
            this.del_btn.Location = new System.Drawing.Point(219, 353);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(91, 37);
            this.del_btn.TabIndex = 7;
            this.del_btn.Text = "Delete";
            this.del_btn.UseVisualStyleBackColor = false;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // pat_dvg
            // 
            this.pat_dvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pat_dvg.Location = new System.Drawing.Point(374, 116);
            this.pat_dvg.Name = "pat_dvg";
            this.pat_dvg.RowHeadersWidth = 62;
            this.pat_dvg.RowTemplate.Height = 28;
            this.pat_dvg.Size = new System.Drawing.Size(605, 572);
            this.pat_dvg.TabIndex = 50;
            this.pat_dvg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pat_dvg_CellContentClick);
            // 
            // close_btn
            // 
            this.close_btn.AutoSize = true;
            this.close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Hacen Tunisia Lt", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.Location = new System.Drawing.Point(967, 0);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(24, 29);
            this.close_btn.TabIndex = 52;
            this.close_btn.Text = "X";
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // panelbuttons
            // 
            this.panelbuttons.BackColor = System.Drawing.Color.Maroon;
            this.panelbuttons.Controls.Add(this.logout_btn);
            this.panelbuttons.Controls.Add(this.result_btn);
            this.panelbuttons.Controls.Add(this.test_btn);
            this.panelbuttons.Controls.Add(this.agent_btn);
            this.panelbuttons.Controls.Add(this.patient_btn);
            this.panelbuttons.ForeColor = System.Drawing.Color.White;
            this.panelbuttons.Location = new System.Drawing.Point(56, 537);
            this.panelbuttons.Name = "panelbuttons";
            this.panelbuttons.Size = new System.Drawing.Size(228, 140);
            this.panelbuttons.TabIndex = 53;
            // 
            // logout_btn
            // 
            this.logout_btn.Image = ((System.Drawing.Image)(resources.GetObject("logout_btn.Image")));
            this.logout_btn.Location = new System.Drawing.Point(122, 76);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(50, 50);
            this.logout_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logout_btn.TabIndex = 54;
            this.logout_btn.TabStop = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // result_btn
            // 
            this.result_btn.Image = ((System.Drawing.Image)(resources.GetObject("result_btn.Image")));
            this.result_btn.Location = new System.Drawing.Point(53, 76);
            this.result_btn.Name = "result_btn";
            this.result_btn.Size = new System.Drawing.Size(50, 50);
            this.result_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.result_btn.TabIndex = 54;
            this.result_btn.TabStop = false;
            this.result_btn.Click += new System.EventHandler(this.result_btn_Click);
            // 
            // test_btn
            // 
            this.test_btn.Image = ((System.Drawing.Image)(resources.GetObject("test_btn.Image")));
            this.test_btn.Location = new System.Drawing.Point(163, 20);
            this.test_btn.Name = "test_btn";
            this.test_btn.Size = new System.Drawing.Size(50, 50);
            this.test_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.test_btn.TabIndex = 54;
            this.test_btn.TabStop = false;
            this.test_btn.Click += new System.EventHandler(this.test_btn_Click);
            // 
            // agent_btn
            // 
            this.agent_btn.Image = ((System.Drawing.Image)(resources.GetObject("agent_btn.Image")));
            this.agent_btn.Location = new System.Drawing.Point(90, 20);
            this.agent_btn.Name = "agent_btn";
            this.agent_btn.Size = new System.Drawing.Size(50, 50);
            this.agent_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.agent_btn.TabIndex = 54;
            this.agent_btn.TabStop = false;
            this.agent_btn.Click += new System.EventHandler(this.agent_btn_Click);
            // 
            // patient_btn
            // 
            this.patient_btn.Image = ((System.Drawing.Image)(resources.GetObject("patient_btn.Image")));
            this.patient_btn.Location = new System.Drawing.Point(25, 20);
            this.patient_btn.Name = "patient_btn";
            this.patient_btn.Size = new System.Drawing.Size(50, 50);
            this.patient_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.patient_btn.TabIndex = 54;
            this.patient_btn.TabStop = false;
            this.patient_btn.Click += new System.EventHandler(this.patient_btn_Click);
            // 
            // Patients_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(990, 700);
            this.Controls.Add(this.panelbuttons);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.pat_dvg);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.patdob_date);
            this.Controls.Add(this.patientgen_combobox);
            this.Controls.Add(this.patphone_txt);
            this.Controls.Add(this.pataddress_txt);
            this.Controls.Add(this.patname_txt);
            this.Font = new System.Drawing.Font("Hacen Tunisia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Patients_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patients_Page";
            ((System.ComponentModel.ISupportInitialize)(this.pat_dvg)).EndInit();
            this.panelbuttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logout_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.result_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agent_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patient_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox patname_txt;
        private System.Windows.Forms.TextBox pataddress_txt;
        private System.Windows.Forms.TextBox patphone_txt;
        private System.Windows.Forms.ComboBox patientgen_combobox;
        private System.Windows.Forms.DateTimePicker patdob_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.DataGridView pat_dvg;
        private System.Windows.Forms.Label close_btn;
        private System.Windows.Forms.Panel panelbuttons;
        private System.Windows.Forms.PictureBox logout_btn;
        private System.Windows.Forms.PictureBox result_btn;
        private System.Windows.Forms.PictureBox test_btn;
        private System.Windows.Forms.PictureBox agent_btn;
        private System.Windows.Forms.PictureBox patient_btn;
    }
}