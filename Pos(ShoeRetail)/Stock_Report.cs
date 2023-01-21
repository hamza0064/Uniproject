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

namespace Pos_ShoeRetail_
{
    public partial class Stock_Report : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-LNIKLOR;Initial Catalog=ShoeRetail(Pos);Integrated Security=True");

        public Stock_Report()
        {
            InitializeComponent();
            BindGrid();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gv_report_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void BindGrid()
        {
            SqlDataAdapter data = new SqlDataAdapter("select * from product", con);
            con.Open();
            DataTable ds = new DataTable();
            data.Fill(ds);
            gv_report.DataSource = ds;
            con.Close();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            string Qry = "select * from Product where ProductID like '" + txt_Search.Text + "%'";
            con.Open();
            SqlCommand obj = new SqlCommand(Qry,con);
            SqlDataAdapter sdr = new SqlDataAdapter(obj);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            gv_report.DataSource = dt;
            con.Close();


        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
