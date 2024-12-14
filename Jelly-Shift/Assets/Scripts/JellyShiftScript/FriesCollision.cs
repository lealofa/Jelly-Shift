using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriesCollision : MonoBehaviour
{
    SoundManager soundManager;
    [SerializeField] private ParticleSystem friesParticle;
    private void Start()
    {
        soundManager = GameObject.Find("Sound Manager").GetComponent<SoundManager>();
    }

    private void OnTriggerEnter(Collider obj)
    {
        if (obj.gameObject.tag == "Fries")
        {
            Instantiate(friesParticle, transform.position, Quaternion.identity);
            soundManager.Fries();
            Destroy(obj.gameObject);
            
        }
    }
}
