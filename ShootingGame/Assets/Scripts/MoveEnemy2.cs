using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy2 : MonoBehaviour
{
    public float speed;
    private float waitTime;
    public float startWaitTime;
    public Transform[] moveSpots;
    private int randomeSpot;
    private float _point;


    private void Start()
    {
        randomeSpot = Random.Range(0, moveSpots.Length);
        waitTime = startWaitTime;
    }

    private void Update()
    {


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

    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);      
        _point = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>().Point -= 2;
    }
}
