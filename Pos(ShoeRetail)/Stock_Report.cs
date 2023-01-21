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
<<<<<<< HEAD
=======
using System.Configuration;
>>>>>>> origin/main

namespace Pos_ShoeRetail_
{
    public partial class Stock_Report : Form
    {
<<<<<<< HEAD
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-LNIKLOR;Initial Catalog=ShoeRetail(Pos);Integrated Security=True");
=======
        static string conString = ConfigurationManager.ConnectionStrings["Pos_ShoeRetail_.Properties.Settings.Setting"].ConnectionString;
        SqlConnection con = new SqlConnection(conString);
>>>>>>> origin/main

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
