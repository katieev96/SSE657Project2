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
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                RentalSubmissionForm rental = new RentalSubmissionForm();
                rental.Show();
            }
            else
            {
                CashierForm cashier = new CashierForm();
                cashier.Show();
            }
            //Application.Exit();
        }
    }
}
