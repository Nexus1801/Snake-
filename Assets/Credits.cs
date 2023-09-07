using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public void returnToIntro()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void returnToGame()
    {
        SceneManager.LoadScene("snake");
    }


}

