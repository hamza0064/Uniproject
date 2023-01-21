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
    public partial class Registration : Form
    {
<<<<<<< HEAD
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-LNIKLOR;Initial Catalog=ShoeRetail(Pos);Integrated Security=True");
=======
        static string conString = ConfigurationManager.ConnectionStrings["Pos_ShoeRetail_.Properties.Settings.Setting"].ConnectionString;
        SqlConnection con = new SqlConnection(conString);
>>>>>>> origin/main


        public Registration()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Signup_Click(object sender, EventArgs e)
        {

            
            string Qry = "insert into users values('"+txt_username.Text+"','"+txt_password.Text+ "',@roleSelection)";
            //string QryForRole = "insert into role values('" +txt_role.Text + "')";
            SqlCommand obj = new SqlCommand(Qry, con);
            if (txt_Roles.Text.Equals("admin"))
            {
                int role = 1;
                obj.Parameters.AddWithValue("@roleSelection", role);
            }
            else
            {
                int role = 2;
                obj.Parameters.AddWithValue("@roleSelection", role);
            }
            
            
            con.Open();
            obj.ExecuteNonQuery();
            con.Close();
            ResgisteredMessage pu = new ResgisteredMessage();
            pu.Show();
            this.Visible = false;

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
