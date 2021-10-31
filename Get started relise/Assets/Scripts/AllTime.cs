using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AllTime : MonoBehaviour
{
    public static float TimeScale = 0;
    public   Text TimeText;
    void Start()
    {
        TimeScale = 0;
        TimeText.text = TimeScale.ToString();
    }

 
    void Update()
    {
        TimeScale += Time.deltaTime;
       
        TimeText.text = TimeScale.ToString("F2");
    }
}
