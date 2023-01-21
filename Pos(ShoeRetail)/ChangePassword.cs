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
    public partial class ChangePassword : Form
    {
        static string conString = ConfigurationManager.ConnectionStrings["Pos_ShoeRetail_.Properties.Settings.Setting"].ConnectionString;
        SqlConnection con = new SqlConnection(conString);
        public ChangePassword()
        {
            InitializeComponent();
            fillbox();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void fillbox()
        {
            

            string Qry = "select * from users";
            SqlCommand cmd = new SqlCommand(Qry, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string username = myreader.GetString(1);
                    fill_box.Items.Add(username);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        private void fill_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            string Qry = "select * from users where username='" + fill_box.Text + "';";
            SqlCommand cmd = new SqlCommand(Qry, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string username = myreader.GetString(1);
                    string password = myreader.GetString(2);
                    txt_username.Text = username;
                    txt_password.Text = password;
                }
                con.Close();
                
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string qry = "UPDATE users SET username = '"+txt_username.Text+"', password = '"+txt_password.Text+"' WHERE username='" + fill_box.Text + "';";
            SqlCommand cmd = new SqlCommand(qry, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            this.Close();
            PasswordUpdate pu = new PasswordUpdate();
            pu.Show();
            this.Visible = false;

        }
    }
}
