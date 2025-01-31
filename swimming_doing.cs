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
    public partial class swimming_doing : Form
    {
        public swimming_doing()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "D:\\Coder Sarker\\C#\\Final_Lab_Project\\Resources\\swiming.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
    }
}
