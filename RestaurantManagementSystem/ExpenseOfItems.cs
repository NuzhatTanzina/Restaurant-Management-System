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
    public partial class ExpenseOfItems : Form
    {
        SqlConnection Conn = new SqlConnection(@"Data Source=LAPTOP-4BP6EI0B\MSSQLSERVER01;Initial Catalog=RMS02;Integrated Security=True");
        public ExpenseOfItems()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ExpenseOfItems_Load(object sender, EventArgs e)
        {

        }

        private void txtItemID_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home2 h2 = new Home2();
            h2.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void GetItemData()
        {
            if (txtItemID.Text == "")
            {
                MessageBox.Show(" Enter Item Id");
            }
            else
            {
                Conn.Open();
                string query = "select * from ItemDB where [Item ID] = '" + txtItemID.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Conn);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    // txtempId.Text = dr["EmpID"].ToString();
                    txtIteName.Text = dr["Item Name"].ToString();
                    txtItemctg.Text = dr["Item Catagory"].ToString();

                }
                Conn.Close();
            }

        }
        int Price, Total;
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (txtItemID.Text == "")
            {
                MessageBox.Show("Slecet An Item");
            }
            else if (txtItemQT.Text == "" || Convert.ToInt32(txtItemQT.Text) < 0 )
            {
                MessageBox.Show("Enter a Valid Number");
            }
            else
            {
                if (txtItemctg.Text == "Fast Food")
                {
                    Price = 180;
                }
                else if (txtItemctg.Text == "Thai & Chinese")
                {
                    Price = 250;
                }
                else if (txtItemctg.Text == "Dessert")
                {
                   Price = 100;
                }
                else if (txtItemctg.Text == "Drinks")
                {
                    Price = 80;
                }
                Total = Price * Convert.ToInt32(txtItemQT.Text);
                PriceSlip.Text = "------Item Price Reciet------" + "\n" + "ItemID:" + txtItemID.Text + "\n" + "Item Name:" + txtIteName.Text + "\n" + "Item Catagory:" + txtItemctg.Text + "\n"  + "Price Per Item :" + Price + "\n" + "Total Price :" + Total + "\n";


            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("==========Item Price Reciet==========", new Font("Calibri", 20, FontStyle.Bold), Brushes.Green, new Point(200));
            e.Graphics.DrawString("Item ID : " + txtItemID.Text, new Font("Calibri", 20, FontStyle.Regular), Brushes.Green, new Point(20, 100));
            e.Graphics.DrawString("Item Name :" + txtIteName.Text, new Font("Calibri", 20, FontStyle.Regular), Brushes.Green, new Point(20, 125));
            e.Graphics.DrawString("Item Catagory : " + txtItemctg.Text, new Font("Calibri", 20, FontStyle.Regular), Brushes.Green, new Point(20, 150));
            e.Graphics.DrawString("Total Price  :" + Total, new Font("Calibri", 20, FontStyle.Regular), Brushes.Green, new Point(20, 200));
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void PriceSlip_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            GetItemData();
        }
    }
}
