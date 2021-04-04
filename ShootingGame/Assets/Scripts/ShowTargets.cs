using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTargets : MonoBehaviour
{
    [SerializeField] private GameObject LineAtack;
    [SerializeField] private GameObject ShowTarget;

    void Start()
    {
        
    }

    
    void Update()
    {

        
        //if (gameObject.GetComponent<CapsuleCollider>() == LineAtack.GetComponent<BoxCollider>())
        //{
        //    ShowTarget.SetActive(true);
        //}
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "LineAtack")
        {
            ShowTarget.SetActive(true);
        }
    }
}
