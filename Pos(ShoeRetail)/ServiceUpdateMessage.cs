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
    public partial class ServiceUpdateMessage : Form
    {
        public ServiceUpdateMessage()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            UpdateServices Mbu = new UpdateServices();
            Mbu.Show();
            this.Visible = false;
        }
    }
}
