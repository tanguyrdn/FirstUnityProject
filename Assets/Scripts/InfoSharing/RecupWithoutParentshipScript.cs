using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecupWithoutParentshipScript : MonoBehaviour
{
    [SerializeField]
    private GameObject Obj;

    void Start()
    {
        GameObject Obj1 = GameObject.Find("Obj1");
        GameObject[] Ennemis = GameObject.FindGameObjectsWithTag("Ennemis");

        Debug.Log(Obj.name);
    }
}
