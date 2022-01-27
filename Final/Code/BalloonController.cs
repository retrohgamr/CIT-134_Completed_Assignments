//      retohGamr
//      12/6/21
//      Final Project CIT 134

using UnityEngine;

public class BalloonController : MonoBehaviour
{
    public int Index
    { get; set; }
    private UIController uiController;
    public ParticleSystem boom;
    private int balloonPoints;
    private int SaveGame;
    private bool activated;

    // Start is called before the first frame update
    private void Start()
    {   
        uiController = GameObject.Find("UIDocument").GetComponent<UIController>();

        SaveGame = PlayerPrefs.GetInt("CurrentSave");

        balloonPoints = 100;

        activated = false;
    }

    //OnTriggerEnter runs when object mesh collides with this gameobject's mesh
    private void OnTriggerEnter(Collider collider)
    {
        //set boom position to this position
        boom.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 10, this.transform.position.z);
        //spawn boom
        Instantiate(boom);
        //add balloonPoints to score
        uiController.score += balloonPoints;
        uiController.totalScore += balloonPoints;
        if (uiController.totalScore > HighScoreController.SaveScore[0, SaveGame])
        {
            HighScoreController.SaveScore[0, SaveGame] = uiController.totalScore;
            PlayerPrefs.SetInt($"highScore_{SaveGame}", HighScoreController.SaveScore[0, SaveGame]);
            PlayerPrefs.Save();
        }

        //update score
        uiController.UpdateScore();
        //set true to run gameobject destruction
        activated = true;
    }

    private void FixedUpdate()
    {
        CheckPopped();
    }

    private void CheckPopped()
    {
        //when popped, manipulate balloon and destroy this gameObject
        if (activated)
        {
            PlayerPrefs.SetString($"BalloonIndexPopped{this.Index}_{SaveGame}", "true");
            PlayerPrefs.Save();

            Destroy(gameObject);
            activated = false;
        }
    }
}