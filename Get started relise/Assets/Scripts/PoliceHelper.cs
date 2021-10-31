using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class PoliceHelper : MonoBehaviour
{
    public float Radius = 200;
    GameObject Target;
    CarAIControl _CarController;
    void Start()
    {
        _CarController = GetComponent<CarAIControl>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Target)
            return;

       
        Collider[] colider = Physics.OverlapSphere(transform.position , Radius);
        foreach (var item in colider)
        {
            if (item.GetComponent<PlayerHelper>())
            {
                Target = item.gameObject;
                _CarController.SetTarget(Target.transform);
            }
        }
    }
}
