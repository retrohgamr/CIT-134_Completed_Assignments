//  retrohGamr
//  10/11/2021
//  Chapter 5 Exercise 1



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_5_exercise_1
{

    public partial class Form1 : Form
    {

        //initialize random to gen random number
        Random random = new Random();

        //initialize ints for use in the game
        int randomNumber;
        int guess;
        int attempts = 0;
        int successes = 0;


        public Form1()
        {
            InitializeComponent();

            //generate the initial random number and assign to a variable named randomNumber
            randomNumber = random.Next(101);
            label4.Text = successes.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try //exception handling for non-integer input from user
            {
                //  parse input from user and assignt to variable
                guess = int.Parse(textBox1.Text);
            }
            catch{
                //display error message in the case user does not input integer
                MessageBox.Show("input an integer between 0 and 101.");
            }

            //if the random number matches the users input
            if (guess == randomNumber)
            {
                //generate a new random number for the next game
                randomNumber = random.Next(101);

                //congradulate the user
                MessageBox.Show("CONGRADULATIONS!!!!  you guessed my number :)");

                //set attempts label to empty
                label2.Text = "";

                //reset attempts int used in code
                attempts = 0;

                //add 1 success to success counter variable
                successes++;

                //update number of successes in user GUI
                label4.Text = successes.ToString();
            }
            else
            {
                //in the case the user  input does not match the random number
                        //display message in textbox
                richTextBox1.Text = "try to guess my number again!";

                //  add 1 to the attempt counter
                attempts++;

                //update the attempt counter in the User GUI
                label2.Text = attempts.ToString();
            }

            
        }




        //THIS IS A BUTTTON TO CHEAT IN THE GAME.
        //THIS WAS ADDED FOR THE INSTRUCTURES USE
        private void button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show(randomNumber.ToString());
        }
    }
}
