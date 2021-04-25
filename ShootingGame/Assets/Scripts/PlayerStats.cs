using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    private float _playerMaxHP = 100;   
    private float _point = 0;
    private int _countBullet = 0;
    private int _bulletInMagazine;

    public int CountBullet;
    public int BulletInMagazine;
    public float PlayerCurHP;
    public float Point;

    public GameObject HpText;
    public GameObject PointText;
    public GameObject BulletText;


    void Awake ()
    {
        Cursor.lockState = CursorLockMode.Locked;

        PlayerCurHP = _playerMaxHP;
        Point = _point;
        CountBullet = _countBullet;
        BulletInMagazine = _bulletInMagazine;
    }

    public void Update()
    {
        HpText.GetComponent<Text>().text = "HP: " + PlayerCurHP.ToString();
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

    public void TakeDamage(float damage)
    {
        PlayerCurHP -= damage;
        if (PlayerCurHP <= 0)
        {
            Death();
        }
    }

    private void Death()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
