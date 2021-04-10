using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTargets : MonoBehaviour
{
    public GameObject Target1;
    public GameObject Target2;
    public GameObject Target3;
  

    private void OnTriggerEnter(Collider other)
    {
        Target1.SetActive(true);
        Target2.SetActive(true);
        Target3.SetActive(true);

        Target1.GetComponent<Animation>().enabled = true;
        Target2.GetComponent<Animation>().enabled = true;
        Target3.GetComponent<Animation>().enabled = true;

    }
    
   
}
