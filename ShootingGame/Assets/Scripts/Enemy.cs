using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private float _enemyHP = 100;
    [SerializeField] private float _curEnemyHP;
    private float _point;
    
    private float _damage;

    void Awake()
    {
        _curEnemyHP = _enemyHP;
    }

    private void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerStats>().TakeDamage(5);
        }
    }

    public void TakeDamage (float damage)
    {
        _curEnemyHP -= damage;
        if (_curEnemyHP <= 0)
        {
            Death();
        }
    }

    private void Death()
    {
        Destroy(gameObject);
        _point = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>().Point += 2;
    }

   

}
