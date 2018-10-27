using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalCompany
{
    public partial class RentalSubmissionForm : Form
    {
        string firstname, lastname, emailaddr, phonenum, age, vehicalType;
        DateTime pickuptime, dropofftime;
        bool gasEmis, gps, addDriver, satRadio, roadAssist; 
        public RentalSubmissionForm()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            hideAllForm();
        }

        public void hideAllForm()
        {
            firstNameTextBox.Hide();
            lastNameTextBox.Hide();
            ageComboBox.Hide();
            emailTextBox.Hide();
            phoneNumberTextBox.Hide();
            pickupDatePicker.Hide();
            dropoffDatePicker.Hide();
            vehicleComboBox.Hide();
            addOnsCheckedListBox.Hide();
            submitButton.Hide();
        }
    }
}
