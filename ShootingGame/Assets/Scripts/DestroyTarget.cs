using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTarget : MonoBehaviour
{
    
    private float _point;
    private void Start()
    {
        Destroy(gameObject, 2);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
        _point = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>().Point += 1;
    }
  

}
