//  retrohGamr
//  11/15/21
//  Chapter 7 Excercise 8


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_Chapter_7_excercise_8
{
    public partial class TicTacToeForm : Form
    {
        const int rows = 3;
        const int cols = 3;
        int[,] boardInt = new int[rows, cols];
        string[,] boardString = new string[rows, cols];

        Random rand = new Random();

        public TicTacToeForm()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newGameBtn_Click(object sender, EventArgs e)
        {
            Game();
        }

        private void Game()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    boardInt[i, j] = rand.Next(2);
                    if (boardInt[i, j] == 0)
                    {
                        boardString[i, j] = "O";
                    }
                    else
                    {
                        boardString[i, j] = "X";
                    }
                }
            }
            newGameBoard();
            checkWinner();
        }

        private void newGameBoard()
        {
            upLeftLbl.Text    =  boardString[0, 0]; //
            upMidLbl.Text     =  boardString[0, 1];
            upRightLbl.Text   =  boardString[0, 2]; //
            leftMidLbl.Text   =  boardString[1, 0];
            midMidLbl.Text    =  boardString[1, 1]; //
            rightMidLbl.Text  =  boardString[1, 2];
            downLeftLbl.Text  =  boardString[2, 0]; //
            downMidLbl.Text   =  boardString[2, 1];
            downRightLbl.Text =  boardString[2, 2]; //
        }

        private int[] calculateScore()
        {
            int xScore = 0;
            int oScore = 0;
            for (int i = 0; i < 3; i++)
            {
                var colString = boardString[i, 0] + boardString[i, 1] + boardString[i, 2];
                var rowString = boardString[0, i] + boardString[1, i] + boardString[2, i];
                if (rowString == "XXX")
                {
                    xScore++;
                }
                else if (rowString == "OOO")
                {
                    oScore++;
                }
                if (colString == "XXX")
                {
                    xScore++;
                }
                else if (colString == "OOO")
                {
                    oScore++;
                }
            }
            //Left Up to Down Right Diag
            if (upLeftLbl.Text + midMidLbl.Text + downRightLbl == "XXX")
            {
                xScore++;
            }
            if (upLeftLbl.Text + midMidLbl.Text + downRightLbl == "OOO")
            {
                oScore++;
            }
            //Right Up to Down Left Diag
            if (upRightLbl.Text + midMidLbl.Text + downLeftLbl == "XXX")
            {
                xScore++;
            }
            if (upLeftLbl.Text + midMidLbl.Text + downRightLbl == "OOO")
            {
                oScore++;
            }

            var score = new []{ xScore, oScore };
            return score;
        }

        private void checkWinner()
        {
            int[] score = calculateScore(); 
            
            //check scores and display winner
            if (score[0] == score[1])
            {
                textBox.Text = "Tie Game.";
            }
            else if (score[0] < score[1])
            {
                textBox.Text = "O Wins!";
            }
            else 
            {
                textBox.Text = "X Wins!";
            }
        }
    }
}