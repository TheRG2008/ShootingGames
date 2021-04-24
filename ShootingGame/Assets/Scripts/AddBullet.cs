using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddBullet : MonoBehaviour
{
   
    private int _bulletCount;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            _bulletCount = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>().CountBullet += 30;
        }
        
    }
}
