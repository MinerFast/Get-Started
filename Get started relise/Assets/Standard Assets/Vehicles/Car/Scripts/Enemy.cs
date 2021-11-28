using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Enemy : MonoBehaviour
{
    private GameObject player;
    protected NavMeshAgent enemyMesh;
    public WheelCollider[] wColForward;
    public WheelCollider[] wColBack;
    public GameObject[] wheel;
    private bool onCollision = false;
    void Start()
    {
        enemyMesh = GetComponent<NavMeshAgent>();
        enemyMesh.enabled = false;
    }

    void LateUpdate()
    {
        player = GameObject.FindGameObjectWithTag("Target");
        EnemyMove();
    }
    void EnemyMove()
    {

        if (transform.hasChanged)
        {
            if (onCollision == false)
            {
                foreach (GameObject wheel in wheel)
                {
                    wheel.transform.Rotate(new Vector3(360, 0, 0) * Time.deltaTime);

                }
            }
        }
                       
        
    }
    Vector3 PlayerPos()
    {
        if (onCollision == true)
        {
            return new Vector3(0, 0, 0);
        }
        else
        {
            return new Vector3(player.transform.position.x, 6.3f, player.transform.position.z);
        }
        
    }
    private void FixedUpdate()
    {
        Collider[] colider = Physics.OverlapSphere(transform.position, 60);
        foreach (var item in colider)
        {
            if (item.CompareTag("Car"))
            {
                player = item.gameObject;
                enemyMesh.enabled = true;
                enemyMesh.SetDestination(PlayerPos());
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        Destroy(gameObject.GetComponent<NavMeshAgent>());
        onCollision = true;
        
    }


}
