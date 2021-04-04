using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private Animator _anim;
    void Start()
    {
        _anim = GetComponent<Animator>();
    }

    
    void Update()
    {

        if ( Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            _anim.SetBool("walk", true);
        }
        else
        {
            _anim.SetBool("walk", false);
        }

        if (Input.GetKey(KeyCode.A))
        {
            _anim.SetBool("left", true);
        }
        else
        {
            _anim.SetBool("left", false);
        }

        if (Input.GetKey(KeyCode.D))
        {
            _anim.SetBool("right", true);
        }
        else
        {
            _anim.SetBool("right", false);
        }

        if (Input.GetKey(KeyCode.Mouse0))
        {
            _anim.SetBool("shoot", true);
        }
        else
        {
            _anim.SetBool("shoot", false);
        }

      

    }
}
