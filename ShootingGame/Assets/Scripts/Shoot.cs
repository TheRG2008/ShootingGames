using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;    
    [SerializeField] private Transform _bulletSpawnPlace;
    [SerializeField] private Transform _mineSpawnPlace;
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject _mine;
    private Animator _anim;
    private int _bulletInMagazine;
    

    private void Awake()
    {
        _anim = GetComponent<Animator>();
    }
    private void Update()
    {
       

        _bulletInMagazine = Player.GetComponent<PlayerStats>().BulletInMagazine;

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (_bulletInMagazine > 0)
            {
                _anim.SetBool("shoot", true);
                //GrateShoot();
            }             
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            
            InstantMine();
            
        }

    }

    private void InstantMine()
    {
        Instantiate(_mine, _mineSpawnPlace.position, _mineSpawnPlace.rotation);
    }

    private void GrateShoot ()
    {
        Instantiate(_bullet, _bulletSpawnPlace.position, _bulletSpawnPlace.rotation);   
        _bulletInMagazine = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>().BulletInMagazine -= 1;
        _anim.SetBool("shoot", false);
    }

    
}
