using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Final_Lab_Project
{
    public partial class family_members_ : Form
    {
        private SqlConnection con;

        public family_members_()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=DESKTOP-MGVJ7QM\SQLEXPRESS;Initial Catalog=family_member;Integrated Security=True;Encrypt=False");

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
               
                SqlCommand cmd = new SqlCommand("INSERT INTO member_list values (@fullname, @relationship, @age, @gender, @dob, @nid, @email, @phone, @username, @password)", con);
                

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
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM member_list", con);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
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

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(name_textbox.Text))
            {
                if (MessageBox.Show("Are you sure you want to delete?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        string query = "DELETE FROM member_list WHERE Name = @fullname";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@fullname", name_textbox.Text);
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

        private void family_label_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void age_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void relationship_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nid_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            s_a1 s = new s_a1();
            s.Show();
            this.Hide();
        }
    }
}

