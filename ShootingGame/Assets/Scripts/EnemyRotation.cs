using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotation : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _speed;
    [SerializeField] private GameObject _player;

    private void OnTriggerStay (Collider other)
    {
        //transform.LookAt(target);
        if (other = _player.GetComponent<Collider>())
        {
            var pos = _target.position - transform.position;
            Quaternion rot = Quaternion.LookRotation(pos);
            transform.rotation = Quaternion.Slerp(transform.rotation, rot, _speed * Time.deltaTime);

            
        }

        //transform.Rotate(0.5f, 0.1f, 0.2f); //непрерывное вращение
        //transform.rotation = Quaternion.Euler(0, 45, 0);  //резкий поворот.
        //transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 45, 0), Time.deltaTime); //плавный поворот

        //if (door == 0)
        //{ transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 0), Time.deltaTime); }
        //if (door == 1)
        //{ transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 90, 0), Time.deltaTime); }




    }


}
