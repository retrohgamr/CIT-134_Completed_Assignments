//    retrohGamr
//    9/20/21
//    In Class Assignment
//    Many Ifs


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace In_Class_Lab__Many_Ifs_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "9")
                {
                    label1.Text = "----.";
                }
                else if (textBox1.Text == "A")
                {
                    label1.Text = ".-";
                }
                else if (textBox1.Text == "B")
                {
                    label1.Text = "-...";
                }
                else if (textBox1.Text == "C")
                {
                    label1.Text = "-.-.";
                }
                else if (textBox1.Text == "D")
                {
                    label1.Text = "-..";
                }
                else if (textBox1.Text == "E")
                {
                    label1.Text = ".";
                }
                else if (textBox1.Text == "F")
                {
                    label1.Text = "..-.";
                }
                else if (textBox1.Text == "G")
                {
                    label1.Text = "--.";
                }
                else if (textBox1.Text == "H")
                {
                    label1.Text = "....";
                }
                else if (textBox1.Text == "I")
                {
                    label1.Text = "..";
                }
                else if (textBox1.Text == "J")
                {
                    label1.Text = ".---";
                }
                else if (textBox1.Text == "K")
                {
                    label1.Text = "-.-";
                }
                else if (textBox1.Text == "L")
                {
                    label1.Text = ".-..";
                }
                else if (textBox1.Text == "M")
                {
                    label1.Text = "--";
                }
                else if (textBox1.Text == "N")
                {
                    label1.Text = "-.";
                }
                else if (textBox1.Text == "O")
                {
                    label1.Text = "---";
                }
                else if (textBox1.Text == "P")
                {
                    label1.Text = ".--.";
                }
                else if (textBox1.Text == "Q")
                {
                    label1.Text = "--.-";
                }
                else if (textBox1.Text == "R")
                {
                    label1.Text = ".-.";
                }
                else if (textBox1.Text == "S")
                {
                    label1.Text = "...";
                }
                else if (textBox1.Text == "T")
                {
                    label1.Text = "-";
                }
                else if (textBox1.Text == "U")
                {
                    label1.Text = "..-";
                }
                else if (textBox1.Text == "V")
                {
                    label1.Text = "...-";
                }
                else if (textBox1.Text == "W")
                {
                    label1.Text = ".--";
                }
                else if (textBox1.Text == "X")
                {
                    label1.Text = "-..-";
                }
                else if (textBox1.Text == "Y")
                {
                    label1.Text = "-.--";
                }
                else if (textBox1.Text == "Z")
                {
                    label1.Text = "--..";
                }
                else if (textBox1.Text == ".-")
                {
                    label2.Text = "A";
                }
                else if (textBox1.Text == "-...")
                {
                    label2.Text = "B";
                }
                else if (textBox1.Text == "-.-.")
                {
                    label2.Text = "C";
                }
                else if (textBox1.Text == "-..")
                {
                    label2.Text = "D";
                }
                else if (textBox1.Text == ".")
                {
                    label2.Text = "E";
                }
                else if (textBox1.Text == "..-.")
                {
                    label2.Text = "F";
                }
                else if (textBox1.Text == "--.")
                {
                    label2.Text = "G";
                }
                else if (textBox1.Text == "....")
                {
                    label2.Text = "H";
                }
                else if (textBox1.Text == "..")
                {
                    label2.Text = "I";
                }
                else if (textBox1.Text == ".---")
                {
                    label2.Text = "J";
                }
                else if (textBox1.Text == "-.-")
                {
                    label2.Text = "K";
                }
                else if (textBox1.Text == ".-..")
                {
                    label2.Text = "L";
                }
                else if (textBox1.Text == "--")
                {
                    label2.Text = "M";
                }
                else if (textBox1.Text == "-.")
                {
                    label2.Text = "N";
                }
                else if (textBox1.Text == "---")
                {
                    label2.Text = "O";
                }
                else if (textBox1.Text == ".--.")
                {
                    label2.Text = "P";
                }
                else if (textBox1.Text == "--.-")
                {
                    label2.Text = "Q";
                }
                else if (textBox1.Text == ".-.")
                {
                    label2.Text = "R";
                }
                else if (textBox1.Text == "...")
                {
                    label2.Text = "S";
                }
                else if (textBox1.Text == "-")
                {
                    label2.Text = "T";
                }
                else if (textBox1.Text == "..-")
                {
                    label2.Text = "U";
                }
                else if (textBox1.Text == "...-")
                {
                    label2.Text = "V";
                }
                else if (textBox1.Text == ".--")
                {
                    label2.Text = "W";
                }
                else if (textBox1.Text == "-..-")
                {
                    label2.Text = "X";
                }
                else if (textBox1.Text == "-.--")
                {
                    label2.Text = "Y";
                }
                else if (textBox1.Text == "--..")
                {
                    label2.Text = "Z";
                }
                else if (textBox1.Text == ".----")
                {
                    label2.Text = "1";
                }
                else if (textBox1.Text == "..---")
                {
                    label2.Text = "2";
                }
                else if (textBox1.Text == "...--")
                {
                    label2.Text = "3";
                }
                else if (textBox1.Text == "....-")
                {
                    label2.Text = "4";
                }
                else if (textBox1.Text == ".....")
                {
                    label2.Text = "5";
                }
                else if (textBox1.Text == "-....")
                {
                    label2.Text = "6";
                }
                else if (textBox1.Text == "--...")
                {
                    label2.Text = "7";
                }
                else if (textBox1.Text == "---..")
                {
                    label2.Text = "8";
                }
                else if (textBox1.Text == "----.")
                {
                    label2.Text = "9";
                }
                else if (textBox1.Text == "-----")
                {
                    label2.Text = "0";
                }
                else if (textBox1.Text == "1")
                {
                    label1.Text = ".----";
                }
                else if (textBox1.Text == "2")
                {
                    label1.Text = "..---";
                }
                else if (textBox1.Text == "3")
                {
                    label1.Text = "...--";
                }
                else if (textBox1.Text == "4")
                {
                    label1.Text = "....-";
                }
                else if (textBox1.Text == "5")
                {
                    label1.Text = ".....";
                }
                else if (textBox1.Text == "6")
                {
                    label1.Text = "-....";
                }
                else if (textBox1.Text == "7")
                {
                    label1.Text = "--...";
                }
                else if (textBox1.Text == "8")
                {
                    label1.Text = "---..";
                }
                else if (textBox1.Text == "0")
                {
                    label1.Text = "-----";
                } else
                {
                    MessageBox.Show("Please Input morse code for a single letter or number or a single letter or number A-Z, 0-9.  Capital Letters Only!");
                }
            }
            catch
            { 
            MessageBox.Show("Please Input morse code for a single letter or number or a single letter or number A-Z, 0-9.  Capital Letters Only!");

            }
        }
    }
}
