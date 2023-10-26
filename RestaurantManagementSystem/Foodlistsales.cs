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
    public partial class Foodlistsales : Form
    {
        public Foodlistsales()
        {
            InitializeComponent();
        }

        private void HomeIcon_Click(object sender, EventArgs e)
        {
            Home2 h2 = new Home2();
            h2.Show();
            this.Hide();
                
        }

        private void ExitIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection Conn = new SqlConnection(@"Data Source=LAPTOP-4BP6EI0B\MSSQLSERVER01;Initial Catalog=RMS02;Integrated Security=True");
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

        private void ShowButton_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void ItemDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtItemID.Text = ItemDGV.SelectedRows[0].Cells[0].Value.ToString();
            txtItemname.Text = ItemDGV.SelectedRows[0].Cells[1].Value.ToString();
            comboItemctg.Text = ItemDGV.SelectedRows[0].Cells[2].Value.ToString();
            ItemPrice.Text = ItemDGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            txtItemID.Clear();
            txtItemname.Clear();
            ItemPrice.Clear();


        }
    }
}
