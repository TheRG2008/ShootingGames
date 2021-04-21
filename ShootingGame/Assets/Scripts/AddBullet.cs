using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddBullet : MonoBehaviour
{
    //private GameObject _player;
    private int _bulletCount;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        _bulletCount = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>().CountBullet += 30;
    }
}
