﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private GameObject _bullet; 
    [SerializeField] private Transform _bulletSpawnPlace;
    public int _countBullet = 0;
    [SerializeField] private float _speed = 2;

    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (_countBullet > 0) GrateShoot();
            
        }
    }

    private void GrateShoot ()
    {
        Instantiate(_bullet, _bulletSpawnPlace.position, _bulletSpawnPlace.rotation);
        
        _countBullet--;
    }
}
