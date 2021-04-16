using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    private float _playerCurHP = 100;   
    private float _point = 0;
    private int _countBullet = 0;
    public int CountBullet;
    public float PlayerMaxHp;
    public float Point;
    public GameObject HpText;
    public GameObject PointText;
    public GameObject BulletText;


    void Awake ()
    {
        PlayerMaxHp = _playerCurHP;
        Point = _point;
        CountBullet = _countBullet;
    }

    public void Update()
    {
        HpText.GetComponent<Text>().text = "HP: " + PlayerMaxHp.ToString();
        PointText.GetComponent<Text>().text = "Очки: " + Point.ToString();
        BulletText.GetComponent<Text>().text = "Патроны: " + CountBullet.ToString();
    }

}
