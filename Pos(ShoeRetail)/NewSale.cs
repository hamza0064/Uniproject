﻿using System;
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
    public partial class NewSale : Form
    {

        static string conString = ConfigurationManager.ConnectionStrings["Pos_ShoeRetail_.Properties.Settings.Setting"].ConnectionString;
        SqlConnection con = new SqlConnection(conString);
        public NewSale()
        {
            InitializeComponent();
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
                    //txt_date.Text = DateofEntry;
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

        private void txt_purchase_Click(object sender, EventArgs e)
        {
            string Qry = "insert into [dbo].[Purschases] values(@productId,@color,@price,@gender,@date,@size,@brand)";
            SqlCommand cmd = new SqlCommand(Qry, con);
            cmd.Parameters.AddWithValue("@productId", txt_productID.Text);
            cmd.Parameters.AddWithValue("@color", txt_color.Text.ToString());
            cmd.Parameters.AddWithValue("@price", txt_price.Text);
            cmd.Parameters.AddWithValue("@gender", txt_gender.Text.ToString());
            cmd.Parameters.AddWithValue("@date", txt_date.Text.ToString());
            cmd.Parameters.AddWithValue("@size", txt_Size.Text);
            cmd.Parameters.AddWithValue("@brand", txt_brand.Text.ToString());
           
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            receipt();
        }
        public void receipt()
        {
            txt_Receipt.Clear();
            txt_Receipt.Text += "**Nike Shoes Retail Shop**\n\n";
            txt_Receipt.Text += "**Recepit**\n\n";
            txt_Receipt.Text += "Purchase Date :" + DateTime.Now + "\n\n";         
            txt_Receipt.Text += "Gender :" + txt_gender.Text + "\n\n";
            txt_Receipt.Text += "Produch ID :" + txt_productID.Text + "\n\n";
            txt_Receipt.Text += "Color :" + txt_color.Text.ToString() + "\n\n";
            txt_Receipt.Text += "Size :" + txt_Size.Text + "\n\n";
            txt_Receipt.Text += "Brand :" + txt_brand.Text.ToString() + "\n\n";
            txt_Receipt.Text += "Date of Purshased :" + DateTime.Now + "\n\n";
            txt_Receipt.Text += "Total Price :" + txt_price.Text + "\n\n";
        }

        private void txt_print_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txt_Receipt.Text, new Font("Consolas", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }

        private void btn_newsale_Click(object sender, EventArgs e)
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                    {
                        (control as TextBox).Clear();
                    }
                    else
                    {
                        func(control.Controls);
                    }
                }
            };
            func(Controls);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            CustomerServices cs = new CustomerServices();
            cs.Show();
            this.Visible = false;
        }
    }
}
