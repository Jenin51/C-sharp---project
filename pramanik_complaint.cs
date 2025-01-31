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
    public partial class pramanik_complaint : Form
    {
        public pramanik_complaint()
        {
            InitializeComponent();
        }

        private void Send_button_Click(object sender, EventArgs e)
        {
            // Get values from text boxes
            string subject = guna2TextBox1.Text.Trim();
            string complaint = guna2TextBox2.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(subject) || string.IsNullOrEmpty(complaint))
            {
                MessageBox.Show("Please fill all the fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop execution if validation fails
            }

            try
            {
                // Use 'using' to properly manage resources
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MGVJ7QM\SQLEXPRESS;Initial Catalog=family_member;Integrated Security=True;Encrypt=False"))
                {
                    con.Open();
                    string query = "INSERT INTO pramanik_complaint_table (subject, complaint) VALUES (@Subject, @Complaint)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add parameters explicitly with types
                        cmd.Parameters.Add("@subject", SqlDbType.NVarChar).Value = subject;
                        cmd.Parameters.Add("@complaint", SqlDbType.NVarChar).Value = complaint;

                        // Execute the query
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Complaint sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or display the exception for debugging
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Navigate to another form
            pramanik p = new pramanik();
            p.Show();
            this.Hide();
        }

        // Optionally remove this method if not used
        private void pramanik_complaint_Load(object sender, EventArgs e)
        {
            // Load event is currently unused
        }
    }
}

