using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasText : MonoBehaviour
{
    [SerializeField] private Transform _pointSpawnEnemy;
    [SerializeField] private GameObject _miniEnemy;

    private void OnTriggerEnter(Collider other)
    {
        Instantiate(_miniEnemy, _pointSpawnEnemy.position, transform.rotation);
    }

}
