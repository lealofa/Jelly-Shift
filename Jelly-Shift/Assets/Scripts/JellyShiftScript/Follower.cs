using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    private bool IsGameEnded = false;
    public Transform target;
    public float speed = 5f; 
    void Start()
    {
        
    }

    
    void Update()
    {
        Vector3 direction = transform.position + target.position;
        direction = direction.normalized;
        direction.y = 0;
        direction.Normalize();
        if (!IsGameEnded)
        {
            transform.position +=  direction * speed * Time.deltaTime;
            transform.LookAt(new Vector3(target.position.x, transform.position.y, target.position.z));
        }
       
    }
}
