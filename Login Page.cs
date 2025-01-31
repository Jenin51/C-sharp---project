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
    public partial class Login_Page : Form
    {
        public Login_Page()
        {
            InitializeComponent();
        }

        private void Login_Page_Load(object sender, EventArgs e)
        {
           
        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username_textbox.Text) || string.IsNullOrEmpty(password_textbox.Text))
            {
                MessageBox.Show("Username or Password cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try

            {
                
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-MGVJ7QM\\SQLEXPRESS;Initial Catalog=family_member;Integrated Security=True"))
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM login_table WHERE username = @username AND password = @password", con))
                {
                    cmd.Parameters.AddWithValue("@username", username_textbox.Text);
                    cmd.Parameters.AddWithValue("@password", password_textbox.Text);

                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        if (sdr.HasRows)
                        {
                            sdr.Read();
                            string role = sdr["Status"].ToString();

                            if (role == "Admin")
                            {
                                MessageBox.Show("Admin Login Successful", "Success", MessageBoxButtons.OK);
                                apartment_house_selection  ahs=    new apartment_house_selection();
                                ahs.Show();
                                this.Hide();
                                return;
                            }

                            string floor = sdr["Floor"].ToString();
                            Form newForm = null;

                            switch (floor)
                            {
                                case "SARKER":newForm = new s_a1(); break;                               
                                case "PRAMANIK": newForm = new pramanik(); break;
                                case "JAKARIA": newForm = new jakaria(); break;
                            }

                            if (newForm != null)
                            {
                                MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK);
                                newForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("There is a someone already living ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void signup_label_Click(object sender, EventArgs e)
        {
            choice cs= new choice();
            cs.Show();  
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home_Registration cs = new Home_Registration (); 
                cs.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
              password_textbox.PasswordChar = '\0'; 



            }
            else
            {

                password_textbox.PasswordChar = '*'; 
            }
        }
    }
}
