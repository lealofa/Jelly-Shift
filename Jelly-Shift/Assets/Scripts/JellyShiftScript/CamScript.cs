using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScript : MonoBehaviour
{
    public Transform Jelly;
    public Vector3 offset;
    public float lerpValue;
 

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 despos = Jelly.position + offset;

        transform.position = Vector3.Lerp(transform.position, despos, lerpValue);

    }
}
