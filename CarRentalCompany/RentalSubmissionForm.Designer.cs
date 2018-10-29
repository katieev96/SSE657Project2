namespace CarRentalCompany
{
    partial class RentalSubmissionForm
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
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.rentalsHeader = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.ageComboBox = new System.Windows.Forms.ComboBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.vehicleComboBox = new System.Windows.Forms.ComboBox();
            this.vehicleLabel = new System.Windows.Forms.Label();
            this.pickupDatePicker = new System.Windows.Forms.DateTimePicker();
            this.dropoffDatePicker = new System.Windows.Forms.DateTimePicker();
            this.pickupLabel = new System.Windows.Forms.Label();
            this.dropoffLabel = new System.Windows.Forms.Label();
            this.addonLabel = new System.Windows.Forms.Label();
            this.addOnsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(532, 140);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(265, 38);
            this.firstNameTextBox.TabIndex = 0;
            this.firstNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_KeyPress);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(532, 206);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(265, 38);
            this.lastNameTextBox.TabIndex = 1;
            this.lastNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_KeyPress);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(532, 277);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(265, 38);
            this.emailTextBox.TabIndex = 2;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(532, 353);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.phoneNumberTextBox.MaxLength = 10;
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(265, 38);
            this.phoneNumberTextBox.TabIndex = 3;
            this.phoneNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_KeyPress);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(148, 148);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(160, 32);
            this.firstNameLabel.TabIndex = 5;
            this.firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(148, 213);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(159, 32);
            this.lastNameLabel.TabIndex = 6;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(148, 284);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(95, 32);
            this.emailLabel.TabIndex = 7;
            this.emailLabel.Text = "Email:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(148, 361);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(213, 32);
            this.phoneLabel.TabIndex = 8;
            this.phoneLabel.Text = "Phone Number:";
            // 
            // rentalsHeader
            // 
            this.rentalsHeader.AutoSize = true;
            this.rentalsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalsHeader.Location = new System.Drawing.Point(208, 11);
            this.rentalsHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rentalsHeader.Name = "rentalsHeader";
            this.rentalsHeader.Size = new System.Drawing.Size(554, 85);
            this.rentalsHeader.TabIndex = 9;
            this.rentalsHeader.Text = "KG Car Rentals";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(388, 992);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(169, 53);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.Submit_Click);
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
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(148, 688);
            this.ageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(74, 32);
            this.ageLabel.TabIndex = 14;
            this.ageLabel.Text = "Age:";
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
            // 
            // vehicleLabel
            // 
            this.vehicleLabel.AutoSize = true;
            this.vehicleLabel.Location = new System.Drawing.Point(148, 609);
            this.vehicleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vehicleLabel.Name = "vehicleLabel";
            this.vehicleLabel.Size = new System.Drawing.Size(188, 32);
            this.vehicleLabel.TabIndex = 16;
            this.vehicleLabel.Text = "Vehicle Type:";
            // 
            // pickupDatePicker
            // 
            this.pickupDatePicker.Location = new System.Drawing.Point(532, 441);
            this.pickupDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.pickupDatePicker.Name = "pickupDatePicker";
            this.pickupDatePicker.Size = new System.Drawing.Size(399, 38);
            this.pickupDatePicker.TabIndex = 17;
            // 
            // dropoffDatePicker
            // 
            this.dropoffDatePicker.Location = new System.Drawing.Point(532, 518);
            this.dropoffDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dropoffDatePicker.Name = "dropoffDatePicker";
            this.dropoffDatePicker.Size = new System.Drawing.Size(399, 38);
            this.dropoffDatePicker.TabIndex = 18;
            // 
            // pickupLabel
            // 
            this.pickupLabel.AutoSize = true;
            this.pickupLabel.Location = new System.Drawing.Point(148, 448);
            this.pickupLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pickupLabel.Name = "pickupLabel";
            this.pickupLabel.Size = new System.Drawing.Size(189, 32);
            this.pickupLabel.TabIndex = 19;
            this.pickupLabel.Text = "Pick-Up Date:";
            // 
            // dropoffLabel
            // 
            this.dropoffLabel.AutoSize = true;
            this.dropoffLabel.Location = new System.Drawing.Point(148, 525);
            this.dropoffLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dropoffLabel.Name = "dropoffLabel";
            this.dropoffLabel.Size = new System.Drawing.Size(198, 32);
            this.dropoffLabel.TabIndex = 20;
            this.dropoffLabel.Text = "Drop-Off Date:";
            // 
            // addonLabel
            // 
            this.addonLabel.AutoSize = true;
            this.addonLabel.Location = new System.Drawing.Point(148, 786);
            this.addonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addonLabel.Name = "addonLabel";
            this.addonLabel.Size = new System.Drawing.Size(135, 32);
            this.addonLabel.TabIndex = 22;
            this.addonLabel.Text = "Add-Ons:";
            // 
            // addOnsCheckedListBox
            // 
            this.addOnsCheckedListBox.FormattingEnabled = true;
            this.addOnsCheckedListBox.Items.AddRange(new object[] {
            "Gas Emission Offset - $10/Day",
            "GPS - $15/Day",
            "Additional Driver - $13/Day",
            "Satellite Radio - $8/Day",
            "Roadside Assistance - $8/Day"});
            this.addOnsCheckedListBox.Location = new System.Drawing.Point(532, 786);
            this.addOnsCheckedListBox.Margin = new System.Windows.Forms.Padding(4);
            this.addOnsCheckedListBox.Name = "addOnsCheckedListBox";
            this.addOnsCheckedListBox.Size = new System.Drawing.Size(453, 169);
            this.addOnsCheckedListBox.TabIndex = 25;
            // 
            // RentalSubmissionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1019, 1214);
            this.Controls.Add(this.addOnsCheckedListBox);
            this.Controls.Add(this.addonLabel);
            this.Controls.Add(this.dropoffLabel);
            this.Controls.Add(this.pickupLabel);
            this.Controls.Add(this.dropoffDatePicker);
            this.Controls.Add(this.pickupDatePicker);
            this.Controls.Add(this.vehicleLabel);
            this.Controls.Add(this.vehicleComboBox);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.ageComboBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.rentalsHeader);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1050, 1250);
            this.Name = "RentalSubmissionForm";
            this.Text = "KG Rentals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label rentalsHeader;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.ComboBox ageComboBox;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.ComboBox vehicleComboBox;
        private System.Windows.Forms.Label vehicleLabel;
        private System.Windows.Forms.DateTimePicker pickupDatePicker;
        private System.Windows.Forms.DateTimePicker dropoffDatePicker;
        private System.Windows.Forms.Label pickupLabel;
        private System.Windows.Forms.Label dropoffLabel;
        private System.Windows.Forms.Label addonLabel;
        private System.Windows.Forms.CheckedListBox addOnsCheckedListBox;
    }
}

