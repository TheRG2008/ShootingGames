using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    CharacterController MyPawnBody;
    float moveX, moveY;
    public float SensX = 5, SensY = 10;
    
    void Start()
    {
        MyPawnBody = this.GetComponent<CharacterController>();
    }

    public Vector2 MinMax_Y = new Vector2(-40, 40),
          MinMax_X = new Vector2(-360, 360);

    static float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360F) angle -= 360F;
        if (angle > 360F) angle += 360F;
        return Mathf.Clamp(angle, min, max);
    }
    // Update is called once per frame
    void Update()
    {
        {
            if (MyPawnBody != null)
            {
                moveY -= Input.GetAxis("Mouse Y") * SensY;

                moveY = ClampAngle(moveY, MinMax_Y.x, MinMax_Y.y);
                moveX += Input.GetAxis("Mouse X") * SensX;

                moveX = ClampAngle(moveX, MinMax_X.x, MinMax_X.y);

                MyPawnBody.transform.rotation = Quaternion.Euler(moveY, moveX, 0);
            }

        }
    }
    //public float mouseSens = 9.0f;

    //void Update()
    //{
    //    //transform.Rotate(0, Input.GetAxis("Mouse X") * mouseSens, 0);
    //    //transform.Rotate(Input.GetAxis("Mouse Y") * mouseSens,0 , 0);


    //}
}
