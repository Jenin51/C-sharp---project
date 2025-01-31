using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;

namespace Final_Lab_Project
{
    public partial class s_a1 : Form
    {
        public s_a1()
        {
            InitializeComponent();
            timer1.Start();

        }

        private void s_a1_Load(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;

        }

        private void welcoming_label_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login_Page l = new Login_Page();
            l.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
              
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            time_label.Text = DateTime.Now.ToString("HH:mm:ss");
            
        }

        private void time_label_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            swimming_pool s = new swimming_pool();
                s.Show();
        }

        private void add_family_button_Click(object sender, EventArgs e)
        {
            family_members_ f = new family_members_();
            f.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to log out?", "Log Out", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("You have successfully logged out");

                Login_Page login_Page = new Login_Page();
                login_Page.Show();
                this.Hide();

            }
            else { 

            
            
            
            }
               
        }

        private void guest_button_Click(object sender, EventArgs e)
        {
            sarker_guest s = new sarker_guest();
                s.Show();
            this.Hide();
        }

        private void swim_button_Click(object sender, EventArgs e)
        {
            sarker_chatt s = new sarker_chatt();
                s.Show();
            this.Hide();
        }

        private void complaints_Click(object sender, EventArgs e)
        {
            sarker_complaint s = new sarker_complaint();
            s.Show();
            this.Hide();

        }

        private void utility_bill_Click(object sender, EventArgs e)
        {
            sarker_utiliy_bill s = new sarker_utiliy_bill();
            s.Show();
                this.Hide();

        }
    }
}
