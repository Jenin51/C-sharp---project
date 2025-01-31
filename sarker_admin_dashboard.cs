using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Lab_Project
{
    public partial class sarker_admin_dashboard : Form
    {
        public sarker_admin_dashboard()
        {
            InitializeComponent();
        }

        private void complaint_button_Click(object sender, EventArgs e)
        {
            sarker_complaint_admin sarker = new sarker_complaint_admin();
                sarker.ShowDialog();    
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void utility_button_Click(object sender, EventArgs e)
        {

        }

        private void guest_button_Click(object sender, EventArgs e)
        {

        }

        private void familymember_button_Click(object sender, EventArgs e)
        {

        }
    }
}
