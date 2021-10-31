using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuHelper : MonoBehaviour
{
    public Text PointText;
    public int Zero=0;
    public string TextPointScore;
    private void Start()
    {
       
            TextPointScore = PlayerPrefs.GetString("Score");
           
        
        
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.SetString("Score", TextPointScore);
    }
    void Update()
    {
        TextPointScore = (Setting.points * 2 - (AllTime.TimeScale / 11)).ToString("F0");
        PointText.text = TextPointScore;
        if ((Setting.points * 2 - (AllTime.TimeScale / 11)<0))
        {
            PointText.text = Zero.ToString("F0");
        }
        PlayerPrefs.SetString("Score", TextPointScore);

    }
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }
}
