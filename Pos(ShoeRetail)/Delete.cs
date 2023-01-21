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
    public partial class Delete : Form
    {
        static string conString = ConfigurationManager.ConnectionStrings["Pos_ShoeRetail_.Properties.Settings.Setting"].ConnectionString;
        SqlConnection con = new SqlConnection(conString);
        public Delete()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            


            string Qry = "select * from Product where ProductID='" + txt_Search.Text + "'";
            SqlCommand cmd = new SqlCommand(Qry, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string productID = myreader.GetString(0);
                    string Color = myreader.GetString(1);
                    int Price = myreader.GetInt32(2);
                    string Catergory = myreader.GetString(3);
                    string DateofEntry = myreader.GetString(4);
                    int size = myreader.GetInt32(5);
                    string brand = myreader.GetString(6);
                    txt_productID.Text = productID;
                    txt_Size.Text = size.ToString();
                    txt_gender.Text = Catergory;
                    txt_color.Text = Color;
                    txt_date.Text = DateofEntry;
                    txt_brand.Text = brand;
                    txt_price.Text = Price.ToString(); ;

                }
                con.Close();

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string Qry = "DELETE FROM Product WHERE ProductID='"+txt_Search.Text+"'";
            SqlCommand cmd = new SqlCommand(Qry, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            this.Close();
            MessageDelete Md = new MessageDelete();
            Md.Show();
            this.Visible = false;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
