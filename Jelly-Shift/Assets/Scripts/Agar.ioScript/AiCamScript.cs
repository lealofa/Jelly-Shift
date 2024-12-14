using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiCamScript : MonoBehaviour
{
    public Transform Aplayer;
    public Vector3 Aoffset;
    

    
    void Update()
    {
        transform.position = Aplayer.position + Aoffset;
    }
}
