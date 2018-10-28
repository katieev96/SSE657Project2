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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void vehicleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            hideAllForm();
            popUp();

            
        }

        public void hideAllForm()
        {
            firstName.Enabled = false;
            lastName.Enabled = false;
            ageComboBox.Enabled = false;
            email.Enabled = false;
            phoneNumber.Enabled = false;
            pickup.Enabled = false;
            dropoff.Enabled = false;
            vehicleComboBox.Enabled = false;
            addOnsCheckedBox.Enabled = false;
            submit.Enabled = false;
        }

        public void popUp()
        {
            string message = "";
            message += ("USER INFORMATION" + "\r\n");
            message += (lastName.Text + ", " + firstName.Text + "\t" + ageComboBox.Text.ToString());
            message += "\r\n";
            message += (email.Text + "\t" + phoneNumber.Text);
            message += ("\r\n" + "\r\n");
            message += ("RENTAL INFORMATION" + "\r\n");
            message += (vehicleComboBox.Text + " rental from: " + "\r\n");
            message += ("\t" + pickup.Text + " to " + dropoff.Text);
            if (addOnsCheckedBox.SelectedIndex >= 0)
            {
                message += ("\r\n" + "Add-Ons include:" + "\r\n");

                var v = addOnsCheckedBox.CheckedItems;
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
