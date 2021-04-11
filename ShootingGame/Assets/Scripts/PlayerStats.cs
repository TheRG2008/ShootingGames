using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    private float _playerCurHP = 100;   
    private float _point = 0;
    public float PlayerMaxHp;
    public float Point;
    
    

    void Awake ()
    {
        PlayerMaxHp = _playerCurHP;
        Point = _point;
    }

}
