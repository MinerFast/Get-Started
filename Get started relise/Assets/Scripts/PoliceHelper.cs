using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class PoliceHelper : MonoBehaviour
{
    public float Radius = 200;
    GameObject Target;
    CarAIControl _CarController;
    public WheelCollider[] WColForward;
    public WheelCollider[] WColBack;
    void Start()
    {
        _CarController = GetComponent<CarAIControl>();
    }

    private void FixedUpdate()
    {
        if (Target)
            return;


        Collider[] colider = Physics.OverlapSphere(transform.position, Radius);
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
