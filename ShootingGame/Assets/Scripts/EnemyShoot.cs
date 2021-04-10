using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField] private Transform _gun1;
    [SerializeField] private Transform _gun2;
    [SerializeField] private Transform _gun3;
    [SerializeField] private Transform _gun4;
    [SerializeField] private GameObject _bullet;

    private void OnTriggerStay(Collider other)
    {
        Instantiate(_bullet, _gun1.position, _gun1.rotation);
        Instantiate(_bullet, _gun2.position, _gun2.rotation);
        Instantiate(_bullet, _gun3.position, _gun3.rotation);
        Instantiate(_bullet, _gun4.position, _gun4.rotation);
    }
}
