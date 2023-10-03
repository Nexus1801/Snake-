using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void playPink()
    {
        SceneManager.LoadScene("snake");
    }

    public void playRed()
    {
        SceneManager.LoadScene("RedSnake");
    }

    public void playBlue()
    {
        SceneManager.LoadScene("BlueSnake");
    }

    public void playYellow()
    {
        SceneManager.LoadScene("YellowSnake");
    }

    public void goBack()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void selectColor()
    {
        SceneManager.LoadScene("SelectColor");
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
