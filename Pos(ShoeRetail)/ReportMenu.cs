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
    public partial class ReportMenu : Form
    {
        public ReportMenu()
        {
            InitializeComponent();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            UserPanel ur = new UserPanel();
            ur.Show();
            this.Visible = false;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_SalesReport_Click(object sender, EventArgs e)
        {
            SalesReport Sr = new SalesReport();
            Sr.Show();
            this.Visible = false;
        }

        private void btn_StockReport_Click(object sender, EventArgs e)
        {
            StockReport Str = new StockReport();
            Str.Show();
            this.Visible = false;

        }

        private void btn_ServiceReport_Click(object sender, EventArgs e)
        {
            ServicesReport Sr = new ServicesReport();
            Sr.Show();
            this.Visible = false;
        }
    }
}
