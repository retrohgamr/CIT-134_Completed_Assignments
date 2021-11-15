//  retrohGamr
//  10/4/21
//  Chapter 4 Excercise 12
//
//          Create an application that:
//
//      [X]      lets the user select a workshop from one listbox
//
//      [X]      a location from the other lisbox.
//
//      [X]      When the user clicks a button, the applciation
//              should calculate and display the registration cost,
//              the lodging cost and the total cost.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_4_Textbook_Excercise_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //initilize variables for calculations
        int regFee;
        int lodgeFee;
        int days;
        private void button1_Click(object sender, EventArgs e)
        {
            string workSelect = listWork.SelectedItem.ToString();
            //Workshop Decision through listbox selection
            switch (workSelect)
            {
                case "Handling Stress":
                    days = 3;
                    regFee = 1000;
                    break;
                case "Time Management":
                    days = 3;
                    regFee = 800;
                    break;
                case "Supervision Skills":
                    days = 3;
                    regFee = 1500;
                    break;
                case "Negotiation":
                    days = 5;
                    regFee = 1300;
                    break;
                case "How to Interview":
                    days = 1;
                    regFee = 500;
                    break;
                default:
                    break;
            }
            string locationSelect = listLocation.SelectedItem.ToString();
            //Location Decision through listbox decision
            switch (locationSelect)
            {
                case "Austin":
                    lodgeFee = 150;
                    break;
                case "Chicago":
                    lodgeFee = 225;
                    break;
                case "Dallas":
                    lodgeFee = 175;
                    break;
                case "Orlando":
                    lodgeFee = 300;
                    break;
                case "Phoenix":
                    lodgeFee = 175;
                    break;
                case "Raleigh":
                    lodgeFee = 150;
                    break;
                default:
                    break;
            }
            //calculate cost totals and display
            textBox1.Text = (regFee).ToString("C");
            textBox2.Text = (lodgeFee * days).ToString("C");
            textBox3.Text = (regFee + (lodgeFee * days)).ToString("C");
        }

    }
}