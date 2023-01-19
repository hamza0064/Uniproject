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
    public partial class UpdateItem : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-LNIKLOR;Initial Catalog=ShoeRetail(Pos);Integrated Security=True");

        public UpdateItem()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-LNIKLOR;Initial Catalog=ShoeRetail(Pos);Integrated Security=True");
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
                    txt_product.Text = productID;
                    txt_Size.Text = size.ToString();
                    txt_gender.Text = Catergory;
                    txt_color.Text = Color;
                    txt_date.Text = DateofEntry;
                    txt_brand.Text = brand;
                    txt_price.Text = Price.ToString(); ;
                    
                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string qry = "UPDATE Product SET ProductID= '" + txt_product.Text + "',Color='"+txt_color.Text+"',Price="+txt_price.Text+",Catergory='"+txt_gender.Text+"',DateOfEntry='"+txt_date.Text+"',Size="+txt_Size.Text+",Brand='"+txt_brand.Text+"' where ProductID='"+txt_Search.Text+"'";
            SqlCommand cmd = new SqlCommand(qry, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            this.Close();
            
            MessageUpate Mbu = new MessageUpate();
            Mbu.Show();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
