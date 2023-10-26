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
    public partial class ViewItems : Form
    {
        public ViewItems()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection(@"Data Source=LAPTOP-4BP6EI0B\MSSQLSERVER01;Initial Catalog=RMS02;Integrated Security=True");
        private void getItemData()
        {

            if (txtItemIdSearch.Text == "")
            {
                MessageBox.Show("Fill up Id section");
            }


            else
            {
                Conn.Open();
                string query = "select * from ItemDB where [Item ID] = '" + txtItemIdSearch.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Conn);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    txtItemId.Text = dr["Item ID"].ToString();
                    txtItemName.Text = dr["Item Name"].ToString();
                    txtItemctg.Text = dr["Item Catagory"].ToString();
                    txtItemPrice.Text = dr["Item Price"].ToString();
                    
                }
                Conn.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ViewEmployee Ve = new ViewEmployee();
            Ve.Show();
            this.Hide();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            getItemData();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            txtItemId.Clear();
            txtItemName.Clear();
            txtItemctg.Clear();
            txtItemPrice.Clear();
            txtItemIdSearch.Clear();
        }
    }
}
