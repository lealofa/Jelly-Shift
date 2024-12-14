using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HJCamScript : MonoBehaviour
{
    public Transform ball;
    public Vector3 offset;
    public float sSpeed;
    void Start()
    {
        offset = transform.position - ball.position;
    }

    
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, offset + ball.position,sSpeed);
        
    }
}
