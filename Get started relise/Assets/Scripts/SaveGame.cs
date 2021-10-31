using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveGame : MonoBehaviour
{
    public void Start()
    {
        AudioListener.volume = PlayerPrefs.GetFloat("volume");
     //   AudioListener.volume = SettingHelper.VolumeSlider;
    }
    public void Update()
    {
        
    }
}
