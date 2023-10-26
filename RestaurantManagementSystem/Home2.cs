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
    public partial class Home2 : Form
    {
        public Home2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ExpenseOfItems EI = new ExpenseOfItems();
            EI.Show();
            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            LogIn Lg = new LogIn();
            Lg.Show();
            this.Hide();

        }

        private void ExitIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Home2_Load(object sender, EventArgs e)
        {

        }

        private void FoodListIcon_Click(object sender, EventArgs e)
        {
            Foodlistsales Fs = new Foodlistsales();
            Fs.Show();
            this.Hide();
        }
    }
}
