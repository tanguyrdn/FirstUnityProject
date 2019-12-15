using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PathfindingScript : MonoBehaviour
{
    [SerializeField]
    private Transform[] Target;

    // Start is called before the first frame update
    void Start()
    {
        GoToTarget(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<NavMeshAgent>().remainingDistance < 3)
            GoToTarget();
    }

    private void GoToTarget()
    {
        GetComponent<NavMeshAgent>().SetDestination(Target[Random.Range(0, Target.Length)].position);
    }
}
