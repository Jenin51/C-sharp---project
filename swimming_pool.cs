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
    public partial class swimming_pool : Form
    {
        public swimming_pool()
        {
            InitializeComponent();
        }

        private void swim_back_button_Click(object sender, EventArgs e)
        {
            swimming_doing swimming_Doing = new swimming_doing();
            swimming_Doing.Show();
        }
    }
}
