using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSpawnWallEnemy : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private GameObject _enemy;
    private int _countEnemy = 20;
    private int _random;

    private void Awake()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        
        InvokeRepeating("StartSpawnEnemys", 0.1f, 2);
    }

    void StartSpawnEnemys()
    {
        if (_countEnemy > 0)
        {
            _random = Random.Range(0, _spawnPoints.Length);
            Instantiate(_enemy, _spawnPoints[_random].position, transform.rotation);
            _countEnemy--;
        }
        else CancelInvoke();
            

        //for (int i = 0; i < _spawnPoints.Length; i++)
        //{
        //    Instantiate(_enemy, _spawnPoints[i].position, Quaternion.identity);
        //    _countEnemy -= 1;
        //}

    }

}
