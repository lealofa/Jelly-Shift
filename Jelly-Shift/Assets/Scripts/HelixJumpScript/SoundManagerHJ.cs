using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerHJ : MonoBehaviour
{

    private AudioSource audioS;
    [SerializeField] private AudioClip balldeath;
    [SerializeField] private AudioClip winHJ;
    [SerializeField] private AudioClip jumpHJ;
    [SerializeField] private AudioClip ringHJ;
    void Start()
    {
        audioS = GetComponent<AudioSource>();
    }

    public void BallDeath()
    {
        audioS.PlayOneShot(balldeath);
    }

    public void WinLevel()
    {
        audioS.PlayOneShot(winHJ);
    }

    public void JumpHJ()
    {
        audioS.PlayOneShot(jumpHJ);
    }

    public void RingHJ()
    {
        audioS.PlayOneShot(ringHJ);
    }
   
}
