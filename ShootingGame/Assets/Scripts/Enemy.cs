using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    [SerializeField] private float _enemyHP = 100;
    [SerializeField] private float _curEnemyHP;
    private Animator _anim;
    private float _point;
    private GameObject _player;
    private float _distanse;
    
    
    void Awake()
    {
        _curEnemyHP = _enemyHP;
        _anim = GetComponent<Animator>();
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    private void FixedUpdate()
    {
        if (gameObject.transform.position != Vector3.zero)
        {
            _anim.SetBool("walk", true); 
        }
        else
        {
            _anim.SetBool("walk", false);
        }
        _anim.SetBool("damage", false);
        

        _distanse = Vector3.Distance(transform.position, _player.transform.position);
        if (_distanse <= 0.5)
        {
            _anim.SetBool("atack", true);
            
        }
        else
        {
            _anim.SetBool("atack", false);
        }

    }

    private void Atack ()
    {
        _player.gameObject.GetComponent<PlayerStats>().TakeDamage(5);
        _anim.SetBool("atack", false);
       
    }

    public void TakeDamage (float damage)
    {
        
        _curEnemyHP -= damage;
        _anim.SetBool("damage", true);
        if (_curEnemyHP <= 0)
        {
            _anim.SetBool("death", true);
            Invoke("Death", 1.2f);
        }
    }

  
    private void Death()
    {
        
        Destroy(gameObject);
        _point = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>().Point += 2;
    }

   

}
