﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    public float speed;
    private float waitTime;
    public float startWaitTime;
    public Transform[] moveSpots;
    private int randomeSpot;


    private void Start()
    {
        randomeSpot = Random.Range(0, moveSpots.Length);
        waitTime = startWaitTime;
    }

    private void Update()
    {
        //for (int i = 0; i < moveSpots.Length; i++)
        //{
        //    transform.position = Vector3.MoveTowards(transform.position, moveSpots[i].position, speed * Time.deltaTime);
        //}



        transform.position = Vector3.MoveTowards(transform.position, moveSpots[randomeSpot].position, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, moveSpots[randomeSpot].position) < 0.2f)
        {
            if (waitTime <= 0)
            {
                randomeSpot = Random.Range(0, moveSpots.Length);
                waitTime = startWaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
    }
}
