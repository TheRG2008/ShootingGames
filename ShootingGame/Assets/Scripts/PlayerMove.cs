using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _speed;
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
        }
        _directional.y -= 1;
        _player.Move(_directional * _speed * Time.deltaTime);
    }

    void MouseLook()
    {
        _yRotaye = Input.GetAxis("Mouse X");
       
        transform.Rotate(0, _yRotaye * _sensitivity * Time.deltaTime, 0);
    }


}
