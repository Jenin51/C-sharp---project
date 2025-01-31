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
    
    public partial class sarker_floor_select : Form
    {
        public string SelectedHouseNumber { get; private set; }
        public sarker_floor_select()
        {
            InitializeComponent();
           
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            SelectedHouseNumber = "S: A-1 selected";
            Home_Registration home_Registration = new Home_Registration();
            home_Registration.Show();
            
        }

        private void sarker_floor_select_Load(object sender, EventArgs e)
        {

        }

        private void continue_button_Click(object sender, EventArgs e)
        {

        }
    }
}
