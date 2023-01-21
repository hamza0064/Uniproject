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
using System.Configuration;

namespace Pos_ShoeRetail_
{
    public partial class ServicesReport : Form
    {
        static string conString = ConfigurationManager.ConnectionStrings["Pos_ShoeRetail_.Properties.Settings.Setting"].ConnectionString;
        SqlConnection con = new SqlConnection(conString);

        public ServicesReport()
        {
            InitializeComponent();
            BindGrid();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            string Qry = "select * from [dbo].[Customers] where CustomerID like '" + txt_Search.Text + "%'";
            con.Open();
            SqlCommand obj = new SqlCommand(Qry, con);
            SqlDataAdapter sdr = new SqlDataAdapter(obj);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            gv_Servicereport.DataSource = dt;
            con.Close();
        }

        private void gv_Servicereport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void BindGrid()
        {
            SqlDataAdapter data = new SqlDataAdapter("select * from [dbo].[Customers]", con);
            con.Open();
            DataTable ds = new DataTable();
            data.Fill(ds);
            gv_Servicereport.DataSource = ds;
            con.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            ReportMenu Rm = new ReportMenu();          
            Rm.Show();
            this.Visible = false;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
