namespace MedicalLab
{
    partial class Results_Page
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
            this.close_btn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.del_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.res_dvg = new System.Windows.Forms.DataGridView();
            this.patname_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.agname_combocox = new System.Windows.Forms.ComboBox();
            this.tsname_comboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.result_comboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ok_btn = new System.Windows.Forms.Button();
            this.tests_txt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.costs_txt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.res_dvg)).BeginInit();
            this.SuspendLayout();
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
            this.close_btn.TabIndex = 68;
            this.close_btn.Text = "X";
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 29);
            this.label2.TabIndex = 67;
            this.label2.Text = "Results Page";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Hacen Tunisia Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(990, 56);
            this.label1.TabIndex = 66;
            this.label1.Text = "Medical Laboratory Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // del_btn
            // 
            this.del_btn.BackColor = System.Drawing.Color.Maroon;
            this.del_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_btn.ForeColor = System.Drawing.Color.White;
            this.del_btn.Location = new System.Drawing.Point(808, 201);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(91, 37);
            this.del_btn.TabIndex = 10;
            this.del_btn.Text = "Delete";
            this.del_btn.UseVisualStyleBackColor = false;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.Maroon;
            this.edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_btn.ForeColor = System.Drawing.Color.White;
            this.edit_btn.Location = new System.Drawing.Point(861, 163);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(91, 37);
            this.edit_btn.TabIndex = 9;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.Maroon;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.Location = new System.Drawing.Point(764, 163);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(91, 37);
            this.add_btn.TabIndex = 8;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // res_dvg
            // 
            this.res_dvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.res_dvg.Location = new System.Drawing.Point(12, 323);
            this.res_dvg.Name = "res_dvg";
            this.res_dvg.RowHeadersWidth = 62;
            this.res_dvg.RowTemplate.Height = 28;
            this.res_dvg.Size = new System.Drawing.Size(967, 365);
            this.res_dvg.TabIndex = 72;
            this.res_dvg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.res_dvg_CellContentClick);
            // 
            // patname_comboBox
            // 
            this.patname_comboBox.FormattingEnabled = true;
            this.patname_comboBox.Location = new System.Drawing.Point(99, 91);
            this.patname_comboBox.Name = "patname_comboBox";
            this.patname_comboBox.Size = new System.Drawing.Size(140, 37);
            this.patname_comboBox.TabIndex = 1;
            this.patname_comboBox.SelectedIndexChanged += new System.EventHandler(this.patname_comboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(109, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 29);
            this.label3.TabIndex = 75;
            this.label3.Text = "Patient Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Location = new System.Drawing.Point(110, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 29);
            this.label6.TabIndex = 75;
            this.label6.Text = "Agentt Name";
            // 
            // agname_combocox
            // 
            this.agname_combocox.FormattingEnabled = true;
            this.agname_combocox.Location = new System.Drawing.Point(99, 163);
            this.agname_combocox.Name = "agname_combocox";
            this.agname_combocox.Size = new System.Drawing.Size(140, 37);
            this.agname_combocox.TabIndex = 3;
            this.agname_combocox.SelectedIndexChanged += new System.EventHandler(this.agname_combocox_SelectedIndexChanged);
            // 
            // tsname_comboBox
            // 
            this.tsname_comboBox.FormattingEnabled = true;
            this.tsname_comboBox.Location = new System.Drawing.Point(99, 237);
            this.tsname_comboBox.Name = "tsname_comboBox";
            this.tsname_comboBox.Size = new System.Drawing.Size(140, 37);
            this.tsname_comboBox.TabIndex = 5;
            this.tsname_comboBox.SelectedIndexChanged += new System.EventHandler(this.tsname_comboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Location = new System.Drawing.Point(119, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 29);
            this.label7.TabIndex = 75;
            this.label7.Text = "Test Name";
            // 
            // result_comboBox
            // 
            this.result_comboBox.FormattingEnabled = true;
            this.result_comboBox.Items.AddRange(new object[] {
            "Negative (-)",
            "Positive (+)"});
            this.result_comboBox.Location = new System.Drawing.Point(274, 163);
            this.result_comboBox.Name = "result_comboBox";
            this.result_comboBox.Size = new System.Drawing.Size(140, 37);
            this.result_comboBox.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Location = new System.Drawing.Point(312, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 29);
            this.label9.TabIndex = 75;
            this.label9.Text = "Result";
            // 
            // ok_btn
            // 
            this.ok_btn.BackColor = System.Drawing.Color.Maroon;
            this.ok_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok_btn.ForeColor = System.Drawing.Color.White;
            this.ok_btn.Location = new System.Drawing.Point(460, 163);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(54, 37);
            this.ok_btn.TabIndex = 7;
            this.ok_btn.Text = "=>";
            this.ok_btn.UseVisualStyleBackColor = false;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // tests_txt
            // 
            this.tests_txt.Enabled = false;
            this.tests_txt.Location = new System.Drawing.Point(556, 91);
            this.tests_txt.Multiline = true;
            this.tests_txt.Name = "tests_txt";
            this.tests_txt.Size = new System.Drawing.Size(182, 183);
            this.tests_txt.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Location = new System.Drawing.Point(619, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 29);
            this.label10.TabIndex = 75;
            this.label10.Text = "Tests";
            // 
            // costs_txt
            // 
            this.costs_txt.Enabled = false;
            this.costs_txt.Location = new System.Drawing.Point(744, 91);
            this.costs_txt.Name = "costs_txt";
            this.costs_txt.Size = new System.Drawing.Size(208, 37);
            this.costs_txt.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Location = new System.Drawing.Point(820, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 29);
            this.label11.TabIndex = 75;
            this.label11.Text = "Costs";
            // 
            // search_txt
            // 
            this.search_txt.BackColor = System.Drawing.Color.Gainsboro;
            this.search_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search_txt.Enabled = false;
            this.search_txt.Location = new System.Drawing.Point(365, 287);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(261, 30);
            this.search_txt.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Hacen Tunisia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(248, 289);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 26);
            this.label12.TabIndex = 76;
            this.label12.Text = "Search Here";
            // 
            // Results_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(990, 700);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tsname_comboBox);
            this.Controls.Add(this.result_comboBox);
            this.Controls.Add(this.agname_combocox);
            this.Controls.Add(this.patname_comboBox);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.tests_txt);
            this.Controls.Add(this.costs_txt);
            this.Controls.Add(this.res_dvg);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Hacen Tunisia", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Results_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Results_Page";
            ((System.ComponentModel.ISupportInitialize)(this.res_dvg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label close_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.DataGridView res_dvg;
        private System.Windows.Forms.ComboBox patname_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox agname_combocox;
        private System.Windows.Forms.ComboBox tsname_comboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox result_comboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.TextBox tests_txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox costs_txt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.Label label12;
    }
}