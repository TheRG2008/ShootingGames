using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OpenDoorButton : MonoBehaviour
{
    [SerializeField] private GameObject _bulls;
    [SerializeField] private GameObject _box;
    public UnityEvent OpenShow;
    

    private void OnTriggerEnter(Collider other)
    {
        OpenShow?.Invoke();
        _box.GetComponent<Rigidbody>().useGravity = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (_bulls)
        _bulls.SetActive(false);
        
        _box.GetComponent<Rigidbody>().useGravity = false;
    }




}
