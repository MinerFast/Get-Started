using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Easteregg : MonoBehaviour
{
    public GameObject RickandMorti;
    public GameObject City;
    public int ñheck;
    private string[] Egg;
    private int index;



    void Start()
    {
        ñheck = 0;
        Egg = new string[] { "a", "c", "t", "e", "n" };
        index = 0;
    }


    void Update()
    {
        if (ñheck == 0)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetKeyDown(Egg[index]))
                {
                    index++;
                }
                else
                {
                    index = 0;
                }
            }
            if (index == Egg.Length)
            {
                Instantiate(RickandMorti);
                Destroy(City);
                ñheck = 1;
            }
        }
    }
}
