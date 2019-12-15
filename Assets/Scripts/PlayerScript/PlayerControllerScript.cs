using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerScript : MonoBehaviour
{
    [SerializeField]
    private float Speed;

    [SerializeField]
    private float RotationSpeed;
    
    [SerializeField]
    [Range(0, 500)]
    public float JumpForce;
    
    private int NbColliderinTrigger = 0;

    
    void Update()
    {
        float DeltaSpeed = Speed * Time.deltaTime;
        //GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 10));
        float DeltaRot = RotationSpeed * Time.deltaTime;

        int Axe = 0;
        if (Input.GetKey(KeyCode.Z))
            Axe = 1;
        if (Input.GetKey(KeyCode.S))
            Axe = -1;

        Vector3 CurrentSpeed = GetComponent<Rigidbody>().velocity;
        Vector3 MaxSpeed = Axe * Speed * transform.forward;

        GetComponent<Rigidbody>().AddForce(MaxSpeed - CurrentSpeed);


         if (Input.GetKey(KeyCode.D))
             transform.Rotate(new Vector3(0, DeltaRot, 0));
         if (Input.GetKey(KeyCode.Q))
             transform.Rotate(new Vector3(0, -DeltaRot, 0));
        /*float Xaxis = Input.GetAxis("Mouse X");
        transform.Rotate(new Vector3(0, Xaxis * DeltaRot, 0));*/
        if (Input.GetKey(KeyCode.Space) && NbColliderinTrigger>0 )
            GetComponent<Rigidbody>().AddForce(new Vector3(0, JumpForce, 0));
    }
    private void OnTriggerEnter(Collider other)
    {
        NbColliderinTrigger++;
    }

    private void OnTriggerExit(Collider other)
    {
        NbColliderinTrigger--;
    }
}
