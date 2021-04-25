using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSpawnWallEnemy : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private GameObject _enemy;
    private int _countEnemy = 20;

    private void Awake()
    {
        Random random = new Random();
    }
    private void OnTriggerEnter(Collider other)
    {
        InvokeRepeating("StartSpawnEnemys", 0.1f, 1);
    }

    void StartSpawnEnemys()
    {
        while (_countEnemy > 0)
        {
            for (int i = 0; i < _spawnPoints.Length; i++)
            {
                Instantiate(_enemy, _spawnPoints[i].position, Quaternion.identity);
                _countEnemy -= 1;
            }
            
        }

        
    }

}
