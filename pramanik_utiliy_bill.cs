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
    public partial class pramanik_utiliy_bill : Form
    {
        string connectionString = @"Data Source=DESKTOP-MGVJ7QM\SQLEXPRESS;Initial Catalog=family_member;Integrated Security=True;Encrypt=False";
        public pramanik_utiliy_bill()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pramanik pramanik = new pramanik();
            pramanik.Show();
                this.Hide();    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM pramanik_utilities_table", sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                {
                }
            }
        }
    }
}
