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
    public partial class Jakaria_family : Form
    {
        private SqlConnection con;
        public Jakaria_family()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=DESKTOP-MGVJ7QM\SQLEXPRESS;Initial Catalog=family_member;Integrated Security=True;Encrypt=False");
        }

        private void Jakaria_family_Load(object sender, EventArgs e)
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

                SqlCommand cmd = new SqlCommand("INSERT INTO jakaria_family values (@fullname, @relationship, @age, @gender, @dob, @nid, @email, @phone, @username, @password)", con);


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
                BindData();
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
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM jakaria_family", con);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while binding data: " + ex.Message);
            }
        }

        private void family_members__Load(object sender, EventArgs e)
        {
            BindData();
        }

       

        private void back_button_Click(object sender, EventArgs e)
        {
            jakaria jakaria = new jakaria();
            jakaria.Show();
                this.Hide();
        }

        private void delete_button_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(name_textbox.Text))
            {
                if (MessageBox.Show("Are you sure you want to delete?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        string query = "DELETE FROM jakaria_family WHERE Name = @fullname";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@fullame", name_textbox.Text);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Family Member is deleted successfully");
                        BindData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill the name field");
            }
        }
    }
}

