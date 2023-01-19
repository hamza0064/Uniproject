using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos_ShoeRetail_
{
    public partial class Admin_Panel : Form
    {
        public Admin_Panel()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Registration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
        }

        private void btn_updatepassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePassword pass = new ChangePassword();
            pass.Show();
        }

        private void btn_Mstock_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Stock_Manage SM = new Stock_Manage();
            SM.Show();
        }

        private void btn_SalesReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Stock_Report Sr = new Stock_Report();
            Sr.Show();
           
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Visible = false;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
