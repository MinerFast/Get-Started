using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingHelper : MonoBehaviour
{
    public Slider Volume;
    public static float VolumeSlider;
    public Toggle Hight;
    public Toggle Midle;
    public Toggle Low;
    void Start()
    {
       

        if (!PlayerPrefs.HasKey("value"))
        {
            VolumeSlider =  PlayerPrefs.GetFloat("volume");
            Volume.value = VolumeSlider;
        }
        
    }

   
    void Update()
    {
       
    }
    public void ChangeVolume()
    {
        VolumeSlider = Volume.value;
        AudioListener.volume = VolumeSlider;
        PlayerPrefs.SetFloat("volume", VolumeSlider);
        PlayerPrefs.Save();

    }


    public void Graphick()
    {
        if (Low.isOn == true)
        {
            QualitySettings.currentLevel = QualityLevel.Fastest;
        }
        if (Midle.isOn == false)
        {
            QualitySettings.currentLevel = QualityLevel.Simple;
        }
        if (Hight.isOn==false)
        {
            QualitySettings.currentLevel = QualityLevel.Fantastic;
        }
    }
}
