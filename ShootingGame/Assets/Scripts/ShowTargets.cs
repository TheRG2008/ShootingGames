using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTargets : MonoBehaviour
{
    public GameObject Target1;
 

    private void OnTriggerEnter(Collider other)
    {
        Target1.SetActive(true);
        Destroy(gameObject);
    }
    
   
}
