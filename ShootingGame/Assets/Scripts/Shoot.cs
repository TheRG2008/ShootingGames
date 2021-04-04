using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private GameObject _bullet; 
    [SerializeField] private Transform _bulletSpawnPlace; 

    private void Update()
    {
        
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Instantiate(_bullet, _bulletSpawnPlace.position, _bulletSpawnPlace.rotation);
            
        }
    }

}
