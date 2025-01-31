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
    public partial class sarker_complaint_admin : Form
    {
        private SqlConnection con;
        public sarker_complaint_admin()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=DESKTOP-MGVJ7QM\SQLEXPRESS;Initial Catalog=family_member;Integrated Security=True;Encrypt=False");
        }

        private void Send_notice_button_Click(object sender, EventArgs e)
        {
            string notice = write_textbox.Text;
            string date = dateTimePicker1.Text;
            if(string.IsNullOrEmpty(notice)|| string.IsNullOrEmpty(date)) 
                {
                MessageBox.Show("Please fill up all the fields");
                return; 

            }
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO sarker_complaint values (@notice, @date)", con);
                cmd.Parameters.AddWithValue("@notice", notice);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Complaint sent successfully");
                write_textbox.Text = "";
                dateTimePicker1.Text = "";
                BindData();
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
        void BindData()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM sarker_complaint", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
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

        private void sarker_complaint_admin_Load(object sender, EventArgs e)
        {

        }

        private void write_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
