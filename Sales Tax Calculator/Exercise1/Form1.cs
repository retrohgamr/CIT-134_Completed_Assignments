//      retrohGamr
//      9/20/21
//      Chapter 3 Excercise 1
//    Create a Windows Form application that 
//    allows the user to enter the amount 
//    of a purchase. The program should then
//    calculate the state and county sales
//    tax.
//
//    Assume the state sales tax is 3.75
//    percent and the county sales tax is 2.25
//    percent.
//
//    The program should display:
//    [X]  entry box for user information
//    [X]  the amount of the purchase
//    [X]  the state sales tax
//    [X]  the county sales tax
//    [X]  the total sales tax
//    [X]  the total of the sale
//          (which is the sum of the amount of purchase plus the
//          total sales tax). Use the decimal type for
//          the variables.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1
{
    public partial class Form1 : Form
    {
        decimal saleInpt;
        decimal stateTax = 0.0375m;
        decimal countyTax = 0.0225m;
        decimal totalTax = 0m;
        decimal totalSale = 0m;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //catch exceptions for non-decimal inputs
            try
            {
                //take input from user and display cart total
                saleInpt = decimal.Parse(textBox1.Text);
                textBox2.Text = saleInpt.ToString("c");
                //calculate and display state sales tax
                stateTax = saleInpt * 0.0375m;
                textBox3.Text = stateTax.ToString("c");
                //calculate and display county sales tax
                countyTax = saleInpt * 0.0225m;
                textBox4.Text = countyTax.ToString("c");
                //calculate and display total sales tax
                totalTax = countyTax + stateTax;
                textBox5.Text = totalTax.ToString("c");
                //calculate and display the sale total
                totalSale = saleInpt + stateTax + countyTax;
                textBox6.Text = totalSale.ToString("c");

            }
            catch(Exception ex)
            { 
                MessageBox.Show("ERROR:  " + ex.Message);
                textBox1.Text = "";
            }
        }
    }
}
