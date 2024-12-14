using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgarMove : MonoBehaviour
{
    public float Aspeed = 20f;


    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector3 moveA = new Vector3(moveX, 0, moveY) * Aspeed * Time.deltaTime;
        transform.Translate(moveA);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Food") || collision.gameObject.CompareTag("Bot"))
        {
            if (collision.transform.localScale.magnitude < transform.localScale.magnitude)
            {

                Vector3 otherScale = collision.transform.localScale;

                Destroy(collision.gameObject);

                FindObjectOfType<ScoreManager>().UpdateScore(otherScale.x);

                transform.localScale += otherScale;

            }
        }
    }
}
