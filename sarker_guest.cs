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

namespace Final_Lab_Project
{
    public partial class sarker_guest : Form
    {
        public sarker_guest()
        {
            InitializeComponent();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            string name = name_textbox.Text;
            string age = age_textbox.Text;
            string relationship = relationship_textbox.Text;
            string gender = gender_combo.Text;
            string date = dateTimePicker1.Text;
            string time = dateTimePicker2.Text;
            string nid = nid_textbox.Text;
            string phone = phone_textbox.Text;
            string address = address_textbox.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(age) || string.IsNullOrEmpty(relationship) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(date) || string.IsNullOrEmpty(time) || string.IsNullOrEmpty(nid) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }
            else
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MGVJ7QM\SQLEXPRESS;Initial Catalog=family_member;Integrated Security=True;Encrypt=False"))
                    {
                        using (SqlCommand cmd = new SqlCommand("INSERT INTO sarker_guest_table values (@name, @age, @relationship, @gender, @date, @time, @nid, @phone, @address)", con))
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@name", name);
                            cmd.Parameters.AddWithValue("@age", age);
                            cmd.Parameters.AddWithValue("@relationship", relationship);
                            cmd.Parameters.AddWithValue("@gender", gender);
                            cmd.Parameters.AddWithValue("@date", date);
                            cmd.Parameters.AddWithValue("@time", time);
                            cmd.Parameters.AddWithValue("@nid", nid);
                            cmd.Parameters.AddWithValue("@phone", phone);
                            cmd.Parameters.AddWithValue("@address", address);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Data inserted successfully");
                            return;
                           
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"An error occurred while connecting to the database: {ex.Message}");
                }
            }









        }

        private void close_button_Click(object sender, EventArgs e)
        {
            s_a1 s_A1 = new s_a1(); 
                s_A1.Show();
            this.Hide();
        }
    }
    }

