using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalLab
{
    public partial class Patients_Page : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=MedicalLab;Integrated Security=True");
        public Patients_Page()
        {
            InitializeComponent();
            PatientsUpdate();
        }
        public void PatientsUpdate()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda = new SqlDataAdapter("Select * from Patients", con);
            SqlCommandBuilder scb = new SqlCommandBuilder();
            scb = new SqlCommandBuilder(sda);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            pat_dvg.DataSource = ds.Tables[0];
            con.Close();
        }
        public void Clear()
        {
            patname_txt.Text = "";
            patientgen_combobox.SelectedIndex = -1;
            patphone_txt.Text = "";
            pataddress_txt.Text = "";
            patdob_date.Value = DateTime.Now;
            Key = 0;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (patname_txt.Text == "" || patientgen_combobox.SelectedIndex == -1 || patphone_txt.Text == ""
              || pataddress_txt.Text == "")
            {
                MessageBox.Show("Missing Information", "Patient Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand com = new SqlCommand();
                    com = new SqlCommand("Insert into Patients(PatName , PatAddress , PatPhone , PatDOB" +
                        ", PatCreatedAt , PatGender) Values ('" + patname_txt.Text + "' , '" + pataddress_txt.Text + "' , '" + patphone_txt.Text + "' , '" + patdob_date.Value.Date + "'," +
                        "'" + DateTime.Now + "' , '" + patientgen_combobox.SelectedItem.ToString() + "')", con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Patient Added Successfully", "Add New Patient", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    PatientsUpdate();
                    Clear();
                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.Message, "Patient Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (patname_txt.Text == "" || patientgen_combobox.SelectedIndex == -1 || patphone_txt.Text == ""
              || pataddress_txt.Text == "")
            {
                MessageBox.Show("Missing Information", "Patient Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand com = new SqlCommand();
                    com = new SqlCommand("Update Patients set [PatName]='" + patname_txt.Text + "' , [PatAddress] ='" + pataddress_txt.Text + "' , [PatPhone] ='" + patphone_txt.Text + "' ,[PatDOB] ='" + patdob_date.Value.Date + "'" +
                        ", [PatGender] ='" + patientgen_combobox.SelectedItem.ToString() + "' where PatID = '" + Key + "'", con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Patient Updated Successfully", "Update Patient", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    PatientsUpdate();
                    Clear();
                    add_btn.Enabled = true;

                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.Message, "Patient Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        int Key = 0;
        private void pat_dvg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            add_btn.Enabled = false;

            int i = e.RowIndex;
            DataGridViewRow row = pat_dvg.Rows[i];
            patname_txt.Text = row.Cells[1].Value.ToString();
            pataddress_txt.Text = row.Cells[2].Value.ToString();
            patphone_txt.Text = row.Cells[3].Value.ToString();
            patdob_date.Text = row.Cells[4].Value.ToString();
            patientgen_combobox.SelectedItem = row.Cells[5].Value.ToString();

            if (patname_txt.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(row.Cells[0].Value.ToString());
            }
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select Patient !! ", "Patient Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand com = new SqlCommand();
                    com = new SqlCommand("Delete Patients where PatID = '" + Key + "'", con);
                    com.ExecuteNonQuery();
                    if (MessageBox.Show("Do Yoy Want Delete ['" + patname_txt.Text + "'] Data ? ", "Delete Patient", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        MessageBox.Show("Patient Deleted Successfully", "Delete Patient", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Patients_Page patients = new Patients_Page();
                        patients.Show();
                    }
                    con.Close();
                    PatientsUpdate();
                    Clear();
                    add_btn.Enabled = true;
                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.Message, "Patient Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void patient_btn_Click(object sender, EventArgs e)
        {
            Patients_Page patients = new Patients_Page();
            patients.Show();
            this.Hide();
        }

        private void agent_btn_Click(object sender, EventArgs e)
        {
            Agents_Page agents = new Agents_Page();
            agents.Show();
            this.Hide();
        }

        private void test_btn_Click(object sender, EventArgs e)
        {
            Tests_Page tests = new Tests_Page();
            tests.Show();
            this.Hide();
        }

        private void result_btn_Click(object sender, EventArgs e)
        {
            Results_Page results = new Results_Page();
            results.Show();
            this.Hide();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            LogIn_Page logIn = new LogIn_Page();
            logIn.Show();
            this.Hide();
        }
    }
}
