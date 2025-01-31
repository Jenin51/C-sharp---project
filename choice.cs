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
    public partial class choice : Form
    {
        public choice()
        {
            InitializeComponent();
        }

        private void choice_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void support_admin_radio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void next_button_Click(object sender, EventArgs e)
        {
            if (house_radion.Checked) {

                Home_Registration home = new Home_Registration();
                home.Show();
                this.Visible = false;
            }
            else if (support_admin_radio.Checked)
            {
                verify_code admin = new verify_code();
                admin.Show();
                this.Visible = false;





            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login_Page login = new Login_Page();
            login.Show();
            this.Visible = false;

        }
    }
}
