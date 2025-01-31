using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;

namespace Final_Lab_Project
{
    public partial class pramanik_family : Form
    {
        private SqlConnection con;
        public pramanik_family()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=DESKTOP-MGVJ7QM\SQLEXPRESS;Initial Catalog=family_member;Integrated Security=True;Encrypt=False");
        }

        private void pramanik_family_Load(object sender, EventArgs e)
        {
           
        }
       

        private void insert_button_Click(object sender, EventArgs e)
        {

            string fullname = name_textbox.Text;
            string relationship = relationship_textbox.Text;
            string age = age_textbox.Text;
            string gender = gender_combo.SelectedItem != null ? gender_combo.SelectedItem.ToString() : string.Empty;
            string dob = dateTimePicker1.Text;
            string nid = nid_textbox.Text;
            string email = email_textbox.Text;
            string phone = phone_textbox.Text;
            string username = username_textbox.Text;
            string password = password_textbox.Text;

            if (string.IsNullOrEmpty(fullname) || string.IsNullOrEmpty(relationship) || string.IsNullOrEmpty(age) ||
                string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(dob) || string.IsNullOrEmpty(nid) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }



            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO pramanik_family values (@fullname, @relationship, @age, @gender, @dob, @nid, @email, @phone, @username, @password)", con);


                cmd.Parameters.AddWithValue("@fullname", fullname);
                cmd.Parameters.AddWithValue("@relationship", relationship);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@dob", dob);
                cmd.Parameters.AddWithValue("@nid", nid);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Family Member is added successfully");
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }
        


        void BindData()
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM pramanik_list", con);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while binding data: " + ex.Message);
            }
        }
        

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            pramanik p = new pramanik();
            p.Show();
            this.Hide();

        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            pramanik pramanik = new pramanik();
            pramanik.Show();
            this.Hide();
        }
    }
}
