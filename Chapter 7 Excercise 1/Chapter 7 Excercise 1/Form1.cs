//      Jacob Slaughter
//      11/9/21
//      Chapter 7 Excercise 1
//
//          Create a 20 question multiple choice exam that
//          
//      [X]  store the correct answers in an array
//
//      [X]  read student answers from a text file and store these answers in an array
//
//      [X]  display message if student passed exam (15/20 to pass)
//
//      [X]  display total number of correct answers, incorrect answers and display
//          the numbers of each incorrectly answered question.

using System;
using System.IO;
using System.Windows.Forms;

namespace Chapter_7_Excercise_1
{
    public partial class Form1 : Form
    {
        private bool isQuizGraded;
        string[] studentAns;
        string[] answerKey;
        public Form1()
        {
            InitializeComponent();
            isQuizGraded = false;
            //  Prepare array to import answers
            studentAns = new string[20];
            //  Set answer key
            answerKey = new string[]{
                "B", "D", "A", "A", "C", "A", "B", "A", "C", "D",
                "B", "C", "D", "A", "D", "C", "C", "B", "D", "A"
            };
        }

        //
        //  Import Button
        private void importBtn_Click(object sender, EventArgs e)
        {
            //  Request student answer document
            openFileDialog1.ShowDialog();
            listBox1.Items.Clear();
            try
            {   
                StreamReader inputFile = new StreamReader(openFileDialog1.OpenFile());
                for (int i = 0; i < studentAns.Length; i++)
                {
                    //  Read each line in student document and store to array
                    studentAns[i] = inputFile.ReadLine();
                    //  Write each line to listbox
                    listBox1.Items.Add(studentAns[i]);
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {   
                MessageBox.Show(ex.Message);
            }
        }
        //
        //  Grading Button
        private void checkAnsBtn_Click(object sender, EventArgs e)
        {
            if (!isQuizGraded && listBox1.Items.Count != 0)
            {
                int totalCorrect = 0;
                try
                {   
                    listBox1.Items.Clear();
                    for (int i = 0; i < studentAns.Length; i++)
                    {
                        string studentAnswer = studentAns[i];
                        string correctAnswer = answerKey[i];

                        //  Check each item in student answer and compare to answer key
                        if (studentAns[i].ToString() != answerKey[i].ToString())
                        {
                            studentAns[i] = $"{studentAnswer}   " +
                                $"Incorrect.  Correct answer is {correctAnswer}";
                            listBox1.Items.Add(studentAns[i]);
                        }
                        else
                        {
                            studentAns[i] = $"{studentAnswer}   " +
                                $"Correct.";
                            listBox1.Items.Add(studentAns[i]);
                            totalCorrect++;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //  Pass/Fail logic
                if (totalCorrect >= 15)
                {
                    scoreBox.Text = $"  Score:    {totalCorrect} / 20";
                    MessageBox.Show("Passed!");
                    totalCorrect = 0;
                }
                else
                {
                    scoreBox.Text = $"  Score:    {totalCorrect} / 20";
                    MessageBox.Show("Failed.");
                }
                isQuizGraded = true;
                //  End Pass/Fail logic
            }   
            //  Prevent graded quiz from being graded again
            else if (isQuizGraded)
            {
                MessageBox.Show("You must clear the current quiz before grading a new one.");
            }
            else
            {
                MessageBox.Show("You must import a quiz to grade.");
            }
        }
        //
        //  Clear Button
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            scoreBox.Text = "  Score:    __ / 20";
            isQuizGraded = false;
        }

        private void scoreBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}