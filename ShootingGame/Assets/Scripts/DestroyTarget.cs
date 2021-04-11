using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTarget : MonoBehaviour
{
    
    private float _point;
    private void Start()
    {
        Destroy(gameObject, 3);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
        _point = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>().Point += 1;
    }

}
