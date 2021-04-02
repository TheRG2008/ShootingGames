using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _speed = 1;
    private Vector3 _dir;
    
    
    void Start()
    {
        
    }

    
    void Update()
    {
        _dir.x = Input.GetAxis("Horizontal");
        _dir.z = Input.GetAxis("Vertical");

    }

    private void FixedUpdate()
    {
        var speed = _speed * _dir * Time.deltaTime;
        transform.Translate(speed);
        _dir = Vector3.zero;
    }
}
