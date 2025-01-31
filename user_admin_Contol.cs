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
using Final_Lab_Project.loginDataSetTableAdapters;

namespace Final_Lab_Project
{
    public partial class user_admin_Contol : Form
    {
        public user_admin_Contol()
        {
            InitializeComponent();
        }

        private void user_admin_Contol_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginDataSet1.login' table. You can move, or remove it, as needed.
            this.loginTableAdapter1.Fill(this.loginDataSet1.login);
            // TODO: This line of code loads data into the 'loginDataSet.login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.loginDataSet.login);

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            loginBindingSource1.AddNew();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            loginBindingSource1.EndEdit();
            loginTableAdapter1.Update(loginDataSet1);

        }


        private void delete_button_Click(object sender, EventArgs e)
        {
            loginBindingSource1.RemoveCurrent();
        }

        private void colse_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void first_button_Click(object sender, EventArgs e)
        {
            loginBindingSource1.MoveFirst();
        }

        private void previous_button_Click(object sender, EventArgs e)
        {
            loginBindingSource1.MovePrevious();
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            loginBindingSource1.MoveNext();
        }

        private void last_button_Click(object sender, EventArgs e)
        {
            loginBindingSource1.MoveLast();
        }
    }
}
