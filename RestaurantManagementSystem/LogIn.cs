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

namespace RestaurantManagementSystem
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4BP6EI0B\MSSQLSERVER01;Initial Catalog=RMS02;Integrated Security=True");

        private void LogInButton_Click(object sender, EventArgs e)
        {
            string username, userpassword;
            username = txtUsername.Text;
            userpassword = txtPassword.Text;

            try
            {
                string querry = "SELECT * FROM LogInDB WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "';";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                conn.Open();

                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    username = txtUsername.Text;
                    if (dt.Rows[0][2].ToString() == "Manager")
                    {
                        Home h = new Home(username);
                        h.Show();
                        this.Hide();
                    }
                    else 
                    {
                        Home2 h2 = new Home2();
                        h2.Show();
                        this.Hide();

                    }
         

                }
                else
                {
                    MessageBox.Show("Invalid Login Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Clear();
                    txtPassword.Clear();

                }


            }
            catch
            {
                MessageBox.Show("Error Login");
            }

        }
    }
}
