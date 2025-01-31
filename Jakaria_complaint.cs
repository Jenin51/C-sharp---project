using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;    

namespace Final_Lab_Project
{
    public partial class Jakaria_complaint : Form
    {
        public Jakaria_complaint()
        {
            InitializeComponent();
           
        }

        private void Jakaria_complaint_Load(object sender, EventArgs e)
        {

        }

        private void Send_button_Click(object sender, EventArgs e)
        {

            string subject = subject_textbox.Text;
            string complaint = complaint_textbox.Text;
            if (string.IsNullOrEmpty(subject) || string.IsNullOrEmpty(complaint))
            {
                MessageBox.Show("Please fill all the fields");





            }
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MGVJ7QM\SQLEXPRESS;Initial Catalog=family_member;Integrated Security=True;Encrypt=False");
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO jakaria_complaint_table values (@subject, @complaint)", con);
                cmd.Parameters.AddWithValue("@subject", subject);
                cmd.Parameters.AddWithValue("@complaint", complaint);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Complaint Sent successfully");





            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            jakaria p = new jakaria();
            p.Show();
            this.Hide();
        }
    }
}
