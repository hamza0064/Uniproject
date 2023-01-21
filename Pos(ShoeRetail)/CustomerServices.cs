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
    public partial class CustomerServices : Form
    {
        public CustomerServices()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_NewSale_Click(object sender, EventArgs e)
        {
            NewService service = new NewService();
            service.Show();
            this.Visible = false;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            UserPanel ur = new UserPanel();
            ur.Show();
            this.Visible = false;
        }

        private void btn_CustomerService_Click(object sender, EventArgs e)
        {
            UpdateServices update = new UpdateServices();
            update.Show();
            this.Visible = false;
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            ViewService view = new ViewService();
            view.Show();
            this.Visible = false;
        }
    }
}
