using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private GameObject _bullet; 
    [SerializeField] private Transform _bulletSpawnPlace;
    [SerializeField] private int _countBullet = 8;

    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (_countBullet > 0 )
            Instantiate(_bullet, _bulletSpawnPlace.position, _bulletSpawnPlace.rotation);
            _countBullet--;
        }
    }

}
