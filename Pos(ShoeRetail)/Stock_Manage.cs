using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos_ShoeRetail_
{
    public partial class Stock_Manage : Form
    {
        public Stock_Manage()
        {
            InitializeComponent();
        }

        private void Stock_Manage_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Item_Click(object sender, EventArgs e)
        {
            addItem additem = new addItem();
            additem.Show();
            this.Visible = false;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            UpdateItem updateitem = new UpdateItem();
            updateitem.Show();
            this.Visible = false;
        }

        private void btn_DeleteItem_Click(object sender, EventArgs e)
        {
            Delete dlt = new Delete();
            dlt.Show();
            this.Visible = false;
        }

        private void btn_StockR_Click(object sender, EventArgs e)
        {
            Stock_Report Sr = new Stock_Report();
            Sr.Show();
            this.Visible = false;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
