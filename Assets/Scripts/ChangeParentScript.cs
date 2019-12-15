using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeParentScript : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Cubes;


    void Start()
    {
        foreach (GameObject g in Cubes)
        {
            g.transform.SetParent(transform);
        }
    }
}
