using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace Final_Lab_Project
{
    public partial class Home_Registration : Form
    {

        public Home_Registration()
        {
            InitializeComponent();
        }

        private void address_Click(object sender, EventArgs e)
        {

        }

        private void phone_number_Click(object sender, EventArgs e)
        {

        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void full_name_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void save_button_Click(object sender, EventArgs e)
        {
            DateTime dob = Convert.ToDateTime(dateTimePicker1.Text);
            int age = (int)((DateTime.Now - dob).TotalDays / 365.25);
            age_textbox.Text = age.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Home_Registration_Load(object sender, EventArgs e)
        {

        }

        private void register_button_Click(object sender, EventArgs e)
        {
            string username = username_textbox.Text;
            string password = password_textbox.Text;
            string name = fullname_textbox.Text;
            string email = email_textbox.Text;
            string phone = phone_textbox.Text;
            string address = address_text.Text;
            string dob = dateTimePicker1.Text;
            string age = age_textbox.Text;
            string status = comboBox1.SelectedItem != null ? comboBox1.SelectedItem.ToString() : string.Empty;
            string apartment_number = flat_selection_combobox.SelectedItem != null ? flat_selection_combobox.SelectedItem.ToString() : string.Empty;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(dob) || string.IsNullOrEmpty(age) || string.IsNullOrEmpty(status) || string.IsNullOrEmpty(apartment_number))
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-MGVJ7QM\\SQLEXPRESS;Initial Catalog=family_member;Integrated Security=True");
                con.Open();

                string insertQuery = "INSERT INTO login_table (UserName, Password, Name, Email, Phone, Address, DOB, Age, Status, Floor) VALUES (@UserName, @Password, @Name, @Email, @Phone, @Address, @DOB, @Age, @Status, @Floor)";

                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@UserName", username_textbox.Text);
                cmd.Parameters.AddWithValue("@Password", password_textbox.Text);
                cmd.Parameters.AddWithValue("@Name", fullname_textbox.Text);
                cmd.Parameters.AddWithValue("@Email", email_textbox.Text);
                cmd.Parameters.AddWithValue("@Phone", phone_textbox.Text);
                cmd.Parameters.AddWithValue("@Address", address_text.Text);
                cmd.Parameters.AddWithValue("@DOB", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@Age", age_textbox.Text);
                cmd.Parameters.AddWithValue("@Status", comboBox1.SelectedItem != null ? comboBox1.SelectedItem.ToString() : string.Empty);
                cmd.Parameters.AddWithValue("@Floor", flat_selection_combobox.SelectedItem != null ? flat_selection_combobox.SelectedItem.ToString() : string.Empty);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Registration is Successful", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Visible = false;
                Login_Page login_Page = new Login_Page();
                login_Page.Show();

            }

        }

        public void UpdateLabel(string text)
        {
            please_select.Text = text;
        }

        private void Selection_button_Click(object sender, EventArgs e)
        {
            string name = flat_selection_combobox.SelectedItem?.ToString();


            if (!string.IsNullOrEmpty(name))
            {
                please_select.Text = "Flat " + name + " is Selected";
            }
            else
            {
                please_select.Text = "Please select an option.";
            }
        }

        private void please_select_Click(object sender, EventArgs e)
        {


        }

        private void flat_selection_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                Login_Page login_Page = new Login_Page();
                login_Page.Show();
            this.Visible = false;

        }
        }
    }

