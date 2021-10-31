using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointerControl : MonoBehaviour
{
    public Image pointImage;
    public Transform target;
    private Vector2 pointPos;
   

    // Update is called once per frame
    void Update()
    {
        pointPos = Camera.main.WorldToScreenPoint(target.position);
        pointPos.x = Mathf.Clamp(pointPos.x, 10.0f, Screen.width - 15f);
        pointPos.y = Mathf.Clamp(pointPos.y, 10.0f, Screen.width);
        pointImage.transform.position = pointPos;
    }
}
