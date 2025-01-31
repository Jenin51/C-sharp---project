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
    public partial class pramanik_admin_dashboard : Form
    {
        public pramanik_admin_dashboard()
        {
            InitializeComponent();
        }

        private void complaint_button_Click(object sender, EventArgs e)
        {
            pramanik_complaint_admin complaint = new pramanik_complaint_admin();
            complaint.Show();
            this.Hide();
        }
    }
}
