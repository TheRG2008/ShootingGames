using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{
    [SerializeField] private float _radius;
    [SerializeField] private float _force;    
    private GameObject _player;  

    private void Start()   
    {        
        Invoke("Explode", 4);
    }   

    public void Explode ()
    {
        Collider[] overlappedColliders = Physics.OverlapSphere(transform.position, _radius);

        for (int i = 0; i < overlappedColliders.Length; i++)
        {
            
            Rigidbody rigidbody = overlappedColliders[i].attachedRigidbody;
            if (rigidbody)
            {
                Debug.Log(overlappedColliders[i]);
                rigidbody.AddExplosionForce(_force, transform.position, _radius, 1f);

                Enemy enemy = rigidbody.GetComponent<Enemy>();
                if (enemy)
                {
                    enemy.TakeDamage(500);
                }

            }

        }
        Destroy(gameObject);
    }

}
