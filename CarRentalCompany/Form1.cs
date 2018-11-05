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
        string file = String.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Display File
            var fD = new OpenFileDialog();
            DialogResult result = fD.ShowDialog();  //Show dialog
            if(result == DialogResult.OK)   //if user selects file
            {
                file = fD.FileName;

                textBox1.Text = file;
                textBox1.ForeColor = System.Drawing.Color.Black;
                textBox1.Enabled = true;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Hide panels when reset
            tableLayoutPanel2.Visible = false;
            //label4.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Read File Input
            var size = -1;
            string text;
            try
            {
                text = System.IO.File.ReadAllText(file);
                size = text.Length;

                label3.Text = text;

                tableLayoutPanel2.Visible = true;
                //Display User Info
                infoToText(text);

            }
            catch (Exception ex) { }

            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //label4.Visible = true;
        }

        private void infoToText(string text)
        {

        }
    }
}
