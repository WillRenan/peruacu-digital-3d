using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PAUSA : MonoBehaviour

{
    public Transform pauseMenu;
    public Transform cameraPosed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) {
            if (pauseMenu.gameObject.activeSelf)
            {
                pauseMenu.gameObject.SetActive(false);
                Cursor.visible = false;
                Time.timeScale = 1;
                
                
                //Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                pauseMenu.gameObject.SetActive(true);
                Cursor.visible = true;
                Time.timeScale = 0;
            }
           
        } 
                    
    }
    public void LoadCena(int indexCena)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(indexCena);
    }
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("SAIU");
    }
}
