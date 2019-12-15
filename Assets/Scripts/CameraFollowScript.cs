using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour
{
    [SerializeField]
    private Transform Target1;

    [SerializeField]
    private Transform Target2;
    
    [SerializeField]
    private float CameraSpeed;

    [SerializeField]
    private float DeltaHeight;
    
    [SerializeField]
    private float MinDist, MaxDist;

    void Update()
    {
        Vector3 Middle = Vector3.Lerp(Target1.position, Target2.position, 0.5f);
        float distance = Vector3.Distance(Target1.position, Target2.position);

        if (distance > 50)
            distance = 50;
        if (distance < 10)
            distance = 10;
        Vector3 t = Middle + new Vector3(0, distance, 0);
        //transform.position = Target.position + new Vector3(0, 10, 0);
        transform.position = Vector3.Lerp(transform.position, t, Time.deltaTime * 5);
    }
}
