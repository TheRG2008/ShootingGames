using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _speed;
    //private Vector3 _dir;
    public float gravity;

    private CharacterController _charController;
    

    void Start()
    {
        _charController = GetComponent<CharacterController>();
    }


    void Update()
    {

        float deltaX = Input.GetAxis("Horizontal") * _speed;
        float deltaZ = Input.GetAxis("Vertical") * _speed;

        Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        movement = Vector3.ClampMagnitude(movement, _speed);

        movement.y = gravity;
        movement *= Time.deltaTime;

        movement = transform.TransformDirection(movement);
        _charController.Move(movement);

        


    }

    //private void FixedUpdate()
    //{
    //    //var speed = _speed * _dir * Time.deltaTime;
    //    //transform.Translate(speed);
    //    //_dir = Vector3.zero;
    //}
}
