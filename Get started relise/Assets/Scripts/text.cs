using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text : MonoBehaviour
{
    public Slider r;
    public Slider g;
    public Slider b;
    public float First;
    public float Two;
    public float Three;
    public GameObject Cube;
    void Start()
    {
      

    }

    // Update is called once per frame
    void Update()
    {
        First = r.value;
        Two = g.value;
        Three = b.value;
        Color newColor = new Color(First,Two,Three,255);
        Cube.GetComponent<Renderer>().material.color =  newColor;

    }
}
