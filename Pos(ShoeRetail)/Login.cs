using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace Pos_ShoeRetail_
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-LNIKLOR;Initial Catalog=ShoeRetail(Pos);Integrated Security=True");
         
        public Login()
        {
            InitializeComponent();
            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
          if(txt_username.Text !="" && txt_password.Text != "")
            {
                //Admin_Panel admin = new Admin_Panel();
                //admin.Show();
                //this.Visible = false;
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from users inner join role on users.userrole = role.roleid where username = @username and password = @password", con);
                cmd.Parameters.AddWithValue("@username",txt_username.Text);
                cmd.Parameters.AddWithValue("@password", txt_password.Text);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if(dt.Rows.Count >0)
                {
                    string usertype = dt.Rows[0][5].ToString();
                    if(usertype == "admin")
                    {
                        Admin_Panel admin = new Admin_Panel();
                        admin.Show();
                        this.Visible = false;
                    }
                    if(usertype== "cashier")
                    {
                        UserPanel user = new UserPanel();
                        user.Show();
                        this.Visible = false;
                    }

                }
                con.Close();
            }
            else
            {
                Wrong cp = new Wrong();
                cp.Show();
            }
            
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
