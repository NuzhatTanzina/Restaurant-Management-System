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
    public partial class ExpenseofEmp : Form
    {
        public ExpenseofEmp()
        {
            InitializeComponent();
        }

        SqlConnection Conn = new SqlConnection(@"Data Source=LAPTOP-4BP6EI0B\MSSQLSERVER01;Initial Catalog=RMS02;Integrated Security=True");

        private void GetEmpData()
        {
            if(txtempId.Text == "")
            {
                MessageBox.Show(" Enter Employee Id");
            }
            else
            {
                Conn.Open();
                string query = "select * from EmpDB where EmpID = '" + txtempId.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Conn);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    // txtempId.Text = dr["EmpID"].ToString();
                    txtempname.Text = dr["EmpName"].ToString();
                    txtemppos.Text = dr["EmpPos"].ToString();

                }
                Conn.Close();
            }
           
        }
        private void ExpenseofEmp_Load(object sender, EventArgs e)
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

        private void ShowButton_Click(object sender, EventArgs e)
        {
            GetEmpData();

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("==========Employee Salary Data==========", new Font("Calibri", 20, FontStyle.Bold), Brushes.Green, new Point(200));
            e.Graphics.DrawString("Employee ID : " + txtempId.Text, new Font("Calibri", 20, FontStyle.Regular), Brushes.Green, new Point(20, 100));
            e.Graphics.DrawString("Employee Name :" + txtempname.Text, new Font("Calibri", 20, FontStyle.Regular), Brushes.Green, new Point(20, 125));
            e.Graphics.DrawString("Employee Position : " + txtemppos.Text, new Font("Calibri", 20, FontStyle.Regular), Brushes.Green, new Point(20, 150));
            e.Graphics.DrawString("Employee Totat Salary  :"  + Total , new Font("Calibri", 20, FontStyle.Regular), Brushes.Green, new Point(20, 200));
        }
        int Perday, Total;
        private void CalcButton_Click(object sender, EventArgs e)
        {
            if(txtemppos.Text=="")
            {
                MessageBox.Show("Slecet An Employee");
            }
            else if(txtempwd.Text==""|| Convert.ToInt32(txtempwd.Text) > 28)
            {
                MessageBox.Show("Enter a Valid Number of Days");
            }
            else
            {
                if(txtemppos.Text=="Manager")
                {
                    Perday = 710;
                }
                else if(txtemppos.Text == "Chef")
                {
                    Perday = 570;
                }
                else if(txtemppos.Text=="Salesman")
                {
                    Perday = 425;
                }
                Total = Perday * Convert.ToInt32(txtempwd.Text);
                SalarySlip.Text ="------Employee Salary Reciet------"+"\n"+"Employee ID:" +txtempId.Text + "\n" +"Employee Name:"+ txtempname.Text + "\n" +"Employee Position:"+ txtemppos.Text + "\n" +"Working Days:"+ txtempwd.Text + "\n" +"Daily Salary:" +Perday + "\n" +"Total Salary:" + Total + "\n";


            }
        }
    }
}
