using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBox : MonoBehaviour
{
    public GameObject Box;
    private void OnTriggerEnter(Collider other)
    {
        var component = Box.GetComponent<Animation>().enabled = true;
        
    }

}
