using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ring : MonoBehaviour
{
    public Transform ball;
    private GameManager gm;
    public GameObject[] childRings;
    public Slider slider;
    SoundManagerHJ soundManagerHJScript;
    float radius = 100f;
    float force = 45f;
    void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
        ball = GameObject.FindGameObjectWithTag("Ball").transform;
        soundManagerHJScript = GameObject.Find("SoundManager").GetComponent<SoundManagerHJ>();
    }

    
    void Update()
    {
        if (transform != null)
        {



            if (transform.position.y + 10.2f >= ball.position.y)
            {
                soundManagerHJScript.RingHJ();
                slider.value+=25;
                foreach (GameObject ring in childRings)
                {
                    Rigidbody rb = ring.GetComponent<Rigidbody>();
                    if (rb != null)
                    {
                        rb.isKinematic = false;
                        



                        
                        Vector3 direction = new Vector3(Random.Range(-1f, 1f), 0f, Random.Range(-1f, 1f));
                        direction.Normalize(); 

                        rb.AddForce(direction * force, ForceMode.Impulse);
                    }

                   
                }

                this.enabled = false;
                
                gm.GameScore(25); 

            }

        }

    }
}
