using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    public Transform playerResPos;
    GameOver gameOscript;
    SoundManager soundManagerScript;

    private void Awake()
    {
        gameOscript = GameObject.Find("GameOverUI").GetComponent<GameOver>();
        soundManagerScript = GameObject.Find("Sound Manager").GetComponent<SoundManager>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            soundManagerScript.Hit();
            Destroy(collision.gameObject);
            gameOscript.GetComponent<Canvas>().enabled = true; 
        }
    }

 
}
