using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BotAI : MonoBehaviour
{
    public float moveSpeed = 3f;
    private Vector3 targetPosition;

    void Start()
    {
        SetRandomTargetPosition();
    }

    void Update()
    {
        MoveTowardsTarget();
    }

    void SetRandomTargetPosition()
    {
        float x = Random.Range(-194f, 194f);
        float y = Random.Range(-151f, 151f);
        targetPosition = new Vector3(x, 0.5f, y);
    }

    void MoveTowardsTarget()
    {
        Vector3 direction = (targetPosition - transform.position).normalized;
        transform.position += direction * moveSpeed * Time.deltaTime;

        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            SetRandomTargetPosition();
        }
    }

    


}
