using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField] private Transform _gun1;   
    [SerializeField] private GameObject _bullet;
    [SerializeField] private GameObject _player;
    [SerializeField] private float _startTimeBtwShots1;
   
    private float _timeBtwShots1;   
    private Transform _playerPosition;

    private void Awake()
    {
        _timeBtwShots1 = _startTimeBtwShots1;     
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other = _player.GetComponent<Collider>())
        {
            ShootEnemy1();       
        }

    }

    private void ShootEnemy1()
    {
        if (_timeBtwShots1 <= 0)
        {
            Instantiate(_bullet, _gun1.position, _gun1.rotation);

            _timeBtwShots1 = _startTimeBtwShots1;
        }
        else
        {
            _timeBtwShots1 -= Time.deltaTime;
        }
    }
 
}
