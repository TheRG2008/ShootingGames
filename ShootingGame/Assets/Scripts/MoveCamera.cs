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
        _rotation.x = Input.GetAxis("Mouse X") * _sensitivity * Time.deltaTime;
        _rotation.y = Input.GetAxis("Mouse Y") * _sensitivity * Time.deltaTime;

        _rotation.y = Mathf.Clamp(_rotation.y, -90f, 90f);
        _camera.transform.localRotation = Quaternion.Euler(_rotation.y, 0f, 0f);

        transform.Rotate(Vector3.up * _rotation.x);
    }


}
