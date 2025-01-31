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
    public partial class pramanik : Form
    {
        public pramanik()
        {
            InitializeComponent();
        }

        private void welcoming_label_Click(object sender, EventArgs e)
        {

        }

        private void add_family_button_Click(object sender, EventArgs e)
        {
            pramanik_family pramanik_family = new pramanik_family();
            pramanik_family.Show();
            this.Close();
        }

        private void guest_button_Click(object sender, EventArgs e)
        {
            pramanik_guest pramanik_guest = new pramanik_guest();   
            pramanik_guest.Show();
            this.Hide();    
        }

        private void button2_Click(object sender, EventArgs e)
        {
           MessageBox.Show("You have successfully logged out");
            Login_Page l = new Login_Page();
            l.Show();
            this.Hide();
        }

        private void utility_bill_Click(object sender, EventArgs e)
        {
            pramanik_utiliy_bill p = new pramanik_utiliy_bill();
                    p.Show();
            this.Hide();

        }

        private void complaints_Click(object sender, EventArgs e)
        {
            pramanik_complaint p = new pramanik_complaint();
            p.Show();
            this.Hide();

        }

        private void time_label_Click(object sender, EventArgs e)
        {
            
        }
    }
}
