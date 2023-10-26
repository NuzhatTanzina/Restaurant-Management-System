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
    public partial class FoodList : Form
    {
        public FoodList()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void HomeIcon_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void ExitIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection Conn = new SqlConnection(@"Data Source=LAPTOP-4BP6EI0B\MSSQLSERVER01;Initial Catalog=RMS02;Integrated Security=True");

        private void ItemAddButton_Click(object sender, EventArgs e)
        {
            if (txtItemId.Text == "" || txtItemName.Text == "" || txtItemPrice.Text == "")
            {
                MessageBox.Show("Missing Inormation");
            }
            else
            {
                try
                {
                    Conn.Open();
                    string query = "Insert into ItemDB values('" + txtItemId.Text + "','" + txtItemName.Text + "','" + comboItemCg.SelectedItem.ToString() + "','" + txtItemPrice.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item Successfully Added");
                    Conn.Close();
                    populate();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void populate()
        {
            Conn.Open();
            string query = "select * from ItemDB";
            SqlDataAdapter sda = new SqlDataAdapter(query, Conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ItemDGV.DataSource = ds.Tables[0];
            Conn.Close();

        }

        private void ShowIten_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txtItemId.Clear();
            txtItemName.Clear();
            txtItemPrice.Clear();
        }

        private void ItemDelButton_Click(object sender, EventArgs e)
        {
            if (txtItemId.Text == "")
            {
                MessageBox.Show("Enter the Item ID");
            }
            else
            {
                try
                {
                    Conn.Open();
                    string query = " delete from ItemDB where [Item ID] = '" + txtItemId.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Conn);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item Deleted Successfully");
                    Conn.Close();
                    populate();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void ItemDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtItemId.Text = ItemDGV.SelectedRows[0].Cells[0].Value.ToString();
            txtItemName.Text = ItemDGV.SelectedRows[0].Cells[1].Value.ToString();
            comboItemCg.Text = ItemDGV.SelectedRows[0].Cells[2].Value.ToString();
            txtItemPrice.Text = ItemDGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void ItemEditButton_Click(object sender, EventArgs e)
        {
            if(txtItemId.Text == "" || txtItemId.Text == "" || txtItemPrice.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Conn.Open();
                    string query = " update ItemDB set [Item Name] = '" + txtItemName.Text + "', [Item Catagory] = '" + comboItemCg.SelectedItem.ToString() + "',[Item Price] = '" + txtItemPrice.Text + "'where [Item ID] = '" + txtItemId.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item Updated Successfully");
                    Conn.Close();
                    populate();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void txtItemId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
