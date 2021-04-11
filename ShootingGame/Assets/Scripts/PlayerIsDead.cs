using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerIsDead : MonoBehaviour
{
    [SerializeField] private GameObject _laser;
    private float _curentHP;

    private void OnCollisionEnter(Collision collision)
    {
        _curentHP = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>().PlayerMaxHp -= 5;

        if (_curentHP < 0)
        {
            SceneManager.LoadScene("SampleScene");
            Debug.Log("Player is dead");
        }

    }
}
