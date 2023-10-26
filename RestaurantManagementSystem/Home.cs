using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class Home : Form
    {
        string UserName;
        public Home()
        {
            InitializeComponent();
        }
        public Home(string username) :this()

        {
            this.UserName = username;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EmployeelistIcon_Click(object sender, EventArgs e)
        {
            Employees E = new Employees();
            E.Show();
            this.Hide();

        }

        private void LogoutIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            LogIn LI = new LogIn();
            LI.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EmployeesLable_Click(object sender, EventArgs e)
        {
            Employees E = new Employees();
            E.Show();
            this.Hide();

        }

        private void FoodlistIcon_Click(object sender, EventArgs e)
        {
            FoodList Fl = new FoodList();
            Fl.Show();
            this.Hide();
        }

        private void FoodlistLable_Click(object sender, EventArgs e)
        {
            FoodList Fl = new FoodList();
            Fl.Show();
            this.Hide();
        }

        private void ViewallIcon_Click(object sender, EventArgs e)
        {
            ViewEmployee Ve = new ViewEmployee();
            Ve.Show();
            this.Hide();
        }

        private void ViewAllLable_Click(object sender, EventArgs e)
        {
            ViewEmployee Ve = new ViewEmployee();
            Ve.Show();
            this.Hide();
        }

        private void ExpenseIcon_Click(object sender, EventArgs e)
        {
            ExpenseofEmp Ex = new ExpenseofEmp();
            Ex.Show();
            this.Hide();
        }

        private void ExpenseLable_Click(object sender, EventArgs e)
        {
            ExpenseofEmp Ex = new ExpenseofEmp();
            Ex.Show();
            this.Hide();
        }
    }
}
