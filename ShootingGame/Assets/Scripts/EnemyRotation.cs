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

            transform.Rotate(0.0f, 0.0f, 5f);
        }

        
    }


}
