using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splashscreen2 : MonoBehaviour
{
  void Start() {
    StartCoroutine(ToMainMenu());
  }

  IEnumerator ToMainMenu() {
    yield return new WaitForSeconds(3);
    SceneManager.LoadScene("MainMenu");
  }

}