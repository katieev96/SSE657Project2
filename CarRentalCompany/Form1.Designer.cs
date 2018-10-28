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
            this.firstName.Location = new System.Drawing.Point(532, 140);
            this.firstName.Margin = new System.Windows.Forms.Padding(4);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(265, 38);
            this.firstName.TabIndex = 0;
            this.firstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_KeyPress);
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(532, 206);
            this.lastName.Margin = new System.Windows.Forms.Padding(4);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(265, 38);
            this.lastName.TabIndex = 1;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(532, 277);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(265, 38);
            this.email.TabIndex = 2;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Location = new System.Drawing.Point(532, 353);
            this.phoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.phoneNumber.MaxLength = 10;
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(265, 38);
            this.phoneNumber.TabIndex = 3;
            this.phoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 213);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 284);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 361);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phone Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(208, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(554, 85);
            this.label5.TabIndex = 9;
            this.label5.Text = "KG Car Rentals";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(388, 992);
            this.submit.Margin = new System.Windows.Forms.Padding(4);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(169, 53);
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
            this.ageComboBox.Location = new System.Drawing.Point(532, 684);
            this.ageComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.ageComboBox.Name = "ageComboBox";
            this.ageComboBox.Size = new System.Drawing.Size(399, 39);
            this.ageComboBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 688);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 32);
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
            this.vehicleComboBox.Location = new System.Drawing.Point(532, 605);
            this.vehicleComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.vehicleComboBox.Name = "vehicleComboBox";
            this.vehicleComboBox.Size = new System.Drawing.Size(399, 39);
            this.vehicleComboBox.TabIndex = 15;
            this.vehicleComboBox.SelectedIndexChanged += new System.EventHandler(this.vehicleComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 609);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 32);
            this.label7.TabIndex = 16;
            this.label7.Text = "Vehicle Type:";
            // 
            // pickup
            // 
            this.pickup.Location = new System.Drawing.Point(532, 441);
            this.pickup.Margin = new System.Windows.Forms.Padding(4);
            this.pickup.Name = "pickup";
            this.pickup.Size = new System.Drawing.Size(399, 38);
            this.pickup.TabIndex = 17;
            // 
            // dropoff
            // 
            this.dropoff.Location = new System.Drawing.Point(532, 518);
            this.dropoff.Margin = new System.Windows.Forms.Padding(4);
            this.dropoff.Name = "dropoff";
            this.dropoff.Size = new System.Drawing.Size(399, 38);
            this.dropoff.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(148, 448);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 32);
            this.label8.TabIndex = 19;
            this.label8.Text = "Pick-Up Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(148, 525);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 32);
            this.label9.TabIndex = 20;
            this.label9.Text = "Drop-Off Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(148, 786);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 32);
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
            this.addOnsCheckedBox.Location = new System.Drawing.Point(532, 786);
            this.addOnsCheckedBox.Margin = new System.Windows.Forms.Padding(4);
            this.addOnsCheckedBox.Name = "addOnsCheckedBox";
            this.addOnsCheckedBox.Size = new System.Drawing.Size(453, 169);
            this.addOnsCheckedBox.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1019, 1214);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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

