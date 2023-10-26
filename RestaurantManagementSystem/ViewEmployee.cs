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
    public partial class ViewEmployee : Form
    {
        SqlConnection Conn = new SqlConnection(@"Data Source=LAPTOP-4BP6EI0B\MSSQLSERVER01;Initial Catalog=RMS02;Integrated Security=True");
        private void getEmpData()
        {
            if (txtEmpIDSearch.Text == "")
            {
                MessageBox.Show("Fill up Id section");
            }

            
            else
            {
                Conn.Open();
                string query = "select * from EmpDB where EmpID = '" + txtEmpIDSearch.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Conn);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    txtEmpID.Text = dr["EmpID"].ToString();
                    txtEmpName.Text = dr["EmpName"].ToString();
                    txtEmpPos.Text = dr["EmpPos"].ToString();
                    txtEmpDOB.Text = dr["EmpDoB"].ToString();
                    txtEmpSalary.Text = dr["EmpSalary"].ToString();
                }
                Conn.Close();
            }
            
        }
        public ViewEmployee()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ViewEmployee_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            getEmpData();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            txtEmpID.Clear();
            txtEmpName.Clear();
            txtEmpPos.Clear();
            txtEmpDOB.Clear();
            txtEmpSalary.Clear();
            txtEmpIDSearch.Clear();
        }

        private void ViewItemIcon02_Click(object sender, EventArgs e)
        {
            ViewItems Ve = new ViewItems();
            Ve.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog()== DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("==========Employee Summary==========", new Font("Calibri", 20, FontStyle.Bold), Brushes.Green , new Point(200));
            e.Graphics.DrawString("Employee ID : "+txtEmpID.Text, new Font("Calibri", 20, FontStyle.Regular), Brushes.Green, new Point(20,100));
            e.Graphics.DrawString("Employee Name :" + txtEmpName.Text, new Font("Calibri", 20, FontStyle.Regular), Brushes.Green, new Point(20, 125));
            e.Graphics.DrawString("Employee Position : " + txtEmpPos.Text, new Font("Calibri", 20, FontStyle.Regular), Brushes.Green, new Point(20, 150));
            e.Graphics.DrawString("Employee DOB  :"+ txtEmpDOB.Text, new Font("Calibri", 20, FontStyle.Regular), Brushes.Green, new Point(20, 175));
            e.Graphics.DrawString("Employee Salary  :"+txtEmpSalary.Text,new Font("Calibri", 20, FontStyle.Regular), Brushes.Green, new Point(20, 200));
          

        }
    }
}
