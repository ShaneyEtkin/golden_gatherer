using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
 
    public Button newGameButton;

    public Button loadButton;

    public Button exitGameButton;

    public string newGameSceneName;

    public GameObject loadGameMenu;

    public void NewGame()
    {
        SceneManager.LoadScene(newGameSceneName);
    }

    public void OpenLoadGameMenu()
    {
        loadGameMenu.SetActive(true);
    }

    public void ExitGame()
    {

    }
}
