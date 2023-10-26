
namespace RestaurantManagementSystem
{
    partial class Employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.ShowEmpButton = new System.Windows.Forms.Button();
            this.EmpDGV = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.EmpExit = new System.Windows.Forms.PictureBox();
            this.EmpHome = new System.Windows.Forms.PictureBox();
            this.DelEmp = new System.Windows.Forms.Button();
            this.EditEmp = new System.Windows.Forms.Button();
            this.AddEmp = new System.Windows.Forms.Button();
            this.txtEsalary = new System.Windows.Forms.TextBox();
            this.dateEbob = new System.Windows.Forms.DateTimePicker();
            this.comboEposition = new System.Windows.Forms.ComboBox();
            this.txtEname = new System.Windows.Forms.TextBox();
            this.txtEid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpDGV)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Clearbutton);
            this.panel1.Controls.Add(this.ShowEmpButton);
            this.panel1.Controls.Add(this.EmpDGV);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.DelEmp);
            this.panel1.Controls.Add(this.EditEmp);
            this.panel1.Controls.Add(this.AddEmp);
            this.panel1.Controls.Add(this.txtEsalary);
            this.panel1.Controls.Add(this.dateEbob);
            this.panel1.Controls.Add(this.comboEposition);
            this.panel1.Controls.Add(this.txtEname);
            this.panel1.Controls.Add(this.txtEid);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 454);
            this.panel1.TabIndex = 0;
            // 
            // Clearbutton
            // 
            this.Clearbutton.BackColor = System.Drawing.Color.Green;
            this.Clearbutton.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Clearbutton.Location = new System.Drawing.Point(194, 396);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(79, 32);
            this.Clearbutton.TabIndex = 16;
            this.Clearbutton.Text = "Clear";
            this.Clearbutton.UseVisualStyleBackColor = false;
            this.Clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
            // 
            // ShowEmpButton
            // 
            this.ShowEmpButton.BackColor = System.Drawing.Color.Green;
            this.ShowEmpButton.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowEmpButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ShowEmpButton.Location = new System.Drawing.Point(72, 396);
            this.ShowEmpButton.Name = "ShowEmpButton";
            this.ShowEmpButton.Size = new System.Drawing.Size(79, 32);
            this.ShowEmpButton.TabIndex = 15;
            this.ShowEmpButton.Text = "Show";
            this.ShowEmpButton.UseVisualStyleBackColor = false;
            this.ShowEmpButton.Click += new System.EventHandler(this.ShowEmpButton_Click);
            // 
            // EmpDGV
            // 
            this.EmpDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EmpDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmpDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpDGV.GridColor = System.Drawing.Color.Green;
            this.EmpDGV.Location = new System.Drawing.Point(352, 103);
            this.EmpDGV.Name = "EmpDGV";
            this.EmpDGV.ReadOnly = true;
            this.EmpDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmpDGV.Size = new System.Drawing.Size(423, 325);
            this.EmpDGV.TabIndex = 14;
            this.EmpDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpDGV_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.EmpExit);
            this.panel2.Controls.Add(this.EmpHome);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 68);
            this.panel2.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(184, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(434, 39);
            this.label6.TabIndex = 2;
            this.label6.Text = "Restaurant Management System";
            this.label6.UseCompatibleTextRendering = true;
            // 
            // EmpExit
            // 
            this.EmpExit.Image = ((System.Drawing.Image)(resources.GetObject("EmpExit.Image")));
            this.EmpExit.Location = new System.Drawing.Point(716, 13);
            this.EmpExit.Name = "EmpExit";
            this.EmpExit.Size = new System.Drawing.Size(73, 44);
            this.EmpExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EmpExit.TabIndex = 1;
            this.EmpExit.TabStop = false;
            this.EmpExit.Click += new System.EventHandler(this.EmpExit_Click);
            // 
            // EmpHome
            // 
            this.EmpHome.Image = ((System.Drawing.Image)(resources.GetObject("EmpHome.Image")));
            this.EmpHome.Location = new System.Drawing.Point(16, 13);
            this.EmpHome.Name = "EmpHome";
            this.EmpHome.Size = new System.Drawing.Size(73, 44);
            this.EmpHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EmpHome.TabIndex = 0;
            this.EmpHome.TabStop = false;
            this.EmpHome.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DelEmp
            // 
            this.DelEmp.BackColor = System.Drawing.Color.Green;
            this.DelEmp.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelEmp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DelEmp.Location = new System.Drawing.Point(130, 329);
            this.DelEmp.Name = "DelEmp";
            this.DelEmp.Size = new System.Drawing.Size(79, 32);
            this.DelEmp.TabIndex = 12;
            this.DelEmp.Text = "Delete";
            this.DelEmp.UseVisualStyleBackColor = false;
            this.DelEmp.Click += new System.EventHandler(this.DelEmp_Click);
            // 
            // EditEmp
            // 
            this.EditEmp.BackColor = System.Drawing.Color.Green;
            this.EditEmp.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditEmp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EditEmp.Location = new System.Drawing.Point(245, 329);
            this.EditEmp.Name = "EditEmp";
            this.EditEmp.Size = new System.Drawing.Size(79, 32);
            this.EditEmp.TabIndex = 11;
            this.EditEmp.Text = "Edit";
            this.EditEmp.UseVisualStyleBackColor = false;
            this.EditEmp.Click += new System.EventHandler(this.EditEmp_Click);
            // 
            // AddEmp
            // 
            this.AddEmp.BackColor = System.Drawing.Color.Green;
            this.AddEmp.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddEmp.Location = new System.Drawing.Point(16, 329);
            this.AddEmp.Name = "AddEmp";
            this.AddEmp.Size = new System.Drawing.Size(79, 32);
            this.AddEmp.TabIndex = 10;
            this.AddEmp.Text = "Add";
            this.AddEmp.UseVisualStyleBackColor = false;
            this.AddEmp.Click += new System.EventHandler(this.AddEmp_Click);
            // 
            // txtEsalary
            // 
            this.txtEsalary.Location = new System.Drawing.Point(159, 260);
            this.txtEsalary.Name = "txtEsalary";
            this.txtEsalary.Size = new System.Drawing.Size(165, 20);
            this.txtEsalary.TabIndex = 9;
            // 
            // dateEbob
            // 
            this.dateEbob.Location = new System.Drawing.Point(159, 220);
            this.dateEbob.Name = "dateEbob";
            this.dateEbob.Size = new System.Drawing.Size(165, 20);
            this.dateEbob.TabIndex = 8;
            // 
            // comboEposition
            // 
            this.comboEposition.FormattingEnabled = true;
            this.comboEposition.Items.AddRange(new object[] {
            "Manager",
            "Chef",
            "Salesman"});
            this.comboEposition.Location = new System.Drawing.Point(159, 182);
            this.comboEposition.Name = "comboEposition";
            this.comboEposition.Size = new System.Drawing.Size(165, 21);
            this.comboEposition.TabIndex = 7;
            this.comboEposition.SelectedIndexChanged += new System.EventHandler(this.comboEposition_SelectedIndexChanged);
            // 
            // txtEname
            // 
            this.txtEname.Location = new System.Drawing.Point(159, 144);
            this.txtEname.Name = "txtEname";
            this.txtEname.Size = new System.Drawing.Size(165, 20);
            this.txtEname.TabIndex = 6;
            // 
            // txtEid
            // 
            this.txtEid.Location = new System.Drawing.Point(159, 103);
            this.txtEid.Name = "txtEid";
            this.txtEid.Size = new System.Drawing.Size(165, 20);
            this.txtEid.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(13, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Employee Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(13, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Employee DOB";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(13, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Employee Position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(13, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(13, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Name";
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpDGV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboEposition;
        private System.Windows.Forms.TextBox txtEname;
        private System.Windows.Forms.TextBox txtEid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox EmpHome;
        private System.Windows.Forms.Button DelEmp;
        private System.Windows.Forms.Button EditEmp;
        private System.Windows.Forms.Button AddEmp;
        private System.Windows.Forms.TextBox txtEsalary;
        private System.Windows.Forms.DateTimePicker dateEbob;
        private System.Windows.Forms.PictureBox EmpExit;
        private System.Windows.Forms.DataGridView EmpDGV;
        private System.Windows.Forms.Button ShowEmpButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Clearbutton;
    }
}