using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour
{
    [SerializeField] private GameObject _bullet; 
    [SerializeField] private Transform _bulletSpawnPlace;    
   
    private int _countBullet;
    public int CountBullet;
    public GameObject BulletText;

    private void Awake()
    {
        CountBullet = _countBullet;
    }

    private void Update()
    {
        BulletText.GetComponent<Text>().text = "Патроны: " + CountBullet.ToString();
        
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (CountBullet > 0) GrateShoot();
  
        }
    }

    private void GrateShoot ()
    {
        Instantiate(_bullet, _bulletSpawnPlace.position, _bulletSpawnPlace.rotation);
        CountBullet--;
    }
}
