using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armo : MonoBehaviour
{
    
    [SerializeField] private GameObject _patrons;

    
    void Update()
    {
        transform.Rotate(0, 0, 0.5f);

    }
    private void OnTriggerEnter(Collider other)
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>().CountBullet += 30;
        Destroy(_patrons,0.1f);
    }


}

