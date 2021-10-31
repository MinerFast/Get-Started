using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameHelper : MonoBehaviour
{
    public Text TimeText;
    const float Distanse = 40;
    const int PointCount = 10;
    public GameObject[] MisiionPoints;
    int CurrentIndex;
    int CurrentPoint;
    public Transform StartPosition;
    public GameObject RacePrefab;
    GameObject _playerCar;
    GameObject _Car;
    float lasttime;
    void Start()
    {
        _playerCar = Instantiate(RacePrefab) as GameObject;
        _playerCar.transform.SetParent(StartPosition, false);
        _playerCar.transform.position = new Vector3(62f, 1f, 184f);
        _playerCar.transform.rotation = Quaternion.identity;
        _playerCar.GetComponentInChildren<ChangeColor>().LoadCar(Setting.PlayerCar);
        _Car = _playerCar.GetComponentInChildren<ChangeColor>().gameObject;
        foreach (var item in MisiionPoints)
            item.SetActive(false);
        MisiionPoints[0].SetActive(true);
        lasttime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Vector3.Distance(_Car.transform.position, MisiionPoints[CurrentIndex].transform.position) < Distanse)
        {
            CurrentPoint += PointCount;
            MisiionPoints[CurrentIndex].SetActive(false);
            CurrentIndex++;
            TimeText.text = (Time.time - lasttime).ToString("F2");
            
            if (CurrentIndex >= MisiionPoints.Length)
            {
                Setting.points += CurrentPoint;
                SceneManager.LoadScene("Score");
            }
            else
            {
                MisiionPoints[CurrentIndex].SetActive(true);
            }
            lasttime = Time.time;


        }
    }
}
