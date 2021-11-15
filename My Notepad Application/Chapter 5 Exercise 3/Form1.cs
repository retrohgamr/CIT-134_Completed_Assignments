//   retrohGamr
//   10/11/2021
//   Chapter 5 excerice 3
//
//      Create a notepad application
//
//      [X]  name as title
//      
//      [X]  icon of my choosing
//      
//      fully functional with      
//          [X]  New menu option
//          [X]  Open menu option
//          [X]  Save menu option

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Chapter_5_Exercise_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void tsmiNew_Click(object sender, EventArgs e)
        {
            richTextBox.Text = "";
        }
        private void tmsiOpen_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader inputFile;
                    inputFile = File.OpenText(openFile.FileName);
                    richTextBox.Text = "";
                    while (!inputFile.EndOfStream)
                    {
                        richTextBox.Text = inputFile.ReadToEnd();
                    }
                    inputFile.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else 
            {
                MessageBox.Show("Canceled.");
            }
        }
        private void tmsiSave_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile;
            try
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    outputFile = File.CreateText(saveFile.FileName);
                    outputFile.WriteLine(richTextBox.Text);
                    outputFile.Close();
                }
                else
                {
                    MessageBox.Show("Canceled");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Saving File. " + ex.Message);
            }
        }
        private void tmsiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is my personal NotePad Application.  It can save, open and create new text files to edit.");
        }
        private void tmsiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
