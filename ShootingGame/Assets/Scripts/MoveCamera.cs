using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Camera _camera;
    [SerializeField] private float _sensitivity = 5f;

    private Vector3 _rotation;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {        
        _rotation.y = Input.GetAxis("Mouse Y") * _sensitivity * Time.deltaTime;       
    }


}
