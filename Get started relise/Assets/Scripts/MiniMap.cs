using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMap : MonoBehaviour
{
     Transform Player;
    Vector3 PlayerVector;
  
    private void Start()
    {
         Player = GameObject.FindGameObjectWithTag("Car").transform;
       
    }
    void LateUpdate()
    {
        UpdateCamerPos();
    }
     void UpdateCamerPos()
    {
        Vector3 newPos = Player.position;
        newPos.y = transform.position.y;
        transform.position = newPos;
        transform.rotation = Quaternion.Euler(90, Player.eulerAngles.y, 0);
    }
}
