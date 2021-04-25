using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] private Transform _target;
    private Vector3 _position;
    private Vector3 _angle;
   
    void Start()
    {
        _position = _target.InverseTransformPoint(transform.position);
        
    }


    private void LateUpdate()
    {
        var currentPosition = _target.TransformPoint(_position);
        transform.position = currentPosition;
        transform.LookAt(_target);
    }

   
}
