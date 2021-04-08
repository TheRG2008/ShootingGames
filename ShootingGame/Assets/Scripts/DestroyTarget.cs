using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTarget : MonoBehaviour
{
    public GameObject Player;
    private float _point;
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
        _point = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>()._point += 1;
    }

}
