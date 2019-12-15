using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpMovementScript : MonoBehaviour
{
    [SerializeField]
    private Transform StartP, EndP;

    [SerializeField]
    private AnimationCurve Curve;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //float p = Mathf.PingPong(Time.time, 1);
        //float s = (Mathf.Sin(Time.time) + 1) / 2;
        float c = Curve.Evaluate(Time.time);
        //transform.position = Vector3.Lerp(StartP.position, EndP.position, s);
        //transform.localScale = Vector3.Lerp(new Vector3(1,1,1), new Vector3(3,3,3), c);
        GetComponent<MeshRenderer>().material.color = Color.Lerp(Color.blue, Color.red, c);
    }
}
