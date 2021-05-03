using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GreenEnemyMove : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private GameObject[] _point;
    private NavMeshAgent _navMeshAgent;
    private float _countPoint;
    private int _random;



    private void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        
    }
    void Start()
    {
        _point = GameObject.FindGameObjectsWithTag("Points");

             

    }


    private void Update()
    {
        _random = Random.Range(0, _point.Length);
        _navMeshAgent.SetDestination(_point[_random].transform.position * _speed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("LineAtack"))
        {
            Destroy(gameObject);
            _countPoint = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>().Point -= 1;
        }
        
    }
}

