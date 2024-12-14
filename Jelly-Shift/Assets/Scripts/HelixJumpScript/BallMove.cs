using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using DG.Tweening;

public class BallMove : MonoBehaviour
{
    
    public Rigidbody rb;
    private float jumpForce=4f;
    public GameObject splashPreFab;
    UITManager uimanagerScript;
    WinScreenHJ wsScript;
    SoundManagerHJ soundManagerHJScript;
    public RectTransform revive;
    public RectTransform heartRed, restart, yoW;
    public float revealDuration = 1f;

    


    private void Start()
    {
        uimanagerScript = GameObject.Find("GameOverCanvas").GetComponent<UITManager>();
        wsScript = GameObject.Find("WinScreenCanvas").GetComponent<WinScreenHJ>();
        soundManagerHJScript = GameObject.Find("SoundManager").GetComponent<SoundManagerHJ>();

    }

    private void OnCollisionEnter(Collision collision)
    {
        rb.velocity = Vector3.up * jumpForce;
        soundManagerHJScript.JumpHJ();
        GameObject splash = Instantiate(splashPreFab, transform.position +new Vector3 (0f,-0.10f,0f), transform.rotation);
        splash.transform.SetParent(collision.gameObject.transform);

        string materialName = collision.gameObject.GetComponent<MeshRenderer>().material.name;

         

        if (materialName == "SafePlatform (Instance)")
        {
            
        }

        else if (materialName == "UnSafePlatform (Instance)")
        {
            soundManagerHJScript.BallDeath();
            Destroy(gameObject);
            revive.DOScale(Vector3.zero, revealDuration).From();
            heartRed.DOAnchorPos3DY(800f, revealDuration).From();
            restart.DOAnchorPosY(-800f, revealDuration).From();
            yoW.DOAnchorPosX(-1450f, revealDuration).From();

            uimanagerScript.GetComponent<Canvas>().enabled = true;

            


        }
        
        else if (materialName == "FPWhite (Instance)"||materialName=="FPBlack (Instance)")
        {
            soundManagerHJScript.WinLevel();
            Time.timeScale = 0f;
            wsScript.GetComponent<Canvas>().enabled = true;
            
        }

       
        
    }
}
