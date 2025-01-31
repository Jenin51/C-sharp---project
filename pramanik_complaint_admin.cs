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
    public partial class pramanik_complaint_admin : Form
    {
        private SqlConnection con;
        public pramanik_complaint_admin()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=DESKTOP-MGVJ7QM\SQLEXPRESS;Initial Catalog=family_member;Integrated Security=True;Encrypt=False");
        }

        private void pramanik_complaint_admin_Load(object sender, EventArgs e)
        {

        }

        private void Send_notice_button_Click(object sender, EventArgs e)
        {
            string notice = write_textbox.Text;
            string date = dateTimePicker1.Text;
            if (string.IsNullOrEmpty(notice) || string.IsNullOrEmpty(date))
            {
                MessageBox.Show("Please fill up all the fields");
                return;

            }
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO pramanik_complaint_admin_table values (@notice, @date)", con);
                cmd.Parameters.AddWithValue("@notice", notice);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Complaint sent successfully");
                write_textbox.Text = "";
                dateTimePicker1.Text = "";
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
    }
}
