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
    public partial class UserPanel : Form
    {
        public UserPanel()
        {
            InitializeComponent();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Visible = false;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_NewSale_Click(object sender, EventArgs e)
        {
            NewSale ns = new  NewSale();
            ns.Show();
            this.Visible = false;

        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            ReportMenu rm = new ReportMenu();
            rm.Show();
            this.Visible = false;
        }

        private void btn_CustomerService_Click(object sender, EventArgs e)
        {
            CustomerServices CS = new CustomerServices();
            CS.Show();
            this.Visible = false;
        }

        private void UserPanel_Load(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
