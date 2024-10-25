using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharRotation : MonoBehaviour
{
    public Transform orientation;

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = orientation.eulerAngles;
        transform.rotation = Quaternion.Euler(transform.localEulerAngles.x, rot.y+90, transform.localEulerAngles.z);
    }
}
