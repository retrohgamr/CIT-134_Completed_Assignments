//      retohGamr
//      12/6/21
//      Final Project CIT 134

using UnityEngine;

public class BalloonGenerator : MonoBehaviour
{
    private GameObject balloon;
    private GameObject trebuchet;
    private Vector3[] balloonStore;
    public int balloonCount;
    private int randomBalloonCordinateY;
    private int randomBalloonCordinateZ;
    private int SaveGame;
    private int randomBalloonCordinateYmin;
    private int randomBalloonCordinateYmax;
    private int randomBalloonCordinateZmin;
    private int randomBalloonCordinateZmax;

    // Start is called before the first frame update
    private void Start()
    {
        balloon = GameObject.Find("Balloon");

        SaveGame = PlayerPrefs.GetInt("CurrentSave");
        trebuchet = GameObject.Find("trebuchetGame");

        randomBalloonCordinateYmin = 100;
        randomBalloonCordinateYmax = 1200;
        randomBalloonCordinateZmin = -200;
        randomBalloonCordinateZmax = 7500;
        balloonCount = 1000;
        randomBalloonCordinateY = 0;
        randomBalloonCordinateZ = 0;

        balloonStore = new Vector3[balloonCount];

        if (PlayerPrefs.GetString($"isNewGame_{SaveGame}") == "true")
        {   
            //spawn balloons
            for (int i = 0; i < balloonCount; i++)
            {
                BalloonGenerateNewGame(i);
            }
        }
        else
        {   
            // load balloons
            int i = 0;
            do
            {
                BalloonGenerateFromSave(i);
                i++;
            } while (i < balloonCount);
        }
    }

    private void BalloonGenerateNewGame(int i)
    {
        randomBalloonCordinateY = Random.Range(randomBalloonCordinateYmin, randomBalloonCordinateYmax);
        randomBalloonCordinateZ = Random.Range(randomBalloonCordinateZmin, randomBalloonCordinateZmax);
        balloonStore.SetValue(new Vector3(trebuchet.transform.position.x, randomBalloonCordinateY, randomBalloonCordinateZ), i);

        PlayerPrefs.SetFloat($"balloon{i}_Y_{SaveGame}", balloonStore[i].y);
        PlayerPrefs.SetFloat($"balloon{i}_Z_{SaveGame}", balloonStore[i].z);
        PlayerPrefs.SetString($"BalloonIndexPopped{i}_{SaveGame}", "false");

        balloon.transform.position = new Vector3(balloonStore[i].x, balloonStore[i].y, balloonStore[i].z);

        var thisBalloon = GameObject.Instantiate(balloon);

        thisBalloon.GetComponent<BalloonController>().Index = i;

        if (i == 0)
        {
            PlayerPrefs.SetString($"isNewGame_{SaveGame}", "false");
        }
        PlayerPrefs.Save();
    }

    private void BalloonGenerateFromSave(int i)
    {
        if (PlayerPrefs.GetString($"BalloonIndexPopped{i}_{SaveGame}") != "true")
        {
            balloon.transform.position = new Vector3(trebuchet.transform.position.x, PlayerPrefs.GetFloat($"balloon{i}_Y_{SaveGame}"), PlayerPrefs.GetFloat($"balloon{i}_Z_{SaveGame}"));

            var thisBalloon = GameObject.Instantiate(balloon);

            thisBalloon.GetComponent<BalloonController>().Index = i;
        }
    }
}