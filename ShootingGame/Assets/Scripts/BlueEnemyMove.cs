﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BlueEnemyMove : MonoBehaviour
{
    private Transform _player;    
    private NavMeshAgent _navMeshAgent;
    

    private void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }


    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().transform;
        
    }

    private void Update()
    {
        _navMeshAgent.SetDestination(_player.position);
    }
}