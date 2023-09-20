using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void goCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void goOGBuild()
    {
        SceneManager.LoadScene("OGSnake");
    }    

    public void loadVersionNotes()
    {
        SceneManager.LoadScene("Version Notes");
    }

    public void endGame()
    {
        Application.Quit();
    }

    public void loadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
