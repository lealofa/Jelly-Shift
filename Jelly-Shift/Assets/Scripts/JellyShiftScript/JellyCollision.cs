using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellyCollision : MonoBehaviour
{
    SoundManager soundManagerScript;

    private void Start()
    {
        soundManagerScript = GameObject.Find("Sound Manager").GetComponent<SoundManager>();
    }
    private void OnTriggerEnter(Collider obj)
    {
        if (obj.gameObject.tag == "Obstacle")
        {
            GhostJelly.Instance.ChangePosOfTheGhost();
            soundManagerScript.Ghost();
        }
    }
}
