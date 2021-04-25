using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GreenEnemyMove : MonoBehaviour
{
    private Transform _point;
    private NavMeshAgent _navMeshAgent;


    private void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }
    void Start()
    {
        _point = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().transform;

    }




    private void Update()
    {
        _navMeshAgent.SetDestination(_point.position);
    }
}
