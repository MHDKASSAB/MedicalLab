using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalLab
{
    public partial class AdminLogIn : Form
    {
        public AdminLogIn()
        {
            InitializeComponent();
        }

        private void cancel_lbl_Click(object sender, EventArgs e)
        {
            LogIn_Page logIn = new LogIn_Page();
            logIn.Show();
            this.Hide();
        }

        private void password_txt_TextChanged(object sender, EventArgs e)
        {
            if (this.password_txt.Text == null)
            {
                MessageBox.Show("Please insert Admin Password", "Admin LogIn Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (password_txt.Text == "Password")
            {
                Patients_Page patients = new Patients_Page();
                patients.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Admin Password", "Admin LogIn Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
