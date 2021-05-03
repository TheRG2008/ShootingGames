using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OpenDoorButton : MonoBehaviour
{
    [SerializeField] private GameObject _bulls;
    [SerializeField] private GameObject _box;
    [SerializeField] private GameObject _wall;

    private void OnTriggerEnter(Collider other)
    {
        _bulls.SetActive(true);
        _box.GetComponent<Rigidbody>().useGravity = true;
        _wall.SetActive(false);
    }

    private void OnTriggerExit(Collider other)
    {
        if (_bulls)
        _bulls.SetActive(false);
        _wall.SetActive(true);
        _box.GetComponent<Rigidbody>().useGravity = false;
    }

}
