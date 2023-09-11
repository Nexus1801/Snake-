using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splashscreen : MonoBehaviour
{
  void Start() {
    StartCoroutine(ToMainMenu());
  }

  IEnumerator ToMainMenu() {
    yield return new WaitForSeconds(2);
    SceneManager.LoadScene("MainMenu");
  }

}
