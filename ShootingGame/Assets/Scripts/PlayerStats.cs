using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    private float _playerCurHP = 100;   
    private float _point = 0;
    public float PlayerMaxHp;
    public float Point;
    public GameObject HpText;
    public GameObject PointText;
    

    void Awake ()
    {
        PlayerMaxHp = _playerCurHP;
        Point = _point;
    }

    public void Update()
    {
        HpText.GetComponent<Text>().text = "HP: " + PlayerMaxHp.ToString();
        PointText.GetComponent<Text>().text = "Очки: " + Point.ToString();
    }

}
