using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private float _enemyHP = 100;
    [SerializeField] private float _curEnemyHP;
    private float _damage;



   
    void Awake()
    {
        _curEnemyHP = _enemyHP;
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
    }
}
