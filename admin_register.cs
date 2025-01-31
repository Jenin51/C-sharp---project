using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Web.UI.WebControls;

namespace Final_Lab_Project
{
    public partial class admin_register : Form
    {
        public admin_register()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void done_button_Click(object sender, EventArgs e)
        {
            string passss = pass_textbox.Text;
            string passss2 = confirm_textbox.Text;

            if (string.IsNullOrEmpty(pass_textbox.Text) || string.IsNullOrEmpty(confirm_textbox.Text) || string.IsNullOrEmpty(admin_username_textbox.Text) || string.IsNullOrEmpty(username_textbox.Text) ||
                string.IsNullOrEmpty(nid_number_textbox.Text) || string.IsNullOrEmpty(username_textbox.Text) || string.IsNullOrEmpty(email_textbox.Text) || string.IsNullOrEmpty(address_textbox.Text) ||
               string.IsNullOrEmpty(phone_textbox.Text))
            {

                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK);


            }

            else if (passss != passss2)
            {
                MessageBox.Show("Password does not match", "Error", MessageBoxButtons.OK);
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MGVJ7QM\SQLEXPRESS;Initial Catalog=family_member;Integrated Security=True;Encrypt=False");

                con.Open();
                try
                {
                    string query = "INSERT INTO login_table(UserName, Password, Name, Email, Phone, Address, DOB,Status) VALUES(@UserName, @Password, @Name, @Email, @Phone, @Address, @DOB, @Status)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Name", admin_username_textbox.Text);
                    cmd.Parameters.AddWithValue("@Password", pass_textbox.Text);
                    cmd.Parameters.AddWithValue("@UserName", username_textbox.Text);
                    cmd.Parameters.AddWithValue("@Email", email_textbox.Text);
                    cmd.Parameters.AddWithValue("@Phone", phone_textbox.Text);
                    cmd.Parameters.AddWithValue("@Address", address_textbox.Text);
                    cmd.Parameters.AddWithValue("@DOB", admin_dob.Text);
                    cmd.Parameters.AddWithValue("@Status", "Admin");
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Welcome, Admin!\n\nAs an admin, you are expected to:\n" + "- Maintain the confidentiality of user data.\n" +
            "- Ensure fair use of the system.\n" +
            "- Avoid any actions that may compromise system integrity.\n\n" +
            "Thank you for upholding these standards.",
            "Admin Ethics",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
                    Login_Page home = new Login_Page();
                    home.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
               
            }
        }

        private void admin_register_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login_Page home = new Login_Page(); 
                home.Show();
                    this.Hide();
        }
    }
}
