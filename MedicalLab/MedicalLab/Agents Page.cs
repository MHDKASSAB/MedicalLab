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
    public partial class Agents_Page : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=MedicalLab;Integrated Security=True");
        public Agents_Page()
        {
            InitializeComponent();
            AgentUpdate();
        }
        public void AgentUpdate()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda = new SqlDataAdapter("Select * from Agents", con);
            SqlCommandBuilder scb = new SqlCommandBuilder();
            scb = new SqlCommandBuilder(sda);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            agents_dvg.DataSource = ds.Tables[0];
            con.Close();
        }
        public void Clear()
        {
            agname_txt.Text = "";
            aggen_combobox.SelectedIndex = -1;
            agpass_txt.Text = "";
            agphone_txt.Text = "";
            agaddress_txt.Text = "";
            agquali_combocox.SelectedIndex = -1;
            agaccess_combobox.SelectedIndex = -1;
            agdob_date.Value = DateTime.Now;
            Key = 0;

        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (agname_txt.Text == "" || aggen_combobox.SelectedIndex == -1 || agpass_txt.Text == ""
                || agphone_txt.Text == "" || agquali_combocox.SelectedIndex == -1 || agaddress_txt.Text == "")
            {
                MessageBox.Show("Missing Information", "Agent Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand com = new SqlCommand();
                    com = new SqlCommand("Insert into Agents(AgName , AgPass , AgPhone , AgAddress" +
                        ", AgGender , AgQualification , AgDOB , AgCreatedAt , AgAccess) Values ('" + agname_txt.Text + "' , '" + agpass_txt.Text + "' , '" + agphone_txt.Text + "' , '" + agaddress_txt.Text + "'," +
                        "'" + aggen_combobox.SelectedItem.ToString() + "' , '" + agquali_combocox.SelectedItem.ToString() + "' , '" + agdob_date.Value.Date + "' , '" + DateTime.Now + "', '" + agaccess_combobox.SelectedIndex.ToString() + "')", con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Agent Added Successfully", "Add New Agent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    AgentUpdate();
                    Clear();
                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.Message, "Agent Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        int Key = 0;
        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (agname_txt.Text == "" || aggen_combobox.SelectedIndex == -1 || agpass_txt.Text == ""
               || agphone_txt.Text == "" || agquali_combocox.SelectedIndex == -1 || agaddress_txt.Text == "")
            {
                MessageBox.Show("Missing Information", "Agent Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand com = new SqlCommand();
                    com = new SqlCommand("Update Agents set [AgName]='" + agname_txt.Text + "' , [AgPass] ='" + agpass_txt.Text + "' , [AgPhone] ='" + agphone_txt.Text + "' , [AgAddress] ='" + agaddress_txt.Text + "'" +
                        ", [AgGender] ='" + aggen_combobox.SelectedItem.ToString() + "' , [AgQualification] ='" + agquali_combocox.SelectedItem.ToString() + "' , [AgDOB] ='" + agdob_date.Value.Date + "''" + agaccess_combobox.SelectedItem.ToString() + "'" +
                        "where AgID = '" + Key + "'", con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Agent Updated Successfully", "Update Agent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    AgentUpdate();
                    Clear();
                    add_btn.Enabled = true;
                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.Message, "Agent Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select Agent !! ", "Agent Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand com = new SqlCommand();
                    com = new SqlCommand("Delete Agents where AgID = '" + Key + "'", con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Agent Deleted Successfully", "Delete Agent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    AgentUpdate();
                    Clear();
                    add_btn.Enabled = true;
                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.Message, "Agent Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void agents_dvg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            add_btn.Enabled = false;

            int i = e.RowIndex;
            DataGridViewRow row = agents_dvg.Rows[i];
            agname_txt.Text = row.Cells[1].Value.ToString();
            agpass_txt.Text = row.Cells[2].Value.ToString();
            agphone_txt.Text = row.Cells[3].Value.ToString();
            agaddress_txt.Text = row.Cells[4].Value.ToString();
            aggen_combobox.SelectedItem = row.Cells[5].Value.ToString();
            agquali_combocox.SelectedItem = row.Cells[6].Value.ToString();
            agdob_date.Text = row.Cells[7].Value.ToString();
            agaccess_combobox.SelectedItem = row.Cells[9].Value.ToString();


            if (agname_txt.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(row.Cells[0].Value.ToString());
            }
        }


        private void patient_btn_Click_1(object sender, EventArgs e)
        {
            Patients_Page patients = new Patients_Page();
            patients.Show();
            this.Hide();
        }

        private void agent_btn_Click_1(object sender, EventArgs e)
        {
            Agents_Page agents = new Agents_Page();
            agents.Show();
            this.Hide();
        }

        private void test_btn_Click_1(object sender, EventArgs e)
        {
            Tests_Page tests = new Tests_Page();
            tests.Show();
            this.Hide();
        }

        private void result_btn_Click_1(object sender, EventArgs e)
        {
            Results_Page results = new Results_Page();
            results.Show();
            this.Hide();
        }

        private void logout_btn_Click_1(object sender, EventArgs e)
        {
            LogIn_Page logIn = new LogIn_Page();
            logIn.Show();
            this.Hide();
        }
    }
}
