using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 6.0f;
    //public float jumpValue = 8.0f;
    public float gravity = 20.0f;
    private Vector3 moveDirection = Vector3.zero;

    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            //if (Input.GetButton("Jump"))
            //{
            //    moveDirection.y = jumpValue;
            //}
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
    //[SerializeField] private float _speed;    
    //public float gravity;

    //private CharacterController _charController;


    //void Start()
    //{

    //    _charController = GetComponent<CharacterController>();
    //}


    //void Update()
    //{

    //    float deltaX = Input.GetAxis("Horizontal") * _speed;
    //    float deltaZ = Input.GetAxis("Vertical") * _speed;

    //    Vector3 movement = new Vector3(deltaX, 0, deltaZ);
    //    movement = Vector3.ClampMagnitude(movement, _speed);

    //    //movement.y = gravity;
    //    movement *= Time.deltaTime;

    //    movement = transform.TransformDirection(movement);
    //    _charController.Move(movement);



    //}


}
