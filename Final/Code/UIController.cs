//      retohGamr
//      12/6/21
//      Final Project CIT 134

using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class UIController : MonoBehaviour
{
    private UIDocument root;
    private GameObject rock;
    private GameObject trebuchetGame;
    public Button newThrowBtn;
    private Button menuBtn;
    private Button howToPlayBtn;
    private Button mainMenuBtn;
    private Button exitToDeskTopBtn;
    private VisualElement saveMenu;
    private VisualElement menuBack;
    private VisualElement helpBack;
    private Label scoreLabel;
    private Label distanceLabel;
    private Label farthestDistanceLabel;
    private Label totalScoreLabel;
    private float distance;
    private float distanceScaleFactor;
    public int score;
    public int totalScore;
    public int SaveGame;
    private int menu;
    private int gameScene;
    private bool menuOpen;
    private bool helpMenuOpen;

    // Start is called before the first frame update
    private void Start()
    {
        //Save Data Management
        SaveGame = PlayerPrefs.GetInt("CurrentSave");
        HighScoreController.SaveScore = new int[2, 3];
        HighScoreController.SaveScore[1, SaveGame] = PlayerPrefs.GetInt($"farthestThrow_{SaveGame}");
        HighScoreController.SaveScore[0, SaveGame] = PlayerPrefs.GetInt($"highScore_{SaveGame}");
        if (PlayerPrefs.GetString($"isNewGame_{SaveGame}") == "true")
            totalScore = 0;
        else
            totalScore = PlayerPrefs.GetInt($"totalScore_{SaveGame}");

        //UI Elements
        root = GetComponent<UIDocument>();
        var rootVE = root.rootVisualElement;
        newThrowBtn = rootVE.Q<Button>("newThrowBtn");
        menuBtn = rootVE.Q<Button>("menuBtn");
        howToPlayBtn = rootVE.Q<Button>("howToPlayBtn");
        mainMenuBtn = rootVE.Q<Button>("mainMenuBtn");
        exitToDeskTopBtn = rootVE.Q<Button>("exitToDeskTopBtn");
        scoreLabel = rootVE.Q<Label>("pointsLabel");
        totalScoreLabel = rootVE.Q<Label>("totalPointsLabel");
        farthestDistanceLabel = rootVE.Q<Label>("farthestDistanceLabel");
        distanceLabel = rootVE.Q<Label>("distanceLabel");
        menuBack = rootVE.Q<VisualElement>("menuBack");
        saveMenu = rootVE.Q<VisualElement>("saveMenu");
        helpBack = rootVE.Q<VisualElement>("helpBack");

        //rock and trebuchet set to Game Objects in scene
        rock = GameObject.Find("rock");
        trebuchetGame = GameObject.Find("trebuchetGame");

        //UI
        score = 0;
        distance = 0;
        distanceScaleFactor = 0.15f;
        helpMenuOpen = true;
        menuOpen = true;
        scoreLabel.text = score.ToString();

        //Scene Loading
        menu = 0;
        gameScene = 1;

        //actions for clicking buttons in UI
        howToPlayBtn.clicked += HowToPlayBtn_Clicked;
        menuBtn.clicked += MenuBtn_Clicked;
        newThrowBtn.clicked += NewThrowBtn_Clicked;
        mainMenuBtn.clicked += MainMenuBtn_Clicked;
        exitToDeskTopBtn.clicked += ExitToDeskTopBtn_Clicked;
    }

    private void FixedUpdate()
    {
        UpdateScore();
        DisctanceCalc();
    }

    public void UpdateScore()
    {
        scoreLabel.text = this.score.ToString();

        PlayerPrefs.SetInt($"totalScore_{SaveGame}", totalScore);
        PlayerPrefs.Save();
        totalScoreLabel.text = PlayerPrefs.GetInt($"totalScore_{SaveGame}").ToString();
    }

    private void DisctanceCalc()
    {
        distance = (rock.transform.position.z - trebuchetGame.transform.position.z) * distanceScaleFactor;
        if (!rock.GetComponent<RockController>().groundCollision)
        {
            distanceLabel.text = Convert.ToInt32(distance).ToString() + "m";
            if (distance > HighScoreController.SaveScore[1, SaveGame])
            {
                HighScoreController.SaveScore[1, SaveGame] = Convert.ToInt32(distance);
                PlayerPrefs.SetInt($"farthestThrow_{SaveGame}", HighScoreController.SaveScore[1, SaveGame]);
                PlayerPrefs.Save();
            }
            farthestDistanceLabel.text = PlayerPrefs.GetInt($"farthestThrow_{SaveGame}").ToString();
        }
    }

    private void MenuBtn_Clicked()
    {
        switch (menuOpen)
        {
            case true:
                menuBack.style.display = DisplayStyle.Flex;
                menuOpen = false;
                break;

            default:
                menuBack.style.display = DisplayStyle.None;
                helpBack.style.display = DisplayStyle.None;
                menuOpen = true;
                helpMenuOpen = true;
                break;
        }
    }

    private void NewThrowBtn_Clicked()
    {
        SceneManager.LoadScene(gameScene);
    }

    private void HowToPlayBtn_Clicked()
    {
        switch (helpMenuOpen)
        {
            case true:
                helpBack.style.display = DisplayStyle.Flex;
                helpMenuOpen = false;
                break;

            default:
                helpBack.style.display = DisplayStyle.None;
                helpMenuOpen = true;
                break;
        }
    }

    private void MainMenuBtn_Clicked()
    {
        HighScoreController.ScoreBoardCalculation();
        SceneManager.LoadScene(menu);
    }

    private void ExitToDeskTopBtn_Clicked()
    {
        HighScoreController.ScoreBoardCalculation();
        Application.Quit();
    }
}