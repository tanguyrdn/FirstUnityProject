using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecuperationChildrenScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Debug.Log(transform.GetChild(i).gameObject.name);
        }
    }

    
}
