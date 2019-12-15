using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecuperationParentScript : MonoBehaviour
{
    void Start()
    {
        Debug.Log(transform.parent.gameObject.name);
    }
}
