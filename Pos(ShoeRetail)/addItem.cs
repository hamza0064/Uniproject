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
    public partial class addItem : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-LNIKLOR;Initial Catalog=ShoeRetail(Pos);Integrated Security=True");

        public addItem()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Additem_Click(object sender, EventArgs e)
        {
            string Qry = "insert into Product values(@productId,@color,@price,@gender,@date,@size,@brand)";
            SqlCommand cmd = new SqlCommand(Qry,con);
            cmd.Parameters.AddWithValue("@productId", txt_productID.Text);
            cmd.Parameters.AddWithValue("@color", txt_color.Text.ToString());
            cmd.Parameters.AddWithValue("@price", txt_price.Text);
            cmd.Parameters.AddWithValue("@gender", txt_gender.Text.ToString());
            cmd.Parameters.AddWithValue("@date", txt_datepicker.Text.ToString());
            cmd.Parameters.AddWithValue("@size",txt_Size.Text);
            cmd.Parameters.AddWithValue("@brand", txt_brand.Text.ToString());
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox Mb = new MessageBox();
            Mb.Show();
            this.Visible = false;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
