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
    public partial class UpdateServices : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-LNIKLOR;Initial Catalog=ShoeRetail(Pos);Integrated Security=True");

        public UpdateServices()
        {
            InitializeComponent();
        }

        

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-LNIKLOR;Initial Catalog=ShoeRetail(Pos);Integrated Security=True");
            string Qry = "select * from [dbo].[Customers] where CustomerID='" + txt_Search.Text + "'";
            SqlCommand cmd = new SqlCommand(Qry, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {

                    string productID = myreader.GetString(1);
                    string Color = myreader.GetString(2);
                    int Price = myreader.GetInt32(3);
                    string Catergory = myreader.GetString(4);
                    int size = myreader.GetInt32(5);
                    string brand = myreader.GetString(6);
                    string customername = myreader.GetString(7);
                    string address = myreader.GetString(8);
                    string pdate = myreader.GetString(9);
                    string ddate = myreader.GetString(10);
                    int schargers = myreader.GetInt32(11);
                    string phone = myreader.GetString(12);


                    txt_productID.Text = productID;
                    txt_Size.Text = size.ToString();
                    txt_gender.Text = Catergory;
                    txt_color.Text = Color;
                    txt_brand.Text = brand;
                    txt_price.Text = Price.ToString();
                    txt_customername.Text = customername;
                    txt_Address.Text = address;
                    txt_Phone.Text = phone;
                    txt_servicecharges.Text = schargers.ToString();
                    txt_purshaseddate.Text = pdate;
                    txt_deliverdate.Text = ddate;

                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            string qry = "UPDATE Customers SET ProductID= '" + txt_productID.Text + "',Color='" + txt_color.Text + "',Price=" + txt_price.Text + ",Catergory='" + txt_gender.Text + "',Size=" + txt_Size.Text + ",Brand='" + txt_brand.Text + "',CustomerName='" + txt_customername.Text + "',Address='" + txt_Address.Text + "',PurshasedDate='" + txt_purshaseddate.Text + "',DeliverDate='" + txt_deliverdate.Text + "',ServiceCharges='" + txt_servicecharges.Text + "',Phone='" + txt_Phone.Text + "' where CustomerID='" + txt_Search.Text + "'";
            SqlCommand cmd = new SqlCommand(qry, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            this.Close();

            ServiceUpdateMessage Mbu = new ServiceUpdateMessage();
            Mbu.Show();
            this.Visible = false;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            CustomerServices cs = new CustomerServices();
            cs.Show();
            this.Visible = false;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
