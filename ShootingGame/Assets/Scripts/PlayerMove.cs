using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpHeight;
    [SerializeField] private float _gravity;

    private float _xMove;    
    private float _zMove;

    private float _yRotaye;
    
    private float _sensitivity = 200f;
    private Vector3 _directional;
    private CharacterController _player;
    

    private void Awake()
    {
        _player = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;

    }
    private void Update()
    {
        Walk();
        MouseLook();        
    }

  

    void Walk()
    {
        _xMove = Input.GetAxis("Horizontal");
        _zMove = Input.GetAxis("Vertical");     
        
        if (_player.isGrounded)
        {
            _directional = new Vector3(_xMove, 0f, _zMove);
            _directional = transform.TransformDirection(_directional);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _directional.y += _jumpHeight;
            }

        }
        _directional.y -= _gravity;
        _player.Move(_directional * _speed * Time.deltaTime);
    }

    void MouseLook()
    {
        _yRotaye = Input.GetAxis("Mouse X");
       
        transform.Rotate(0, _yRotaye * _sensitivity * Time.deltaTime, 0);
    }


}
