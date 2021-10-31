using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    public GameObject[] CarParts;
    public GameObject[] CarSpoilers;
    public GameObject Prefab;
    public Slider RSlider;
    public Slider GSlider;
    public Slider BSlider;
    public float R;
    public float G;
    public float B;


    CarModel _carmodel = new CarModel();
    private Color newColor;

    void Start()
    {
        RSlider.value = PlayerPrefs.GetFloat("R");
        BSlider.value = PlayerPrefs.GetFloat("B");
        GSlider.value = PlayerPrefs.GetFloat("G");
    }

  
     public void Update()
    {

        R = RSlider.value;
        G = GSlider.value;
        B = BSlider.value;
      

        newColor = new Color(R, G, B, 255);

        PlayerPrefs.SetFloat("R", R);
        PlayerPrefs.SetFloat("B", B);
        PlayerPrefs.SetFloat("G", G);
        PlayerPrefs.Save();

        foreach (var item in CarParts)
        {
          item.GetComponent<MeshRenderer>().material.color = newColor;
        }
        _carmodel.Color = newColor;
    }

    public void LoadCar(CarModel model)
    {
        if (model == null)
            return;
        ChangeColorParts(model.Color);
        ChangeSloilersParts(model.Spoils);
    }
    public void SaveCar()
    {
        Setting.PlayerCar = _carmodel;

    }    
    public void ChangeSloilersParts(int SloilerId)
    {
        foreach (var item in CarSpoilers)
            item.SetActive(false);
        CarSpoilers[SloilerId].SetActive(true);
        _carmodel.Spoils = SloilerId;
        
        SaveCar();
    }
    public void ChangeColorParts(Color targetColor)
    {
       
        
            
        foreach (var item in CarParts)
        {
            item.GetComponent<MeshRenderer>().material.color = targetColor;
        }
        _carmodel.Color = targetColor; 
       


    }
    public void ApplyColor()
    {
        R = RSlider.value;
        G = GSlider.value;
        B = BSlider.value;


        newColor = new Color(R, G, B, 255);
        _carmodel.Color = newColor;

        SaveCar();

    }
}
