using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float mouseSens = 9.0f;
  
    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Mouse X") * mouseSens, 0);
        

    }
}
