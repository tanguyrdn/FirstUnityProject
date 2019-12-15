using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SamuraiControllerScript : MonoBehaviour
{
    public Transform Target;

    // Start is called before the first frame update
    void Start()
    {
        GoToTarget();
    }

    // Update is called once per frame
    void Update()
    {
        float Speed = Vector3.Magnitude(GetComponent<NavMeshAgent>().velocity);
        GetComponentInChildren<Animator>().SetFloat("Speed", Speed);

        if (GetComponent<NavMeshAgent>().remainingDistance < 3)
            GetComponentInChildren<Animator>().SetTrigger("Attack");

        GoToTarget();
    }

    private void GoToTarget()
    {
        Target = GameObject.Find("Player").transform;
        GetComponent<NavMeshAgent>().SetDestination(Target.position);
    }
}
