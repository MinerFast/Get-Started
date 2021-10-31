using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTime : MonoBehaviour
{
    public Text TimeAll;
    void Start()
    {
       TimeAll.text = AllTime.TimeScale.ToString("F0"); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
