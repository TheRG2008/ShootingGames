using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBox : MonoBehaviour
{
    public GameObject Box;
    public GameObject Player;
    public GameObject Bullet;
    public GameObject Gun;
    public GameObject GunInHand;


    private void OnTriggerEnter(Collider other)
    {
        
        Box.GetComponent<Animation>().enabled = true;
        if (Bullet)
        {
            Player.GetComponent<Shoot>().CountBullet += 8;
        }
   
        Destroy(Bullet, 0.2f);
        Destroy(Gun, 0.2f);
        GunInHand.SetActive(true);

    }

}
