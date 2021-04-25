using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestBox : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        gameObject.GetComponent<Rigidbody>().useGravity = true;
    }

}
