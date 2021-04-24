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
    private int _bulletInMagazine;
    public int CountBullet;
    public int BulletInMagazine;
    public float PlayerMaxHp;
    public float Point;
    public GameObject HpText;
    public GameObject PointText;
    public GameObject BulletText;


    void Awake ()
    {
        Cursor.lockState = CursorLockMode.Locked;
        PlayerMaxHp = _playerCurHP;
        Point = _point;
        CountBullet = _countBullet;
        BulletInMagazine = _bulletInMagazine;
    }

    public void Update()
    {
        HpText.GetComponent<Text>().text = "HP: " + PlayerMaxHp.ToString();
        PointText.GetComponent<Text>().text = "Очки: " + Point.ToString();
        BulletText.GetComponent<Text>().text = "Патроны: " + CountBullet.ToString();

        if (Input.GetKeyDown(KeyCode.R))
            Invoke("Reload", 2);
    }

    private void Reload()
    {
        
        BulletInMagazine += CountBullet;

        if (BulletInMagazine > 30)
        {
            CountBullet = BulletInMagazine - 30;
            BulletInMagazine = 30;
        }
        else CountBullet = 0;
    }

}
