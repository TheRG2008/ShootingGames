using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class VragMove : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _pointPosition;
    
    private NavMeshAgent _navMeshAgent;

    private void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Start()
    {
        _navMeshAgent.SetDestination(_pointPosition.position);
    }



}
