using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalCompany
{
    public partial class RentalSubmissionForm : Form
    { 
        public RentalSubmissionForm()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            //Adds text to a file Customer.txt that will only contain this customers info

            //File.WriteAllText(@"C:\\Project2\\Customer.txt", firstNameTextBox.Text + ", "
            //    + lastNameTextBox.Text + ", " + emailTextBox.Text + ", "
            //    + phoneNumberTextBox.Text
            //    + ";" + Environment.NewLine);


            //Adds text to a file that also contains all entries from other customers

            string filename = @"Downloads\\Customer.txt";
            string items ="";
            foreach(string check in addOnsCheckedListBox.CheckedItems)
            {
                //items += check.Text;
                items += ", ";
            }
            string addCustomer = firstNameTextBox.Text + ", "
                + lastNameTextBox.Text + ", "
                + emailTextBox.Text + ", "
                + phoneNumberTextBox.Text + ","
                + pickupDatePicker.Text + ","
                + dropoffDatePicker.Text + ","
                + vehicleComboBox.Text + ","
                + ageComboBox.Text + ","
                + items
                + ";" + Environment.NewLine;
            File.AppendAllText(filename, addCustomer);
            hideAllForm();
            popUp();
        }

        public void hideAllForm()
        {
            firstNameTextBox.Enabled = false;
            lastNameTextBox.Enabled = false;
            ageComboBox.Enabled = false;
            emailTextBox.Enabled = false;
            phoneNumberTextBox.Enabled = false;
            pickupDatePicker.Enabled = false;
            dropoffDatePicker.Enabled = false;
            vehicleComboBox.Enabled = false;
            addOnsCheckedListBox.Enabled = false;
            submitButton.Enabled = false;
        }

        public void popUp()
        {
            string message = "";
            message += ("USER INFORMATION" + "\r\n");
            message += (lastNameTextBox.Text + ", " + firstNameTextBox.Text + "\t" + ageComboBox.Text.ToString());
            message += "\r\n";
            message += (emailTextBox.Text + "\t" + phoneNumberTextBox.Text);
            message += ("\r\n" + "\r\n");
            message += ("RENTAL INFORMATION" + "\r\n");
            message += (vehicleComboBox.Text + " rental from: " + "\r\n");
            message += ("\t" + pickupDatePicker.Text + " to " + dropoffDatePicker.Text);
            if (addOnsCheckedListBox.SelectedIndex >= 0)
            {
                message += ("\r\n" + "Add-Ons include:" + "\r\n");

                var v = addOnsCheckedListBox.CheckedItems;
                for (int i = 0; i < v.Count; i++)
                {
                    message += ("\t" + v[i] + "\r\n");
                }
            }


            MessageBox.Show(message, "Review Rental Information");
        }

        private void Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
