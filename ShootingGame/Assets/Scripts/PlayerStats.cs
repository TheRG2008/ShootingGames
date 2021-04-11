using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private float _playerCurHP;
    [SerializeField] private GameObject bull;
    private float _playerMaxHp = 100;
    public float _point = 0;
    
    

    void Awake ()
    {
        _playerCurHP = _playerMaxHp;
    }

    private void OnTrigerEnter (Collider other)
    {
       
            _playerCurHP -= 5;
            PlayerIsDead();
        
    }

    private void PlayerIsDead()
    {
        if (_playerCurHP <= 0)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }

    void Update()
    {
        Debug.Log(_point);
    }
}
