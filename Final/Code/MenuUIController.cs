//      retohGamr
//      12/6/21
//      Final Project CIT 134

using System;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MenuUIController : MonoBehaviour
{
    private UIDocument root;
    private VisualElement saveMenu;
    private VisualElement overWriteMenu;
    private VisualElement helpBack;
    private TextField saveGameUserInput;
    private Label highScoreLabel;
    private Button loadGameBtn;
    private Button exitBtn;
    private Button saveOneBtn;
    private Button saveTwoBtn;
    private Button saveThreeBtn;
    private Button overWriteGameBtn;
    private Button howToPlayBtn;
    readonly private int on = 1;
    readonly private int off = 0;
    private int currentSave;
    private int save1;
    private int save2;
    private int save3;
    private string saveName;
    private bool saveMenuOpen;
    private bool helpMenuOpen;
    private bool overWriteMenuOpen;

    // Start is called before the first frame update
    private void Start()
    {
        //UIElements
        root = GetComponent<UIDocument>();
        var rootVE = root.rootVisualElement;
        highScoreLabel = rootVE.Q<Label>("highScoreLabel");
        exitBtn = rootVE.Q<Button>("exitBtn");
        loadGameBtn = rootVE.Q<Button>("loadGameBtn");
        saveOneBtn = rootVE.Q<Button>("saveOneBtn");
        saveTwoBtn = rootVE.Q<Button>("saveTwoBtn");
        saveThreeBtn = rootVE.Q<Button>("saveThreeBtn");
        overWriteGameBtn = rootVE.Q<Button>("overWriteGameBtn");
        howToPlayBtn = rootVE.Q<Button>("howToPlayBtn");
        helpBack = rootVE.Q<VisualElement>("helpBack");
        saveMenu = rootVE.Q<VisualElement>("saveMenu");
        overWriteMenu = rootVE.Q<VisualElement>("overWriteUserInput");
        saveGameUserInput = rootVE.Q<TextField>("saveGameUserInput");

        //used for saving
        save1 = 0;
        save2 = 1;
        save3 = 2;

        //used for displaying menu in UI
        saveMenuOpen = true;
        helpMenuOpen = true;
        overWriteMenuOpen = true;

        //actions for clicking buttons in UI
        saveOneBtn.clicked += SaveOneBtn_Clicked;
        saveTwoBtn.clicked += SaveTwoBtn_Clicked;
        saveThreeBtn.clicked += SaveThreeBtn_Clicked;
        overWriteGameBtn.clicked += OverWriteGameBtn_Clicked;
        loadGameBtn.clicked += PlayGameBtn_Clicked;
        howToPlayBtn.clicked += HowToPlayBtn_Clicked;
        exitBtn.clicked += ExitBtn_Clicked;

        //Save Data Management
        if (PlayerPrefs.GetInt("save1toggle") == on)
            saveOneBtn.text = PlayerPrefs.GetString("Save_1");
        else
            saveOneBtn.text = "Empty";
        if (PlayerPrefs.GetInt("save2toggle") == on)
            saveTwoBtn.text = PlayerPrefs.GetString("Save_2");
        else
            saveTwoBtn.text = "Empty";
        if (PlayerPrefs.GetInt("save3toggle") == on)
            saveThreeBtn.text = PlayerPrefs.GetString("Save_3");
        else
            saveThreeBtn.text = "Empty";

        //read scoreboard.txt to display the highest score
        string path = Environment.CurrentDirectory + @"\scoreboard.txt";
        try
        {
            if (File.Exists(path))
            {
                StreamReader streamReader;
                streamReader = new StreamReader(path);
                highScoreLabel.text = "";
                highScoreLabel.text = "HighScore: " + streamReader.ReadLine();
                streamReader.Close();
            }
        }
        catch (Exception ex)
        {
            Debug.Log(ex.Message);
        }
    }

    private void SaveOneBtn_Clicked()
    {
        currentSave = save1;
        if (PlayerPrefs.GetInt("save1toggle") == off)
            overWriteMenu.style.display = DisplayStyle.Flex;
        else
            LoadGame();
    }

    private void SaveTwoBtn_Clicked()
    {
        currentSave = save2;
        if (PlayerPrefs.GetInt("save2toggle") == off)
            overWriteMenu.style.display = DisplayStyle.Flex;
        else
            LoadGame();
    }

    private void SaveThreeBtn_Clicked()
    {
        currentSave = save3;
        if (PlayerPrefs.GetInt("save3toggle") == off)
            overWriteMenu.style.display = DisplayStyle.Flex;
        else
            LoadGame();
    }

    private void OverWriteGameBtn_Clicked()
    {
        //Save Data Management
        saveName = saveGameUserInput.value;
        switch (currentSave)
        {
            case 0:
                saveOneBtn.text = saveName;
                PlayerPrefs.SetInt("save1toggle", on);
                PlayerPrefs.SetString($"isNewGame_{currentSave}", "true");
                break;

            case 1:
                saveTwoBtn.text = saveName;
                PlayerPrefs.SetInt("save2toggle", on);
                PlayerPrefs.SetString($"isNewGame_{currentSave}", "true");
                break;

            case 2:
                saveThreeBtn.text = saveName;
                PlayerPrefs.SetInt("save3toggle", on);
                PlayerPrefs.SetString($"isNewGame_{currentSave}", "true");
                break;
        }
        
        overWriteMenu.style.display = DisplayStyle.None;
        saveGameUserInput.value = "Enter Save Name";

        LoadGame();
    }

    private void HowToPlayBtn_Clicked()
    {
        //displaying menu with How To Play dbutton
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

    private void PlayGameBtn_Clicked()
    {
        //displaying menu with Load Game button
        switch (saveMenuOpen)
        {
            case true:
                saveMenu.style.display = DisplayStyle.Flex;
                saveMenuOpen = false;
                overWriteMenuOpen = false;
                break;

            default:
                saveMenu.style.display = DisplayStyle.None;
                saveMenuOpen = true;
                overWriteMenuOpen = true;
                overWriteMenu.style.display = DisplayStyle.None;
                break;
        }
    }

    private void LoadGame()
    {
        int gameScene = 1;

        //Save Data Management
        PlayerPrefs.SetString("Save_1", saveOneBtn.text);
        PlayerPrefs.SetString("Save_2", saveTwoBtn.text);
        PlayerPrefs.SetString("Save_3", saveThreeBtn.text);
        PlayerPrefs.SetInt("CurrentSave", currentSave);
        PlayerPrefs.Save();
        //Load Game
        SceneManager.LoadScene(gameScene);
    }

    public void ExitBtn_Clicked()
    {
        Application.Quit();
    }
}