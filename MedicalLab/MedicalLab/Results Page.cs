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
    public partial class Results_Page : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=MedicalLab;Integrated Security=True");
        public Results_Page()
        {
            InitializeComponent();
            ResultsUpdate();
            GetPatientsName();
            //GetPatientsID();
            GetAgentssName();
            //GetAgentID();
            GetTetssName();
            //GetTestCode();
            Clear();
        }
        public void Clear()
        {
            costs_txt.Text = "";
            tests_txt.Text = "";
            result_comboBox.SelectedIndex = -1;
            agname_combocox.SelectedIndex = -1;
            patname_comboBox.SelectedIndex = -1;
            tsname_comboBox.SelectedIndex = -1;
            //patid_txt.Text = "";
            //agid_txt.Text = "";
            //tscode_txt.Text = "";
            Key = 0;
        }
        public void ResultsUpdate()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda = new SqlDataAdapter("Select * from Results", con);
            SqlCommandBuilder scb = new SqlCommandBuilder();
            scb = new SqlCommandBuilder(sda);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            res_dvg.DataSource = ds.Tables[0];
            con.Close();
        }

        private void GetSearchPatients()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda = new SqlDataAdapter("Select * from Results where PatName = '" + search_txt.Text + "' ".Trim().ToLower().ToUpper().TrimStart().TrimEnd(), con);
            SqlCommandBuilder scb = new SqlCommandBuilder();
            scb = new SqlCommandBuilder(sda);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            res_dvg.DataSource = ds.Tables[0];
            con.Close();
        }
        //private void GetPatientsID()
        //{
        //    SqlCommand com = new SqlCommand();
        //    com = new SqlCommand("Select * From Patients where PatName = '" + patname_comboBox.SelectedValue.ToString() + "'", con);
        //    con.Open();
        //    DataTable dt = new DataTable();
        //    SqlDataAdapter sda = new SqlDataAdapter(com);
        //    sda.Fill(dt);
        //    foreach (DataRow Dr in dt.Rows)
        //    {
        //        patid_txt.Text = Dr["PatID"].ToString();
        //    }
        //    con.Close();
        //}
        private void GetPatientsName()
        {
            con.Open();
            SqlCommand com = new SqlCommand();
            com = new SqlCommand("Select PatName From Patients", con);
            SqlDataReader sdr;
            sdr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PatName", typeof(string));
            dt.Load(sdr);
            patname_comboBox.ValueMember = "PatName";
            patname_comboBox.DataSource = dt;
            con.Close();
        }
        private void GetAgentssName()
        {
            con.Open();
            SqlCommand com = new SqlCommand();
            com = new SqlCommand("Select AgName From Agents", con);
            SqlDataReader sdr;
            sdr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("AgName", typeof(string));
            dt.Load(sdr);
            agname_combocox.ValueMember = "AgName";
            agname_combocox.DataSource = dt;
            con.Close();
        }
        //private void GetAgentID()
        //{
        //    con.Open();
        //    SqlCommand com = new SqlCommand();
        //    com = new SqlCommand("Select * From Agents where AgName = '" + agname_combocox.SelectedValue.ToString() + "'", con);
        //    DataTable dt = new DataTable();
        //    SqlDataAdapter sda = new SqlDataAdapter(com);
        //    sda.Fill(dt);
        //    foreach (DataRow Dr in dt.Rows)
        //    {
        //        agid_txt.Text = Dr["AgID"].ToString();
        //    }
        //    con.Close();
        //}
        private void GetTetssName()
        {
            con.Open();
            SqlCommand com = new SqlCommand();
            com = new SqlCommand("Select TsName From Tests", con);
            SqlDataReader sdr;
            sdr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TsName", typeof(string));
            dt.Load(sdr);
            tsname_comboBox.ValueMember = "TsName";
            tsname_comboBox.DataSource = dt;
            con.Close();
        }
        int Cost;
        //private void GetTestCode()
        //{
        //    con.Open();
        //    SqlCommand com = new SqlCommand();
        //    com = new SqlCommand("Select * From Tests where TsName = '" + tsname_comboBox.SelectedValue.ToString() + "'", con);
        //    DataTable dt = new DataTable();
        //    SqlDataAdapter sda = new SqlDataAdapter(com);
        //    sda.Fill(dt);
        //    foreach (DataRow Dr in dt.Rows)
        //    {
        //        tscode_txt.Text = Dr["TsCode"].ToString();
        //        Cost = Convert.ToInt32(Dr["TsCost"].ToString());
        //    }
        //    con.Close();
        //}
        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (costs_txt.Text == "" ||
            tests_txt.Text == "" ||
            result_comboBox.SelectedIndex == -1 ||
            agname_combocox.SelectedIndex == -1 ||
            patname_comboBox.SelectedIndex == -1 ||
            tsname_comboBox.SelectedIndex == -1)
            //patid_txt.Text == "" ||
            //agid_txt.Text == "" ||
            //tscode_txt.Text == "")
            {
                MessageBox.Show("Missing Information", "Result Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand com = new SqlCommand();
                    com = new SqlCommand("Insert into Results (PatName , TsName , ReCost , ReResult , AgName , ReDate , TestOK)" +
                        " Values ('" + patname_comboBox.SelectedValue.ToString() + "' , '" + tsname_comboBox.SelectedValue.ToString() + "' ,'" + costs_txt.Text + "','" + result_comboBox.SelectedItem.ToString() + "','" + agname_combocox.SelectedValue.ToString() + "'," +
                        "'" + DateTime.Now + "' , '" + tests_txt.Text + "')", con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Result Added Successfully", "Add New Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    ResultsUpdate();
                    Clear();
                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.Message, "Result Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        int Key = 0;
        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (costs_txt.Text == "" ||
            tests_txt.Text == "" ||
            result_comboBox.SelectedIndex == -1 ||
            agname_combocox.SelectedIndex == -1 ||
            patname_comboBox.SelectedIndex == -1 ||
            tsname_comboBox.SelectedIndex == -1)
            //patid_txt.Text == "" ||
            //agid_txt.Text == "" ||
            //tscode_txt.Text == "")
            {
                MessageBox.Show("Missing Information", "Result Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand com = new SqlCommand();
                    com = new SqlCommand("Update Tests set [PatName]='" + patname_comboBox.SelectedValue.ToString() + "' ," +
                        "[TsName] ='" + tsname_comboBox.SelectedValue.ToString() + "' , " +
                        "[ReCost] = '" + costs_txt.Text + "'" +
                        "[ReResult] = '" + result_comboBox.SelectedItem.ToString() + "'" +
                        "[AgName] = '" + agname_combocox.SelectedValue.ToString() + "'" +
                        //"[AgID] = '" + agid_txt.Text + "'" +
                        //"[PatID] = '" + patid_txt.Text + "'" +
                        //"[TsCode] = '" + tscode_txt.Text + "'" +
                        //"[TestOK] = '" + tests_txt.Text + "' " +
                        "where ReID = '" + Key + "'", con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Result Updated Successfully", "Update Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    ResultsUpdate();
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
                MessageBox.Show("Select Result !! ", "Result Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand com = new SqlCommand();
                    com = new SqlCommand("Delete Results where ReID = '" + Key + "'", con);
                    if (MessageBox.Show("Do You Want Delete this Result ? ", "Delete Result", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        MessageBox.Show("Result Deleted Successfully", "Delete Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Results_Page results = new Results_Page();
                        results.Show();
                    }
                    com.ExecuteNonQuery();
                    con.Close();
                    ResultsUpdate();
                    Clear();
                    add_btn.Enabled = true;
                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.Message, "Result Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void res_dvg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            add_btn.Enabled = false;
            //this.agid_txt.Enabled = false;
            //this.patid_txt.Enabled = false;
            //this.tscode_txt.Enabled = false;

            int i = e.RowIndex;
            DataGridViewRow row = res_dvg.Rows[i];
            patname_comboBox.SelectedValue = row.Cells[1].Value.ToString();
            tsname_comboBox.SelectedValue = row.Cells[2].Value.ToString();
            costs_txt.Text = row.Cells[3].Value.ToString();
            result_comboBox.SelectedItem = row.Cells[4].Value.ToString();
            agname_combocox.SelectedValue = row.Cells[5].Value.ToString();
            //agid_txt.Text = row.Cells[6].Value.ToString();
            //patid_txt.Text = row.Cells[7].Value.ToString();
            //tscode_txt.Text = row.Cells[8].Value.ToString();
            tests_txt.Text = row.Cells[9].Value.ToString();

            if (costs_txt.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(row.Cells[0].Value.ToString());
            }
        }
        string Tr = "";
        int TotCost = 0;
        private void ok_btn_Click(object sender, EventArgs e)
        {
            if (result_comboBox.SelectedIndex == -1 || tsname_comboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Result and Test Name ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Tr = Tr + tsname_comboBox.SelectedValue.ToString() + " : " + result_comboBox.SelectedItem.ToString() + ",";
                tests_txt.Text = Tr;
                TotCost = TotCost + Cost;
                costs_txt.Text = "" + TotCost;
            }
        }

        private void agname_combocox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //GetAgentID();
        }

        private void patname_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //GetPatientsID();
        }

        private void tsname_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //GetTestCode();
        }
    }
}
