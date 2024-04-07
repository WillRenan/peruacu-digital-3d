using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuPrincipal : MonoBehaviour
{
  public void LoadCenas(int indexScene)
    {
        SceneManager.LoadScene(indexScene);
    }
  public void ExitGame()
    {
        Application.Quit();
        Debug.Log("SAIU");
    }
    /*https://www.youtube.com/watch?v=WaOU-YzdE7w */
}
