namespace CarRentalCompany
{
    partial class Form1
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
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.ageComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.vehicleComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pickup = new System.Windows.Forms.DateTimePicker();
            this.dropoff = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.addOnsCheckedBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(399, 113);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(200, 31);
            this.firstName.TabIndex = 0;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(399, 166);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(200, 31);
            this.lastName.TabIndex = 1;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(399, 223);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(200, 31);
            this.email.TabIndex = 2;
            this.email.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // phoneNumber
            // 
            this.phoneNumber.Location = new System.Drawing.Point(399, 285);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(200, 31);
            this.phoneNumber.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phone Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(156, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(443, 67);
            this.label5.TabIndex = 9;
            this.label5.Text = "KG Car Rentals";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(291, 800);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(127, 43);
            this.submit.TabIndex = 10;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // ageComboBox
            // 
            this.ageComboBox.DisplayMember = "18";
            this.ageComboBox.FormattingEnabled = true;
            this.ageComboBox.Items.AddRange(new object[] {
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25+"});
            this.ageComboBox.Location = new System.Drawing.Point(399, 552);
            this.ageComboBox.Name = "ageComboBox";
            this.ageComboBox.Size = new System.Drawing.Size(300, 33);
            this.ageComboBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 555);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Age:";
            // 
            // vehicleComboBox
            // 
            this.vehicleComboBox.AllowDrop = true;
            this.vehicleComboBox.FormattingEnabled = true;
            this.vehicleComboBox.Items.AddRange(new object[] {
            "Car",
            "Truck",
            "SUV"});
            this.vehicleComboBox.Location = new System.Drawing.Point(399, 488);
            this.vehicleComboBox.Name = "vehicleComboBox";
            this.vehicleComboBox.Size = new System.Drawing.Size(300, 33);
            this.vehicleComboBox.TabIndex = 15;
            this.vehicleComboBox.SelectedIndexChanged += new System.EventHandler(this.vehicleComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 491);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Vehicle Type:";
            // 
            // pickup
            // 
            this.pickup.Location = new System.Drawing.Point(399, 356);
            this.pickup.Name = "pickup";
            this.pickup.Size = new System.Drawing.Size(300, 31);
            this.pickup.TabIndex = 17;
            // 
            // dropoff
            // 
            this.dropoff.Location = new System.Drawing.Point(399, 418);
            this.dropoff.Name = "dropoff";
            this.dropoff.Size = new System.Drawing.Size(300, 31);
            this.dropoff.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(111, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Pick-Up Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(111, 423);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Drop-Off Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(111, 634);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "Add-Ons:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // addOnsCheckedBox
            // 
            this.addOnsCheckedBox.FormattingEnabled = true;
            this.addOnsCheckedBox.Items.AddRange(new object[] {
            "Gas Emission Offset - $10/Day",
            "GPS - $15/Day",
            "Additional Driver - $13/Day",
            "Satellite Radio - $8/Day",
            "Roadside Assistance - $8/Day"});
            this.addOnsCheckedBox.Location = new System.Drawing.Point(399, 634);
            this.addOnsCheckedBox.Name = "addOnsCheckedBox";
            this.addOnsCheckedBox.Size = new System.Drawing.Size(341, 160);
            this.addOnsCheckedBox.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(764, 979);
            this.Controls.Add(this.addOnsCheckedBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dropoff);
            this.Controls.Add(this.pickup);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.vehicleComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ageComboBox);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.email);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Name = "Form1";
            this.Text = "KG Rentals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.ComboBox ageComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox vehicleComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker pickup;
        private System.Windows.Forms.DateTimePicker dropoff;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckedListBox addOnsCheckedBox;
    }
}

