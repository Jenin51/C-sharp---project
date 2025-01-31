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
    public partial class apartment_house_selection : Form
    {
        public apartment_house_selection()
        {
            InitializeComponent();
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void apartment_house_selection_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            sarker_admin_dashboard sarker = new sarker_admin_dashboard();
            sarker.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            pramanik_admin_dashboard pramanik = new pramanik_admin_dashboard();
            pramanik.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            jakaria_admin_dashboard ja = new jakaria_admin_dashboard();
            ja.ShowDialog();
            this.Close();

        }
    }
}
