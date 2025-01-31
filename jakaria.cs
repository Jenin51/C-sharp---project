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
    public partial class jakaria : Form
    {
        public jakaria()
        {
            InitializeComponent();
        }

        private void add_family_button_Click(object sender, EventArgs e)
        {
            Jakaria_family pramanik_family = new Jakaria_family();    
              pramanik_family.Show();
            this.Close();
        }

        private void guest_button_Click(object sender, EventArgs e)
        {
            jakaria_guest p= new jakaria_guest(); 
            p.Show();
            Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have successfully logged out");
            Login_Page l = new Login_Page();
            l.Show();
                this.Hide();    
        }

        private void swim_button_Click(object sender, EventArgs e)
        {
            Jakaria_chatcs p = new Jakaria_chatcs();
            p.Show();   
            this.Hide();

        }

        private void utility_bill_Click(object sender, EventArgs e)
        {
            jakaria_utiliy_bill p = new jakaria_utiliy_bill();
            p.Show();
                this.Hide();
        }

        private void complaints_Click(object sender, EventArgs e)
        {
            Jakaria_complaint p = new Jakaria_complaint();
            p.Show();
                this.Hide();
        }
    }
}
