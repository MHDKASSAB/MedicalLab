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
    public partial class LogIn_Page : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=MedicalLab;Integrated Security=True");
        public LogIn_Page()
        {
            InitializeComponent();
        }

        private void conasadmin_lbl_Click(object sender, EventArgs e)
        {
            AdminLogIn adminLogIn = new AdminLogIn();
            adminLogIn.Show();
            this.Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand com = new SqlCommand("Select * from Agents where AgName = '" + username_txt.Text + "'" +
                    "and AgPass = '" + password_txt.Text + "'", con);
                con.Open();
                SqlDataReader sdr = com.ExecuteReader();
                sdr.Read();
                if (sdr.HasRows)
                {
                    MessageBox.Show("Welcom " + sdr["AgName"].ToString(), "LogIn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Patients_Page patients = new Patients_Page();
                    patients.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invaild UserName or Password", "LogIn Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
