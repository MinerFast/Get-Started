using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Easteregg : MonoBehaviour
{
    public GameObject RickandMorti;
    public GameObject City;
    public int �heck;
    private string[] Egg;
    private int index;



    void Start()
    {
        �heck = 0;
        Egg = new string[] { "a", "c", "t", "e", "n" };
        index = 0;
    }


    void Update()
    {
        if (�heck == 0)
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
                �heck = 1;
            }
        }
    }
}
