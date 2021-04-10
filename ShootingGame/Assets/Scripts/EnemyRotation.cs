using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotation : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float _speed;




  

    private void OnTriggerStay (Collider other)
    {
        //transform.LookAt(target);
        var pos = target.position - transform.position;
        Quaternion rot = Quaternion.LookRotation(pos);
        transform.rotation = Quaternion.Slerp(transform.rotation, rot, _speed * Time.deltaTime);
    }


}
