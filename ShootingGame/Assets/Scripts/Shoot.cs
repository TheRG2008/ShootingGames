using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;    
    [SerializeField] private Transform _bulletSpawnPlace;
    [SerializeField] private GameObject Player;

    private int _bulletInMagazine;
    

    private void Awake()
    {
        //_bulletCount = Player.GetComponent<PlayerStats>().CountBullet;
    }
    private void Update()
    {
       

        _bulletInMagazine = Player.GetComponent<PlayerStats>().BulletInMagazine;

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (_bulletInMagazine > 0)
            {
                GrateShoot();
            }             
        }

       
    }

    private void GrateShoot ()
    {
        Instantiate(_bullet, _bulletSpawnPlace.position, _bulletSpawnPlace.rotation);   
        _bulletInMagazine = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>().BulletInMagazine -= 1;
    }

    
}
