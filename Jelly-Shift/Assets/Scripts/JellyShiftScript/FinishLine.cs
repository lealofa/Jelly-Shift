using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{

    WinScreen finishLscript;
    JellyScript move;
    public void Awake()
    {
        finishLscript = GameObject.Find("WinScreenUI").GetComponent<WinScreen>();
    }
    private void OnTriggerEnter(Collider obj)
    {
        if (obj.gameObject.tag == "Player")
        {

            finishLscript.GetComponent<Canvas>().enabled = true;
            Time.timeScale = 0;
            
            

        }
    }

}
