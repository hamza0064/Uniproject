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
    public partial class ViewService : Form
    {
        public ViewService()
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
        public void receipt()
        {
            txt_Receipt.Clear();
            txt_Receipt.Text += "**Nike Shoes Retail Shop**\n\n";
            txt_Receipt.Text += "**Recepit**\n\n";
            txt_Receipt.Text += "Date :" + DateTime.Now + "\n\n";
            txt_Receipt.Text += "CustomerName :" + txt_customername.Text + "\n\n";
            txt_Receipt.Text += "Phone :" + txt_Phone.Text + "\n\n";
            txt_Receipt.Text += "Gender :" + txt_gender.Text + "\n\n";
            txt_Receipt.Text += "Address :" + txt_Address.Text + "\n\n";
            txt_Receipt.Text += "Produch ID :" + txt_productID.Text + "\n\n";
            txt_Receipt.Text += "Color :" + txt_color.Text.ToString() + "\n\n";
            txt_Receipt.Text += "Size :" + txt_Size.Text + "\n\n";
            txt_Receipt.Text += "Brand :" + txt_brand.Text.ToString() + "\n\n";
            txt_Receipt.Text += "Date of Purshased :" + txt_purshaseddate.ToString() + "\n\n";
            txt_Receipt.Text += "Date of Deliver :" + txt_deliverdate.ToString() + "\n\n";
            txt_Receipt.Text += "Services Charges :" + txt_servicecharges.Text + "\n\n";
            txt_Receipt.Text += "Total Price :" + txt_price.Text + "\n\n";
        }

        private void btn_newservice_Click(object sender, EventArgs e)
        {
            receipt();
        }
 
        private void txt_print_Click_1(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txt_Receipt.Text, new Font("Consolas", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));
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
