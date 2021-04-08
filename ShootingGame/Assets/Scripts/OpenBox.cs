using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBox : MonoBehaviour
{
    public GameObject Box;
    public GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        
        Box.GetComponent<Animation>().enabled = true;
        Player.GetComponent<Shoot>()._countBullet += 8;
       
       
    }

}
