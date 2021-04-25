using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFalse : MonoBehaviour
{
    [SerializeField] private Transform _pointSpawnEnemy;
    [SerializeField] private GameObject _miniEnemy;
    private int _countEnemy = 20;

    private void OnTriggerEnter(Collider other)
    {
        InvokeRepeating("SpawnEnemy", 0.2f, 0.2f);
    }

    void SpawnEnemy()
    {
        if (_countEnemy > 0)
        {
            Instantiate(_miniEnemy, _pointSpawnEnemy.position, transform.rotation);
            _countEnemy -= 1;
        }
        else CancelInvoke("SpawnEnemy");
        
    }

}
