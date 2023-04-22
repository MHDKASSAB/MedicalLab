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
    public partial class Tests_Page : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=MedicalLab;Integrated Security=True");
        public Tests_Page()
        {
            InitializeComponent();
            TestUpdate();
        }
        public void TestUpdate()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda = new SqlDataAdapter("Select * from Tests", con);
            SqlCommandBuilder scb = new SqlCommandBuilder();
            scb = new SqlCommandBuilder(sda);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            tests_dvg.DataSource = ds.Tables[0];
            con.Close();
        }
        public void Clear()
        {
            tsname_txt.Text = "";
            tsprice_txt.Text = "";
            Key = 0;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (tsname_txt.Text == "" || tsprice_txt.Text == "")
            {
                MessageBox.Show("Missing Information", "Test Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand com = new SqlCommand();
                    com = new SqlCommand("Insert into Tests(TsName , TsCost , TsDate) Values ('" + tsname_txt.Text + "' , '" + tsprice_txt.Text + "' , '" + DateTime.Now + "')", con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Test Added Successfully", "Add New Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    TestUpdate();
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
            if (tsname_txt.Text == "" || tsprice_txt.Text == "")
            {
                MessageBox.Show("Missing Information", "Test Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand com = new SqlCommand();
                    com = new SqlCommand("Update Tests set [TsName]='" + tsname_txt.Text + "' , [TsCost] ='" + tsprice_txt.Text + "' where TsCode = '" + Key + "'", con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Test Updated Successfully", "Update Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    TestUpdate();
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
                MessageBox.Show("Select Test !! ", "Test Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand com = new SqlCommand();
                    com = new SqlCommand("Delete Tests where TsCode = '" + Key + "'", con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Test Deleted Successfully", "Delete Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    TestUpdate();
                    Clear();
                    add_btn.Enabled = true;
                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.Message, "Test Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tests_dvg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            add_btn.Enabled = false;
            int i = e.RowIndex;
            DataGridViewRow row = tests_dvg.Rows[i];
            tsname_txt.Text = row.Cells[1].Value.ToString();
            tsprice_txt.Text = row.Cells[2].Value.ToString();


            if (tsname_txt.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(row.Cells[0].Value.ToString());
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
