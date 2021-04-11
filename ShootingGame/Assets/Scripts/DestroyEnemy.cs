using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    private float _point;
    [SerializeField] private GameObject Enemy;
 
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(Enemy);
        _point = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>().Point += 2;
    }
}
