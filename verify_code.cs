using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;    

namespace Final_Lab_Project
{
    public partial class verify_code : Form
    {
        public verify_code()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string t = textBox1.Text;
            int number;

            if (string.IsNullOrEmpty(t) || !char.IsDigit(t, t.Length - 1) || !char.IsControl(t, t.Length - 1))
            {
                MessageBox.Show("Please enter only digits", "Error", MessageBoxButtons.OK);
                return;
            }
            else if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter the code", "Error", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MGVJ7QM\SQLEXPRESS;Initial Catalog=cd;Integrated Security=True");
                    con.Open();
                    string query = "select * from code where code = '" + textBox1.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Invalid Code", "Error", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Code Verified", "Success", MessageBoxButtons.OK);
                        admin_register home = new admin_register();
                        home.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter the code", "Error", MessageBoxButtons.OK);
            }
        }

        private void verify_code_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login_Page home = new Login_Page();
            home.Show();
            this.Hide();    
        }
    }
}
