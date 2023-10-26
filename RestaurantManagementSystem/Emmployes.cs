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
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void EmpExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection Conn = new SqlConnection(@"Data Source=LAPTOP-4BP6EI0B\MSSQLSERVER01;Initial Catalog=RMS02;Integrated Security=True");

        private void AddEmp_Click(object sender, EventArgs e)
        {
            if (txtEid.Text == "" || txtEname.Text == "" || txtEsalary.Text == "")
            {
                MessageBox.Show("Missing Inormation");
            }
            else
            {
                try
                {
                    Conn.Open();
                    string query = "Insert into EmpDB values('" + txtEid.Text + "','" + txtEname.Text + "','" + comboEposition.SelectedItem.ToString() + "','" + dateEbob.Value.Date + "','" + txtEsalary.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Successfully Added");
                    Conn.Close();
                    populate();

                }catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void comboEposition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void populate()
        {
            Conn.Open();
            string query = "select * from EmpDB";
            SqlDataAdapter sda = new SqlDataAdapter(query, Conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EmpDGV.DataSource = ds.Tables[0];
            Conn.Close();
                
        }

        private void ShowEmpButton_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void DelEmp_Click(object sender, EventArgs e)
        {
           
            if (txtEid.Text == "") 
            {
                MessageBox.Show("Enter the Employee ID");
            }
            else
            {
                try
                {
                    Conn.Open();
                    string query = " delete from EmpDB where EmpID = '" + txtEid.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Conn);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Deleted Successfully");
                    Conn.Close();
                    populate();


                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }
        private void EmpDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEid.Text = EmpDGV.SelectedRows[0].Cells[0].Value.ToString();
            txtEname.Text = EmpDGV.SelectedRows[0].Cells[1].Value.ToString();
            comboEposition.Text = EmpDGV.SelectedRows[0].Cells[2].Value.ToString();
            dateEbob.Text = EmpDGV.SelectedRows[0].Cells[3].Value.ToString();
            txtEsalary.Text = EmpDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            txtEid.Clear();
            txtEname.Clear();
            txtEsalary.Clear();
    

        }

        private void EditEmp_Click(object sender, EventArgs e)
        {
            if (txtEid.Text == "" || txtEname.Text == "" || txtEsalary.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                try
                {
                    Conn.Open();
                    string query = " update EmpDB set EmpName = '" + txtEname.Text+"', EmpPos = '" + comboEposition.SelectedItem.ToString() + "',EmpDob = '" + dateEbob.Value.Date + "',EmpSalary = '" + txtEsalary.Text + "'where EmpID = '" + txtEid.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Updated Successfully");
                    Conn.Close();
                    populate();
                }catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message); 
                }
            }
        }
    }
}
