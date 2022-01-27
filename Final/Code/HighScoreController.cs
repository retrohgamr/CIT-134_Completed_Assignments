//      retohGamr
//      12/6/21
//      Final Project CIT 134

using System;
using System.IO;
using UnityEngine;

public class HighScoreController : MonoBehaviour
{
    public static int[,] SaveScore
    { get; set; }

    private static int topScore;
    public static int[] scoreBoard; 

    public static int ScoreBoardCalculation()
    {
        scoreBoard = new int[3];
        scoreBoard[0] = PlayerPrefs.GetInt($"highScore_0");
        scoreBoard[1] = PlayerPrefs.GetInt($"highScore_1");
        scoreBoard[2] = PlayerPrefs.GetInt($"highScore_2");
        Array.Sort(scoreBoard);
        Array.Reverse(scoreBoard);
        topScore = (int)scoreBoard.GetValue(0);

        string path = Environment.CurrentDirectory + @"\scoreboard.txt";
        try
        {
            FileStream fileStream;
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            fileStream = File.Create(path);
            fileStream.Close();

            if (File.Exists(path))
            {
                StreamWriter streamWriter;
                streamWriter = new StreamWriter(path);
                streamWriter.WriteLine(topScore);
                streamWriter.Close();
            }
        }
        catch (Exception ex)
        {
            Debug.Log(ex.Message);
        }
        return topScore;
    }
}