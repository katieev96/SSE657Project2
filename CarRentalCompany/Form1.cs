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
        string firstname, lastname, emailaddr, phonenum, age, vehicalType;
        DateTime pickuptime, dropofftime;
        bool gasEmis, gps, addDriver, satRadio, roadAssist; 
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
            
        }

        public void hideAllForm()
        {
            firstName.Hide();
            lastName.Hide();
            ageComboBox.Hide();
            email.Hide();
            phoneNumber.Hide();
            pickup.Hide();
            dropoff.Hide();
            vehicleComboBox.Hide();
            addOnsCheckedBox.Hide();
            submit.Hide();
        }
    }
}
