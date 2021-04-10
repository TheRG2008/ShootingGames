using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAnimator : MonoBehaviour
{
    private Animator _anim;
    void Start()
    {
        _anim = GetComponent<Animator>();
    }


    void Update()
    {

        if (Input.GetKey(KeyCode.Mouse0))
        {
            _anim.SetBool("Shoot", true);
        }
    }
}
