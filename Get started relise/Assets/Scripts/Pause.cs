using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public static bool GameIsPause = false;
    public GameObject MenuUI;
    public GameObject MiniUp;
    public GameObject MenuUISetting;
    

   
    void Update()
    {
     if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPause)
            {
                Cursor.visible = false;
                Resume();
                MenuUISetting.SetActive(false);
                MiniUp.SetActive(true);

               

            }
            else
            {
                Cursor.visible = false;

                PauseGame();
                MiniUp.SetActive(false);
                //MenuUISetting.SetActive(false);
            }
        } 
            
    }
    public void Resume()
    {
        Cursor.visible = false;

        MenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPause = false;
        AudioListener.pause = false;
        Cursor.visible = false;
    }
    void PauseGame()
    {
        Cursor.visible = true;
        
        MenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;
        AudioListener.pause = true;
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
        AudioListener.pause = false;
    }
    public void Quik()
    {
        Application.Quit ();
    }
    public void Setting()
    {
        Cursor.visible = true;
        MenuUI.SetActive(false);
        MenuUISetting.SetActive(true);
    }
}
