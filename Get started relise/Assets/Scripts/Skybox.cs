using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skybox : MonoBehaviour
{
    
    public Material SkyCartoonDay; //1
    public LightingSettings one;
    public Material SkyCartoonNigth; //1
    public Material SkyColdNight; //16
    public Material SkyColdDay; //12
    public Material Skydusk; //17
    public Material SkyEpicDay; //18
    public Material SkyEpicSakuraDay; //29
    public Material SkyNightMoon; //19
    public Material SkyRainy; //5
    public Material SkySpace; //6
    

    void Start()
    {

        if (Random.value > 0.99f) //1
        {
            RenderSettings.skybox = SkyCartoonDay;
        }
        else
        if (Random.value > 0.99f) //1
        {
            RenderSettings.skybox = SkyCartoonNigth;
        }
        else
        if (Random.value > 0.95f) //5
        {
            RenderSettings.skybox = SkyRainy;
        }
        else
        if (Random.value > 0.94f) //6
        {
            RenderSettings.skybox = SkySpace;
        }
        else
        if (Random.value > 0.99f) //1
        {
            RenderSettings.skybox = SkyColdDay;
        }
        else
        if (Random.value > 0.84f) //16
        {
            RenderSettings.skybox = SkyColdNight;
        }
        else
        if (Random.value > 0.83f) //17
        {
            RenderSettings.skybox = Skydusk;
        }
        else
        if (Random.value > 0.82f) //18
        {
            RenderSettings.skybox = SkyEpicDay;
        }
        else
        if (Random.value > 0.81f) // 19
        {
            RenderSettings.skybox = SkyNightMoon;
        }
        else
        if (Random.value > 0.80f) // 20
        {
            RenderSettings.skybox = SkyEpicSakuraDay;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
