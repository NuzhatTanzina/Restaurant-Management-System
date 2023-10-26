
namespace RestaurantManagementSystem
{
    partial class FoodList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ItemDGV = new System.Windows.Forms.DataGridView();
            this.Clear = new System.Windows.Forms.Button();
            this.ShowIten = new System.Windows.Forms.Button();
            this.ItemDelButton = new System.Windows.Forms.Button();
            this.ItemEditButton = new System.Windows.Forms.Button();
            this.ItemAddButton = new System.Windows.Forms.Button();
            this.comboItemCg = new System.Windows.Forms.ComboBox();
            this.txtItemPrice = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtItemId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.ExitIcon = new System.Windows.Forms.PictureBox();
            this.HomeIcon = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDGV)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ItemDGV);
            this.panel1.Controls.Add(this.Clear);
            this.panel1.Controls.Add(this.ShowIten);
            this.panel1.Controls.Add(this.ItemDelButton);
            this.panel1.Controls.Add(this.ItemEditButton);
            this.panel1.Controls.Add(this.ItemAddButton);
            this.panel1.Controls.Add(this.comboItemCg);
            this.panel1.Controls.Add(this.txtItemPrice);
            this.panel1.Controls.Add(this.txtItemName);
            this.panel1.Controls.Add(this.txtItemId);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 452);
            this.panel1.TabIndex = 0;
            // 
            // ItemDGV
            // 
            this.ItemDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ItemDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemDGV.GridColor = System.Drawing.Color.Green;
            this.ItemDGV.Location = new System.Drawing.Point(356, 134);
            this.ItemDGV.Name = "ItemDGV";
            this.ItemDGV.ReadOnly = true;
            this.ItemDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemDGV.Size = new System.Drawing.Size(413, 294);
            this.ItemDGV.TabIndex = 14;
            this.ItemDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemDGV_CellContentClick);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.Green;
            this.Clear.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.Color.White;
            this.Clear.Location = new System.Drawing.Point(206, 397);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 31);
            this.Clear.TabIndex = 13;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // ShowIten
            // 
            this.ShowIten.BackColor = System.Drawing.Color.Green;
            this.ShowIten.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowIten.ForeColor = System.Drawing.Color.White;
            this.ShowIten.Location = new System.Drawing.Point(91, 397);
            this.ShowIten.Name = "ShowIten";
            this.ShowIten.Size = new System.Drawing.Size(75, 31);
            this.ShowIten.TabIndex = 12;
            this.ShowIten.Text = "Show";
            this.ShowIten.UseVisualStyleBackColor = false;
            this.ShowIten.Click += new System.EventHandler(this.ShowIten_Click);
            // 
            // ItemDelButton
            // 
            this.ItemDelButton.BackColor = System.Drawing.Color.Green;
            this.ItemDelButton.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemDelButton.ForeColor = System.Drawing.Color.White;
            this.ItemDelButton.Location = new System.Drawing.Point(147, 348);
            this.ItemDelButton.Name = "ItemDelButton";
            this.ItemDelButton.Size = new System.Drawing.Size(75, 31);
            this.ItemDelButton.TabIndex = 11;
            this.ItemDelButton.Text = "Delete";
            this.ItemDelButton.UseVisualStyleBackColor = false;
            this.ItemDelButton.Click += new System.EventHandler(this.ItemDelButton_Click);
            // 
            // ItemEditButton
            // 
            this.ItemEditButton.BackColor = System.Drawing.Color.Green;
            this.ItemEditButton.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemEditButton.ForeColor = System.Drawing.Color.White;
            this.ItemEditButton.Location = new System.Drawing.Point(260, 348);
            this.ItemEditButton.Name = "ItemEditButton";
            this.ItemEditButton.Size = new System.Drawing.Size(75, 31);
            this.ItemEditButton.TabIndex = 10;
            this.ItemEditButton.Text = "Edit";
            this.ItemEditButton.UseVisualStyleBackColor = false;
            this.ItemEditButton.Click += new System.EventHandler(this.ItemEditButton_Click);
            // 
            // ItemAddButton
            // 
            this.ItemAddButton.BackColor = System.Drawing.Color.Green;
            this.ItemAddButton.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemAddButton.ForeColor = System.Drawing.Color.White;
            this.ItemAddButton.Location = new System.Drawing.Point(33, 348);
            this.ItemAddButton.Name = "ItemAddButton";
            this.ItemAddButton.Size = new System.Drawing.Size(75, 31);
            this.ItemAddButton.TabIndex = 9;
            this.ItemAddButton.Text = "Add";
            this.ItemAddButton.UseVisualStyleBackColor = false;
            this.ItemAddButton.Click += new System.EventHandler(this.ItemAddButton_Click);
            // 
            // comboItemCg
            // 
            this.comboItemCg.FormattingEnabled = true;
            this.comboItemCg.Items.AddRange(new object[] {
            "Fast Food",
            "Thai & Chinese",
            "Dessert",
            "Drinks"});
            this.comboItemCg.Location = new System.Drawing.Point(173, 231);
            this.comboItemCg.Name = "comboItemCg";
            this.comboItemCg.Size = new System.Drawing.Size(162, 21);
            this.comboItemCg.TabIndex = 8;
            // 
            // txtItemPrice
            // 
            this.txtItemPrice.Location = new System.Drawing.Point(173, 283);
            this.txtItemPrice.Name = "txtItemPrice";
            this.txtItemPrice.Size = new System.Drawing.Size(162, 20);
            this.txtItemPrice.TabIndex = 7;
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(173, 182);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(162, 20);
            this.txtItemName.TabIndex = 6;
            // 
            // txtItemId
            // 
            this.txtItemId.Location = new System.Drawing.Point(173, 134);
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.Size = new System.Drawing.Size(162, 20);
            this.txtItemId.TabIndex = 5;
            this.txtItemId.TextChanged += new System.EventHandler(this.txtItemId_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(29, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Item Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(29, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Item Catagory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(29, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(29, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.ExitIcon);
            this.panel2.Controls.Add(this.HomeIcon);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 65);
            this.panel2.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(201, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(393, 30);
            this.label5.TabIndex = 2;
            this.label5.Text = "Restaurant Management System";
            // 
            // ExitIcon
            // 
            this.ExitIcon.Image = ((System.Drawing.Image)(resources.GetObject("ExitIcon.Image")));
            this.ExitIcon.Location = new System.Drawing.Point(702, 12);
            this.ExitIcon.Name = "ExitIcon";
            this.ExitIcon.Size = new System.Drawing.Size(87, 41);
            this.ExitIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitIcon.TabIndex = 1;
            this.ExitIcon.TabStop = false;
            this.ExitIcon.Click += new System.EventHandler(this.ExitIcon_Click);
            // 
            // HomeIcon
            // 
            this.HomeIcon.Image = ((System.Drawing.Image)(resources.GetObject("HomeIcon.Image")));
            this.HomeIcon.Location = new System.Drawing.Point(13, 12);
            this.HomeIcon.Name = "HomeIcon";
            this.HomeIcon.Size = new System.Drawing.Size(76, 41);
            this.HomeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HomeIcon.TabIndex = 0;
            this.HomeIcon.TabStop = false;
            this.HomeIcon.Click += new System.EventHandler(this.HomeIcon_Click);
            // 
            // FoodList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FoodList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FoodList";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDGV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox ExitIcon;
        private System.Windows.Forms.PictureBox HomeIcon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button ShowIten;
        private System.Windows.Forms.Button ItemDelButton;
        private System.Windows.Forms.Button ItemEditButton;
        private System.Windows.Forms.Button ItemAddButton;
        private System.Windows.Forms.ComboBox comboItemCg;
        private System.Windows.Forms.TextBox txtItemPrice;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtItemId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView ItemDGV;
        private System.Windows.Forms.Label label5;
    }
}