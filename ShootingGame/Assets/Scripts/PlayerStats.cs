using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private float _playerMaxHp = 100, _playerCurHP = 0;
    public float _point = 0;
    
    

    void Awake ()
    {
        
    }
    private void Start()
    {
        
    }

    
    void Update()
    {
        Debug.Log(_point);
    }
}
