using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeTravel : MonoBehaviour
{
    private List<Vector3> positions = new List<Vector3>();
    private List<Quaternion> rotations = new List<Quaternion>();

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1) && positions.Count > 0)
        {
            transform.position = positions[positions.Count - 1];
            transform.rotation = rotations[rotations.Count - 1];
            positions.RemoveAt(positions.Count - 1);
            rotations.RemoveAt(rotations.Count - 1);

        }
        else
        {
            positions.Add(transform.position);
            rotations.Add(transform.rotation);
        }
    }
}
