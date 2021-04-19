using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove2 : MonoBehaviour
{
    
    [SerializeField] private float _speed = 5f;
    private CharacterController _characterController;
    private Vector3 _direction;
    private Vector3 _velocity;
    

    

    void Awake()
    {
        _characterController = GetComponent<CharacterController>();
    }

    private void FixedUpdate()
    {
        _direction.x = Input.GetAxis("Horizontal");
        _direction.z = Input.GetAxis("Vertical");

        if (_direction.magnitude > 1f)
        {
            _direction.Normalize();
        }

        var motion = transform.right * _direction.x + transform.forward * _direction.z;
        _characterController.Move(motion * (_speed * Time.fixedDeltaTime));
        if (_characterController.isGrounded)
        {
            _velocity.y = -0.1f;
        }
        else
        {
            _velocity += Physics.gravity * Time.fixedDeltaTime;
        }

        _characterController.Move(_velocity * Time.fixedDeltaTime);
    }

}
