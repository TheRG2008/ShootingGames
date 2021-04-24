using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed;
   
    private void Awake()    {
      
        Destroy(gameObject, 1);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<Enemy>().TakeDamage(20);
        }
    }



    void Update()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }

}

