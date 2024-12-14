using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eat : MonoBehaviour
{
      private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Bot") || collision.gameObject.CompareTag("Food"))
        {
            if (collision.transform.localScale.magnitude < transform.localScale.magnitude)
            {

                Vector3 otherScale = collision.transform.localScale;

                Destroy(collision.gameObject);

                

                transform.localScale += otherScale;
                
            }
        }
    }
}
