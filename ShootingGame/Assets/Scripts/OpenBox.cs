using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBox : MonoBehaviour
{
    public GameObject Box;
    public GameObject Player;
    public GameObject Bullet;
    public GameObject Gun;

    private void OnTriggerEnter(Collider other)
    {
        
        Box.GetComponent<Animation>().enabled = true;
        if (Bullet)
        {
            Player.GetComponent<Shoot>()._countBullet += 8;
        }
   
        Destroy(Bullet, 1);
        Destroy(Gun, 1);
        

    }

}
