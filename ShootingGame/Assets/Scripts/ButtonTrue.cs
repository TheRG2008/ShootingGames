using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrue : MonoBehaviour
{
    [SerializeField] private GameObject _door;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(_door);

        }

    }
}
