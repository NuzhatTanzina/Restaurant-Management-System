
namespace RestaurantManagementSystem
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitLable = new System.Windows.Forms.Label();
            this.HomeLable = new System.Windows.Forms.Label();
            this.LogoutIcon = new System.Windows.Forms.PictureBox();
            this.HomeIcon = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ExpenseLable = new System.Windows.Forms.Label();
            this.ExpenseIcon = new System.Windows.Forms.PictureBox();
            this.FoodlistLable = new System.Windows.Forms.Label();
            this.FoodlistIcon = new System.Windows.Forms.PictureBox();
            this.ViewallIcon = new System.Windows.Forms.PictureBox();
            this.EmployeelistIcon = new System.Windows.Forms.PictureBox();
            this.ViewAllLable = new System.Windows.Forms.Label();
            this.EmployeesLable = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeIcon)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoodlistIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewallIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeelistIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.BackButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ExitLable);
            this.panel1.Controls.Add(this.HomeLable);
            this.panel1.Controls.Add(this.LogoutIcon);
            this.panel1.Controls.Add(this.HomeIcon);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 452);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BackButton
            // 
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.Location = new System.Drawing.Point(27, 418);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(41, 31);
            this.BackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackButton.TabIndex = 9;
            this.BackButton.TabStop = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(224, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Restaurant Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ExitLable
            // 
            this.ExitLable.AutoSize = true;
            this.ExitLable.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitLable.ForeColor = System.Drawing.Color.Green;
            this.ExitLable.Location = new System.Drawing.Point(739, 59);
            this.ExitLable.Name = "ExitLable";
            this.ExitLable.Size = new System.Drawing.Size(34, 17);
            this.ExitLable.TabIndex = 4;
            this.ExitLable.Text = "Exit";
            // 
            // HomeLable
            // 
            this.HomeLable.AutoSize = true;
            this.HomeLable.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeLable.ForeColor = System.Drawing.Color.Green;
            this.HomeLable.Location = new System.Drawing.Point(24, 59);
            this.HomeLable.Name = "HomeLable";
            this.HomeLable.Size = new System.Drawing.Size(49, 17);
            this.HomeLable.TabIndex = 3;
            this.HomeLable.Text = "Home";
            // 
            // LogoutIcon
            // 
            this.LogoutIcon.Image = ((System.Drawing.Image)(resources.GetObject("LogoutIcon.Image")));
            this.LogoutIcon.Location = new System.Drawing.Point(725, 9);
            this.LogoutIcon.Name = "LogoutIcon";
            this.LogoutIcon.Size = new System.Drawing.Size(63, 47);
            this.LogoutIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoutIcon.TabIndex = 2;
            this.LogoutIcon.TabStop = false;
            this.LogoutIcon.Click += new System.EventHandler(this.LogoutIcon_Click);
            // 
            // HomeIcon
            // 
            this.HomeIcon.Image = ((System.Drawing.Image)(resources.GetObject("HomeIcon.Image")));
            this.HomeIcon.Location = new System.Drawing.Point(12, 9);
            this.HomeIcon.Name = "HomeIcon";
            this.HomeIcon.Size = new System.Drawing.Size(71, 47);
            this.HomeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HomeIcon.TabIndex = 1;
            this.HomeIcon.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Controls.Add(this.ExpenseLable);
            this.panel2.Controls.Add(this.ExpenseIcon);
            this.panel2.Controls.Add(this.FoodlistLable);
            this.panel2.Controls.Add(this.FoodlistIcon);
            this.panel2.Controls.Add(this.ViewallIcon);
            this.panel2.Controls.Add(this.EmployeelistIcon);
            this.panel2.Controls.Add(this.ViewAllLable);
            this.panel2.Controls.Add(this.EmployeesLable);
            this.panel2.Location = new System.Drawing.Point(0, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 333);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // ExpenseLable
            // 
            this.ExpenseLable.AutoSize = true;
            this.ExpenseLable.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpenseLable.ForeColor = System.Drawing.Color.Transparent;
            this.ExpenseLable.Location = new System.Drawing.Point(621, 217);
            this.ExpenseLable.Name = "ExpenseLable";
            this.ExpenseLable.Size = new System.Drawing.Size(118, 32);
            this.ExpenseLable.TabIndex = 9;
            this.ExpenseLable.Text = "Expense";
            this.ExpenseLable.Click += new System.EventHandler(this.ExpenseLable_Click);
            // 
            // ExpenseIcon
            // 
            this.ExpenseIcon.Image = ((System.Drawing.Image)(resources.GetObject("ExpenseIcon.Image")));
            this.ExpenseIcon.Location = new System.Drawing.Point(619, 90);
            this.ExpenseIcon.Name = "ExpenseIcon";
            this.ExpenseIcon.Size = new System.Drawing.Size(114, 110);
            this.ExpenseIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExpenseIcon.TabIndex = 8;
            this.ExpenseIcon.TabStop = false;
            this.ExpenseIcon.Click += new System.EventHandler(this.ExpenseIcon_Click);
            // 
            // FoodlistLable
            // 
            this.FoodlistLable.AutoSize = true;
            this.FoodlistLable.BackColor = System.Drawing.Color.Transparent;
            this.FoodlistLable.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodlistLable.ForeColor = System.Drawing.Color.Transparent;
            this.FoodlistLable.Location = new System.Drawing.Point(46, 217);
            this.FoodlistLable.Name = "FoodlistLable";
            this.FoodlistLable.Size = new System.Drawing.Size(132, 32);
            this.FoodlistLable.TabIndex = 5;
            this.FoodlistLable.Text = "Food List";
            this.FoodlistLable.Click += new System.EventHandler(this.FoodlistLable_Click);
            // 
            // FoodlistIcon
            // 
            this.FoodlistIcon.BackColor = System.Drawing.Color.Transparent;
            this.FoodlistIcon.Image = ((System.Drawing.Image)(resources.GetObject("FoodlistIcon.Image")));
            this.FoodlistIcon.Location = new System.Drawing.Point(52, 90);
            this.FoodlistIcon.Name = "FoodlistIcon";
            this.FoodlistIcon.Size = new System.Drawing.Size(119, 110);
            this.FoodlistIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FoodlistIcon.TabIndex = 3;
            this.FoodlistIcon.TabStop = false;
            this.FoodlistIcon.Click += new System.EventHandler(this.FoodlistIcon_Click);
            // 
            // ViewallIcon
            // 
            this.ViewallIcon.BackColor = System.Drawing.Color.Transparent;
            this.ViewallIcon.Image = ((System.Drawing.Image)(resources.GetObject("ViewallIcon.Image")));
            this.ViewallIcon.Location = new System.Drawing.Point(436, 90);
            this.ViewallIcon.Name = "ViewallIcon";
            this.ViewallIcon.Size = new System.Drawing.Size(115, 110);
            this.ViewallIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ViewallIcon.TabIndex = 5;
            this.ViewallIcon.TabStop = false;
            this.ViewallIcon.Click += new System.EventHandler(this.ViewallIcon_Click);
            // 
            // EmployeelistIcon
            // 
            this.EmployeelistIcon.BackColor = System.Drawing.Color.Transparent;
            this.EmployeelistIcon.Image = ((System.Drawing.Image)(resources.GetObject("EmployeelistIcon.Image")));
            this.EmployeelistIcon.Location = new System.Drawing.Point(246, 90);
            this.EmployeelistIcon.Name = "EmployeelistIcon";
            this.EmployeelistIcon.Size = new System.Drawing.Size(119, 110);
            this.EmployeelistIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EmployeelistIcon.TabIndex = 4;
            this.EmployeelistIcon.TabStop = false;
            this.EmployeelistIcon.Click += new System.EventHandler(this.EmployeelistIcon_Click);
            // 
            // ViewAllLable
            // 
            this.ViewAllLable.AutoSize = true;
            this.ViewAllLable.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAllLable.ForeColor = System.Drawing.Color.Transparent;
            this.ViewAllLable.Location = new System.Drawing.Point(439, 217);
            this.ViewAllLable.Name = "ViewAllLable";
            this.ViewAllLable.Size = new System.Drawing.Size(112, 32);
            this.ViewAllLable.TabIndex = 7;
            this.ViewAllLable.Text = "View All";
            this.ViewAllLable.Click += new System.EventHandler(this.ViewAllLable_Click);
            // 
            // EmployeesLable
            // 
            this.EmployeesLable.AutoSize = true;
            this.EmployeesLable.BackColor = System.Drawing.Color.Transparent;
            this.EmployeesLable.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeesLable.ForeColor = System.Drawing.Color.Transparent;
            this.EmployeesLable.Location = new System.Drawing.Point(240, 217);
            this.EmployeesLable.Name = "EmployeesLable";
            this.EmployeesLable.Size = new System.Drawing.Size(149, 32);
            this.EmployeesLable.TabIndex = 6;
            this.EmployeesLable.Text = "Employees";
            this.EmployeesLable.Click += new System.EventHandler(this.EmployeesLable_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeIcon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoodlistIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewallIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeelistIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label HomeLable;
        private System.Windows.Forms.PictureBox LogoutIcon;
        private System.Windows.Forms.PictureBox HomeIcon;
        private System.Windows.Forms.Label ExitLable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BackButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label FoodlistLable;
        private System.Windows.Forms.PictureBox FoodlistIcon;
        private System.Windows.Forms.PictureBox ViewallIcon;
        private System.Windows.Forms.PictureBox EmployeelistIcon;
        private System.Windows.Forms.Label ViewAllLable;
        private System.Windows.Forms.Label EmployeesLable;
        private System.Windows.Forms.Label ExpenseLable;
        private System.Windows.Forms.PictureBox ExpenseIcon;
    }
}